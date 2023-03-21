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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReplaceMaterial), Member = "ReplaceMaterials")]
	private void Update()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(ReplaceMaterialsManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(ReplaceMaterial), Member = "ReplaceMaterials")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReplaceMaterial), Member = "ScanForRenderers")]
	[CallerCount(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ReplaceMaterial), Member = "SetMaterialNameMap")]
	[CalledBy(Type = typeof(ReplaceMaterial), Member = "Start")]
	[CalledBy(Type = typeof(ReplaceMaterial), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 5)]
	public void ScanForRenderers()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ChooseRandomMaterial(bool useRandom)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ReplaceMaterial), Member = "Update")]
	[CalledBy(Type = typeof(ReplaceMaterial), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 3)]
	public void ReplaceMaterials(Material srcMat, int newMatIndex)
	{
	}

	[CalledBy(Type = typeof(ReplaceMaterial), Member = "ScanForRenderers")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	private void SetMaterialNameMap()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public ReplaceMaterial()
	{
	}
}
