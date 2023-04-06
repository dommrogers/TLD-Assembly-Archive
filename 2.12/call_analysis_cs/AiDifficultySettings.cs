using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiDifficultySettings : MonoBehaviour
{
	private readonly List<AiDifficultySetting> m_Settings;

	[CalledBy(Type = typeof(BaseAi), Member = "Start_Common")]
	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	[CallerCount(Count = 4)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public AiDifficultySetting GetSetting(AiDifficulty difficulty, AiSubType ast)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void InitializeSettings()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public AiDifficultySettings()
	{
	}
}
