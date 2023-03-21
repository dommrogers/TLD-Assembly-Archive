using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Conditions;
using UnityEngine;
using UnityEngine.AI;

public class Fire : MonoBehaviour
{
	public delegate void FireStateDelegate();

	public EffectsControllerFire m_FX;

	public bool m_StartLit;

	public bool m_IsPerpetual;

	public FuelSourceItem m_FuelPrefabIfLit;

	public float m_BurnMinutesIfLit;

	public string m_ChimneyGuid;

	public int m_NumStartingCharcoalPieces;

	public float m_NumCharcoalPiecesGeneratedPerHour;

	public int m_MaxNumCharcoal;

	public string m_FireAudioString;

	public bool m_ApplyToHeatSource;

	public float m_LightIntensityMultiplier;

	public bool m_BreakdownEnabled;

	public float m_BreakdownRealSecondsElapsed;

	public float m_BreakdownGameMinutes;

	public string m_BreakdownAudio;

	public HeatSource m_HeatSource;

	private FireState m_FireState;

	private FireStartingState m_FireStartingState;

	private float m_FireStageDurationSeconds;

	private float m_FireStarterUseSeconds;

	private float m_TinderSmolderSeconds;

	private float m_TinderSmallFlameSeconds;

	private float m_TinderMediumBurnSeconds;

	private float m_DurationSecondsToReduceToEmbers;

	private float m_EmberDurationSecondsTOD;

	private float m_EmberTimer;

	private bool m_UseEmbers;

	private GameObject m_DestroyOnFailure;

	private float m_ElapsedOnTODSeconds;

	private float m_ElapsedOnTODSecondsUnmodified;

	private float m_MaxOnTODSeconds;

	private float m_UsableFuelRemaining;

	private uint m_FireStarterLoop;

	private uint m_FireLoop;

	private float m_FuelHeatIncrease;

	private DamageTrigger m_DamageTrigger;

	private Campfire m_Campfire;

	private NavMeshObstacle m_NavMeshObstacle;

	private FuelSourceItem m_FuelUsedToStart;

	private bool m_FullBurnTriggered;

	private bool m_StartedByPlayer;

	private float m_TimeOffSeconds;

	private SmokeTrail m_SmokeTrail;

	private bool m_StartHasBeenCalled;

	private static FireSaveDataProxy m_FireSaveDataProxy;

	private int m_NumGeneratedCharcoalPieces;

	private bool m_HasCollectedCharcoal;

	private List<string> m_TrackedBurntItems;

	private float m_BurningTimeTODHours;

	private static bool m_IsStartingFireUIInProgress;

	private bool m_TriggerStageRequested;

	private static Collider[] s_CookableColliderCandidates;

	public static event FireStateDelegate OnFireStateChanged
	{
		[CompilerGenerated]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateWoodStove")]
		[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingSlot")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(Panel_ActionPicker), Member = "RemoveAllDelegates")]
		[CalledBy(Type = typeof(Panel_ActionPicker), Member = "RemoveAllDelegates")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 4)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Campfire), Member = "SetState")]
	[Calls(Type = typeof(Fire), Member = "PlayFireLoop")]
	[Calls(Type = typeof(Fire), Member = "TurnOn")]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(FireManager), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Campfire), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[Calls(Type = typeof(Fire), Member = "MaybeUpdateLongestBurningFireStat")]
	[Calls(Type = typeof(Fire), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(FireManager), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Fire), Member = "TurnOff")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 47)]
	[Calls(Type = typeof(Campfire), Member = "Deserialize")]
	[Calls(Type = typeof(Campfire), Member = "SetState")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Campfire), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "PlayFireLoop")]
	[Calls(Type = typeof(Fire), Member = "TurnOn")]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private float GetWeatherAdjustedElapsedDuration(float realtimeSeconds)
	{
		return default(float);
	}

	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "DeactivateAllFX")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[Calls(Type = typeof(Campfire), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "TurnOff")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODSeconds")]
	[Calls(Type = typeof(Fire), Member = "MaybeUpdateLongestBurningFireStat")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODSeconds")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Fire), Member = "GetWeatherAdjustedElapsedDuration")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Fire), Member = "MaybeBlowOutFromWind")]
	[Calls(Type = typeof(Fire), Member = "UpdateFireStage")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Fire), Member = "UpdateFireAudio")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeUpdateLongestBurningFireStat(float burnTimeInHours)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FireState GetFireState()
	{
		return default(FireState);
	}

	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(FireManager), Member = "SpawnPlayerFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnFuelBurnt(GearItem fuel)
	{
	}

	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ForceBurnResearchItem")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(Fire), Member = "GetFireOuterRadiusScale")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[Calls(Type = typeof(Fire), Member = "OnFuelBurnt")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	public void AddFuel(GearItem fuel, bool inForge)
	{
	}

	[CalledBy(Type = typeof(Condition_RemainingFireBurnTime), Member = "OnCheck")]
	[CalledBy(Type = typeof(FireManager), Member = "SerializeChimneyData")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFireDurationLabel")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFireDurationLabel")]
	[CalledBy(Type = typeof(WoodStove), Member = "GetHoverText")]
	[CalledBy(Type = typeof(WoodStove), Member = "GetMinutesLeftToBurn")]
	[CalledBy(Type = typeof(Campfire), Member = "GetMinutesLeftToBurn")]
	[CalledBy(Type = typeof(Campfire), Member = "GetHoverText")]
	[CalledBy(Type = typeof(ClothingItem), Member = "Serialize")]
	[CalledBy(Type = typeof(Fire), Member = "CanTakeTorch")]
	[CalledBy(Type = typeof(Fire), Member = "GetRemainingLifeTimeHours")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(ParticleFadeFire), Member = "LateUpdate")]
	[CalledBy(Type = typeof(LightFadeFire), Member = "LateUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Serialize")]
	public float GetRemainingLifeTimeSeconds()
	{
		return default(float);
	}

	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[CallerCount(Count = 0)]
	public float GetRemainingLifeTimeHours()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(LightFadeFire), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 3)]
	public float GetIgnitionTotalGameTimeSeconds()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(FireManager), Member = "SpawnPlayerFire")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[Calls(Type = typeof(Fire), Member = "PlayStartingFireVoiceEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Fire), Member = "TurnOn")]
	public void PlayerBeginCreate(bool attemptSuccessful, float startTimeSeconds, FireStarterItem starter, FuelSourceItem fuel, FireStarterItem accelerant, bool destoryOnFailure)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Campfire), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Fire), Member = "AttachToNearbyCookables")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	[CallsUnknownMethods(Count = 54)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[Calls(Type = typeof(Campfire), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WoodStove), Member = "Close")]
	[Calls(Type = typeof(Fire), Member = "StopFireLoop")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Fire), Member = "TurnOff")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 0)]
	public void ExitFireStarting(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 0)]
	public bool CanFeedFire()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsBurning()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public float GetMinutesBurning()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetUnmodifiedMinutesBurning()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetBurningTimeTODHours()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public bool IsEmbers()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Fire), Member = "PlayerBeginCreate")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOff")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOffImmediate")]
	[CalledBy(Type = typeof(Fire), Member = "UpdateFireStage")]
	[CalledBy(Type = typeof(Fire), Member = "UpdateFireStage")]
	[CalledBy(Type = typeof(Fire), Member = "UpdateFireStage")]
	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[CalledBy(Type = typeof(Fire), Member = "StartFireLit")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Fire), Member = "UpdateFireStage")]
	[CalledBy(Type = typeof(Fire), Member = "Start")]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[Calls(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	public void FireStateSet(FireState stage)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Fire), Member = "StartFireLit")]
	[CalledBy(Type = typeof(Fire), Member = "UpdateFireAudio")]
	[CalledBy(Type = typeof(Fire), Member = "UpdateFireStage")]
	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Fire), Member = "Start")]
	public void PlayFireLoop(float blend)
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "TurnOff")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	public void StopFireLoop()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOffImmediate")]
	[CalledBy(Type = typeof(Fire), Member = "OnDisable")]
	public void StopFireLoopImmediate()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Fire), Member = "StartFireLit")]
	[CalledBy(Type = typeof(Fire), Member = "PlayerBeginCreate")]
	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[CalledBy(Type = typeof(Fire), Member = "Start")]
	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[Calls(Type = typeof(Fire), Member = "GetFireOuterRadiusScale")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void TurnOn(FuelSourceItem fuel, bool maskTempIncrease)
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[CalledBy(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "StopFireLoop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	public void TurnOff()
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[CalledBy(Type = typeof(EntityWard), Member = "DisableWard")]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Fire), Member = "StopFireLoopImmediate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void TurnOffImmediate()
	{
	}

	[CallerCount(Count = 0)]
	public void ReduceDurationByTODSeconds(float seconds)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ReduceHeatByDegrees(float degreesCelsius)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float GetCurrentTempIncrease()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Campfire), Member = "GetHoverText")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFireDurationLabel")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFireDurationLabel")]
	[CalledBy(Type = typeof(WoodStove), Member = "GetHoverText")]
	[CalledBy(Type = typeof(WoodStove), Member = "GetHoverText")]
	[CalledBy(Type = typeof(Forge), Member = "GetHoverText")]
	[CalledBy(Type = typeof(Campfire), Member = "GetHoverText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public string GetHeatIncreaseText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public void ForceBurnTimeInMinutes(float minutes)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "InitEffect")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void SetSmokeTrail(SmokeTrail st)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CalledBy(Type = typeof(Fire), Member = "MaybeBlowOutFromWind")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CallsUnknownMethods(Count = 9)]
	public bool FireShouldBlowOutFromWind()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool StartedByPlayer()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Fire), Member = "HasAttachedCookables")]
	public bool CanBreakdownFire()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CanTakeTorch")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "AddFeedFireActions")]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeSeconds")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public bool CanTakeTorch()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "AddLightFireActions")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "DismantleFireCompleteCallback")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "CanHarvestCharcoal")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	public int GetAvailableCharcoalPieces()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public void RemoveAllCharcoal()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Condition_ItemConsumedInFire), Member = "OnCheck")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool HasBurntItem(string itemName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsStartingFireUIInProgress()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	private void CalculateStageDurations(float fireStarterUseTimeSeconds, float fireStartTimeSeconds)
	{
	}

	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[Calls(Type = typeof(Fire), Member = "PlayFireLoop")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	private void UpdateFireStage()
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[Calls(Type = typeof(Campfire), Member = "CanFeedFire")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "FireShouldBlowOutFromWind")]
	private void MaybeBlowOutFromWind()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Fire), Member = "PlayFireLoop")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateFireAudio()
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "TurnOn")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	private float GetFireOuterRadiusScale()
	{
		return default(float);
	}

	[Calls(Type = typeof(Campfire), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "PlayFireLoop")]
	[Calls(Type = typeof(Fire), Member = "TurnOn")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	private void StartFireLit()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(Fire), Member = "GetStartFireUrgencySwitch")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CalledBy(Type = typeof(Fire), Member = "PlayerBeginCreate")]
	[CallsUnknownMethods(Count = 4)]
	private void PlayStartingFireVoiceEvent(bool successful)
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "PlayStartingFireVoiceEvent")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallerCount(Count = 1)]
	private uint GetStartFireUrgencySwitch()
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FireManager), Member = "RemoveFire")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Fire), Member = "StopFireLoopImmediate")]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[Calls(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	private void AttachToNearbyCookables()
	{
	}

	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "AddLightFireActions")]
	[CalledBy(Type = typeof(Fire), Member = "CanBreakdownFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool HasAttachedCookables()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	private int RoundOutput(float heatToRound)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Fire()
	{
	}
}
