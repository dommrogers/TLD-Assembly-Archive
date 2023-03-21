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

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TintMaterials), Member = "UpdateTint")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void OnValidate()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(TintMaterials), Member = "OnEnable")]
	[CalledBy(Type = typeof(TintMaterials), Member = "Deserialize")]
	private void UpdateTint()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(TintMaterials), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TintMaterials), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TintMaterials), Member = "UpdateTint")]
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
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TintMaterials), Member = "Serialize")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(TintMaterials), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 2)]
	public static void DeserializeAll(string text)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public TintMaterials()
	{
	}
}
