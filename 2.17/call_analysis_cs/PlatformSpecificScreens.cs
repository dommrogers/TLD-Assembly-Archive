using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlatformSpecificScreens : ScriptableObject
{
	public string m_PlatformName;

	private string[] m_Screens;

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	public bool Contains(string screenName)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PlatformSpecificScreens()
	{
	}
}
