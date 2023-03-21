using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SpawnWildlife_TriggerSaveData
{
	public bool m_PlayerHasEnteredTrigger;

	public string m_Guid;

	public bool m_IsSpawnActive;

	public bool m_IsSpawnAuroraActive;

	public List<string> m_RemovedBaseAiGuids;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public SpawnWildlife_TriggerSaveData()
	{
	}
}
