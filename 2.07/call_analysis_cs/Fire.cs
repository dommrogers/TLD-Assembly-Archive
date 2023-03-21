using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Conditions;
using TLD.Serialization;
using TLD.UI.Generics;
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

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	private string _003CPrefabAddress_003Ek__BackingField;

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

	private float m_ElapsedOnTODSeconds;

	private float m_ElapsedOnTODSecondsUnmodified;

	private float m_MaxOnTODSeconds;

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

	private Action<bool> m_OnDoneStartingFire;

	private static Collider[] s_CookableColliderCandidates;

	public string PrefabAddress
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public static event FireStateDelegate OnFireStateChanged
	{
		[CompilerGenerated]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateFireplaceInteraction")]
		[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingSlot")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(FireManager), Member = "Serialize")]
	[Calls(Type = typeof(Campfire), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(FireManager), Member = "Deserialize")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "TurnOff")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "TurnOffImmediate")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(Fire), Member = "StartFireLit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Campfire), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "MaybeUpdateLongestBurningFireStat")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	private float GetWeatherAdjustedElapsedDuration(float realtimeSeconds)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Fire), Member = "StartFireLit")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FireManager), Member = "RemoveFire")]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(TimeOfDay), Member = "GetTODSeconds")]
	[Calls(Type = typeof(Fire), Member = "TurnOff")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "DeactivateAllFX")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Fire), Member = "UpdateFireStage")]
	[Calls(Type = typeof(Fire), Member = "UpdateFireAudio")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODSeconds")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Fire), Member = "GetWeatherAdjustedElapsedDuration")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Fire), Member = "FireShouldBlowOutFromWind")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Fire), Member = "MaybeUpdateLongestBurningFireStat")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeUpdateLongestBurningFireStat(float burnTimeInHours)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public FireState GetFireState()
	{
		return default(FireState);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnFuelBurnt(GearItem fuel)
	{
	}

	[Calls(Type = typeof(Fire), Member = "GetFireOuterRadiusScale")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ForceBurnResearchItem")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Fire), Member = "OnFuelBurnt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	public void AddFuel(GearItem fuel, bool inForge)
	{
	}

	[CalledBy(Type = typeof(FireManager), Member = "SerializeChimneyData")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CalledBy(Type = typeof(ClothingItem), Member = "Serialize")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Serialize")]
	[CalledBy(Type = typeof(ParticleFadeFire), Member = "LateUpdate")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	public float GetRemainingLifeTimeSeconds()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Condition_RemainingFireBurnTime), Member = "OnCheck")]
	public float GetRemainingLifeTimeHours()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(LightFadeFire), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 1)]
	public float GetIgnitionTotalGameTimeSeconds()
	{
		return default(float);
	}

	[Calls(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "TurnOn")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Fire), Member = "PlayStartingFireVoiceEvent")]
	public void PlayerBeginCreate(bool attemptSuccessful, float startTimeSeconds, FireStarterItem starter, FuelSourceItem fuel, FireStarterItem accelerant, Action<bool> onDoneStartingFire)
	{
	}

	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Fire), Member = "AttachToNearbyCookables")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	[CalledBy(Type = typeof(Fire), Member = "PlayerBeginCreate")]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Fire), Member = "TurnOff")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(WoodStove), Member = "Close")]
	private void ExitFireStarting(bool success, bool playerCancel, float progress)
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

	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Fire), Member = "StartFireLit")]
	[CalledBy(Type = typeof(Fire), Member = "UpdateFireStage")]
	[CalledBy(Type = typeof(Fire), Member = "UpdateFireStage")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOffImmediate")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOff")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CalledBy(Type = typeof(Fire), Member = "PlayerBeginCreate")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[Calls(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void FireStateSet(FireState stage)
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "UpdateFireAudio")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Fire), Member = "StartFireLit")]
	[CalledBy(Type = typeof(Fire), Member = "UpdateFireStage")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	public void PlayFireLoop(float blend)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void StopFireLoop()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void StopFireLoopImmediate()
	{
	}

	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Fire), Member = "PlayerBeginCreate")]
	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Fire), Member = "StartFireLit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Fire), Member = "GetFireOuterRadiusScale")]
	[CallerCount(Count = 2)]
	public void TurnOn(FuelSourceItem fuel, bool maskTempIncrease)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	public void TurnOff()
	{
	}

	[CalledBy(Type = typeof(EntityWard), Member = "DisableWard")]
	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	public void TurnOffImmediate()
	{
	}

	[CallerCount(Count = 0)]
	public void ReduceDurationByTODSeconds(float seconds)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void ReduceHeatByDegrees(float degreesCelsius)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetCurrentTempIncrease()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFireDurationLabel")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFireDurationLabel")]
	[CalledBy(Type = typeof(Forge), Member = "UpdateInteraction")]
	[CalledBy(Type = typeof(FireplaceInteraction), Member = "GetHoverText")]
	[CalledBy(Type = typeof(FireplaceInteraction), Member = "GetHoverText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public string GetHeatIncreaseText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public void ForceBurnTimeInMinutes(float minutes)
	{
	}

	[CalledBy(Type = typeof(SmokeTrail), Member = "InitEffect")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void SetSmokeTrail(SmokeTrail st)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "MaybeBlowOutFromWind")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CallsUnknownMethods(Count = 6)]
	public bool FireShouldBlowOutFromWind()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool StartedByPlayer()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Fire), Member = "HasAttachedCookables")]
	[CalledBy(Type = typeof(FireManager), Member = "Deserialize")]
	public bool CanBreakdownFire()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CanTakeTorch")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "AddFeedFireActions")]
	public bool CanTakeTorch()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public bool HasBurntItem(string itemName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool IsStartingFireUIInProgress()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	private void CalculateStageDurations(float fireStarterUseTimeSeconds, float fireStartTimeSeconds)
	{
	}

	[Calls(Type = typeof(Fire), Member = "PlayFireLoop")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	private void UpdateFireStage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "FireShouldBlowOutFromWind")]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeBlowOutFromWind()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[Calls(Type = typeof(Fire), Member = "PlayFireLoop")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private void UpdateFireAudio()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOn")]
	[CallsUnknownMethods(Count = 2)]
	private float GetFireOuterRadiusScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Fire), Member = "Start")]
	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Fire), Member = "PlayFireLoop")]
	[Calls(Type = typeof(Fire), Member = "TurnOn")]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void StartFireLit()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Fire), Member = "PlayerBeginCreate")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	private void PlayStartingFireVoiceEvent(bool successful)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 3)]
	private uint GetStartFireUrgencySwitch()
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[Calls(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	private void AttachToNearbyCookables()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "AddLightFireActions")]
	[CalledBy(Type = typeof(Fire), Member = "CanBreakdownFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	private bool HasAttachedCookables()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private int RoundOutput(float heatToRound)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Fire()
	{
	}
}
