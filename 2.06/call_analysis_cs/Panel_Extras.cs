using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Extras : Panel_AutoReferenced
{
	[Serializable]
	public class ExtraMenuItem
	{
		public enum ExtraMenuItemType
		{
			Journals,
			Back
		}

		public ExtraMenuItemType m_Type;

		public string m_LabelLocalizationId;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public ExtraMenuItem()
		{
		}
	}

	public ButtonLegendContainer m_ButtonLegendContainer;

	public string m_TitleLocalizationId;

	public GameObject m_BasicMenuRoot;

	private BasicMenu m_BasicMenu;

	public List<ExtraMenuItem> m_MenuItems;

	private PanelReference<Panel_Sandbox> m_Sandbox;

	private ExtraMenuItem m_JournalMenuItem;

	private int m_CreditsEpisode;

	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Extras), Member = "AddMenuItem")]
	[CallsUnknownMethods(Count = 11)]
	public Action GetActionFromType(ExtraMenuItem.ExtraMenuItemType type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Extras), Member = "ConfigureMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Extras), Member = "GetActionFromType")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void AddMenuItem(int itemIndex)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Extras), Member = "Enable")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(Panel_Extras), Member = "AddMenuItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	private void ConfigureMenu()
	{
	}

	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_Extras), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[CallsUnknownMethods(Count = 3)]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "ExitInterface")]
	public bool ShouldShowExtras()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_MainMenu), Member = "OnLogs")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	public void OnClickJournals()
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "StopMainMenuMusic")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	private void PlayCredits(int episodeIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Credits), Member = "ShowCredits")]
	[CallsUnknownMethods(Count = 11)]
	private void HandleOnCreditsLoaded(Panel_Base panel)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnCreditsFadedIn()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "PlayMainMenuMusic")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void OnCreditsEnd()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnClickBack()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public Panel_Extras()
	{
	}
}
