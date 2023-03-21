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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LoadingScreenData), Member = "GetRandomNoRepeat")]
	[CallsUnknownMethods(Count = 5)]
	public string GetRandomLoadingBackground()
	{
		return null;
	}

	[Calls(Type = typeof(LoadingScreenData), Member = "GetRandomNoRepeat")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetRandomLoadingTextLocID()
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(LoadingScreenData), Member = "GetRandomLoadingBackground")]
	[CalledBy(Type = typeof(LoadingScreenData), Member = "GetRandomLoadingTextLocID")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "SetBackgroundData")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "SetTextData")]
	[CallsUnknownMethods(Count = 1)]
	private int GetRandomNoRepeat(int length, int lastIndex)
	{
		return default(int);
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public LoadingScreenData()
	{
	}
}
