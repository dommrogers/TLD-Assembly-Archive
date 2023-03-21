using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Extras : Panel_Base
{
	[Serializable]
	public class ExtraMenuItem
	{
		public enum ExtraMenuItemType
		{
			Journals,
			CreditsEp1Ep2,
			Community,
			Updates,
			Back,
			CreditsEp3,
			CreditsEp4
		}

		public ExtraMenuItemType m_Type;

		public string m_LabelLocalizationId;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public ExtraMenuItem()
		{
		}
	}

	public ButtonLegendContainer m_ButtonLegendContainer;

	public string m_TitleLocalizationId;

	public GameObject m_BasicMenuRoot;

	private BasicMenu m_BasicMenu;

	public List<ExtraMenuItem> m_MenuItems;

	private ExtraMenuItem m_JournalMenuItem;

	private int m_CreditsEpisode;

	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Extras), Member = "AddMenuItem")]
	[CallsUnknownMethods(Count = 42)]
	public Action GetActionFromType(ExtraMenuItem.ExtraMenuItemType type)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Extras), Member = "ConfigureMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Extras), Member = "GetActionFromType")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void AddMenuItem(int itemIndex)
	{
	}

	[Calls(Type = typeof(Panel_Extras), Member = "AddMenuItem")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(Panel_Extras), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[Calls(Type = typeof(Panel_Notifications), Member = "HasNotifications")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	private void ConfigureMenu()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(Panel_Extras), Member = "ConfigureMenu")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnLogs")]
	[CallsUnknownMethods(Count = 1)]
	public void OnClickJournals()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Extras), Member = "PlayCredits")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnClickCredits()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Extras), Member = "PlayCredits")]
	public void OnClickCreditsEp3()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnClickCreditsEp4()
	{
	}

	[CalledBy(Type = typeof(Panel_Extras), Member = "OnClickCreditsEp3")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Extras), Member = "OnClickCredits")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "StopMainMenuMusic")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private void PlayCredits(int episodeIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Credits), Member = "ShowCredits")]
	[CallsUnknownMethods(Count = 15)]
	private void HandleOnCreditsLoaded(Panel_Base panel)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnCreditsFadedIn()
	{
	}

	[Calls(Type = typeof(Panel_MainMenu), Member = "PlayMainMenuMusic")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void OnCreditsEnd()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnMainMenuTop")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void OnClickBack()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Notifications), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	public void OnClickUpdates()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public Panel_Extras()
	{
	}
}
