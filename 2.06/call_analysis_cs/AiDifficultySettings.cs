using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiDifficultySettings : MonoBehaviour
{
	private readonly List<AiDifficultySetting> m_Settings;

	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[CalledBy(Type = typeof(BaseAi), Member = "Start_Common")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	public AiDifficultySetting GetSetting(AiDifficulty difficulty, AiSubType ast)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void InitializeSettings()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public AiDifficultySettings()
	{
	}
}
