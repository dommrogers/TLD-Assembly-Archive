using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FastClothData : ScriptableObject
{
	public Mesh m_Mesh;

	public Vector4[] m_BlendShapeMidVertexDeltas;

	public Vector4[] m_BlendShapeMidNormalDeltas;

	public Vector4[] m_BlendShapeEndVertexDeltas;

	public Vector4[] m_BlendShapeEndNormalDeltas;

	private const int BLENDSHAPE_INDEX = 0;

	private const int MAX_SUPPORTED_VERTICES = 256;

	[CalledBy(Type = typeof(FastClothManager), Member = "TryCacheClothMeshData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "GetBlendShapeName")]
	[Calls(Type = typeof(Mesh), Member = "GetBlendShapeFrameCount")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsValid()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void UpdateBlendShapeDeltas()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "GetBlendShapeName")]
	[Calls(Type = typeof(Mesh), Member = "GetBlendShapeFrameCount")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsMeshValid()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public FastClothData()
	{
	}
}
