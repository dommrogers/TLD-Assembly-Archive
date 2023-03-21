using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ActivatedTerrainMaterial : MonoBehaviour
{
	private ActivatedMaterialProperties m_MaterialProperties;

	private Terrain m_Terrain;

	private Material m_OriginalMaterial;

	private Material m_Material;

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Terrain), Member = "set_materialTemplate")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ActivateMaterialProperties(bool isActive)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ActivatedTerrainMaterial()
	{
	}
}
