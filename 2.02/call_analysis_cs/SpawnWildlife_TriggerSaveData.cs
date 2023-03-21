using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SpawnWildlife_TriggerSaveData
{
	public bool m_PlayerHasEnteredTrigger;

	public string m_Guid;

	public bool m_IsSpawnActive;

	public bool m_IsSpawnAuroraActive;

	public List<string> m_RemovedBaseAiGuids;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(SpawnWildlife_Trigger), Member = "Serialize")]
	[CallsUnknownMethods(Count = 7)]
	public SpawnWildlife_TriggerSaveData()
	{
	}
}
