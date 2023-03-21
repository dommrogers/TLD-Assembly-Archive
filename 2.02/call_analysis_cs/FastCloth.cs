using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FastCloth : MonoBehaviour
{
	public FastClothData m_ClothData;

	private MeshRenderer m_Renderer;

	private MeshFilter m_MeshFilter;

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(FastClothManager), Member = "TryCacheClothMeshData")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[CallsUnknownMethods(Count = 10)]
	private void OnDrawGizmosSelected()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FastCloth()
	{
	}
}
