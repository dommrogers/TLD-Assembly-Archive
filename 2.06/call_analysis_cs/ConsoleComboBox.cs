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
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(ConsoleComboBox), Member = "Refresh")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallerCount(Count = 48)]
		set
		{
		}
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public virtual void Start()
	{
	}

	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnLocalize")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnDecrease")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnIncrease")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnEnable")]
	[CallerCount(Count = 5)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "set_value")]
	private void Refresh()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 8)]
	private void RefreshCustomItems()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Lock(bool locked)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIComboBoxScroll")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "Refresh")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	public void OnIncrease()
	{
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ConsoleComboBox), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIComboBoxScroll")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[CallsUnknownMethods(Count = 2)]
	public void OnDecrease()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public int GetCurrentIndex()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "RefreshEndlessNightOption")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "Enable")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 10)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public ConsoleComboBox()
	{
	}
}
