using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LineRenderManager
{
	private static Material m_AdditiveMaterial;

	private static List<LineRenderer> m_LineRenederers;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	public static Material GetAdditiveMaterial()
	{
		return null;
	}

	[Calls(Type = typeof(LineRenderer), Member = "set_endWidth")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(LineRenderer), Member = "set_startWidth")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "set_name")]
	public static LineRenderer CreateLineRenderer(string name, Color color, float width, Material material)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 3)]
	public static void DestroyLineRenderer(LineRenderer lineRenderer)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public LineRenderManager()
	{
	}
}
