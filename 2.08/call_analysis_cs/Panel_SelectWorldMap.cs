using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.SaveState;
using TLD.Scenes;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_SelectWorldMap : Panel_AutoReferenced
{
	private PanelReference<Panel_SelectSurvivor> m_SelectSurvivor;

	private PanelReference<Panel_SelectRegion_Map> m_SelectRegion;

	private ButtonLegendContainer m_ButtonLegendContainer;

	private LocalizedString m_BackButtonText;

	private LocalizedString m_ConfirmButtonText;

	private LocalizedString m_TitleLocalizationText;

	private LocalizedString m_HeaderTitleLocalizationText;

	private Vector3 m_TitleHeaderOffset;

	private GameObject m_BasicMenuRoot;

	private WorldMapChangedEvent m_WorldMapChanged;

	private Transform m_BaseMapParent;

	private float m_FadeDuration;

	private Vector2 m_FadeAlphaBounds;

	private BasicMenu m_BasicMenu;

	private IList<WorldMapSpecification> m_AvailableMaps;

	private Panel_Base m_TargetPanel;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "UpdateAvailableWorldMaps")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnContinue")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "OnChallengeClicked")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "OnExperienceClicked")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnClickBack")]
	public bool ShouldBePartOfFlow()
	{
		return default(bool);
	}

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public void SetTargetPanel(Panel_Base target)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_AutoReferenced), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "PlayFadeIn")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "GetActiveMap")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "RestoreSelection")]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "ConfigureMenu")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "UpdateAvailableWorldMaps")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(TweenAlpha), Member = "Begin")]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void OnFadeOutFinished()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	private void Update()
	{
	}

	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Enable")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void ConfigureMenu()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BasicMenu), Member = "SetItemSelected")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Enable")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void RestoreSelection()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	private void AddMenuItem(WorldMapSpecification worldMapSpecification, int itemIndex)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemId")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(GameManager), Member = "RegionLockedBySelectedMode")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "SetCurrentMap")]
	private void OnWorldMapClicked()
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

	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnSelectionUpdate")]
	private UIWorldMap GetActiveMap()
	{
		return null;
	}

	[Calls(Type = typeof(TweenAlpha), Member = "Begin")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "GetActiveMap")]
	[Calls(Type = typeof(UIWorldMap), Member = "LoadMap")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "SetCurrentMap")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnSelectionUpdate(string id, int value, int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	private void OnClickBack()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void SwapBackgroundWithoutFades(string id, int value, int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	[CallsUnknownMethods(Count = 1)]
	private UIWorldMap GetWorldMap(WorldMapSpecification specification)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TweenAlpha), Member = "Begin")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsUnknownMethods(Count = 2)]
	private void PlayFadeOut(UIWorldMap map)
	{
	}

	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Enable")]
	[Calls(Type = typeof(TweenAlpha), Member = "Begin")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void PlayFadeIn(UIWorldMap map)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "UpdateAvailableWorldMaps")]
	[CallsUnknownMethods(Count = 1)]
	private void HandleProfileLoaded(ProfileState _)
	{
	}

	[CallerCount(Count = 0)]
	public Panel_SelectWorldMap()
	{
	}
}
