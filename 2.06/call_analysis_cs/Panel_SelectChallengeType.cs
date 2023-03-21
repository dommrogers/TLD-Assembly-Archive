using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using TLD.UI;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.PostProcessing;

public class Panel_SelectChallengeType : Panel_AutoReferenced
{
	public ButtonLegendContainer m_ButtonLegendContainer;

	public UITexture m_ChallengeTexture;

	public string m_HeaderTitleLocalizationId;

	public string m_TitleLocalizationId;

	public Vector3 m_TitleHeaderOffset;

	public GameObject m_BasicMenuRoot;

	private BasicMenu m_BasicMenu;

	public List<ChallengeConfig> m_Challenges;

	public UISprite m_TitleIcon;

	public UILocalize m_TitleText;

	public UILocalize m_Description;

	public UILocalize m_Instructions;

	public UILocalize m_BulletPoints;

	public List<UISprite> m_DifficultySprites;

	public Color m_DifficultyOnColor;

	public Color m_DifficultyOffColor;

	private ChallengeConfig m_lastSelectedConfig;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 3)]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_SelectChallengeType), Member = "ChallengeIsLocked")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_SelectChallengeType), Member = "ChallengeIsLocked")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "OnChallengeClicked")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "Update")]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetLockedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private bool ChallengeIsLocked()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "ShouldBePartOfFlow")]
	[Calls(Type = typeof(GameManager), Member = "RegionLockedBySelectedMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_SelectChallengeType), Member = "ChallengeIsLocked")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	public void OnChallengeClicked()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "ConfigureMenu")]
	private void AddMenuItem(int itemIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "Enable")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Panel_SelectChallengeType), Member = "AddMenuItem")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	private void ConfigureMenu()
	{
	}

	[Calls(Type = typeof(Panel_SelectChallengeType), Member = "RestoreSelection")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_SelectChallengeType), Member = "ConfigureMenu")]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetChallengeTexture")]
	[Calls(Type = typeof(AssetReference), Member = "IsValid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetChallengeTexture")]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnClickBack()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[Calls(Type = typeof(UILocalize), Member = "set_value")]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetLockedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetChallengeTexture")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetGameModeConfig")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "RestoreSelection")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetChallengeTexture")]
	[Calls(Type = typeof(UILocalize), Member = "set_value")]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetChallengeTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetLockedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetLockedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILocalize), Member = "set_value")]
	[Calls(Type = typeof(ChallengeConfig), Member = "GetLockedCondition")]
	[Calls(Type = typeof(UILocalize), Member = "set_value")]
	private void UpdateUISelection(int itemIndex)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_SelectChallengeType), Member = "ChallengeIsLocked")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void UpdateButtonLegend()
	{
	}

	[Calls(Type = typeof(Panel_SelectChallengeType), Member = "UpdateUISelection")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "SetItemSelected")]
	private void RestoreSelection()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public Panel_SelectChallengeType()
	{
	}
}
