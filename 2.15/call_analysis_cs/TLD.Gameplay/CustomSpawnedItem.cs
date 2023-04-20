using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Pool;

namespace TLD.Gameplay;

public class CustomSpawnedItem : MonoBehaviour
{
	private AssetReference _003CAddress_003Ek__BackingField;

	private string _003CGuid_003Ek__BackingField;

	private Dictionary<string, CustomSpawnedItemChild> m_Children;

	public AssetReference Address
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 86)]
		set
		{
		}
	}

	public string Guid
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 55)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeGetGuidFromGameObject")]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PooledObject<>), Member = "System.IDisposable.Dispose")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(CustomSpawnedItemManager), Member = "SpawnBigItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CustomSpawnedItem), Member = "SetGuid")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(CustomSpawnedItemChild), Member = "SetGuid")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void InitializeSpawnedItem()
	{
	}

	[CalledBy(Type = typeof(CustomSpawnedItemManager), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	public CustomSpawnedItemSaveData Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(CustomSpawnedItemManager), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CustomSpawnedItem), Member = "SetGuid")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(CustomSpawnedItemChild), Member = "SetGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	public void Deserialize(CustomSpawnedItemSaveData saveData)
	{
	}

	[CalledBy(Type = typeof(CustomSpawnedItem), Member = "InitializeSpawnedItem")]
	[CalledBy(Type = typeof(CustomSpawnedItem), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeAttachObjectGuidAndRegister")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetGuid(string guid)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomSpawnedItem), Member = "ValidateChildren")]
	private void OnValidate()
	{
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(CustomSpawnedItem), Member = "OnValidate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(PooledObject<>), Member = "System.IDisposable.Dispose")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 14)]
	private void ValidateChildren<T>() where T : Component
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public CustomSpawnedItem()
	{
	}
}
