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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
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
		[CallerCount(Count = 50)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(ConsoleComboBox), Member = "Refresh")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public virtual void Start()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnIncrease")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnDecrease")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnLocalize")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnEnable")]
	private void Refresh()
	{
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIComboBoxScroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	public void OnIncrease()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIComboBoxScroll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ConsoleComboBox), Member = "Refresh")]
	public void OnDecrease()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public int GetCurrentIndex()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "RefreshEndlessNightOption")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(string), Member = "Concat")]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public ConsoleComboBox()
	{
	}
}
