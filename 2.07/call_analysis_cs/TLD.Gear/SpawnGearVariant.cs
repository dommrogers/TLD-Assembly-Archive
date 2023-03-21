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
	public class SaveData
	{
		public string m_SpawnerGUID;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
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
			[CallerCount(Count = 28)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
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

		[CallsUnknownMethods(Count = 11)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
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

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	public static string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(SpawnGearVariant), Member = "DeleteSpawnedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpawnGearVariant), Member = "FindSpawner")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private SaveData GetSaveData()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(SpawnGearVariant), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	private void DeleteSpawnedItem()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(SpawnGearVariant), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
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
