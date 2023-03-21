using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD;

public class MapDetailTrackerSO : ScriptableObject
{
	[NonSerialized]
	private List<MapDetail> m_MapDetailObjects;

	private static MapDetailTrackerSO s_Instance;

	[CalledBy(Type = typeof(MapDetailManager), Member = "LockAll")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MapDetailTrackerSO), Member = "Unregister")]
	[CalledBy(Type = typeof(MapDetailTrackerSO), Member = "Register")]
	[CalledBy(Type = typeof(MapDetailTrackerSO), Member = "GetMapDetailObjects")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "LogAllUnmappedLocations")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "MaybeUnlockFaithfulCartographer")]
	[CalledBy(Type = typeof(MapDetail), Member = "OnDestroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 9)]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void Register(MapDetail md)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	public static void Unregister(MapDetail md)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public MapDetailTrackerSO()
	{
	}
}
