using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LineRenderManager
{
	private static Material m_AdditiveMaterial;

	private static List<LineRenderer> m_LineRenederers;

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public static Material GetAdditiveMaterial()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 16)]
	public static LineRenderer CreateLineRenderer(string name, Color color, float width, Material material)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public static void DestroyLineRenderer(LineRenderer lineRenderer)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public LineRenderManager()
	{
	}
}
