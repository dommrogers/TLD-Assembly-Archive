using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FastClothManager : MonoBehaviour
{
	private float m_MaxWindSpeed;

	private float m_WindSpeedChangeDamping;

	private Vector4 m_WindInfo;

	private List<MeshRenderer> m_Renderers;

	private Dictionary<MeshRenderer, MeshFilter> m_RenderersToMeshFilters;

	private Dictionary<Mesh, MaterialPropertyBlock> m_MeshPropertyBlocks;

	private MaterialPropertyBlock m_PlacementPropertyBlock;

	private readonly int m_ClothWindInfoID;

	private readonly int m_ClothBlendShapeMidVertexID;

	private readonly int m_ClothBlendShapeMidNormalID;

	private readonly int m_ClothBlendShapeEndVertexID;

	private readonly int m_ClothBlendShapeEndNormalID;

	[CalledBy(Type = typeof(FastCloth), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(FastClothData), Member = "IsValid")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = ".ctor")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public bool TryCacheClothMeshData(FastClothData clothData)
	{
		return false;
	}

	[CalledBy(Type = typeof(FastCloth), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void RegisterRenderer(MeshRenderer renderer, MeshFilter meshFilter)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void UnRegisterRenderer(MeshRenderer renderer)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Dictionary<, >.ValueCollection.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "IsRendererBeingPlaced")]
	[Calls(Type = typeof(FastClothManager), Member = "CopyPropertyBlockValues")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 21)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(FastClothManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "GetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void CopyPropertyBlockValues(MaterialPropertyBlock fromBlock, MaterialPropertyBlock toBlock)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 21)]
	public FastClothManager()
	{
	}
}
