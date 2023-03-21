using System;
using System.Collections.Generic;
using System.Globalization;
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(PrefabSpawn), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PrefabSpawn), Member = "SpawnObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsUnknownMethods(Count = 32)]
	public GameObject SpawnObjects()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public List<int> CalculateSetWeights(out int sumOfAllWeights)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref sumOfAllWeights) = null;
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(PrefabSpawn), Member = "SpawnObjects")]
	[CallsUnknownMethods(Count = 9)]
	public GameObject SpawnObject(Element spawnElement)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallerCount(Count = 0)]
	public static string GetNameFromValue(string text)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[CallsUnknownMethods(Count = 3)]
	public static int GetIndexFromValue(string text)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetNewKeyFromNameAndIndex(string text, int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static void DeserializeAll(string serialized)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetAll()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public PrefabSpawn()
	{
	}
}
