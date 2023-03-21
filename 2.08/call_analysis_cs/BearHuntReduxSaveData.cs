using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class BearHuntReduxSaveData
{
	public bool m_DeprecatedActive;

	public bool m_Completed;

	public int m_DeprecatedTreeEncounterWonCount;

	public List<BearEncounterInfo> m_BearEncounterInfoList;

	public bool m_PlayerDiesAfterSpearMiss;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public BearHuntReduxSaveData()
	{
	}
}
