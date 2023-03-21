using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class NeedPrefabSaveData
{
	public NPC_NeedPrefabInfo m_NeedPrefab;

	public bool m_HasBeenCompleted;

	public float m_CompletedTimeHoursPlayed;

	public string m_NeedPrefabName;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public NeedPrefabSaveData()
	{
	}
}
