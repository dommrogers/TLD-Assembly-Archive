using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;
using UnityEngine.Pool;

public class PrefabSpawn : MonoBehaviour
{
	[Serializable]
	public class Element
	{
		public GameObject m_Prefab;

		public Vector3 m_Offset;

		public Vector3 m_Rotation;

		public Vector3 m_Scale;

		public int m_SpawnWeight;

		public uint m_LodMask;

		public int m_SetId;

		[NonSerialized]
		public bool m_ShowTransform;

		[NonSerialized]
		public GameObject m_PreviewObject;

		[CallerCount(Count = 0)]
		public Element()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public void Set(Element other)
		{
		}
	}

	public class PrefabSpawnSaveData
	{
		public string m_Guid;

		public bool m_SpawnComplete;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public PrefabSpawnSaveData()
		{
		}
	}

	public Element[] m_PrefabList;

	public float[] m_LodHeights;

	public int m_NumToSpawnMin;

	public int m_NumToSpawnMax;

	public int m_ChanceOfNoSpawn;

	public bool m_TakePrefabScale;

	public bool m_SpawnComplete;

	public bool m_UseSerialization;

	private string m_Guid;

	private static readonly List<PrefabSpawn> s_SerializeSpawners;

	public event Action<List<GameObject>> SpawnCompleted
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PrefabSpawn), Member = "SpawnObjects")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(PrefabSpawn), Member = "Update")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(GenericPool<>), Member = "Get")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PrefabSpawn), Member = "SpawnObject")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(PooledObject<>), Member = "System.IDisposable.Dispose")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 30)]
	public GameObject SpawnObjects()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public List<int> CalculateSetWeights(out int sumOfAllWeights)
	{
		sumOfAllWeights = default(int);
		return null;
	}

	[CalledBy(Type = typeof(PrefabSpawn), Member = "SpawnObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 9)]
	public GameObject SpawnObject(Element spawnElement)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallsUnknownMethods(Count = 3)]
	public static string GetNameFromValue(string text)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "TryParseInt32")]
	[CallsUnknownMethods(Count = 3)]
	public static int GetIndexFromValue(string text)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetNewKeyFromNameAndIndex(string text, int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 7)]
	public static void DeserializeAll(string serialized)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetAll()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public PrefabSpawn()
	{
	}
}
