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

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_shader_toggle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(ShaderComparison), Member = "Toggle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
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
