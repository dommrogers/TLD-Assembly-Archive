using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		[Calls(Type = typeof(Vector3), Member = "get_one")]
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
		[CallerCount(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PrefabSpawn), Member = "SpawnObjects")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void BuildLODGroups(GameObject[] objects)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(PrefabSpawn), Member = "CustomFind")]
	[CallsUnknownMethods(Count = 1)]
	public static int GetBuildPrefabSpawnGUIDDictionaryIndex(Dictionary<string, int> dictIndices, string fullname)
	{
		return default(int);
	}

	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(PrefabSpawn), Member = "GetBuildPrefabSpawnGUIDDictionaryIndex")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private Transform CustomFind(string name, int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 56)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CalledBy(Type = typeof(PrefabSpawn), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PrefabSpawn), Member = "SpawnObject")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetGearSpawnChanceScale")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetReduceMaxItemsInContainer")]
	[Calls(Type = typeof(PrefabSpawn), Member = "CalculateSetWeights")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	public GameObject SpawnObjects()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(PrefabSpawn), Member = "SpawnObjects")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public List<int> CalculateSetWeights(out int sumOfAllWeights)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref sumOfAllWeights) = null;
		return null;
	}

	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PrefabSpawn), Member = "SpawnObjects")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	public GameObject SpawnObject(Element spawnElement)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallsUnknownMethods(Count = 7)]
	public static string GetNameFromValue(string text)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	public static int GetIndexFromValue(string text)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetNewKeyFromNameAndIndex(string text, int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static void DeserializeAll(string serialized)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void ResetAll()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
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
