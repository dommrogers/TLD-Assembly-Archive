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
		[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
		[CalledBy(Type = typeof(UISavedOption), Member = "OnDisable")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(UIPopupList), Member = "set_value")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UISavedOption), Member = "get_key")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt")]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetFloat")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Remove")]
	[Calls(Type = typeof(UISavedOption), Member = "get_key")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CallsUnknownMethods(Count = 1)]
	public void SaveSelection()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt")]
	[CallsUnknownMethods(Count = 1)]
	public void SaveState()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat")]
	[CallsUnknownMethods(Count = 2)]
	public void SaveProgress()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UISavedOption()
	{
	}
}
