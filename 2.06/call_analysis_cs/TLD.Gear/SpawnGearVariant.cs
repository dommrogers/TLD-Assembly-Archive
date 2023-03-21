using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Gear;

public class SpawnGearVariant : MonoBehaviour
{
	[Serializable]
	private struct SaveData
	{
		public string m_SpawnerGUID;
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
			[CallerCount(Count = 44)]
			[DeduplicatedMethod]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
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

		[DeduplicatedMethod]
		[DebuggerHidden]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 8)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private List<AssetReferenceGearItem> m_PrioritySpawnList;

	private GearItem m_SpawnedItem;

	private bool m_HasBeenDestroyed;

	private static readonly List<SpawnGearVariant> s_ActiveSpawners;

	private static readonly List<SaveData> s_SaveData;

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetObjectGuidFromGO")]
	[CallsDeduplicatedMethods(Count = 4)]
	public static string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SpawnGearVariant), Member = "FindSpawner")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnGearVariant), Member = "DeleteSpawnedItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 9)]
	public static void Deserialize(string jsonText)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[IteratorStateMachine(typeof(_003CStart_003Ed__9))]
	[CallerCount(Count = 0)]
	private IEnumerator Start()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 1)]
	private SaveData GetSaveData()
	{
		return default(SaveData);
	}

	[CalledBy(Type = typeof(SpawnGearVariant), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DeleteSpawnedItem()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(SpawnGearVariant), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 4)]
	private static SpawnGearVariant FindSpawner(string spawnerGuid)
	{
		return null;
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public SpawnGearVariant()
	{
	}
}
