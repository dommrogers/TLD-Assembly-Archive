using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class SceneNames
{
	public static Dictionary<int, string> m_Dict;

	private static string[] m_Names;

	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SceneNames()
	{
	}
}
