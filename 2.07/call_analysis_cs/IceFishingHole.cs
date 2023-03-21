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

	[Calls(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(IceFishingHole), Member = "UpdateFrozenState")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "IsPaused")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[CallsUnknownMethods(Count = 6)]
	private void Update()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IceFishingHole), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(IceFishingHole), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(IceFishingHole), Member = "FindIceFishingHoleByGuid")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IceFishingHole), Member = "FindIceFishingHoleByPosition")]
	public static void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByCurrentHP")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 3)]
	public void PerformInteraction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetNormalizedFrozen()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "UpdateFrozenState")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "OnBreakIceComplete")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "ClearHole")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "OnBreakIceComplete")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "OnBreakIceComplete")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Deserialize")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Deserialize")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Start")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Deserialize")]
	public void SetNormalizedFrozen(float normalized)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	public void ClearHole()
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishing), Member = "OnFish")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNextCatchTime")]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "LineBreak")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "OnDisable")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "OnDestroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	public void CancelFishing(bool fromInputManager = false)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsFishingInProgress()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeExitFishing()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(IceFishingHole), Member = "RevealFishInInspectMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNextCatchTime")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "IsPaused")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(IceFishingHole), Member = "LineBreak")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	private void MaybeCatchFish()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsUnknownMethods(Count = 2)]
	private bool RollForLineBreak()
	{
		return default(bool);
	}

	[Calls(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void LineBreak()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(IceFishingHole), Member = "RevealFishInInspectMode")]
	[Calls(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void CatchFish()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CatchFish")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	private void RevealFishInInspectMode(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Update")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODHours")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void UpdateFrozenState()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void SetFishingInProgress(bool inProgress)
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "StartFishing")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 9)]
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
	[CallerCount(Count = 0)]
	public IceFishingHole()
	{
	}
}
