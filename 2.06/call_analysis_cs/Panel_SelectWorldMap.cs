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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 13)]
	public override void Initialize()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnClickBack")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "OnExperienceClicked")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnContinue")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "UpdateAvailableWorldMaps")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "OnChallengeClicked")]
	public bool ShouldBePartOfFlow()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void SetTargetPanel(Panel_Base target)
	{
	}

	[Calls(Type = typeof(Panel_AutoReferenced), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void OnDestroy()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "GetActiveMap")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(BasicMenu), Member = "SetItemSelected")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "PlayFadeIn")]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "ConfigureMenu")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "UpdateAvailableWorldMaps")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "PlayFadeIn")]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void OnFadeOutFinished()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	private void Update()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Enable")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "AddMenuItem")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	private void ConfigureMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(BasicMenu), Member = "SetItemSelected")]
	[CallsUnknownMethods(Count = 3)]
	private void RestoreSelection()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void AddMenuItem(WorldMapSpecification worldMapSpecification, int itemIndex)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(GameManager), Member = "RegionLockedBySelectedMode")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "SetCurrentMap")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemId")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name")]
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
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Enable")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	private UIWorldMap GetActiveMap()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "PlayFadeOut")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "GetActiveMap")]
	[Calls(Type = typeof(UIWorldMap), Member = "LoadMap")]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "SetCurrentMap")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void OnSelectionUpdate(string id, int value, int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	private void OnClickBack()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	[CallsUnknownMethods(Count = 9)]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TweenAlpha), Member = "Begin")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnSelectionUpdate")]
	[CallsUnknownMethods(Count = 7)]
	private void PlayFadeOut(UIWorldMap map)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnFadeOutFinished")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TweenAlpha), Member = "Begin")]
	[CallerCount(Count = 2)]
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
