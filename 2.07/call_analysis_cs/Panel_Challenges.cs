using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Challenges : Panel_AutoReferenced
{
	[Serializable]
	public class ChallengeslMenuItem
	{
		public enum MenuType
		{
			NewChallenge,
			LoadChallenge,
			ResumeChallenge,
			AllChallenges
		}

		public MenuType m_Type;

		public string m_LabelLocalizationId;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public ChallengeslMenuItem()
		{
		}
	}

	private PanelReference<Panel_Badges> m_Badges;

	private PanelReference<Panel_ChooseChallenge> m_ChooseChallenge;

	private PanelReference<Panel_Confirmation> m_Confirmation;

	private PanelReference<Panel_MainMenu> m_MainMenu;

	private PanelReference<Panel_SelectChallengeType> m_SelectChallengeType;

	private PanelReference<Panel_Sandbox> m_Sandbox;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public string m_TitleLocalizationId;

	public GameObject m_BasicMenuRoot;

	public List<ChallengeslMenuItem> m_MenuItems;

	public UILabel m_CloudMessageLabel;

	private BasicMenu m_BasicMenu;

	private CloudMenuExtension m_CloudMenuExtension;

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Action GetActionFromType(ChallengeslMenuItem.MenuType type)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(BasicMenu), Member = "AddExtension")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(Panel_Challenges), Member = "AddMenuItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "Enable")]
	[CallsUnknownMethods(Count = 4)]
	private void ConfigureMenu()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void AddMenuItem(int itemIndex)
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMenuExtensionButtonLegend")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshChallengeSaveSlots")]
	[Calls(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowNotEnoughSaveSlotsAvailableNotification")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetNumSaveSlotsInUse")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 4)]
	public void OnClickNew()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CallsUnknownMethods(Count = 1)]
	public void OnClickLoad()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnLoadSaveSlot")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void OnClickResume()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnClickBack()
	{
	}

	[Calls(Type = typeof(Panel_Badges), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Badges), Member = "OnChallenges")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnMainMenuTop")]
	public void OnClickAllChallenges()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMenuExtensionButtonLegend")]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	public void OnNewChallenge()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_Challenges()
	{
	}
}
