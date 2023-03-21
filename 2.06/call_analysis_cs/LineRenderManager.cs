using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LineRenderManager
{
	private static Material m_AdditiveMaterial;

	private static List<LineRenderer> m_LineRenederers;

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	public static Material GetAdditiveMaterial()
	{
		return null;
	}

	[Calls(Type = typeof(LineRenderer), Member = "set_startWidth")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(LineRenderer), Member = "set_endWidth")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 11)]
	public static LineRenderer CreateLineRenderer(string name, Color color, float width, Material material)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public static void DestroyLineRenderer(LineRenderer lineRenderer)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public LineRenderManager()
	{
	}
}
