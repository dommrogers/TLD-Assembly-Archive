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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(ShaderComparison), Member = "Toggle")]
	[CallsUnknownMethods(Count = 2)]
	public static void Toggle(string tag)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ShaderToggle()
	{
	}
}
