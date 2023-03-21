using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class PropertySheetFactory
{
	private readonly Dictionary<Shader, PropertySheet> m_Sheets;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(PropertySheet), Member = ".ctor")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "LastIndexOf")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallerCount(Count = 58)]
	[Calls(Type = typeof(string), Member = "Format")]
	public PropertySheet Get(Shader shader)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 8)]
	public void Release()
	{
	}
}
