using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ShaderToggle : MonoBehaviour
{
	private ShaderComparison[] m_Shaders;

	private static ShaderToggle m_Instance;

	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(ShaderComparison), Member = "Toggle")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	public static void Toggle(string tag)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ShaderToggle()
	{
	}
}
