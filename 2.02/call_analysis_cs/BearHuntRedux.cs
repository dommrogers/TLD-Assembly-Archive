using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using UnityEngine;

public class BearHuntRedux : MonoBehaviour
{
	private static bool s_DeprecatedActive;

	private static bool s_SaveCheckPoint;

	private static BaseAi s_BearBaseAi;

	private static BearHuntReduxSaveData s_BearHuntReduxSavedData;

	private static bool s_Completed;

	private static bool s_PlayerDiesAfterSpearMiss;

	public static List<BearEncounterInfo> s_BearEncounterInfoList;

	public static bool s_DebugBearHuntRedux;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Start()
	{
	}

	[Calls(Type = typeof(BearHuntRedux), Member = "End")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void UpdateMission()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "Deserialize")]
	public static void Reset()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	public static void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetHuntBear(BaseAi bearAi)
	{
	}

	[CalledBy(Type = typeof(Action_BearHuntRedux), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bear_hunt_redux")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public static void Begin()
	{
	}

	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "MaybeLoseMission")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "Win")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bear_hunt_redux")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "UpdateMission")]
	public static void End()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsActive()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 26)]
	public static bool IsHuntedBear(BaseAi bai)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void OnPlayerDetected(BaseAi bai)
	{
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearSpawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearSpawn")]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	public static bool IsBearSpawned()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static BaseAi GetSpawnedBear()
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearDespawn")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[Calls(Type = typeof(BearHuntRedux), Member = "OnBearSpearOutcomeInternal")]
	public static void OnBearSpearOutcome(BearEncounter.BearSpawnEncounterResult result, BearSpearStruggleOutcome struggleOutcome)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void SaveCheckpoint()
	{
	}

	[Calls(Type = typeof(BearHuntRedux), Member = "FindHuntBear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void RetrieveSpawnedBear()
	{
	}

	[Calls(Type = typeof(BearEncounter), Member = "GetCurrentActiveBearEncounterCountInScene")]
	[Calls(Type = typeof(BearHuntRedux), Member = "FindBearEncounter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Action_ActivateBearEncounter), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bearhuntredux_encounter_activate")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[Calls(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[Calls(Type = typeof(BearEncounter), Member = "Activate")]
	[Calls(Type = typeof(BearEncounter), Member = "GetCurrentActiveBearEncounter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static bool ActivateEncounter(string missionObjectId, bool activate)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetBearEncounterInfo")]
	[CallerCount(Count = 0)]
	public static bool IsEncounterActivated(string missionObjectId)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_SetBearEncounterLast), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bearhuntredux_encounter_last")]
	[Calls(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BearHuntRedux), Member = "FindBearEncounter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsUnknownMethods(Count = 6)]
	public static bool SetLastEncounter(string missionObjectId, bool isLast)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bearhuntredux_encounter_poststrugglemode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Action_SetBearEncounterPostStruggleBehavior), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(BearHuntRedux), Member = "FindBearEncounter")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public static bool SetPostStruggleBehavior(string missionObjectId, BearEncounter.PostStruggleBehavior postStruggleBehavior)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BearHuntRedux), Member = "GetBearEncounterInfo")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsLastEncounter(string missionObjectId)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetBearEncounterInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool HasWonLatestEncounter(string missionObjectId)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void SetPlayerDiesAfterSpearMiss(bool playerShouldDie)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool GetPlayerDiesAfterSpearMiss()
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public static string GetDebugText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BearHuntRedux), Member = "End")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static void MaybeLoseMission()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	private static void MaybeSaveCheckpoint()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "RetrieveSpawnedBear")]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private static BaseAi FindHuntBear()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BearHuntRedux), Member = "End")]
	[CallerCount(Count = 0)]
	private static void Win()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearSpearOutcome")]
	[Calls(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void OnBearSpearOutcomeInternal(BearEncounter.BearSpawnEncounterResult result, BearSpearStruggleOutcome struggleOutcome)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "IsEncounterActivated")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "IsLastEncounter")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "HasWonLatestEncounter")]
	[CalledBy(Type = typeof(TLD_IsLatestBearEncounterWon), Member = "OnCheck")]
	[CalledBy(Type = typeof(TLD_IsBearEncounterActivated), Member = "OnCheck")]
	[CalledBy(Type = typeof(TLD_IsBearEncounterLast), Member = "OnCheck")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "GetOrCreateBearEncounterInfo")]
	[CallerCount(Count = 7)]
	private static BearEncounterInfo GetBearEncounterInfo(string missionObjectId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetBearEncounterInfo")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private static BearEncounterInfo GetOrCreateBearEncounterInfo(string missionObjectId)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetOrCreateBearEncounterInfo")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "SetLastEncounter")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "SetPostStruggleBehavior")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[Calls(Type = typeof(BearEncounter), Member = "GetMissionObjectId")]
	private static void UpdateBearEncounterInfo(BearEncounter bearEncounter)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearSpearOutcomeInternal")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[Calls(Type = typeof(BearEncounter), Member = "EncounterFailed")]
	[Calls(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[Calls(Type = typeof(BearEncounter), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(BearHuntRedux), Member = "End")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BearEncounter), Member = "EncounterWon")]
	private static void OnBearEncounterOutcome(BearEncounter.BearSpawnEncounterResult result, BearSpearStruggleOutcome struggleOutcome, BearEncounter bearEncounter, BearHuntAiRedux bearHuntReduxAi)
	{
	}

	[CalledBy(Type = typeof(BearHuntRedux), Member = "SetPostStruggleBehavior")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "SetLastEncounter")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 3)]
	private static BearEncounter FindBearEncounter(string missionObjectId)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BearHuntRedux()
	{
	}
}
