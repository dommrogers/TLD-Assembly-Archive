using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class ReplaceMaterial : MonoBehaviour
{
	public Material sourceMaterial;

	public List<Material> newMaterial;

	public bool chooseRandom;

	public bool includeChildren;

	private List<Renderer> allRends;

	private int newMatIndex;

	private bool m_MaterialsReplaced;

	private bool m_StartHasBeenCalled;

	private Dictionary<string, List<Renderer>> m_OriginalMaterialNameMap;

	private static ReplaceMaterialSaveDataProxy m_ReplaceMaterialSaveDataProxy;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReplaceMaterial), Member = "ScanForRenderers")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReplaceMaterial), Member = "ReplaceMaterials")]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(ReplaceMaterialsManager), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReplaceMaterial), Member = "ScanForRenderers")]
	[Calls(Type = typeof(ReplaceMaterial), Member = "ReplaceMaterials")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(ReplaceMaterial), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ReplaceMaterial), Member = "SetMaterialNameMap")]
	[CalledBy(Type = typeof(ReplaceMaterial), Member = "Start")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	public void ScanForRenderers()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ChooseRandomMaterial(bool useRandom)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ReplaceMaterial), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ReplaceMaterial), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void ReplaceMaterials(Material srcMat, int newMatIndex)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(ReplaceMaterial), Member = "ScanForRenderers")]
	private void SetMaterialNameMap()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public ReplaceMaterial()
	{
	}
}
