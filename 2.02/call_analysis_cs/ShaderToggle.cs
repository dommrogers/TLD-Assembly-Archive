using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ShaderToggle : MonoBehaviour
{
	private ShaderComparison[] m_Shaders;

	private static ShaderToggle m_Instance;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_shader_toggle")]
	[Calls(Type = typeof(ShaderComparison), Member = "Toggle")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	public static void Toggle(string tag)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ShaderToggle()
	{
	}
}
