using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class IceFishingHole : MonoBehaviour
{
	public const string CAUGHT_FISH_EVENT_NAME = "GearItem_CaughtFish";

	public LocalizedString m_LocalizedDisplayName;

	public float m_MinutesBeforeFreezingStartsAfterClearing;

	public float m_FreezePercentPerGameHour;

	public float m_MinGameMinutesCatchFish;

	public float m_MaxGameMinutesCatchFish;

	public string m_FishingProgressAudio;

	public string m_CatchFishAudio;

	public string m_FreeFishAudio;

	public string m_BreakThroughIceAudio;

	public LootTable m_LootTablePrefab;

	public GameObject m_ClosedHoleMesh;

	public GameObject m_PartialHoleMesh;

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

	public string m_DisplayName
	{
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		get
		{
			return null;
		}
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	public void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	public void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	public void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetFishingInProgress")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetFishingInProgress")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "IsPaused")]
	[Calls(Type = typeof(IceFishingHole), Member = "UpdateFrozenState")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 11)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "DeserializeAll")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(IceFishingHole), Member = "Serialize")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(IceFishingHole), Member = "FindIceFishingHoleByGuid")]
	[Calls(Type = typeof(IceFishingHole), Member = "FindIceFishingHoleByPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(IceFishingHole), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	public static void DeserializeAll(string text)
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessIceFishingHoleInteraction")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetBestFishingTackle")]
	[CallsDeduplicatedMethods(Count = 4)]
	public void OnClick()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetHoverText()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetNormalizedFrozen()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "ClearHole")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "OnBreakIceComplete")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "OnBreakIceComplete")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Deserialize")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "UpdateFrozenState")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Start")]
	public void SetNormalizedFrozen(float normalized)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	public void ClearHole()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "OnFish")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNextCatchTime")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetFishingInProgress")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	public void StartFishing(float seconds, float minutes)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IceFishingHole), Member = "SetFishingInProgress")]
	public void OnFishingComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "LineBreak")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "OnDisable")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "OnDestroy")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetFishingInProgress")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetFishingInProgress")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetFishingInProgress")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeExitFishing()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Update")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNextCatchTime")]
	[Calls(Type = typeof(IceFishingHole), Member = "CatchFish")]
	[Calls(Type = typeof(IceFishingHole), Member = "LineBreak")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "IsPaused")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeCatchFish()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	private bool RollForLineBreak()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[Calls(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void LineBreak()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[Calls(Type = typeof(IceFishingHole), Member = "RevealFishInInspectMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(SkillsManager), Member = "IncrementPointsAndNotify")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LootTable), Member = "GetRandomGearPrefab")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void CatchFish()
	{
	}

	[CallsUnknownMethods(Count = 32)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CatchFish")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	private void RevealFishInInspectMode(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Update")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetNormalizedFrozen")]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODHours")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void UpdateFrozenState()
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "OnFishingComplete")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeExitFishing")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeExitFishing")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CancelFishing")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "StartFishing")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "Update")]
	private void SetFishingInProgress(bool inProgress)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetFishCatchTimeScale")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillIceFishing")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "StartFishing")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[CallsUnknownMethods(Count = 9)]
	private void SetNextCatchTime()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "IsPaused")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateFishingTime(float realtimeSeconds)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 7)]
	private static IceFishingHole FindIceFishingHoleByPosition(IceFishingHoleSaveData proxy)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "DeserializeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	private static IceFishingHole FindIceFishingHoleByGuid(string guid)
	{
		return null;
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public IceFishingHole()
	{
	}
}
