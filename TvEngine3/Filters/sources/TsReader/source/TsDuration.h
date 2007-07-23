#pragma once
#include "packetSync.h"
#include "FileReader.h"
#include "tsheader.h"
#include "Pcr.h"

class CTsDuration: public CPacketSync
{
public:
  CTsDuration();
  virtual ~CTsDuration(void);
  void SetFileReader(FileReader* reader);
	void OnTsPacket(byte* tsPacket);
  void UpdateDuration();
  void SetVideoPid(int pid);
  int  GetPid();
  CRefTime Duration();
  CPcr     StartPcr();
  CPcr     EndPcr();
  CPcr     MaxPcr();
  CPcr     FirstStartPcr();
  CRefTime TotalDuration();
  void     Set(CPcr& startPcr, CPcr& endPcr, CPcr& maxPcr);
private:
  int          m_pid;
  int          m_videoPid;
	FileReader*  m_reader;
  CPcr         m_startPcr;
  CPcr         m_endPcr;
  CPcr         m_maxPcr;
  CPcr         m_firstStartPcr;
  bool         m_bSearchStart;
  bool         m_bSearchEnd;
  bool         m_bSearchMax;
};
