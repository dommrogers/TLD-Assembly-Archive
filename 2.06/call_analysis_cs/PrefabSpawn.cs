using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

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

	private static List<PrefabSpawn> s_SerializeSpawners;

	public event Action<List<GameObject>> SpawnCompleted
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 2)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public void BuildLODGroups(GameObject[] objects)
	{
	}

	[CalledBy(Type = typeof(PrefabSpawn), Member = "CustomFind")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetBuildPrefabSpawnGUIDDictionaryIndex(Dictionary<string, int> dictIndices, string fullname)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(PrefabSpawn), Member = "GetBuildPrefabSpawnGUIDDictionaryIndex")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private Transform CustomFind(string name, int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(PrefabSpawn), Member = "Update")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PrefabSpawn), Member = "CalculateSetWeights")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(PrefabSpawn), Member = "SpawnObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 19)]
	public GameObject SpawnObjects()
	{
		return null;
	}

	[CalledBy(Type = typeof(PrefabSpawn), Member = "SpawnObjects")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public List<int> CalculateSetWeights(out int sumOfAllWeights)
	{
		sumOfAllWeights = default(int);
		return null;
	}

	[CalledBy(Type = typeof(PrefabSpawn), Member = "SpawnObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	public GameObject SpawnObject(Element spawnElement)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Split")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetNameFromValue(string text)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[CallsUnknownMethods(Count = 2)]
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
	[CallsUnknownMethods(Count = 10)]
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
	[CallsUnknownMethods(Count = 20)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public PrefabSpawn()
	{
	}
}
