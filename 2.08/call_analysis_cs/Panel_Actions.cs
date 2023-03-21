using System;
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
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsUnknownMethods(Count = 8)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "GetColorForStatusLine")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Panel_Actions), Member = "UpdateFeelsLike")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(Panel_Actions), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Weather), Member = "GetWeatherStageDisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetPanelAlpha()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "RefreshMissionMessageNoLoc")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "RefreshMissionMessage")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[CallerCount(Count = 2)]
	public void ConfigureForMissionStart()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(Panel_Actions), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Panel_Actions), Member = "UpdateMissionInfo")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideEquipPopup")]
	[Calls(Type = typeof(EquipItemPopup), Member = "HideAmmoPopup")]
	[Calls(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	public void OnInventory()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnLog()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void OnFirstAid()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(PlayerInVehicle), Member = "OnBedroll")]
	[Calls(Type = typeof(SnowShelterManager), Member = "OnBedroll")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LeanToManager), Member = "OnBedroll")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LeanToManager), Member = "PlayerInLeanTo")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	public void OnBedRoll()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(SnowShelterManager), Member = "InstantiateSnowShelter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(SnowShelterManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(SnowShelterManager), Member = "CanAttemptToPlaceSnowShelter")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnSnowShelter()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public override bool IsOverlayPanel()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnLeanToNoCampfire")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnLeanTo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(LeanToManager), Member = "CanAttemptToPlaceLeanTo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(LeanToManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Inventory), Member = "GetLowestConditionGearThatMatchesName")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Inventory), Member = "GetLowestConditionGearThatMatchesName")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnSprayPaint()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnSprayPaint(GearItem sprayPaintCanToUse)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "ExecuteStartFireAction")]
	public void OnStartFire()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RockCacheManager), Member = "CanAttemptToPlaceRockCache")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(RockCacheManager), Member = "GetMissingMaterialsString")]
	public void OnPlaceRockCache()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void OnRepair()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void OnHarvest()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnBack()
	{
	}

	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void DoScrollUp()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
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

	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateWindchill()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Weather), Member = "GetWeatherStageDisplayName")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void UpdateWeatherConditions()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool IsFadingOut()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	private void SetFirstAidElements()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "FreezingBuffActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Headache), Member = "GetAfflictionsCount")]
	[Calls(Type = typeof(Headache), Member = "GetAfflictionsCount")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetAfflictionsCount")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetInsomniaCause")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetRisksCount")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetRisksCount")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetInsomniaCause")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Affliction), Member = "LocalizedNameFromAfflictionType")]
	[Calls(Type = typeof(Affliction), Member = "SpriteNameFromAfflictionType")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetCauseAndEffect")]
	[Calls(Type = typeof(BoxCollider), Member = "set_center")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "SetFirstAidElements")]
	[CallsUnknownMethods(Count = 103)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetAfflictionsCount")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 72)]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Infection), Member = "GetLocation")]
	[Calls(Type = typeof(Infection), Member = "GetLocation")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SprainedAnkle), Member = "GetLocation")]
	[Calls(Type = typeof(SprainedAnkle), Member = "GetLocation")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(InfectionRisk), Member = "GetLocation")]
	[Calls(Type = typeof(InfectionRisk), Member = "GetLocation")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SprainPain), Member = "GetLocation")]
	[Calls(Type = typeof(Headache), Member = "GetCause")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SprainPain), Member = "GetCauseLocId")]
	[Calls(Type = typeof(SprainedWrist), Member = "GetLocation")]
	[Calls(Type = typeof(SprainedWrist), Member = "GetLocation")]
	[Calls(Type = typeof(SprainPain), Member = "GetLocation")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void RefreshScrollList()
	{
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void UpdateMissionInfo()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Update")]
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
