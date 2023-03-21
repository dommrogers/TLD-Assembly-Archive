using Cpp2ILInjected.CallAnalysis;
using TLD.OptionalContent;
using UnityEngine;

public class MainMenuDataSet : ScriptableObject
{
	public OptionalContentConfig m_ContentConfig;

	public string m_AlternateMainMenuAddress;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[CallsUnknownMethods(Count = 1)]
	public bool UseAlternateMainMenu()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public MainMenuDataSet()
	{
	}
}
