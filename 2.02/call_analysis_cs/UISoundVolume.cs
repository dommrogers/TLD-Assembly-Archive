using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UISoundVolume : MonoBehaviour
{
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(NGUITools), Member = "get_soundVolume")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsUnknownMethods(Count = 1)]
	private void OnChange()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UISoundVolume()
	{
	}
}
