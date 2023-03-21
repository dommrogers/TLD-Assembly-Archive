using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class UnlockablePrefabSaveData
{
	public NPC_UnlockablePrefabInfo m_UnlockablePrefab;

	public bool m_Unlocked;

	public string m_UnlockablePrefabName;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public UnlockablePrefabSaveData()
	{
	}
}
