using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;

public class WaterSourceManager
{
	public static List<WaterSource> m_WaterSources;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public static void DisableAll()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(WaterSource), Member = "Serialize")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	public static string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(WaterSource), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(WaterSourceManager), Member = "FindWaterSourceByPosition")]
	public static void Deserialize(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(WaterSourceManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 6)]
	private static WaterSource FindWaterSourceByPosition(WaterSourceSaveData wsd)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallsUnknownMethods(Count = 1)]
	private static WaterSource FindWaterSourceByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public WaterSourceManager()
	{
	}
}
