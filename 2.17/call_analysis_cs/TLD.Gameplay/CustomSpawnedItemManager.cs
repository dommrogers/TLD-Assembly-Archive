using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Serialization;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Pool;

namespace TLD.Gameplay;

public static class CustomSpawnedItemManager
{
	private static List<CustomSpawnedItem> s_Items;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterItem(CustomSpawnedItem item)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	public static void UnregisterItem(CustomSpawnedItem item)
	{
	}

	[CalledBy(Type = typeof(BeachcombingSpawner), Member = "DrawAndPlaceBigItems")]
	[CalledBy(Type = typeof(CustomSpawnedItemManager), Member = "DeserializeAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AssetHelper), Member = "TryInstantiateAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(CustomSpawnedItem), Member = "InitializeSpawnedItem")]
	[CallsUnknownMethods(Count = 1)]
	public static CustomSpawnedItem SpawnBigItem(AssetReference assetReference)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(CustomSpawnedItem), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(PooledObject<>), Member = "System.IDisposable.Dispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "TryDeserializeObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(CustomSpawnedItemManager), Member = "SpawnBigItem")]
	[Calls(Type = typeof(CustomSpawnedItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 3)]
	public static void DeserializeAll(string text)
	{
	}
}
