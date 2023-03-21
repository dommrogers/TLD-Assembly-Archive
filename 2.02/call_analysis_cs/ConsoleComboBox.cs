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
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "SetXPModePopupListString")]
		[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "SetConsoleComboBoxIndex")]
		[CalledBy(Type = typeof(Panel_Debug.DebugElement), Member = "AssignComboBox")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshAccessibilitySettings")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshAudioSliderLabels")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshControlsSettings")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySettings")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmGraphicsOptions")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshLanguage")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshPrivacySettings")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshQualitySettings")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetUiFromQualitySetting")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MaybeSwitchToCustomQuality")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabels")]
		[CallerCount(Count = 50)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(ConsoleComboBox), Member = "Refresh")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 1)]
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

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnIncrease")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnDecrease")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnLocalize")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnEnable")]
	[CallerCount(Count = 5)]
	private void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void RefreshCustomItems()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Lock(bool locked)
	{
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIComboBoxScroll")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "Refresh")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void OnIncrease()
	{
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIComboBoxScroll")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "Refresh")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void OnDecrease()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public int GetCurrentIndex()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "RefreshEndlessNightOption")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 24)]
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
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public ConsoleComboBox()
	{
	}
}
