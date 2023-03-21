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
	[Calls(Type = typeof(Mesh), Member = "GetBlendShapeFrameCount")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "GetBlendShapeName")]
	public bool IsValid()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void UpdateBlendShapeDeltas()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "GetBlendShapeName")]
	[Calls(Type = typeof(Mesh), Member = "GetBlendShapeFrameCount")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsMeshValid()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	public FastClothData()
	{
	}
}
