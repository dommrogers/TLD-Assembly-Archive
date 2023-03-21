using Cpp2ILInjected.CallAnalysis;
using TLD.OptionalContent;
using UnityEngine;

public class MainMenuDataSet : ScriptableObject
{
	public OptionalContentConfig m_ContentConfig;

	public string m_AlternateMainMenuAddress;

	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	public bool UseAlternateMainMenu()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public MainMenuDataSet()
	{
	}
}
