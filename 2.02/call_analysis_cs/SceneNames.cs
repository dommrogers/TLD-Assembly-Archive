using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SceneNames
{
	public static Dictionary<int, string> m_Dict;

	private static string[] m_Names;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[CallsUnknownMethods(Count = 7)]
	public static void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SceneNames()
	{
	}
}
