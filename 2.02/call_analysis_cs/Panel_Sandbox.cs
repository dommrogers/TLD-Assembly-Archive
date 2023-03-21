using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Sandbox : Panel_Base
{
	[Serializable]
	public class MainSurvivalMenuItem
	{
		public enum MenuType
		{
			NewSurvival,
			LoadSurvival,
			ResumeSurvival,
			Feats,
			Back
		}

		public MenuType m_Type;

		public string m_LabelLocalizationId;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public MainSurvivalMenuItem()
		{
		}
	}

	public ButtonLegendContainer m_ButtonLegendContainer;

	public string m_TitleLocalizationId;

	public GameObject m_BasicMenuRoot;

	public List<MainSurvivalMenuItem> m_MenuItems;

	public UILabel m_CloudMessageLabel;

	private BasicMenu m_BasicMenu;

	private CloudMenuExtension m_CloudMenuExtension;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 3)]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMenuExtensionButtonLegend")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "AddMenuItem")]
	[CallsUnknownMethods(Count = 35)]
	public Action GetActionFromType(MainSurvivalMenuItem.MenuType type)
	{
		return null;
	}

	[Calls(Type = typeof(BasicMenu), Member = "AddExtension")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[Calls(Type = typeof(Panel_Sandbox), Member = "AddMenuItem")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetNumSaveSlots")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[CallsUnknownMethods(Count = 21)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	private void ConfigureMenu()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Sandbox), Member = "GetActionFromType")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void AddMenuItem(int itemIndex)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshSandboxSaveSlots")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowNotEnoughSaveSlotsAvailableNotification")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetExperienceModeType")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetNumSaveSlotsInUse")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	public void OnClickNew()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void OnClickLoad()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnLoadSaveSlot")]
	[CallsUnknownMethods(Count = 2)]
	public void OnClickResume()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnMainMenuTop")]
	[Calls(Type = typeof(Panel_Badges), Member = "Enable")]
	[Calls(Type = typeof(Panel_Badges), Member = "OnFeats")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void OnClickFeats()
	{
	}

	[Calls(Type = typeof(Panel_MainMenu), Member = "OnMainMenuTop")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnClickBack()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMenuExtensionButtonLegend")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateButtonLegend()
	{
	}

	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetExperienceModeType")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnNewSandbox()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public Panel_Sandbox()
	{
	}
}
