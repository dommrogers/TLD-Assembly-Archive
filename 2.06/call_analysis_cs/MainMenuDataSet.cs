using Cpp2ILInjected.CallAnalysis;
using TLD.OptionalContent;
using UnityEngine;

public class MainMenuDataSet : ScriptableObject
{
	public OptionalContentConfig m_ContentConfig;

	public string m_AlternateMainMenuAddress;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	public bool UseAlternateMainMenu()
	{
		return default(bool);
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MainMenuDataSet()
	{
	}
}
