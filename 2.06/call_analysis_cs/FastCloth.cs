using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FastCloth : MonoBehaviour
{
	public FastClothData m_ClothData;

	private MeshRenderer m_Renderer;

	private MeshFilter m_MeshFilter;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastClothManager), Member = "TryCacheClothMeshData")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[Calls(Type = typeof(FastClothManager), Member = "RegisterRenderer")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 7)]
	private void OnDrawGizmosSelected()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public FastCloth()
	{
	}
}
