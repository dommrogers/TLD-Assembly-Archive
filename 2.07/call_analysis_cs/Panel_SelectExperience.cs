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
		[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(Panel_SelectExperience), Member = "HideAllAnimatedItems")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(Panel_SelectExperience), Member = "UpdateAnimation")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "ShouldBePartOfFlow")]
	[Calls(Type = typeof(GameManager), Member = "RegionLockedBySelectedMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SelectExperience), Member = "GetSelectedMenuItem")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetGameModeConfig")]
	public void OnExperienceClicked()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "ConfigureMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	private void AddMenuItem(int itemIndex)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SelectExperience), Member = "AddMenuItem")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	private int GetSelectedIndex()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private XPModeMenuItem GetSelectedItemAtIndex(int index)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "OnExperienceClicked")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 2)]
	private XPModeMenuItem GetSelectedMenuItem()
	{
		return null;
	}

	[Calls(Type = typeof(Panel_SelectExperience), Member = "IsPlayingAnimation")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "UpdateAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private bool IsPlayingAnySelectionAnimation()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SelectExperience), Member = "IsPlayingAnimation")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 6)]
	private bool IsPlayingAnyDeselectionAnimation()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "IsPlayingAnyDeselectionAnimation")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "IsPlayingAnySelectionAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool IsPlayingAnimation(int stateHash)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 6)]
	private void OnlyEnableItem(XPModeMenuItem enabledItem)
	{
	}

	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void PlaySelectedAnimation(XPModeMenuItem menuItem)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void PlayDeselectedAnimation(XPModeMenuItem menuItem)
	{
	}

	[Calls(Type = typeof(Panel_SelectExperience), Member = "OnlyEnableItem")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "Update")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SelectExperience), Member = "GetSelectedMenuItem")]
	[Calls(Type = typeof(Panel_SelectExperience), Member = "IsPlayingAnySelectionAnimation")]
	[Calls(Type = typeof(Panel_SelectExperience), Member = "IsPlayingAnyDeselectionAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	private void UpdateAnimation()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "Initialize")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void HideAllAnimatedItems()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateButtonLegend()
	{
	}

	[Calls(Type = typeof(BasicMenu), Member = "SetItemSelected")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void RestoreSelection()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Panel_SelectExperience()
	{
	}
}
