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
	[Calls(Type = typeof(ReplaceMaterial), Member = "ScanForRenderers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReplaceMaterial), Member = "ReplaceMaterials")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(ReplaceMaterialsManager), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReplaceMaterial), Member = "ScanForRenderers")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(ReplaceMaterial), Member = "ReplaceMaterials")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(ReplaceMaterial), Member = "Start")]
	[CalledBy(Type = typeof(ReplaceMaterial), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(ReplaceMaterial), Member = "SetMaterialNameMap")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void ScanForRenderers()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ChooseRandomMaterial(bool useRandom)
	{
	}

	[CalledBy(Type = typeof(ReplaceMaterial), Member = "Update")]
	[CalledBy(Type = typeof(ReplaceMaterial), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void ReplaceMaterials(Material srcMat, int newMatIndex)
	{
	}

	[CalledBy(Type = typeof(ReplaceMaterial), Member = "ScanForRenderers")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
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
