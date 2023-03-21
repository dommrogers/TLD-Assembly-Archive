using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class RandomSpawnObjectManager : MonoBehaviour
{
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldSkipSerialization")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldAllSkipSerialization")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	public static string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "LoadObject")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "HasObject")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAllAndCheckContainers")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldSkipSerialization")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "PruneMissingObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public RandomSpawnObjectManager()
	{
	}
}
