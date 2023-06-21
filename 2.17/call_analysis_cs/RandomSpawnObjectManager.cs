using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class RandomSpawnObjectManager : MonoBehaviour
{
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldAllSkipSerialization")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldSkipSerialization")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public static string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "PruneMissingObjects")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAllAndCheckContainers")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldSkipSerialization")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "HasObject")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "LoadObject")]
	[CallsUnknownMethods(Count = 8)]
	public static void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public RandomSpawnObjectManager()
	{
	}
}
