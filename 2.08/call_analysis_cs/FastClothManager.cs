using System;
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(FastClothData), Member = "IsValid")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = ".ctor")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = ".ctor")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[CalledBy(Type = typeof(FastCloth), Member = "Start")]
	[CallsUnknownMethods(Count = 2)]
	public bool TryCacheClothMeshData(FastClothData clothData)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(FastCloth), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void RegisterRenderer(MeshRenderer renderer, MeshFilter meshFilter)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(FastCloth), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 2)]
	public void UnRegisterRenderer(MeshRenderer renderer)
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(FastClothManager), Member = "CopyPropertyBlockValues")]
	[Calls(Type = typeof(PlayerManager), Member = "IsRendererBeingPlaced")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(FastClothManager), Member = "Update")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "GetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "GetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "GetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "GetVectorArray")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	private void CopyPropertyBlockValues(MaterialPropertyBlock fromBlock, MaterialPropertyBlock toBlock)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	public FastClothManager()
	{
	}
}
