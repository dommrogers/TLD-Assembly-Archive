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
			return false;
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
		[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
		[CalledBy(TypeFullName = "HUDManager.<WaitToShowLocationReveal>d__22", Member = "MoveNext")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public int MaxSceneCount
	{
		[CalledBy(Type = typeof(ZoneSpecification), Member = "LoadRegionAsync")]
		[CalledBy(Type = typeof(ZoneSpecification), Member = "UnloadRegionAsync")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CalledBy(Type = typeof(ZoneSpecification), Member = "LoadRegionAsync")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = ".ctor")]
	[Calls(Type = typeof(SceneSet), Member = "OnBaseSceneLoaded")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "add_Completed")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	public void LoadAsync(ICollection<AsyncOperationHandle<SceneInstance>> loadOperations, ICollection<SceneLoadCondition> conditions, Action<ICollection<AsyncOperationHandle<SceneInstance>>> onAllLoadsStarted = null)
	{
	}

	[CalledBy(Type = typeof(SceneSet), Member = "LoadAsync")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Status")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Result")]
	[Calls(Type = typeof(SceneSet), Member = "LoadAdditiveAndConditionalScenes")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnBaseSceneLoaded(AsyncOperationHandle<SceneInstance> sceneLoad)
	{
	}

	[CalledBy(Type = typeof(SceneSet), Member = "OnBaseSceneLoaded")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AssetReference), Member = "IsValid")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 30)]
	private void LoadAdditiveAndConditionalScenes(ICollection<AssetReference> additiveScenes, ICollection<ConditionalScene> conditionalScenes)
	{
	}

	[CalledBy(Type = typeof(ZoneSpecification), Member = "UnloadRegionAsync")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SceneSet), Member = "IsSceneLoaded")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	public void UnloadAsync(ICollection<AsyncOperationHandle<SceneInstance>> unloadOperations)
	{
	}

	[CalledBy(Type = typeof(SceneSet), Member = "UnloadAsync")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_IsDone")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Result")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	private static bool IsSceneLoaded(AssetReference sceneReference)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void AddExtension(SceneSetExtension extension)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	public SceneSet()
	{
	}
}
