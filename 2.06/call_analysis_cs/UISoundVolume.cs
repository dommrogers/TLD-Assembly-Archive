using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UISoundVolume : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "get_soundVolume")]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat")]
	[CallerCount(Count = 0)]
	private void OnChange()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public UISoundVolume()
	{
	}
}
