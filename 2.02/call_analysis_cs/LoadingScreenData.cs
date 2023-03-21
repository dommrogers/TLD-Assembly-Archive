using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LoadingScreenData : ScriptableObject
{
	public string[] m_LoadingBackgrounds;

	public LocalizedString[] m_LoadingText;

	public float m_MinHoldTime;

	private int m_LastLoadingBackground;

	private int m_LastLoadingText;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LoadingScreenData), Member = "GetRandomNoRepeat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public string GetRandomLoadingBackground()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LoadingScreenData), Member = "GetRandomNoRepeat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public string GetRandomLoadingTextLocID()
	{
		return null;
	}

	[CalledBy(Type = typeof(LoadingScreenData), Member = "GetRandomLoadingBackground")]
	[CalledBy(Type = typeof(LoadingScreenData), Member = "GetRandomLoadingTextLocID")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "SetBackgroundData")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "SetTextData")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private int GetRandomNoRepeat(int length, int lastIndex)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public LoadingScreenData()
	{
	}
}
