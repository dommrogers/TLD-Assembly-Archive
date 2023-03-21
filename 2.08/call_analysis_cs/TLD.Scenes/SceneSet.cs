using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace TLD.Scenes;

public class SceneSet : ScriptableObject
{
	private LocalizedString m_SceneName;

	private bool m_IsOutdoors;

	private RegionGroupSpecification m_RegionGroup;

	private AssetReference m_BaseScene;

	private List<AssetReference> m_AdditiveScenes;

	private List<ConditionalScene> m_ConditionalScenes;

	private List<SceneResolutionOverride> m_ResolutionOverrides;

	[NonSerialized]
	private List<SceneSetExtension> m_Extensions;

	public SceneWeatherOverrideData m_SceneWeatherOverrides;

	private ICollection<AsyncOperationHandle<SceneInstance>> m_LoadOperations;

	private ICollection<SceneLoadCondition> m_Conditions;

	private Action<ICollection<AsyncOperationHandle<SceneInstance>>> m_OnAllLoadsStarted;

	public bool IsOutdoors
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public string NameLocId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string LocalizedName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string RegionGroupName
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		get
		{
			return null;
		}
	}

	public string RegionGroupNameLocId
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string LocalizedRegionGroupName
	{
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
		[CalledBy(Type = typeof(HUDManager._003CWaitToShowLocationReveal_003Ed__27), Member = "MoveNext")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public int MaxSceneCount
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(ZoneSpecification), Member = "UnloadRegionAsync")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(ZoneSpecification), Member = "LoadRegionAsync")]
		get
		{
			return default(int);
		}
	}

	[CalledBy(Type = typeof(ZoneSpecification), Member = "LoadRegionAsync")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SceneSet), Member = "OnBaseSceneLoaded")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CallsUnknownMethods(Count = 11)]
	public void LoadAsync(ICollection<AsyncOperationHandle<SceneInstance>> loadOperations, ICollection<SceneLoadCondition> conditions, Action<ICollection<AsyncOperationHandle<SceneInstance>>> onAllLoadsStarted = null)
	{
	}

	[CalledBy(Type = typeof(SceneSet), Member = "LoadAsync")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(SceneSet), Member = "LoadAdditiveAndConditionalScenes")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SceneSet), Member = "LoadAdditiveAndConditionalScenes")]
	private void OnBaseSceneLoaded(AsyncOperationHandle<SceneInstance> sceneLoad)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(AssetReference), Member = "IsValid")]
	[Calls(Type = typeof(AssetReference), Member = "IsValid")]
	[CalledBy(Type = typeof(SceneSet), Member = "OnBaseSceneLoaded")]
	[CalledBy(Type = typeof(SceneSet), Member = "OnBaseSceneLoaded")]
	[CallsUnknownMethods(Count = 28)]
	private void LoadAdditiveAndConditionalScenes(ICollection<AssetReference> additiveScenes, ICollection<ConditionalScene> conditionalScenes)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(ZoneSpecification), Member = "UnloadRegionAsync")]
	[Calls(Type = typeof(SceneSet), Member = "IsSceneLoaded")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SceneSet), Member = "IsSceneLoaded")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SceneSet), Member = "IsSceneLoaded")]
	public void UnloadAsync(ICollection<AsyncOperationHandle<SceneInstance>> unloadOperations)
	{
	}

	[CalledBy(Type = typeof(SceneSet), Member = "UnloadAsync")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(SceneSet), Member = "UnloadAsync")]
	[CalledBy(Type = typeof(SceneSet), Member = "UnloadAsync")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	private static bool IsSceneLoaded(AssetReference sceneReference)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void AddExtension(SceneSetExtension extension)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetRuntimeSceneResolutionOverride()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public SceneSet()
	{
	}
}
