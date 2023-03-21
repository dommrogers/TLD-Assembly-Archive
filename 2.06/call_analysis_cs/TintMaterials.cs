using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;

public class TintMaterials : MonoBehaviour
{
	[Serializable]
	private class Tint
	{
		public Color m_RedMask;

		public Color m_GreenMask;

		public Color m_BlueMask;

		public bool m_DefaultsAssigned;

		[CallerCount(Count = 0)]
		public void AssignDefaults()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public Tint()
		{
		}
	}

	private Tint[] m_Tints;

	private int m_IndexToUse;

	private string m_TagFilter;

	private MaterialPropertyBlock m_PropertyBlock;

	private readonly int m_TintColorRPropertyID;

	private readonly int m_TintColorGPropertyID;

	private readonly int m_TintColorBPropertyID;

	private static readonly List<TintMaterials> s_Instances;

	private static readonly TintMaterialsSaveData s_SaveData;

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TintMaterials), Member = "UpdateTint")]
	[CallsUnknownMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(TintMaterials), Member = "OnEnable")]
	[CalledBy(Type = typeof(TintMaterials), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateTint()
	{
	}

	[CalledBy(Type = typeof(TintMaterials), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TintMaterials), Member = "UpdateTint")]
	[CalledBy(Type = typeof(TintMaterials), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(TintMaterialsSaveData proxy)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void ResetInstances()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(TintMaterials), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 20)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TintMaterials), Member = "Deserialize")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public TintMaterials()
	{
	}
}
