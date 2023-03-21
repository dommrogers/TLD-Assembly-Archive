using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ConsoleComboBox : MonoBehaviour
{
	public GameObject m_Background;

	public UIButton m_ButtonIncrease;

	public UIButton m_ButtonDecrease;

	public UILabel m_LableValue;

	public UILabel m_LableName;

	public LocalizedString m_LocalizedToolTip;

	public List<string> items;

	public bool m_UseCustomItems;

	public List<GameObject> m_CustomItems;

	public bool m_Localize;

	private int m_CurrentIndex;

	private string m_SelectedItem;

	private bool m_HasStarted;

	private bool m_Locked;

	public List<EventDelegate> onChange;

	private string m_OriginalToolTipLocId;

	public string m_ToolTip
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string value
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 48)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(ConsoleComboBox), Member = "Refresh")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public virtual void Start()
	{
	}

	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnEnable")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnLocalize")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnDecrease")]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnIncrease")]
	private void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 5)]
	private void RefreshCustomItems()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Lock(bool locked)
	{
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIComboBoxScroll")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "Refresh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	public void OnIncrease()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIComboBoxScroll")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "Refresh")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CallsUnknownMethods(Count = 2)]
	public void OnDecrease()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetCurrentIndex()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "Enable")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "RefreshEndlessNightOption")]
	[CallerCount(Count = 2)]
	public void InitializeLockableOptionUI(bool isUnlocked)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleComboBox), Member = "Refresh")]
	private void OnLocalize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleComboBox), Member = "Refresh")]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ConsoleComboBox()
	{
	}
}
