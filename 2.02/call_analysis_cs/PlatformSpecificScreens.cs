using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlatformSpecificScreens : ScriptableObject
{
	public string m_PlatformName;

	private string[] m_Screens;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 3)]
	public bool Contains(string screenName)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PlatformSpecificScreens()
	{
	}
}
