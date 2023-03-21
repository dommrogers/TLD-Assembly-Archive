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

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(FastCloth), Member = "Start")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = ".ctor")]
	[Calls(Type = typeof(FastClothData), Member = "IsValid")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = ".ctor")]
	public bool TryCacheClothMeshData(FastClothData clothData)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(FastCloth), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public void RegisterRenderer(MeshRenderer renderer, MeshFilter meshFilter)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void UnRegisterRenderer(MeshRenderer renderer)
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(FastClothManager), Member = "CopyPropertyBlockValues")]
	[Calls(Type = typeof(PlayerManager), Member = "IsRendererBeingPlaced")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void Update()
	{
	}

	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(FastClothManager), Member = "Update")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "GetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "GetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "GetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "GetVectorArray")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
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
