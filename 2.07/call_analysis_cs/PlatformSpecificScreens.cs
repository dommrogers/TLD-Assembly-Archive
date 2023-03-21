using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlatformSpecificScreens : ScriptableObject
{
	public string m_PlatformName;

	private string[] m_Screens;

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public bool Contains(string screenName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	public PlatformSpecificScreens()
	{
	}
}
