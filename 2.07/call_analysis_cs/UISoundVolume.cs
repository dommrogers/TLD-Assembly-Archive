using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UISoundVolume : MonoBehaviour
{
	[Calls(Type = typeof(NGUITools), Member = "get_soundVolume")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void OnChange()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UISoundVolume()
	{
	}
}
