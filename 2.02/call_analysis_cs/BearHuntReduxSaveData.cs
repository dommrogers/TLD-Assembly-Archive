using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class BearHuntReduxSaveData
{
	public bool m_DeprecatedActive;

	public bool m_Completed;

	public int m_DeprecatedTreeEncounterWonCount;

	public List<BearEncounterInfo> m_BearEncounterInfoList;

	public bool m_PlayerDiesAfterSpearMiss;

	[CalledBy(Type = typeof(BearHuntRedux), Member = ".cctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public BearHuntReduxSaveData()
	{
	}
}
