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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(FastClothData), Member = "IsValid")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = ".ctor")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = ".ctor")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[CallsUnknownMethods(Count = 18)]
	public bool TryCacheClothMeshData(FastClothData clothData)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public void RegisterRenderer(MeshRenderer renderer, MeshFilter meshFilter)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 4)]
	public void UnRegisterRenderer(MeshRenderer renderer)
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(FastClothManager), Member = "CopyPropertyBlockValues")]
	[Calls(Type = typeof(PlayerManager), Member = "IsRendererBeingPlaced")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(FastClothManager), Member = "Update")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVectorArray")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "GetVectorArray")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 28)]
	public FastClothManager()
	{
	}
}
