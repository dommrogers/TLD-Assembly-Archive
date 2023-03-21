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

	[CalledBy(Type = typeof(VertexPaintedMesh), Member = "LoadData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "set_colors")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public void SetMesh(Mesh mesh)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mesh), Member = "set_colors")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ResetMesh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "get_vertices")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Mesh), Member = "set_colors")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public void PaintVertexes(Transform transform, Color colour, PaintVertexDelegate paintVertexDelegate)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public VertexPaintedData()
	{
	}
}
