using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using UnityEngine;
using UnityEngine.Pool;

public class LootTableData : RandomTableData<AssetReferenceGearItem>
{
	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected override bool ShouldFilterOutPrefab(GameObject prefab)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PooledObject<>), Member = "System.IDisposable.Dispose")]
	[CallsUnknownMethods(Count = 8)]
	private bool ShouldDisableForCurrentMode(GameObject prefab)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallsUnknownMethods(Count = 1)]
	private ExperienceMode GetCurrentExperienceMode()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RandomTableData<>), Member = ".ctor")]
	public LootTableData()
	{
		((RandomTableData<>)(object)this)._002Ector();
	}
}
