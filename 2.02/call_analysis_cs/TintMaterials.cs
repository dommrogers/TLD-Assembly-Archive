using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
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
		[CallerCount(Count = 2)]
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

	private static List<TintMaterials> s_Instances;

	private static TintMaterialsSaveData s_SaveData;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(TintMaterials), Member = "Deserialize")]
	[CalledBy(Type = typeof(TintMaterials), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 22)]
	private void UpdateTint()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(TintMaterials), Member = "SerializeAll")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(TintMaterials), Member = "UpdateTint")]
	[CallerCount(Count = 0)]
	public void Deserialize(TintMaterialsSaveData proxy)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void ResetInstances()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(TintMaterials), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 22)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(TintMaterials), Member = "UpdateTint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	public TintMaterials()
	{
	}
}
