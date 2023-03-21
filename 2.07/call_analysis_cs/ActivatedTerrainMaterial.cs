using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ActivatedTerrainMaterial : MonoBehaviour
{
	private ActivatedMaterialProperties m_MaterialProperties;

	private Terrain m_Terrain;

	private Material m_OriginalMaterial;

	private Material m_Material;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsUnknownMethods(Count = 4)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Terrain), Member = "set_materialTemplate")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	private void OnDisable()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ActivateMaterialProperties(bool isActive)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ActivatedTerrainMaterial()
	{
	}
}
