using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD;

public class MapDetailTrackerSO : ScriptableObject
{
	[NonSerialized]
	private List<MapDetail> m_MapDetailObjects;

	private static AsyncOperationHandle<MapDetailTrackerSO> s_Instance;

	[CalledBy(Type = typeof(MapDetail), Member = "OnDestroy")]
	[CalledBy(Type = typeof(MapDetail), Member = "Register")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "MaybeUnlockFaithfulCartographer")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "LogAllUnmappedLocations")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "LockAll")]
	[CalledBy(Type = typeof(MapDetailTrackerSO), Member = "GetMapDetailObjects")]
	[CalledBy(Type = typeof(MapDetailTrackerSO), Member = "Register")]
	[CalledBy(Type = typeof(MapDetailTrackerSO), Member = "Unregister")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "IsValid")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Status")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	public static MapDetailTrackerSO GetInstance()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerable<MapDetail> GetMapDetailObjects()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void Register(MapDetail md)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	public static void Unregister(MapDetail md)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public MapDetailTrackerSO()
	{
	}
}
