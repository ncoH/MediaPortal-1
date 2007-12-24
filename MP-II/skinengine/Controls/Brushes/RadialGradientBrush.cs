#region Copyright (C) 2007 Team MediaPortal

/*
    Copyright (C) 2007 Team MediaPortal
    http://www.team-mediaportal.com
 
    This file is part of MediaPortal II

    MediaPortal II is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    MediaPortal II is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with MediaPortal II.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using MediaPortal.Core.Properties;
using SkinEngine.Effects;
using SkinEngine.DirectX;
using SkinEngine.Controls.Visuals;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using SkinEngine;


namespace SkinEngine.Controls.Brushes
{
  public class RadialGradientBrush : GradientBrush, IAsset
  {
    Texture _texture;
    double _height;
    double _width;
    EffectAsset _effect;
    DateTime _lastTimeUsed;

    Property _centerProperty;
    Property _gradientOriginProperty;
    Property _radiusXProperty;
    Property _radiusYProperty;
    float[] _offsets = new float[12];
    ColorValue[] _colors = new ColorValue[12];

    public RadialGradientBrush()
    {
      _centerProperty = new Property(new Vector2(0.5f, 0.5f));
      _gradientOriginProperty = new Property(new Vector2(0.5f, 0.5f));
      _radiusXProperty = new Property((double)0.5f);
      _radiusYProperty = new Property((double)0.5f);
      ContentManager.Add(this);
      _centerProperty.Attach(new PropertyChangedHandler(OnPropertyChanged));
      _gradientOriginProperty.Attach(new PropertyChangedHandler(OnPropertyChanged));
      _radiusXProperty.Attach(new PropertyChangedHandler(OnPropertyChanged));
      _radiusYProperty.Attach(new PropertyChangedHandler(OnPropertyChanged));
    }

    public Property CenterProperty
    {
      get
      {
        return _centerProperty;
      }
      set
      {
        _centerProperty = value;
      }
    }

    public Vector2 Center
    {
      get
      {
        return (Vector2)_centerProperty.GetValue();
      }
      set
      {
        _centerProperty.SetValue(value);
      }
    }

    public Property GradientOriginProperty
    {
      get
      {
        return _gradientOriginProperty;
      }
      set
      {
        _gradientOriginProperty = value;
      }
    }

    public Vector2 GradientOrigin
    {
      get
      {
        return (Vector2)_gradientOriginProperty.GetValue();
      }
      set
      {
        _gradientOriginProperty.SetValue(value);
      }
    }


    public Property RadiusXProperty
    {
      get
      {
        return _radiusXProperty;
      }
      set
      {
        _radiusXProperty = value;
      }
    }

    public double RadiusX
    {
      get
      {
        return (double)_radiusXProperty.GetValue();
      }
      set
      {
        _radiusXProperty.SetValue(value);
      }
    }

    public Property RadiusYProperty
    {
      get
      {
        return _radiusYProperty;
      }
      set
      {
        _radiusYProperty = value;
      }
    }

    public double RadiusY
    {
      get
      {
        return (double)_radiusYProperty.GetValue();
      }
      set
      {
        _radiusYProperty.SetValue(value);
      }
    }

    protected override void OnPropertyChanged(Property prop)
    {
      Free();
    }
    /// <summary>
    /// Setups the brush.
    /// </summary>
    /// <param name="element">The element.</param>
    public override void SetupBrush(FrameworkElement element, ref PositionColored2Textured[] verts)
    {
      if (_texture == null || element.ActualHeight != _height || element.ActualWidth != _width)
      {
        base.SetupBrush(element, ref verts);

        if (_texture != null)
        {
          _texture.Dispose();
        }
        _height = element.ActualHeight;
        _width = element.ActualWidth;
        _texture = new Texture(GraphicsDevice.Device, 2, 2, 0, Usage.None, Format.A8R8G8B8, Pool.Managed);

        int index = 0;
        foreach (GradientStop stop in GradientStops)
        {
          _offsets[index] = (float)stop.Offset;
          _colors[index] = ColorValue.FromColor(stop.Color);
          _colors[index].Alpha *= (float)Opacity;
          index++;
        }
      }
    }
    public override void BeginRender()
    {
      if (_texture == null) return;
      _effect = ContentManager.GetEffect("radialgradient");
      _effect.Parameters["g_offset"] = _offsets;
      _effect.Parameters["g_color"] = _colors;
      _effect.Parameters["g_stops"] = (int)GradientStops.Count;
      _effect.Parameters["g_focus"] = new float[2] { GradientOrigin.X, GradientOrigin.Y };
      _effect.Parameters["g_center"] = new float[2] { Center.X, Center.Y };
      _effect.Parameters["g_radius"] = new float[2] { (float)RadiusX, (float)RadiusY };
      Matrix m = Matrix.Identity;
      RelativeTransform.GetTransform(out m);
      _effect.Parameters["RelativeTransform"] = m;

      _effect.StartRender(_texture);
      _lastTimeUsed = SkinContext.Now;
    }

    public override void EndRender()
    {
      if (_effect != null)
      {
        _effect.EndRender();
        _effect = null;
      }
    }


    #region IAsset Members

    public bool IsAllocated
    {
      get
      {
        return (_texture != null);
      }
    }

    public bool CanBeDeleted
    {
      get
      {
        if (!IsAllocated)
        {
          return false;
        }
        TimeSpan ts = SkinContext.Now - _lastTimeUsed;
        if (ts.TotalSeconds >= 1)
        {
          return true;
        }

        return false;
      }
    }

    public void Free()
    {
      if (_texture != null)
      {
        _texture.Dispose();
        _texture = null;
      }
    }

    #endregion
  }
}

