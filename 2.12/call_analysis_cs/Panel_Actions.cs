using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay.Condition;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_Actions : Panel_AutoReferenced
{
	public GameObject m_TimeWidgetPos;

	public UILabel m_TimeSurvivedLabel;

	public UILabel m_ConditionsLabel;

	public UILabel m_AirTempLabel;

	public UILabel m_AirTempHeaderLabel;

	public UILabel m_WindChillLabel;

	public UILabel m_WindChillHeaderLabel;

	public UILabel m_ClothingWarmthLabel;

	public UILabel m_ClothingWarmthHeaderLabel;

	public UILabel m_ClothingWindproofLabel;

	public UILabel m_ClothingWindproofHeaderLabel;

	public UILabel m_CalorieBurnLabel;

	public UILabel m_FeelsLikeLabel;

	public Color m_FreezingTempLabelColor;

	public GameObject m_MissionObjectivePanel;

	public UILabel m_ObjectiveStatus;

	public UILabel m_SubObjectiveStatus;

	public MissionsProgressBar m_MissionsProgressBar;

	public UISprite m_SpriteBody;

	public GameObject m_RightPageHealthyObject;

	public ScrollList m_ScrollListEffects;

	public GameObject m_ButtonScrollUp;

	public GameObject m_ButtonScrollDown;

	public UISprite[] m_BodyIconList;

	public UISprite m_StatusLineSprite;

	public float m_FadeTime;

	public float m_FadeTimeMissionStart;

	public UILabel m_MissionObjectiveLabel;

	public UILabel m_MissionObjectiveWithTimerLabel;

	public UILabel m_MissionTimerLabel;

	public GameObject m_MissionObjectWithTimer;

	public GameObject m_MissionObjectNoTimer;

	public GameObject m_SprayPaintCanPrefab;

	public GameObject m_SprayPaintCanPrefabNW2H;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Rest> m_Rest;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_Inventory> m_Inventory;

	private PanelReference<Panel_Log> m_Log;

	private PanelReference<Panel_BedRollSelect> m_BedRollSelect;

	private PanelReference<Panel_SprayPaint> m_SprayPaint;

	private PanelReference<Panel_Repair> m_Repair;

	private PanelReference<Panel_Harvest> m_Harvest;

	private bool m_IgnoreEscape;

	private bool m_IgnoreInput;

	private bool m_DoFadeOut;

	private float m_FadeTimer;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	public override void Initialize()
	{
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Weather), Member = "GetWeatherStageDisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Actions), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(Panel_Actions), Member = "UpdateFeelsLike")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "GetColorForStatusLine")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetPanelAlpha()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "RefreshMissionMessage")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "RefreshMissionMessageNoLoc")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[CallsUnknownMethods(Count = 1)]
	public void ConfigureForMissionStart()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideAmmoPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Actions), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(Panel_Actions), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnInventory()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnLog()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnFirstAid()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LeanToManager), Member = "PlayerInLeanTo")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(LeanToManager), Member = "OnBedroll")]
	[Calls(Type = typeof(SnowShelterManager), Member = "OnBedroll")]
	[Calls(Type = typeof(PlayerInVehicle), Member = "OnBedroll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 14)]
	public void OnBedRoll()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SnowShelterManager), Member = "CanAttemptToPlaceSnowShelter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(SnowShelterManager), Member = "InstantiateSnowShelter")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void OnSnowShelter()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public override bool IsOverlayPanel()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "OnLeanTo")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnLeanToNoCampfire")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LeanToManager), Member = "CanAttemptToPlaceLeanTo")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(LeanToManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void OnLeanToInternal(bool hasCampfire)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Actions), Member = "OnLeanToInternal")]
	public void OnLeanTo()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Actions), Member = "OnLeanToInternal")]
	public void OnLeanToNoCampfire()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetLowestConditionGearThatMatchesName")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CallsUnknownMethods(Count = 3)]
	public void OnSprayPaint()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	public void OnSprayPaint(GearItem sprayPaintCanToUse)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "ExecuteStartFireAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnStartFire()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RockCacheManager), Member = "CanAttemptToPlaceRockCache")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void OnPlaceRockCache()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnRepair()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnHarvest()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnBack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void DoScrollUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void DoScrollDown()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateAirTemperature()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateWindchill()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Weather), Member = "GetWeatherStageDisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateWeatherConditions()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsFadingOut()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	private void SetFirstAidElements()
	{
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "SetFirstAidElements")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Infection), Member = "GetLocation")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(SprainedAnkle), Member = "GetLocation")]
	[Calls(Type = typeof(SprainedWrist), Member = "GetLocation")]
	[Calls(Type = typeof(SprainPain), Member = "GetCauseLocId")]
	[Calls(Type = typeof(SprainPain), Member = "GetLocation")]
	[Calls(Type = typeof(InfectionRisk), Member = "GetLocation")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(PlayerManager), Member = "FreezingBuffActive")]
	[Calls(Type = typeof(Headache), Member = "GetAfflictionsCount")]
	[Calls(Type = typeof(Headache), Member = "GetCause")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetAfflictionsCount")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetInsomniaCause")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetRisksCount")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Affliction), Member = "LocalizedNameFromAfflictionType")]
	[Calls(Type = typeof(Affliction), Member = "SpriteNameFromAfflictionType")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetCauseAndEffect")]
	[Calls(Type = typeof(BoxCollider), Member = "set_center")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 49)]
	[CallsUnknownMethods(Count = 96)]
	private void RefreshScrollList()
	{
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateMissionInfo()
	{
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateFeelsLike()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Panel_Actions()
	{
	}
}
