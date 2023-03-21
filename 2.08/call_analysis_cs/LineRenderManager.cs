using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LineRenderManager
{
	private static Material m_AdditiveMaterial;

	private static List<LineRenderer> m_LineRenederers;

	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Material GetAdditiveMaterial()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(LineRenderer), Member = "set_startWidth")]
	[Calls(Type = typeof(LineRenderer), Member = "set_endWidth")]
	[CallsUnknownMethods(Count = 6)]
	public static LineRenderer CreateLineRenderer(string name, Color color, float width, Material material)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public static void DestroyLineRenderer(LineRenderer lineRenderer)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public LineRenderManager()
	{
	}
}
