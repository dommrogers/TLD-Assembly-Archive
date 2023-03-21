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
	[Calls(Type = typeof(FastClothData), Member = "IsValid")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = ".ctor")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public bool TryCacheClothMeshData(FastClothData clothData)
	{
		return false;
	}

	[CalledBy(Type = typeof(FastCloth), Member = "Start")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void RegisterRenderer(MeshRenderer renderer, MeshFilter meshFilter)
	{
	}

	[CalledBy(Type = typeof(FastCloth), Member = "OnDestroy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void UnRegisterRenderer(MeshRenderer renderer)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "IsRendererBeingPlaced")]
	[Calls(Type = typeof(FastClothManager), Member = "CopyPropertyBlockValues")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 17)]
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
	[CallsUnknownMethods(Count = 6)]
	public FastClothManager()
	{
	}
}
