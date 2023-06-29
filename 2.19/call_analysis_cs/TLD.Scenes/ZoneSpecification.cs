using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace TLD.Scenes;

public class ZoneSpecification : ScriptableObject
{
	public const string ZONE_LABEL = "Zone";

	public static readonly IList<string> ZONE_KEYS;

	private WorldMapSpecification m_WorldMap;

	private WorldToMap m_WorldToMap;

	private AssetReferenceGameObject m_RegionMap;

	private AssetReferenceGameObject m_MainMapIcon;

	private AssetReferenceTexture2D m_TOCTexture;

	private SceneSet m_Scenes;

	private ZoneSpecification m_ParentZoneSpecification;

	public SceneSet Scenes
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
	}

	public ZoneSpecification ParentZoneSpecification
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
	}

	public string ZoneName
	{
		[CalledBy(Type = typeof(Panel_Log), Member = "GetSurvivalRecordSummaryText")]
		[CalledBy(Type = typeof(SandboxRecord), Member = "GetSurvivalRecordSummaryText")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string ZoneNameId
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public bool HasRegionMap
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public bool HasMapIcon
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public WorldMapSpecification WorldMap
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
	}

	public WorldToMap WorldToMap
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(WorldToMap);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public AsyncOperationHandle<GameObject> InstantiateRegionMapAsync(Transform parent)
	{
		return default(AsyncOperationHandle<GameObject>);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public AsyncOperationHandle<GameObject> InstantiateMapIconAsync(Transform parent)
	{
		return default(AsyncOperationHandle<GameObject>);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	public Texture2D GetTOCTexture()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SceneSet), Member = "get_MaxSceneCount")]
	[Calls(Type = typeof(SceneSet), Member = "LoadAsync")]
	[CallsUnknownMethods(Count = 2)]
	public IList<AsyncOperationHandle<SceneInstance>> LoadRegionAsync(ICollection<SceneLoadCondition> conditions = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SceneSet), Member = "get_MaxSceneCount")]
	[Calls(Type = typeof(SceneSet), Member = "UnloadAsync")]
	[CallsUnknownMethods(Count = 2)]
	public IList<AsyncOperationHandle<SceneInstance>> UnloadRegionAsync()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public ZoneSpecification()
	{
	}
}
