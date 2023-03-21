using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class BearHuntReduxSaveData
{
	public bool m_DeprecatedActive;

	public bool m_Completed;

	public int m_DeprecatedTreeEncounterWonCount;

	public List<BearEncounterInfo> m_BearEncounterInfoList;

	public bool m_PlayerDiesAfterSpearMiss;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = ".cctor")]
	[CallsUnknownMethods(Count = 7)]
	public BearHuntReduxSaveData()
	{
	}
}
