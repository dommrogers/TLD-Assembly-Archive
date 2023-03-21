using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD;

public class MapDetailTrackerSO : ScriptableObject
{
	[NonSerialized]
	private List<MapDetail> m_MapDetailObjects;

	private static AsyncOperationHandle<MapDetailTrackerSO> s_Instance;

	[CalledBy(Type = typeof(MapDetailManager), Member = "LockAll")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MapDetailTrackerSO), Member = "Unregister")]
	[CalledBy(Type = typeof(MapDetailTrackerSO), Member = "Register")]
	[CalledBy(Type = typeof(MapDetailTrackerSO), Member = "GetMapDetailObjects")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "LogAllUnmappedLocations")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MapDetail), Member = "Register")]
	[CalledBy(Type = typeof(MapDetail), Member = "OnDestroy")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(MapDetailManager), Member = "MaybeUnlockFaithfulCartographer")]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public static void Register(MapDetail md)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static void Unregister(MapDetail md)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public MapDetailTrackerSO()
	{
	}
}
