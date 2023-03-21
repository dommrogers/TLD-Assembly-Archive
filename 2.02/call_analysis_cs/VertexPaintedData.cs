using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class VertexPaintedData : ScriptableObject
{
	public enum State
	{
		PerAsset,
		PerScene,
		PerInstance,
		PerGameMode
	}

	private Color[] m_Colours;

	private Mesh m_Mesh;

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Mesh), Member = "set_colors")]
	[CalledBy(Type = typeof(VertexPaintedMesh), Member = "LoadData")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void SetMesh(Mesh mesh)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mesh), Member = "set_colors")]
	[CallsUnknownMethods(Count = 1)]
	public void ResetMesh()
	{
	}

	[Calls(Type = typeof(Mesh), Member = "set_colors")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Mesh), Member = "get_vertices")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[CallsUnknownMethods(Count = 8)]
	public void PaintVertexes(Transform transform, Color colour, PaintVertexDelegate paintVertexDelegate)
	{
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public VertexPaintedData()
	{
	}
}
