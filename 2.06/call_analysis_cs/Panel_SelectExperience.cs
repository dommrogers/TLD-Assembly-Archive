using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using TLD.UI;
using UnityEngine;

public class Panel_SelectExperience : Panel_AutoReferenced
{
	[Serializable]
	private class XPModeMenuItem
	{
		public GameObject m_Display;

		public SandboxConfig m_SandboxConfig;

		public AnimationStateRef m_PlayOnSelect;

		public AnimationStateRef m_PlayOnDeselect;

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 11)]
		public XPModeMenuItem()
		{
		}
	}

	private enum AnimationState
	{
		None,
		Select,
		Deselect
	}

	public ButtonLegendContainer m_ButtonLegendContainer;

	public string m_HeaderTitleLocalizationId;

	public string m_TitleLocalizationId;

	public Vector3 m_TitleHeaderOffset;

	public GameObject m_BasicMenuRoot;

	private BasicMenu m_BasicMenu;

	public Animator m_Animator;

	private List<XPModeMenuItem> m_MenuItems;

	public Color m_CustomXPLabelColor;

	private int m_LastItemIndexSelected;

	private XPModeMenuItem m_PreviousMenuItemSelected;

	private AnimationState m_CurrentEpisodeAnimationState;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_SelectExperience), Member = "HideAllAnimatedItems")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(Panel_SelectExperience), Member = "UpdateAnimation")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "RegionLockedBySelectedMode")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "ShouldBePartOfFlow")]
	[Calls(Type = typeof(Panel_SelectExperience), Member = "GetSelectedMenuItem")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetGameModeConfig")]
	[CallsDeduplicatedMethods(Count = 5)]
	public void OnExperienceClicked()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	private void AddMenuItem(int itemIndex)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(Panel_SelectExperience), Member = "AddMenuItem")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	private void ConfigureMenu()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnClickBack()
	{
	}

	[CallerCount(Count = 0)]
	private void ResetStartRegionAndSceneSets()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[CallsUnknownMethods(Count = 1)]
	private int GetSelectedIndex()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private XPModeMenuItem GetSelectedItemAtIndex(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "OnExperienceClicked")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private XPModeMenuItem GetSelectedMenuItem()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_SelectExperience), Member = "IsPlayingAnimation")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 5)]
	private bool IsPlayingAnySelectionAnimation()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_SelectExperience), Member = "IsPlayingAnimation")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool IsPlayingAnyDeselectionAnimation()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "IsPlayingAnySelectionAnimation")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "IsPlayingAnyDeselectionAnimation")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsPlayingAnimation(int stateHash)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 5)]
	private void OnlyEnableItem(XPModeMenuItem enabledItem)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void PlaySelectedAnimation(XPModeMenuItem menuItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	private void PlayDeselectedAnimation(XPModeMenuItem menuItem)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "Update")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Panel_SelectExperience), Member = "OnlyEnableItem")]
	[Calls(Type = typeof(Panel_SelectExperience), Member = "GetSelectedMenuItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SelectExperience), Member = "IsPlayingAnySelectionAnimation")]
	[Calls(Type = typeof(Panel_SelectExperience), Member = "IsPlayingAnyDeselectionAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	private void UpdateAnimation()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "Initialize")]
	[CallsUnknownMethods(Count = 5)]
	private void HideAllAnimatedItems()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "SetItemSelected")]
	[CallsUnknownMethods(Count = 1)]
	private void RestoreSelection()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public Panel_SelectExperience()
	{
	}
}
