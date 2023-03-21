using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class IceFishingHole : MonoBehaviour
{
	public const string CAUGHT_FISH_EVENT_NAME = "GearItem_CaughtFish";

	public float m_MinutesBeforeFreezingStartsAfterClearing;

	public float m_FreezePercentPerGameHour;

	public float m_MinGameMinutesCatchFish;

	public float m_MaxGameMinutesCatchFish;

	public AK.Wwise.Event m_FishingProgressAudioEvent;

	public AK.Wwise.Event m_CatchFishAudioEvent;

	public AK.Wwise.Event m_FreeFishAudioEvent;

	public AK.Wwise.Event m_BreakThroughIceAudioEvent;

	public LootTableData m_LootTable;

	public GameObject m_ClosedHoleMesh;

	public GameObject m_PartialHoleMesh;

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	private PanelReference<Panel_IceFishing> m_IceFishingPanel;

	private PanelReference<Panel_IceFishingHoleClear> m_ClearHolePanel;

	private float m_MinutesSinceLastClearing;

	private float m_NormalizedFrozen;

	private bool m_FishingInProgress;

	private float m_ElapsedFishingTimeMinutes;

	private float m_NextCatchTimeMinutes;

	private GearItem m_FishingGearUsed;

	private bool m_StartHasBeenCalled;

	private float m_JustCaughtCancelCooldown;

	private static readonly float CAUGHT_FISH_INTERFACE_COOLDOWN;

	private static IceFishingHoleSaveData m_IceFishingHoleSaveData;

	private static List<IceFishingHole> m_IceFishingHoles;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IceFishingHole), Member = "UpdateFrozenState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "IsPaused")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "SerializeAll")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "DeserializeAll")]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(IceFishingHole), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 9)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IceFishingHole), Member = "FindIceFishingHoleByGuid")]
	[Calls(Type = typeof(IceFishingHole), Member = "FindIceFishingHoleByPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(IceFishingHole), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 2)]
	public static void DeserializeAll(string text)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Inventory), Member = "GetBestFishingTackle")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallerCount(Count = 0)]
	public void PerformInteraction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetNormalizedFrozen()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "OnBreakIceComplete")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "OnBreakIceComplete")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "UpdateFrozenState")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Deserialize")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Deserialize")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "ClearHole")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Start")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Deserialize")]
	public void SetNormalizedFrozen(float normalized)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	public void ClearHole()
	{
	}

	[Calls(Type = typeof(IceFishingHole), Member = "SetNextCatchTime")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "OnFish")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	public void StartFishing(float seconds, float minutes)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnFishingComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "LineBreak")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "OnDestroy")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "OnDisable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CallsUnknownMethods(Count = 1)]
	public void CancelFishing(bool fromInputManager = false)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsFishingInProgress()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeExitFishing()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(IceFishingHole), Member = "RevealFishInInspectMode")]
	[Calls(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNextCatchTime")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(IceFishingHole), Member = "LineBreak")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "IsPaused")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void MaybeCatchFish()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	private bool RollForLineBreak()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void LineBreak()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(IceFishingHole), Member = "RevealFishInInspectMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void CatchFish()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CatchFish")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	private void RevealFishInInspectMode(GameObject go)
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODHours")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateFrozenState()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void SetFishingInProgress(bool inProgress)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "StartFishing")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	private void SetNextCatchTime()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "IsPaused")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateFishingTime(float realtimeSeconds)
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private static IceFishingHole FindIceFishingHoleByPosition(IceFishingHoleSaveData proxy)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "DeserializeAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	private static IceFishingHole FindIceFishingHoleByGuid(string guid)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public IceFishingHole()
	{
	}
}
