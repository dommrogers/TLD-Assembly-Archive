using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Serialization;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Gear;

public class SpawnGearVariant : MonoBehaviour
{
	public class SaveData
	{
		public string m_SpawnerGUID;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public SaveData()
		{
		}
	}

	private sealed class _003CStart_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpawnGearVariant _003C_003E4__this;

		private int _003Ci_003E5__2;

		private AsyncOperationHandle<GameObject> _003Cop_003E5__3;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CStart_003Ed__9(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_IsDone")]
		[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Status")]
		[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Result")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
		[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
		[Calls(Type = typeof(Addressables), Member = "Release")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 7)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private List<AssetReferenceGearItem> m_PrioritySpawnList;

	private GearItem m_SpawnedItem;

	private bool m_HasBeenDestroyed;

	private static readonly List<SpawnGearVariant> s_ActiveSpawners;

	private static readonly List<SaveData> s_SaveData;

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public static string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(SpawnGearVariant), Member = "FindSpawner")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnGearVariant), Member = "DeleteSpawnedItem")]
	[CallsUnknownMethods(Count = 4)]
	public static void Deserialize(string jsonText)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__9))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator Start()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private SaveData GetSaveData()
	{
		return null;
	}

	[CalledBy(Type = typeof(SpawnGearVariant), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void DeleteSpawnedItem()
	{
	}

	[CalledBy(Type = typeof(SpawnGearVariant), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static SpawnGearVariant FindSpawner(string spawnerGuid)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SpawnGearVariant()
	{
	}
}
