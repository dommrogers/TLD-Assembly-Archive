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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TintMaterials), Member = "UpdateTint")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void OnValidate()
	{
	}

	[CalledBy(Type = typeof(TintMaterials), Member = "OnEnable")]
	[CalledBy(Type = typeof(TintMaterials), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateTint()
	{
	}

	[CalledBy(Type = typeof(TintMaterials), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(TintMaterials), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TintMaterials), Member = "UpdateTint")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(TintMaterialsSaveData proxy)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetInstances()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(TintMaterials), Member = "Serialize")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(TintMaterials), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
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
