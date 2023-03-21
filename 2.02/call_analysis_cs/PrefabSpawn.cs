using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
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
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		[Calls(Type = typeof(Vector3), Member = "get_one")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallerCount(Count = 7)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PrefabSpawn), Member = "SpawnObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 31)]
	public void BuildLODGroups(GameObject[] objects)
	{
	}

	[CalledBy(Type = typeof(PrefabSpawn), Member = "CustomFind")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetBuildPrefabSpawnGUIDDictionaryIndex(Dictionary<string, int> dictIndices, string fullname)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(PrefabSpawn), Member = "GetBuildPrefabSpawnGUIDDictionaryIndex")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 28)]
	private Transform CustomFind(string name, int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(PrefabSpawn), Member = "Update")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(PrefabSpawn), Member = "CalculateSetWeights")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetReduceMaxItemsInContainer")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetGearSpawnChanceScale")]
	[Calls(Type = typeof(PrefabSpawn), Member = "SpawnObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 56)]
	public GameObject SpawnObjects()
	{
		return null;
	}

	[CalledBy(Type = typeof(PrefabSpawn), Member = "SpawnObjects")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	public List<int> CalculateSetWeights(out int sumOfAllWeights)
	{
		sumOfAllWeights = default(int);
		return null;
	}

	[CalledBy(Type = typeof(PrefabSpawn), Member = "SpawnObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	public GameObject SpawnObject(Element spawnElement)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static string GetNameFromValue(string text)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "TryParseInt32")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static int GetIndexFromValue(string text)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetNewKeyFromNameAndIndex(string text, int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static void DeserializeAll(string serialized)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetAll()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PrefabSpawn()
	{
	}
}
