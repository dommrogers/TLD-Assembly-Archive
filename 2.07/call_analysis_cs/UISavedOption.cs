using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UISavedOption : MonoBehaviour
{
	public string keyName;

	private UIPopupList mList;

	private UIToggle mCheck;

	private UIProgressBar mSlider;

	private string key
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
		[CalledBy(Type = typeof(UISavedOption), Member = "OnDisable")]
		[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
		[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
		get
		{
			return null;
		}
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt")]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(UISavedOption), Member = "get_key")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetFloat")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UISavedOption), Member = "get_key")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UISavedOption), Member = "get_key")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UIPopupList), Member = "set_value")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UISavedOption), Member = "get_key")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(EventDelegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void SaveSelection()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void SaveState()
	{
	}

	[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	public void SaveProgress()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UISavedOption()
	{
	}
}
