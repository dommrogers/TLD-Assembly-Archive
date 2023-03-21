using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ReplaceMaterial), Member = "ScanForRenderers")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ReplaceMaterial), Member = "ReplaceMaterials")]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(ReplaceMaterialsManager), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(ReplaceMaterial), Member = "ScanForRenderers")]
	[Calls(Type = typeof(ReplaceMaterial), Member = "ReplaceMaterials")]
	[CalledBy(Type = typeof(ReplaceMaterialsManager), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(ReplaceMaterial), Member = "Deserialize")]
	[CalledBy(Type = typeof(ReplaceMaterial), Member = "Start")]
	[Calls(Type = typeof(ReplaceMaterial), Member = "SetMaterialNameMap")]
	[CallsUnknownMethods(Count = 11)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void ScanForRenderers()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void ChooseRandomMaterial(bool useRandom)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(ReplaceMaterial), Member = "Deserialize")]
	[CalledBy(Type = typeof(ReplaceMaterial), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void ReplaceMaterials(Material srcMat, int newMatIndex)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(ReplaceMaterial), Member = "ScanForRenderers")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void SetMaterialNameMap()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 15)]
	public ReplaceMaterial()
	{
	}
}
