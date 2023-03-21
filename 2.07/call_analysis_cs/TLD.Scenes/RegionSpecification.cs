using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using TLD.SaveState;
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
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
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
			return false;
		}
	}

	public bool HasSelectRegionItem
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public int IndoorSpawnCount
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ReleaseMiniMapTexture()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public AsyncOperationHandle<GameObject> InstantiateSelectRegionItemAsync(Transform parent)
	{
		return default(AsyncOperationHandle<GameObject>);
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateDisplayedRegions")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_unlock_region")]
	[CalledBy(Type = typeof(WorldMapChangedEvent), Member = "DoesMapHaveUnlockedRegions")]
	[CalledBy(Type = typeof(SandboxBaseConfig), Member = "GetRandomRegionFromAllAvailable")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsUnlocked()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegionSpecification), Member = "MaybeUnlock")]
	public void Visit()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void ForceUnlock()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_unlock_region")]
	[CalledBy(TypeFullName = "GameManager.<>c", Member = "<LoadSceneAsynchronously>b__294_0")]
	[CalledBy(Type = typeof(RegionSpecification), Member = "Visit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeUnlock(UnlockMode reason)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasBeenVisited()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public RegionSpecification()
	{
	}
}
