using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiDifficultySettings : MonoBehaviour
{
	private List<AiDifficultySetting> m_Settings;

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BaseAi), Member = "Start_Common")]
	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AiDifficultySettings), Member = "InitializeSettings")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public AiDifficultySetting GetSetting(AiDifficulty difficulty, AiSubType ast)
	{
		return null;
	}

	[CalledBy(Type = typeof(AiDifficultySettings), Member = "GetSetting")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private void InitializeSettings()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public AiDifficultySettings()
	{
	}
}
