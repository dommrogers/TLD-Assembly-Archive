using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using TLD.Stats;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Scenes;

public class RegionSpecification : ZoneSpecification
{
	public enum UnlockMode
	{
		Unlocked,
		Visited,
		Code
	}

	private LocalizedString m_RegionDescription;

	private AssetReferenceTexture2D m_MiniMap;

	private AssetReferenceGameObject m_SelectRegionPrefab;

	private List<SceneSet> m_InteriorSpawnScenes;

	private UnlockMode m_UnlockMode;

	public StatID m_HoursInRegionStat;

	public string RegionDescription
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public string LocalizedRegionDescription
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public bool HasMiniMapTexture
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public bool HasSelectRegionItem
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public int IndoorSpawnCount
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public SceneSet GetIndoorSpawnScene(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public AsyncOperationHandle<Texture2D> GetMiniMapTextureAsync()
	{
		return default(AsyncOperationHandle<Texture2D>);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ReleaseMiniMapTexture()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public AsyncOperationHandle<GameObject> InstantiateSelectRegionItemAsync(Transform parent)
	{
		return default(AsyncOperationHandle<GameObject>);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateDisplayedRegions")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_unlock_region")]
	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "DoesMapHaveUnlockedRegions")]
	[CalledBy(Type = typeof(SandboxBaseConfig), Member = "GetRandomRegionFromAllAvailable")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsUnlocked()
	{
		return default(bool);
	}

	[Calls(Type = typeof(RegionSpecification), Member = "MaybeUnlock")]
	[CallerCount(Count = 0)]
	public void Visit()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ForceUnlock()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_unlock_region")]
	[CalledBy(Type = typeof(GameManager._003C_003Ec), Member = "<LoadSceneAsynchronously>b__294_0")]
	[CalledBy(Type = typeof(RegionSpecification), Member = "Visit")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeUnlock(UnlockMode reason)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private bool HasBeenVisited()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public RegionSpecification()
	{
	}
}
