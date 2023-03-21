using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RandomSpawnObjectManager : MonoBehaviour
{
	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldSkipSerialization")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldAllSkipSerialization")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(RandomSpawnObjectSaveList), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	public static string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "LoadObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "HasObject")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "DisableAllAndCheckContainers")]
	[Calls(Type = typeof(RandomSpawnObject), Member = "PruneMissingObjects")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RandomSpawnObject), Member = "ShouldSkipSerialization")]
	public static void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RandomSpawnObjectManager()
	{
	}
}
