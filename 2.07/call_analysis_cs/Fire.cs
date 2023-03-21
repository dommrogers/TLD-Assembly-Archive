using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Conditions;
using TLD.SaveState;
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
		[CallerCount(Count = 7)]
		set
		{
		}
	}

	public static event FireStateDelegate OnFireStateChanged
	{
		[CompilerGenerated]
		[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateFireplaceInteraction")]
		[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingSlot")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CalledBy(Type = typeof(FireManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Campfire), Member = "Serialize")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(FireManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Fire), Member = "StartFireLit")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[Calls(Type = typeof(Campfire), Member = "Deserialize")]
	[Calls(Type = typeof(Fire), Member = "MaybeUpdateLongestBurningFireStat")]
	[Calls(Type = typeof(Fire), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Fire), Member = "TurnOff")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 15)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private float GetWeatherAdjustedElapsedDuration(float realtimeSeconds)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[Calls(Type = typeof(Fire), Member = "UpdateFireStage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "FireShouldBlowOutFromWind")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Fire), Member = "GetWeatherAdjustedElapsedDuration")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODSeconds")]
	[Calls(Type = typeof(Fire), Member = "UpdateFireAudio")]
	[Calls(Type = typeof(Fire), Member = "MaybeUpdateLongestBurningFireStat")]
	[Calls(Type = typeof(Fire), Member = "TurnOff")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "DeactivateAllFX")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeUpdateLongestBurningFireStat(float burnTimeInHours)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public FireState GetFireState()
	{
		return default(FireState);
	}

	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 2)]
	public void OnFuelBurnt(GearItem fuel)
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ForceBurnResearchItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Fire), Member = "OnFuelBurnt")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "LocalPrint")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerParticleSystems")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[Calls(Type = typeof(Fire), Member = "GetFireOuterRadiusScale")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void AddFuel(GearItem fuel, bool inForge)
	{
	}

	[CalledBy(Type = typeof(ParticleFadeFire), Member = "LateUpdate")]
	[CalledBy(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(ClothingItem), Member = "Serialize")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Serialize")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CalledBy(Type = typeof(FireManager), Member = "SerializeChimneyData")]
	[CallerCount(Count = 6)]
	public float GetRemainingLifeTimeSeconds()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Condition_RemainingFireBurnTime), Member = "OnCheck")]
	[CallerCount(Count = 1)]
	public float GetRemainingLifeTimeHours()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(LightFadeFire), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public float GetIgnitionTotalGameTimeSeconds()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Fire), Member = "TurnOn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Fire), Member = "PlayStartingFireVoiceEvent")]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Fire), Member = "ExitFireStarting")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void PlayerBeginCreate(bool attemptSuccessful, float startTimeSeconds, FireStarterItem starter, FuelSourceItem fuel, FireStarterItem accelerant, Action<bool> onDoneStartingFire)
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "PlayerBeginCreate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(GearItem), Member = "BreakOnUse")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(WoodStove), Member = "Close")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Fire), Member = "TurnOff")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(PlayerManager), Member = "ConsumeUnitFromInventory")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[Calls(Type = typeof(Fire), Member = "AttachToNearbyCookables")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PanViewCamera), Member = "ReattachToPlayer")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 17)]
	private void ExitFireStarting(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 0)]
	public bool CanFeedFire()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsBurning()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public float GetMinutesBurning()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetUnmodifiedMinutesBurning()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetBurningTimeTODHours()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public bool IsEmbers()
	{
		return false;
	}

	[CalledBy(Type = typeof(Fire), Member = "PlayerBeginCreate")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOff")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOffImmediate")]
	[CalledBy(Type = typeof(Fire), Member = "UpdateFireStage")]
	[CalledBy(Type = typeof(Fire), Member = "StartFireLit")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[Calls(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	[Calls(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 5)]
	public void FireStateSet(FireState stage)
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "UpdateFireStage")]
	[CalledBy(Type = typeof(Fire), Member = "UpdateFireAudio")]
	[CalledBy(Type = typeof(Fire), Member = "StartFireLit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(Fire), Member = "PlayerBeginCreate")]
	[CalledBy(Type = typeof(Fire), Member = "StartFireLit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[Calls(Type = typeof(Fire), Member = "GetFireOuterRadiusScale")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[Calls(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[CallsUnknownMethods(Count = 1)]
	public void TurnOn(FuelSourceItem fuel, bool maskTempIncrease)
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[CallsUnknownMethods(Count = 2)]
	public void TurnOff()
	{
	}

	[CalledBy(Type = typeof(EntityWard), Member = "DisableWard")]
	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "StopAllFX")]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[CallsUnknownMethods(Count = 1)]
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
		return 0f;
	}

	[CalledBy(Type = typeof(FireplaceInteraction), Member = "GetHoverText")]
	[CalledBy(Type = typeof(Forge), Member = "UpdateInteraction")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFireDurationLabel")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFireDurationLabel")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	public string GetHeatIncreaseText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public void ForceBurnTimeInMinutes(float minutes)
	{
	}

	[CalledBy(Type = typeof(SmokeTrail), Member = "InitEffect")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetSmokeTrail(SmokeTrail st)
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CalledBy(Type = typeof(Fire), Member = "MaybeBlowOutFromWind")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "OnFeedFire")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public bool FireShouldBlowOutFromWind()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool StartedByPlayer()
	{
		return false;
	}

	[CalledBy(Type = typeof(FireManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Fire), Member = "HasAttachedCookables")]
	public bool CanBreakdownFire()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "AddFeedFireActions")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "CanTakeTorch")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public bool CanTakeTorch()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "AddLightFireActions")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "DismantleFireCompleteCallback")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "CanHarvestCharcoal")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnCharcoalHarvest")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	public int GetAvailableCharcoalPieces()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	public void RemoveAllCharcoal()
	{
	}

	[CalledBy(Type = typeof(Condition_ItemConsumedInFire), Member = "OnCheck")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasBurntItem(string itemName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool IsStartingFireUIInProgress()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	private void CalculateStageDurations(float fireStarterUseTimeSeconds, float fireStartTimeSeconds)
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[Calls(Type = typeof(EffectsControllerFire), Member = "TriggerStage")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Fire), Member = "PlayFireLoop")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(Fire), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Fire), Member = "PlayFireLoop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateFireAudio()
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOn")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 2)]
	private float GetFireOuterRadiusScale()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[CalledBy(Type = typeof(Fire), Member = "Start")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Fire), Member = "FireStateSet")]
	[Calls(Type = typeof(Fire), Member = "TurnOn")]
	[Calls(Type = typeof(Fire), Member = "PlayFireLoop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void StartFireLit()
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "PlayerBeginCreate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 5)]
	private void PlayStartingFireVoiceEvent(bool successful)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 3)]
	private uint GetStartFireUrgencySwitch()
	{
		return 0u;
	}

	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Cookable), Member = "MaybeStartWarmingUpDueToNearbyFire")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[Calls(Type = typeof(CookingPotItem), Member = "AttachedFireIsBurning")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Cookable), Member = "MaybeReattachToNearbyFire")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	private void AttachToNearbyCookables()
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "CanBreakdownFire")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "AddLightFireActions")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsDummyPot")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	private bool HasAttachedCookables()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private int RoundOutput(float heatToRound)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Fire()
	{
	}
}
