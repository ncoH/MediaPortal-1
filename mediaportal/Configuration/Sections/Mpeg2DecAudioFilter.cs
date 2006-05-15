#region Copyright (C) 2005-2006 Team MediaPortal

/* 
 *	Copyright (C) 2005-2006 Team MediaPortal
 *	http://www.team-mediaportal.com
 *
 *  This Program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2, or (at your option)
 *  any later version.
 *   
 *  This Program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 *  GNU General Public License for more details.
 *   
 *  You should have received a copy of the GNU General Public License
 *  along with GNU Make; see the file COPYING.  If not, write to
 *  the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA. 
 *  http://www.gnu.org/copyleft/gpl.html
 *
 */

#endregion

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

using System.Runtime.InteropServices;

using DShowNET;
using DirectShowLib;

#pragma warning disable 108

namespace MediaPortal.Configuration.Sections
{

  public class MPEG2DecAudioFilter : MediaPortal.Configuration.SectionSettings
  {
    //private MediaPortal.UserInterface.Controls.MPLabel label1;
    private MediaPortal.UserInterface.Controls.MPRadioButton radioPCM16Bit;
    private MediaPortal.UserInterface.Controls.MPRadioButton radioButtonPCM24Bit;
    private MediaPortal.UserInterface.Controls.MPRadioButton radioButtonPCM32Bit;
    private MediaPortal.UserInterface.Controls.MPRadioButton radioButtonIEEE;
    private MediaPortal.UserInterface.Controls.MPCheckBox checkBoxNormalize;
    private System.Windows.Forms.TrackBar trackBarBoost;
    private MediaPortal.UserInterface.Controls.MPLabel label2;
    //private MediaPortal.UserInterface.Controls.MPLabel label3;
    //private MediaPortal.UserInterface.Controls.MPLabel label5;
    private MediaPortal.UserInterface.Controls.MPRadioButton radioButtonAC3Speakers;
    private MediaPortal.UserInterface.Controls.MPRadioButton radioButtonAC3SPDIF;
    private MediaPortal.UserInterface.Controls.MPCheckBox checkBoxAC3DynamicRange;
    private MediaPortal.UserInterface.Controls.MPComboBox comboBoxAC3SpeakerConfig;
    private MediaPortal.UserInterface.Controls.MPCheckBox checkBoxAC3LFE;
    private MediaPortal.UserInterface.Controls.MPComboBox comboBoxDTSSpeakerConfig;
    private MediaPortal.UserInterface.Controls.MPCheckBox checkBoxDTSDynamicRange;
    private MediaPortal.UserInterface.Controls.MPRadioButton radioButtonDTSSPDIF;
    private MediaPortal.UserInterface.Controls.MPRadioButton radioButtonDTSSpeakers;
    private MediaPortal.UserInterface.Controls.MPCheckBox checkBoxDTSLFE;
    private MediaPortal.UserInterface.Controls.MPCheckBox checkBoxAACDownmix;
    private MediaPortal.UserInterface.Controls.MPGroupBox groupBox2;
    private MediaPortal.UserInterface.Controls.MPGroupBox groupBox3;
    private MediaPortal.UserInterface.Controls.MPGroupBox groupBox4;
    private MediaPortal.UserInterface.Controls.MPGroupBox groupBox5;
    private MediaPortal.UserInterface.Controls.MPLabel label4;
    private MediaPortal.UserInterface.Controls.MPCheckBox checkBoxAACDynamic;
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 
    /// </summary>
    public MPEG2DecAudioFilter()
      : this("MPA Decoder")
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public MPEG2DecAudioFilter(string name)
      : base(name)
    {
      // This call is required by the Windows Form Designer.
      InitializeComponent();
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (components != null)
        {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }

    #region Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.groupBox4 = new MediaPortal.UserInterface.Controls.MPGroupBox();
      this.radioButtonAC3SPDIF = new MediaPortal.UserInterface.Controls.MPRadioButton();
      this.radioButtonAC3Speakers = new MediaPortal.UserInterface.Controls.MPRadioButton();
      this.checkBoxAC3LFE = new MediaPortal.UserInterface.Controls.MPCheckBox();
      this.comboBoxAC3SpeakerConfig = new MediaPortal.UserInterface.Controls.MPComboBox();
      this.checkBoxAC3DynamicRange = new MediaPortal.UserInterface.Controls.MPCheckBox();
      this.groupBox3 = new MediaPortal.UserInterface.Controls.MPGroupBox();
      this.label4 = new MediaPortal.UserInterface.Controls.MPLabel();
      this.radioPCM16Bit = new MediaPortal.UserInterface.Controls.MPRadioButton();
      this.radioButtonPCM24Bit = new MediaPortal.UserInterface.Controls.MPRadioButton();
      this.radioButtonPCM32Bit = new MediaPortal.UserInterface.Controls.MPRadioButton();
      this.radioButtonIEEE = new MediaPortal.UserInterface.Controls.MPRadioButton();
      this.checkBoxNormalize = new MediaPortal.UserInterface.Controls.MPCheckBox();
      this.trackBarBoost = new System.Windows.Forms.TrackBar();
      this.groupBox2 = new MediaPortal.UserInterface.Controls.MPGroupBox();
      this.radioButtonDTSSPDIF = new MediaPortal.UserInterface.Controls.MPRadioButton();
      this.radioButtonDTSSpeakers = new MediaPortal.UserInterface.Controls.MPRadioButton();
      this.checkBoxDTSLFE = new MediaPortal.UserInterface.Controls.MPCheckBox();
      this.comboBoxDTSSpeakerConfig = new MediaPortal.UserInterface.Controls.MPComboBox();
      this.checkBoxDTSDynamicRange = new MediaPortal.UserInterface.Controls.MPCheckBox();
      this.groupBox5 = new MediaPortal.UserInterface.Controls.MPGroupBox();
      this.checkBoxAACDownmix = new MediaPortal.UserInterface.Controls.MPCheckBox();
      this.label2 = new MediaPortal.UserInterface.Controls.MPLabel();
      this.checkBoxAACDynamic = new MediaPortal.UserInterface.Controls.MPCheckBox();
      this.groupBox4.SuspendLayout();
      this.groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarBoost)).BeginInit();
      this.groupBox2.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox4
      // 
      this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox4.Controls.Add(this.radioButtonAC3SPDIF);
      this.groupBox4.Controls.Add(this.radioButtonAC3Speakers);
      this.groupBox4.Controls.Add(this.checkBoxAC3LFE);
      this.groupBox4.Controls.Add(this.comboBoxAC3SpeakerConfig);
      this.groupBox4.Controls.Add(this.checkBoxAC3DynamicRange);
      this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox4.Location = new System.Drawing.Point(0, 0);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(472, 104);
      this.groupBox4.TabIndex = 0;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "AC3 Decoder Settings";
      // 
      // radioButtonAC3SPDIF
      // 
      this.radioButtonAC3SPDIF.AutoSize = true;
      this.radioButtonAC3SPDIF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonAC3SPDIF.Location = new System.Drawing.Point(16, 48);
      this.radioButtonAC3SPDIF.Name = "radioButtonAC3SPDIF";
      this.radioButtonAC3SPDIF.Size = new System.Drawing.Size(60, 17);
      this.radioButtonAC3SPDIF.TabIndex = 3;
      this.radioButtonAC3SPDIF.Text = "S/PDIF";
      this.radioButtonAC3SPDIF.UseVisualStyleBackColor = true;
      this.radioButtonAC3SPDIF.CheckedChanged += new System.EventHandler(this.radioButtonAC3SPDIF_CheckedChanged);
      // 
      // radioButtonAC3Speakers
      // 
      this.radioButtonAC3Speakers.AutoSize = true;
      this.radioButtonAC3Speakers.Checked = true;
      this.radioButtonAC3Speakers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonAC3Speakers.Location = new System.Drawing.Point(16, 24);
      this.radioButtonAC3Speakers.Name = "radioButtonAC3Speakers";
      this.radioButtonAC3Speakers.Size = new System.Drawing.Size(123, 17);
      this.radioButtonAC3Speakers.TabIndex = 0;
      this.radioButtonAC3Speakers.TabStop = true;
      this.radioButtonAC3Speakers.Text = "Decode to speakers:";
      this.radioButtonAC3Speakers.UseVisualStyleBackColor = true;
      this.radioButtonAC3Speakers.CheckedChanged += new System.EventHandler(this.radioButtonAC3Speakers_CheckedChanged);
      // 
      // checkBoxAC3LFE
      // 
      this.checkBoxAC3LFE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.checkBoxAC3LFE.AutoSize = true;
      this.checkBoxAC3LFE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.checkBoxAC3LFE.Location = new System.Drawing.Point(413, 24);
      this.checkBoxAC3LFE.Name = "checkBoxAC3LFE";
      this.checkBoxAC3LFE.Size = new System.Drawing.Size(43, 17);
      this.checkBoxAC3LFE.TabIndex = 2;
      this.checkBoxAC3LFE.Text = "LFE";
      this.checkBoxAC3LFE.UseVisualStyleBackColor = true;
      // 
      // comboBoxAC3SpeakerConfig
      // 
      this.comboBoxAC3SpeakerConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBoxAC3SpeakerConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxAC3SpeakerConfig.Items.AddRange(new object[] {
            "Mono",
            "Dual Mono",
            "Stereo",
            "Dolby Stereo",
            "3 Front",
            "2 Front + 1 Rear",
            "3 Front + 1 Rear",
            "2 Front + 2 Rear",
            "3 Front + 2 Rear",
            "Channel 1",
            "Channel 2",
            ""});
      this.comboBoxAC3SpeakerConfig.Location = new System.Drawing.Point(168, 20);
      this.comboBoxAC3SpeakerConfig.Name = "comboBoxAC3SpeakerConfig";
      this.comboBoxAC3SpeakerConfig.Size = new System.Drawing.Size(240, 21);
      this.comboBoxAC3SpeakerConfig.TabIndex = 1;
      // 
      // checkBoxAC3DynamicRange
      // 
      this.checkBoxAC3DynamicRange.AutoSize = true;
      this.checkBoxAC3DynamicRange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.checkBoxAC3DynamicRange.Location = new System.Drawing.Point(16, 72);
      this.checkBoxAC3DynamicRange.Name = "checkBoxAC3DynamicRange";
      this.checkBoxAC3DynamicRange.Size = new System.Drawing.Size(136, 17);
      this.checkBoxAC3DynamicRange.TabIndex = 4;
      this.checkBoxAC3DynamicRange.Text = "Dynamic Range Control";
      this.checkBoxAC3DynamicRange.UseVisualStyleBackColor = true;
      // 
      // groupBox3
      // 
      this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox3.Controls.Add(this.label4);
      this.groupBox3.Controls.Add(this.radioPCM16Bit);
      this.groupBox3.Controls.Add(this.radioButtonPCM24Bit);
      this.groupBox3.Controls.Add(this.radioButtonPCM32Bit);
      this.groupBox3.Controls.Add(this.radioButtonIEEE);
      this.groupBox3.Controls.Add(this.checkBoxNormalize);
      this.groupBox3.Controls.Add(this.trackBarBoost);
      this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.groupBox3.Location = new System.Drawing.Point(0, 224);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(472, 121);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "AC3/AAC/DTS/LPCM Format";
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(16, 56);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(40, 16);
      this.label4.TabIndex = 4;
      this.label4.Text = "Boost:";
      // 
      // radioPCM16Bit
      // 
      this.radioPCM16Bit.AutoSize = true;
      this.radioPCM16Bit.Checked = true;
      this.radioPCM16Bit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioPCM16Bit.Location = new System.Drawing.Point(16, 24);
      this.radioPCM16Bit.Name = "radioPCM16Bit";
      this.radioPCM16Bit.Size = new System.Drawing.Size(76, 17);
      this.radioPCM16Bit.TabIndex = 0;
      this.radioPCM16Bit.TabStop = true;
      this.radioPCM16Bit.Text = "PCM 16 bit";
      this.radioPCM16Bit.UseVisualStyleBackColor = true;
      // 
      // radioButtonPCM24Bit
      // 
      this.radioButtonPCM24Bit.AutoSize = true;
      this.radioButtonPCM24Bit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonPCM24Bit.Location = new System.Drawing.Point(104, 24);
      this.radioButtonPCM24Bit.Name = "radioButtonPCM24Bit";
      this.radioButtonPCM24Bit.Size = new System.Drawing.Size(76, 17);
      this.radioButtonPCM24Bit.TabIndex = 1;
      this.radioButtonPCM24Bit.Text = "PCM 24 bit";
      this.radioButtonPCM24Bit.UseVisualStyleBackColor = true;
      // 
      // radioButtonPCM32Bit
      // 
      this.radioButtonPCM32Bit.AutoSize = true;
      this.radioButtonPCM32Bit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonPCM32Bit.Location = new System.Drawing.Point(192, 24);
      this.radioButtonPCM32Bit.Name = "radioButtonPCM32Bit";
      this.radioButtonPCM32Bit.Size = new System.Drawing.Size(76, 17);
      this.radioButtonPCM32Bit.TabIndex = 2;
      this.radioButtonPCM32Bit.Text = "PCM 32 bit";
      this.radioButtonPCM32Bit.UseVisualStyleBackColor = true;
      // 
      // radioButtonIEEE
      // 
      this.radioButtonIEEE.AutoSize = true;
      this.radioButtonIEEE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonIEEE.Location = new System.Drawing.Point(288, 24);
      this.radioButtonIEEE.Name = "radioButtonIEEE";
      this.radioButtonIEEE.Size = new System.Drawing.Size(71, 17);
      this.radioButtonIEEE.TabIndex = 3;
      this.radioButtonIEEE.Text = "IEEE float";
      this.radioButtonIEEE.UseVisualStyleBackColor = true;
      // 
      // checkBoxNormalize
      // 
      this.checkBoxNormalize.AutoSize = true;
      this.checkBoxNormalize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.checkBoxNormalize.Location = new System.Drawing.Point(16, 89);
      this.checkBoxNormalize.Name = "checkBoxNormalize";
      this.checkBoxNormalize.Size = new System.Drawing.Size(70, 17);
      this.checkBoxNormalize.TabIndex = 6;
      this.checkBoxNormalize.Text = "Normalize";
      this.checkBoxNormalize.UseVisualStyleBackColor = true;
      // 
      // trackBarBoost
      // 
      this.trackBarBoost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBarBoost.Location = new System.Drawing.Point(48, 52);
      this.trackBarBoost.Maximum = 100;
      this.trackBarBoost.Name = "trackBarBoost";
      this.trackBarBoost.Size = new System.Drawing.Size(200, 45);
      this.trackBarBoost.TabIndex = 5;
      this.trackBarBoost.TickStyle = System.Windows.Forms.TickStyle.None;
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.radioButtonDTSSPDIF);
      this.groupBox2.Controls.Add(this.radioButtonDTSSpeakers);
      this.groupBox2.Controls.Add(this.checkBoxDTSLFE);
      this.groupBox2.Controls.Add(this.comboBoxDTSSpeakerConfig);
      this.groupBox2.Controls.Add(this.checkBoxDTSDynamicRange);
      this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.groupBox2.Location = new System.Drawing.Point(0, 112);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(472, 104);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "DTS Decoder Settings";
      // 
      // radioButtonDTSSPDIF
      // 
      this.radioButtonDTSSPDIF.AutoSize = true;
      this.radioButtonDTSSPDIF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonDTSSPDIF.Location = new System.Drawing.Point(16, 48);
      this.radioButtonDTSSPDIF.Name = "radioButtonDTSSPDIF";
      this.radioButtonDTSSPDIF.Size = new System.Drawing.Size(60, 17);
      this.radioButtonDTSSPDIF.TabIndex = 3;
      this.radioButtonDTSSPDIF.Text = "S/PDIF";
      this.radioButtonDTSSPDIF.UseVisualStyleBackColor = true;
      this.radioButtonDTSSPDIF.CheckedChanged += new System.EventHandler(this.radioButtonDTSSPDIF_CheckedChanged);
      // 
      // radioButtonDTSSpeakers
      // 
      this.radioButtonDTSSpeakers.AutoSize = true;
      this.radioButtonDTSSpeakers.Checked = true;
      this.radioButtonDTSSpeakers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radioButtonDTSSpeakers.Location = new System.Drawing.Point(16, 24);
      this.radioButtonDTSSpeakers.Name = "radioButtonDTSSpeakers";
      this.radioButtonDTSSpeakers.Size = new System.Drawing.Size(123, 17);
      this.radioButtonDTSSpeakers.TabIndex = 0;
      this.radioButtonDTSSpeakers.TabStop = true;
      this.radioButtonDTSSpeakers.Text = "Decode to speakers:";
      this.radioButtonDTSSpeakers.UseVisualStyleBackColor = true;
      this.radioButtonDTSSpeakers.CheckedChanged += new System.EventHandler(this.radioButtonDTSSpeakers_CheckedChanged);
      // 
      // checkBoxDTSLFE
      // 
      this.checkBoxDTSLFE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.checkBoxDTSLFE.AutoSize = true;
      this.checkBoxDTSLFE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.checkBoxDTSLFE.Location = new System.Drawing.Point(413, 24);
      this.checkBoxDTSLFE.Name = "checkBoxDTSLFE";
      this.checkBoxDTSLFE.Size = new System.Drawing.Size(43, 17);
      this.checkBoxDTSLFE.TabIndex = 2;
      this.checkBoxDTSLFE.Text = "LFE";
      this.checkBoxDTSLFE.UseVisualStyleBackColor = true;
      // 
      // comboBoxDTSSpeakerConfig
      // 
      this.comboBoxDTSSpeakerConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBoxDTSSpeakerConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxDTSSpeakerConfig.Items.AddRange(new object[] {
            "Mono",
            "Dual Mono",
            "Stereo",
            "3 Front",
            "2 Front + 1 Rear",
            "3 Front + 1 Rear",
            "2 Front + 2 Rear",
            "3 Front + 2 Rear"});
      this.comboBoxDTSSpeakerConfig.Location = new System.Drawing.Point(168, 20);
      this.comboBoxDTSSpeakerConfig.Name = "comboBoxDTSSpeakerConfig";
      this.comboBoxDTSSpeakerConfig.Size = new System.Drawing.Size(240, 21);
      this.comboBoxDTSSpeakerConfig.TabIndex = 1;
      // 
      // checkBoxDTSDynamicRange
      // 
      this.checkBoxDTSDynamicRange.AutoSize = true;
      this.checkBoxDTSDynamicRange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.checkBoxDTSDynamicRange.Location = new System.Drawing.Point(16, 72);
      this.checkBoxDTSDynamicRange.Name = "checkBoxDTSDynamicRange";
      this.checkBoxDTSDynamicRange.Size = new System.Drawing.Size(136, 17);
      this.checkBoxDTSDynamicRange.TabIndex = 4;
      this.checkBoxDTSDynamicRange.Text = "Dynamic Range Control";
      this.checkBoxDTSDynamicRange.UseVisualStyleBackColor = true;
      // 
      // groupBox5
      // 
      this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox5.Controls.Add(this.checkBoxAACDynamic);
      this.groupBox5.Controls.Add(this.checkBoxAACDownmix);
      this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.groupBox5.Location = new System.Drawing.Point(0, 353);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(472, 52);
      this.groupBox5.TabIndex = 3;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "AAC Decoder Settings";
      // 
      // checkBoxAACDownmix
      // 
      this.checkBoxAACDownmix.AutoSize = true;
      this.checkBoxAACDownmix.Checked = true;
      this.checkBoxAACDownmix.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxAACDownmix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.checkBoxAACDownmix.Location = new System.Drawing.Point(16, 24);
      this.checkBoxAACDownmix.Name = "checkBoxAACDownmix";
      this.checkBoxAACDownmix.Size = new System.Drawing.Size(111, 17);
      this.checkBoxAACDownmix.TabIndex = 0;
      this.checkBoxAACDownmix.Text = "Downmix to stereo";
      this.checkBoxAACDownmix.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(104, 64);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 16);
      this.label2.TabIndex = 7;
      this.label2.Text = "Boost:";
      // 
      // checkBoxAACDynamic
      // 
      this.checkBoxAACDynamic.AutoSize = true;
      this.checkBoxAACDynamic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.checkBoxAACDynamic.Location = new System.Drawing.Point(192, 24);
      this.checkBoxAACDynamic.Name = "checkBoxAACDynamic";
      this.checkBoxAACDynamic.Size = new System.Drawing.Size(136, 17);
      this.checkBoxAACDynamic.TabIndex = 5;
      this.checkBoxAACDynamic.Text = "Dynamic Range Control";
      this.checkBoxAACDynamic.UseVisualStyleBackColor = true;
      this.checkBoxAACDynamic.CheckedChanged += new System.EventHandler(this.checkBoxAACDynamic_CheckedChanged);
      // 
      // MPEG2DecAudioFilter
      // 
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox5);
      this.Name = "MPEG2DecAudioFilter";
      this.Size = new System.Drawing.Size(472, 408);
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarBoost)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.ResumeLayout(false);

    }
    #endregion

    public override void LoadSettings()
    {
      RegistryKey hkcu = Registry.CurrentUser;
      RegistryKey subkey = hkcu.CreateSubKey(@"Software\Gabest\Filters\MPEG Audio Decoder");
      if (subkey != null)
      {
        try
        {
          long regValue = (long)subkey.GetValue("AacSpeakerConfig");
          if (regValue == 1) checkBoxAACDownmix.Checked = true;
          else checkBoxAACDownmix.Checked = false;

          regValue = (long)subkey.GetValue("AacDynamicRangeControl");
          if (regValue == 1) checkBoxAC3DynamicRange.Checked = true;
          else checkBoxAC3DynamicRange.Checked = false;

          regValue = (long)subkey.GetValue("Ac3DynamicRangeControl");
          if (regValue == 1) checkBoxAC3DynamicRange.Checked = true;
          else checkBoxAC3DynamicRange.Checked = false;

          regValue = (long)subkey.GetValue("Ac3SpeakerConfig");
          if (regValue >= 16) checkBoxAC3LFE.Checked = true;
          else checkBoxAC3LFE.Checked = false;

          regValue = (long)subkey.GetValue("DtsDynamicRangeControl");
          if (regValue == 1) checkBoxDTSDynamicRange.Checked = true;
          else checkBoxDTSDynamicRange.Checked = false;

          regValue = (long)subkey.GetValue("DtsSpeakerConfig");
          if (regValue == 4294967166) checkBoxDTSLFE.Checked = true;
          else checkBoxDTSLFE.Checked = false;

          regValue = (long)subkey.GetValue("Normalize");
          if (regValue == 1) checkBoxNormalize.Checked = true;
          else checkBoxNormalize.Checked = false;

          regValue = (long)subkey.GetValue("Ac3SpeakerConfig");
          comboBoxAC3SpeakerConfig.SelectedIndex = (int)regValue;

          regValue = (long)subkey.GetValue("DtsSpeakerConfig");
          comboBoxDTSSpeakerConfig.SelectedIndex = (int)regValue;

          regValue = (long)subkey.GetValue("Boost");
          trackBarBoost.Value = (int)regValue;

          regValue = (long)subkey.GetValue("SampleFormat");
          radioPCM16Bit.Checked = (regValue == 0);
          radioButtonPCM24Bit.Checked = (regValue == 1);
          radioButtonPCM32Bit.Checked = (regValue == 2);
          radioButtonIEEE.Checked = (regValue == 3);

          regValue = (long)subkey.GetValue("Ac3SpeakerConfig");
          radioButtonAC3Speakers.Checked = (regValue == 0);
          radioButtonAC3SPDIF.Checked = (regValue <= -1);


          regValue = (long)subkey.GetValue("DtsSpeakerConfig");
          radioButtonDTSSpeakers.Checked = (regValue == 0);
          radioButtonDTSSPDIF.Checked = (regValue == -1);
        }
        catch (Exception)
        {
        }
        finally
        {
          subkey.Close();
        }
      }
    }
    public override void SaveSettings()
    {
      RegistryKey hkcu = Registry.CurrentUser;
      RegistryKey subkey = hkcu.CreateSubKey(@"Software\Gabest\Filters\MPEG Audio Decoder");
      if (subkey != null)
      {
        Int32 regValue;
        if (checkBoxAACDownmix.Checked) regValue = 1;
        else regValue = 0;
        subkey.SetValue("AacSpeakerConfig", regValue);

        if (checkBoxAACDynamic.Checked) regValue = 1;
        else regValue = 0;
        subkey.SetValue("AacDynamicRangeControl", regValue);

        if (checkBoxAC3DynamicRange.Checked) regValue = 1;
        else regValue = 0;
        subkey.SetValue("Ac3DynamicRangeControl", regValue);

        if (checkBoxAC3LFE.Checked) regValue = -1;
        else regValue = 0;
        subkey.SetValue("Ac3SpeakerConfig", regValue);

        if (checkBoxDTSDynamicRange.Checked) regValue = 1;
        else regValue = 0;
        subkey.SetValue("DtsDynamicRangeControl", regValue);

        if (checkBoxDTSLFE.Checked) regValue = -1;
        else regValue = 0;
        subkey.SetValue("DtsSpeakerConfig", regValue);

        if (checkBoxNormalize.Checked) regValue = 1;
        else regValue = 0;
        subkey.SetValue("Normalize", regValue);

        subkey.SetValue("Ac3SpeakerConfig", comboBoxAC3SpeakerConfig.SelectedIndex);
        subkey.SetValue("DtsSpeakerConfig", comboBoxDTSSpeakerConfig.SelectedIndex);
        subkey.SetValue("Boost", trackBarBoost.Value);

        if (radioPCM16Bit.Checked) regValue = 0;
        if (radioButtonPCM24Bit.Checked) regValue = 1;
        if (radioButtonPCM32Bit.Checked) regValue = 2;
        if (radioButtonIEEE.Checked) regValue = 3;
        subkey.SetValue("SampleFormat", regValue);

        if (radioButtonAC3Speakers.Checked) regValue = 0;
        if (radioButtonAC3SPDIF.Checked) regValue = -1;
        subkey.SetValue("Ac3SpeakerConfig", regValue);

        if (radioButtonDTSSpeakers.Checked) regValue = 0;
        if (radioButtonDTSSPDIF.Checked) regValue = -1;
        subkey.SetValue("DtsSpeakerConfig", regValue);

        subkey.Close();
      }
    }

    private void radioButtonAC3Speakers_CheckedChanged(object sender, System.EventArgs e)
    {
      if (radioButtonAC3Speakers.Checked)
      {
        //comboBoxAC3SpeakerConfig.Enabled=true;
        //checkBoxAC3LFE.Enabled=true;
      }

    }

    private void radioButtonAC3SPDIF_CheckedChanged(object sender, System.EventArgs e)
    {
      if (radioButtonAC3SPDIF.Checked)
      {
        //comboBoxAC3SpeakerConfig.Enabled=false;
        //checkBoxAC3LFE.Enabled=false;
      }
    }

    private void radioButtonDTSSpeakers_CheckedChanged(object sender, System.EventArgs e)
    {
      if (radioButtonDTSSpeakers.Checked)
      {
        //comboBoxDTSSpeakerConfig.Enabled=true;
        //checkBoxDTSLFE.Enabled=true;
      }
    }

    private void radioButtonDTSSPDIF_CheckedChanged(object sender, System.EventArgs e)
    {
      if (radioButtonDTSSPDIF.Checked)
      {
        //comboBoxDTSSpeakerConfig.Enabled=false;
        //checkBoxDTSLFE.Enabled=false;
      }
    }

    private void checkBoxAACDynamic_CheckedChanged(object sender, EventArgs e)
    {

    }

  }
}

