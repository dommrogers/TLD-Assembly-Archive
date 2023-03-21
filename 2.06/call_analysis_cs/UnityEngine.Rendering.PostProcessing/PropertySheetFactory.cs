using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class PropertySheetFactory
{
	private readonly Dictionary<Shader, PropertySheet> m_Sheets;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public PropertySheetFactory()
	{
	}

	[Obsolete("Use PropertySheet.Get(Shader) with a direct reference to the Shader instead.")]
	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public PropertySheet Get(string shaderName)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(PropertySheet), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "LastIndexOf")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 58)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	public PropertySheet Get(Shader shader)
	{
		return null;
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnDisable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	public void Release()
	{
	}
}
