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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReplaceMaterial), Member = "ScanForRenderers")]
	[Calls(Type = typeof(ReplaceMaterial), Member = "ReplaceMaterials")]
	[CalledBy(Type = typeof(ReplaceMaterialsManager), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ReplaceMaterial), Member = "Deserialize")]
	[CalledBy(Type = typeof(ReplaceMaterial), Member = "Start")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReplaceMaterial), Member = "SetMaterialNameMap")]
	public void ScanForRenderers()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ChooseRandomMaterial(bool useRandom)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(ReplaceMaterial), Member = "Update")]
	[CalledBy(Type = typeof(ReplaceMaterial), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 3)]
	public void ReplaceMaterials(Material srcMat, int newMatIndex)
	{
	}

	[CalledBy(Type = typeof(ReplaceMaterial), Member = "ScanForRenderers")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void SetMaterialNameMap()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public ReplaceMaterial()
	{
	}
}
