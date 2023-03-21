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

	[CalledBy(Type = typeof(MapDetail), Member = "OnDestroy")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "MaybeUnlockFaithfulCartographer")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "LogAllUnmappedLocations")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "LockAll")]
	[CalledBy(Type = typeof(MapDetailTrackerSO), Member = "GetMapDetailObjects")]
	[CalledBy(Type = typeof(MapDetailTrackerSO), Member = "Register")]
	[CalledBy(Type = typeof(MapDetailTrackerSO), Member = "Unregister")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(Resources), Member = "LoadAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
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
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void Register(MapDetail md)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapDetailTrackerSO), Member = "GetInstance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void Unregister(MapDetail md)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public MapDetailTrackerSO()
	{
	}
}
