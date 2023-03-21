using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class PropertySheetFactory
{
	private readonly Dictionary<Shader, PropertySheet> m_Sheets;

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public PropertySheetFactory()
	{
	}

	[Obsolete]
	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public PropertySheet Get(string shaderName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(PropertySheet), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 58)]
	[Calls(Type = typeof(string), Member = "Substring")]
	public PropertySheet Get(Shader shader)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 5)]
	public void Release()
	{
	}
}
