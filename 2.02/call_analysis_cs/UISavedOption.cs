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
		[CalledBy(Type = typeof(UISavedOption), Member = "SaveProgress")]
		[CalledBy(Type = typeof(UISavedOption), Member = "SaveState")]
		[CalledBy(Type = typeof(UISavedOption), Member = "SaveSelection")]
		[CalledBy(Type = typeof(UISavedOption), Member = "OnDisable")]
		[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
		[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
		[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
		[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UISavedOption), Member = "get_key")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UISavedOption), Member = "get_key")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt")]
	[Calls(Type = typeof(UISavedOption), Member = "get_key")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetFloat")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPopupList), Member = "set_value")]
	[Calls(Type = typeof(UISavedOption), Member = "get_key")]
	[CallsUnknownMethods(Count = 33)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UISavedOption), Member = "get_key")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(EventDelegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 28)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UISavedOption), Member = "get_key")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CallsUnknownMethods(Count = 1)]
	public void SaveSelection()
	{
	}

	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UISavedOption), Member = "get_key")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SaveState()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat")]
	[Calls(Type = typeof(UISavedOption), Member = "get_key")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	public void SaveProgress()
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public UISavedOption()
	{
	}
}
