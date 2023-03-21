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

	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(IceFishingHole), Member = "UpdateFrozenState")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "IsPaused")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "SerializeAll")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IceFishingHole), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(IceFishingHole), Member = "FindIceFishingHoleByGuid")]
	[Calls(Type = typeof(IceFishingHole), Member = "FindIceFishingHoleByPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(IceFishingHole), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 2)]
	public static void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByCurrentHP")]
	public void PerformInteraction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetNormalizedFrozen()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "OnBreakIceComplete")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "OnBreakIceComplete")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "OnBreakIceComplete")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "UpdateFrozenState")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "ClearHole")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Start")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Deserialize")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void SetNormalizedFrozen(float normalized)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ClearHole()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNextCatchTime")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "OnFish")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void StartFishing(float seconds, float minutes)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void OnFishingComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "OnDestroy")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "OnDisable")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "LineBreak")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CallsUnknownMethods(Count = 1)]
	public void CancelFishing(bool fromInputManager = false)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsFishingInProgress()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallerCount(Count = 0)]
	private void MaybeExitFishing()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Update")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNextCatchTime")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(IceFishingHole), Member = "RevealFishInInspectMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(IceFishingHole), Member = "LineBreak")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "IsPaused")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallerCount(Count = 1)]
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
	[Calls(Type = typeof(IceFishingHole), Member = "RevealFishInInspectMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void CatchFish()
	{
	}

	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CatchFish")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	private void RevealFishInInspectMode(GameObject go)
	{
	}

	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODHours")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "StartFishing")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 9)]
	private static IceFishingHole FindIceFishingHoleByPosition(IceFishingHoleSaveData proxy)
	{
		return null;
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "DeserializeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	private static IceFishingHole FindIceFishingHoleByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public IceFishingHole()
	{
	}
}
