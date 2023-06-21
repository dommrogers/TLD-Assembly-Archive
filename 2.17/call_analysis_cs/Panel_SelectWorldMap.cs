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
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "add_OnAfterDeserialization")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public override void Initialize()
	{
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnContinue")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "OnChallengeClicked")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "OnExperienceClicked")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnClickBack")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "UpdateAvailableWorldMaps")]
	[CallsUnknownMethods(Count = 2)]
	public bool ShouldBePartOfFlow()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void SetTargetPanel(Panel_Base target)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "remove_OnAfterDeserialization")]
	[Calls(Type = typeof(Panel_AutoReferenced), Member = "OnDestroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "UpdateAvailableWorldMaps")]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "ConfigureMenu")]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "RestoreSelection")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "GetActiveMap")]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "PlayFadeIn")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(TweenAlpha), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 15)]
	public void OnFadeOutFinished()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	private void ConfigureMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BasicMenu), Member = "SetItemSelected")]
	[CallsUnknownMethods(Count = 3)]
	private void RestoreSelection()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void AddMenuItem(WorldMapSpecification worldMapSpecification, int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemId")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "SetCurrentMap")]
	[Calls(Type = typeof(GameManager), Member = "RegionLockedBySelectedMode")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	private void OnWorldMapClicked()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnSelectionUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private UIWorldMap GetActiveMap()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "SetCurrentMap")]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIWorldMap), Member = "LoadMap")]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "GetActiveMap")]
	[Calls(Type = typeof(TweenAlpha), Member = "Begin")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnSelectionUpdate(string id, int value, int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnClickBack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
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
	[Calls(Type = typeof(TweenAlpha), Member = "Begin")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void PlayFadeOut(UIWorldMap map)
	{
	}

	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenAlpha), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
