using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LineRenderManager
{
	private static Material m_AdditiveMaterial;

	private static List<LineRenderer> m_LineRenederers;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Material GetAdditiveMaterial()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(LineRenderer), Member = "set_startWidth")]
	[Calls(Type = typeof(LineRenderer), Member = "set_endWidth")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	public static LineRenderer CreateLineRenderer(string name, Color color, float width, Material material)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
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
