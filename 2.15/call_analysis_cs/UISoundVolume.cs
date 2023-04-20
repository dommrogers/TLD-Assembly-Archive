using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UISoundVolume : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(NGUITools), Member = "get_soundVolume")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat")]
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
