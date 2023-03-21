using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class MB_MultiMaterial
{
	public Material combinedMaterial;

	public bool considerMeshUVs;

	public List<Material> sourceMaterials;

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(MB2_TextureBakeResults), Member = "CreateForMaterialsOnRenderer")]
	[CalledBy(Type = typeof(MB3_TextureBaker._003CCreateAtlasesCoroutine_003Ed__94), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 7)]
	public MB_MultiMaterial()
	{
	}
}
