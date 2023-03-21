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
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public string value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
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
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnIncrease")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnDecrease")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallerCount(Count = 5)]
	[CallAnalysisFailed]
	private void Refresh()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void RefreshCustomItems()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Lock(bool locked)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIComboBoxScroll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	public void OnIncrease()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIComboBoxScroll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	public void OnDecrease()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetCurrentIndex()
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "RefreshEndlessNightOption")]
	[CallsUnknownMethods(Count = 4)]
	public void InitializeLockableOptionUI(bool isUnlocked)
	{
	}

	[Calls(Type = typeof(ConsoleComboBox), Member = "Refresh")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnLocalize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleComboBox), Member = "Refresh")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ConsoleComboBox()
	{
	}
}
