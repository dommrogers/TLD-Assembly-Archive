using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiDifficultySettings : MonoBehaviour
{
	private List<AiDifficultySetting> m_Settings;

	[CalledBy(Type = typeof(BaseAi), Member = "Start_Common")]
	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AiDifficultySettings), Member = "InitializeSettings")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public AiDifficultySettings()
	{
	}
}
