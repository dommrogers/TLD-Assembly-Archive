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

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(FastClothManager), Member = "TryCacheClothMeshData")]
	[Calls(Type = typeof(Mesh), Member = "GetBlendShapeFrameCount")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Mesh), Member = "GetBlendShapeFrameCount")]
	[Calls(Type = typeof(Mesh), Member = "GetBlendShapeName")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool IsMeshValid()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public FastClothData()
	{
	}
}
