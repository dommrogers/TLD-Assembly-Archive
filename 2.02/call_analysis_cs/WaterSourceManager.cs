using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WaterSourceManager
{
	public static List<WaterSource> m_WaterSources;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static void DisableAll()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WaterSourceSaveList), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(WaterSource), Member = "Serialize")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 38)]
	public static string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(WaterSourceManager), Member = "FindWaterSourceByGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WaterSourceManager), Member = "FindWaterSourceByPosition")]
	[Calls(Type = typeof(WaterSource), Member = "Deserialize")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(WaterSourceManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private static WaterSource FindWaterSourceByPosition(WaterSourceSaveData wsd)
	{
		return null;
	}

	[CalledBy(Type = typeof(WaterSourceManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static WaterSource FindWaterSourceByGuid(string guid)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public WaterSourceManager()
	{
	}
}
