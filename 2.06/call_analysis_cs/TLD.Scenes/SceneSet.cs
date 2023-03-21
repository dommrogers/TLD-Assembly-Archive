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

	[NonSerialized]
	private List<SceneSetExtension> m_Extensions;

	public SceneWeatherOverrideData m_SceneWeatherOverrides;

	private ICollection<AsyncOperationHandle<SceneInstance>> m_LoadOperations;

	private ICollection<SceneLoadCondition> m_Conditions;

	private Action<ICollection<AsyncOperationHandle<SceneInstance>>> m_OnAllLoadsStarted;

	public bool IsOutdoors
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return default(bool);
		}
	}

	public string NameLocId
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallsUnknownMethods(Count = 1)]
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
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(HUDManager._003CWaitToShowLocationReveal_003Ed__22), Member = "MoveNext")]
		[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		get
		{
			return null;
		}
	}

	public int MaxSceneCount
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(ZoneSpecification), Member = "LoadRegionAsync")]
		[CalledBy(Type = typeof(ZoneSpecification), Member = "UnloadRegionAsync")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(ZoneSpecification), Member = "LoadRegionAsync")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SceneSet), Member = "OnBaseSceneLoaded")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	public void LoadAsync(ICollection<AsyncOperationHandle<SceneInstance>> loadOperations, ICollection<SceneLoadCondition> conditions, Action<ICollection<AsyncOperationHandle<SceneInstance>>> onAllLoadsStarted = null)
	{
	}

	[CalledBy(Type = typeof(SceneSet), Member = "LoadAsync")]
	[Calls(Type = typeof(SceneSet), Member = "LoadAdditiveAndConditionalScenes")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SceneSet), Member = "LoadAdditiveAndConditionalScenes")]
	private void OnBaseSceneLoaded(AsyncOperationHandle<SceneInstance> sceneLoad)
	{
	}

	[CallsUnknownMethods(Count = 30)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(AssetReference), Member = "IsValid")]
	[Calls(Type = typeof(AssetReference), Member = "IsValid")]
	[CalledBy(Type = typeof(SceneSet), Member = "OnBaseSceneLoaded")]
	[CalledBy(Type = typeof(SceneSet), Member = "OnBaseSceneLoaded")]
	private void LoadAdditiveAndConditionalScenes(ICollection<AssetReference> additiveScenes, ICollection<ConditionalScene> conditionalScenes)
	{
	}

	[CalledBy(Type = typeof(ZoneSpecification), Member = "UnloadRegionAsync")]
	[Calls(Type = typeof(SceneSet), Member = "IsSceneLoaded")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(SceneSet), Member = "IsSceneLoaded")]
	[Calls(Type = typeof(SceneSet), Member = "IsSceneLoaded")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	public void UnloadAsync(ICollection<AsyncOperationHandle<SceneInstance>> unloadOperations)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CalledBy(Type = typeof(SceneSet), Member = "UnloadAsync")]
	[CalledBy(Type = typeof(SceneSet), Member = "UnloadAsync")]
	[CalledBy(Type = typeof(SceneSet), Member = "UnloadAsync")]
	[CallsUnknownMethods(Count = 23)]
	private static bool IsSceneLoaded(AssetReference sceneReference)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void AddExtension(SceneSetExtension extension)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 16)]
	public SceneSet()
	{
	}
}
