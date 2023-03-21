using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using TLD.Serialization;
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
	[CallerCount(Count = 6)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(BearHuntRedux), Member = "End")]
	[CallsUnknownMethods(Count = 1)]
	public static void UpdateMission()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "Deserialize")]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public static string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BearHuntRedux), Member = "Reset")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public static void SetHuntBear(BaseAi bearAi)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bear_hunt_redux")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CalledBy(Type = typeof(Action_BearHuntRedux), Member = "OnExecute")]
	public static void Begin()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "MaybeLoseMission")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bear_hunt_redux")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "UpdateMission")]
	public static void End()
	{
	}

	[CallerCount(Count = 0)]
	public static bool IsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 27)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsHuntedBear(BaseAi bai)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CallsUnknownMethods(Count = 2)]
	public static void OnPlayerDetected(BaseAi bai)
	{
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearSpawn")]
	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearSpawn")]
	public static bool IsBearSpawned()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static BaseAi GetSpawnedBear()
	{
		return null;
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearDespawn")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[Calls(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void OnBearSpearOutcome(BearEncounter.BearSpawnEncounterResult result, BearSpearStruggleOutcome struggleOutcome)
	{
	}

	[CallerCount(Count = 0)]
	public static void SaveCheckpoint()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "FindHuntBear")]
	public static void RetrieveSpawnedBear()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Action_ActivateBearEncounter), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bearhuntredux_encounter_activate")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[Calls(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(BearEncounter), Member = "GetCurrentActiveBearEncounter")]
	[Calls(Type = typeof(BearEncounter), Member = "GetCurrentActiveBearEncounterCountInScene")]
	[Calls(Type = typeof(BearHuntRedux), Member = "FindBearEncounter")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BearEncounter), Member = "Activate")]
	public static bool ActivateEncounter(string missionObjectId, bool activate)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetBearEncounterInfo")]
	public static bool IsEncounterActivated(string missionObjectId)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_SetBearEncounterLast), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bearhuntredux_encounter_last")]
	[Calls(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(BearHuntRedux), Member = "FindBearEncounter")]
	[CallerCount(Count = 2)]
	public static bool SetLastEncounter(string missionObjectId, bool isLast)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Action_SetBearEncounterPostStruggleBehavior), Member = "OnExecute")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bearhuntredux_encounter_poststrugglemode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "FindBearEncounter")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool SetPostStruggleBehavior(string missionObjectId, BearEncounter.PostStruggleBehavior postStruggleBehavior)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BearHuntRedux), Member = "GetBearEncounterInfo")]
	[CallerCount(Count = 0)]
	public static bool IsLastEncounter(string missionObjectId)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetBearEncounterInfo")]
	public static bool HasWonLatestEncounter(string missionObjectId)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static void SetPlayerDiesAfterSpearMiss(bool playerShouldDie)
	{
	}

	[CallerCount(Count = 0)]
	public static bool GetPlayerDiesAfterSpearMiss()
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetDebugText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(BearHuntRedux), Member = "End")]
	[CallsUnknownMethods(Count = 1)]
	private static void MaybeLoseMission()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	private static void MaybeSaveCheckpoint()
	{
	}

	[CalledBy(Type = typeof(BearHuntRedux), Member = "RetrieveSpawnedBear")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	private static BaseAi FindHuntBear()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	private static void Win()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CallsUnknownMethods(Count = 1)]
	private static void OnBearSpearOutcomeInternal(BearEncounter.BearSpawnEncounterResult result, BearSpearStruggleOutcome struggleOutcome)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(TLD_IsBearEncounterLast), Member = "OnCheck")]
	[CalledBy(Type = typeof(TLD_IsLatestBearEncounterWon), Member = "OnCheck")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "GetOrCreateBearEncounterInfo")]
	[CalledBy(Type = typeof(TLD_IsBearEncounterActivated), Member = "OnCheck")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "IsLastEncounter")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "IsEncounterActivated")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "HasWonLatestEncounter")]
	private static BearEncounterInfo GetBearEncounterInfo(string missionObjectId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetBearEncounterInfo")]
	[CallsUnknownMethods(Count = 2)]
	private static BearEncounterInfo GetOrCreateBearEncounterInfo(string missionObjectId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "SetPostStruggleBehavior")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "SetLastEncounter")]
	[Calls(Type = typeof(BearEncounter), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetBearEncounterInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	private static void UpdateBearEncounterInfo(BearEncounter bearEncounter)
	{
	}

	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearSpearOutcomeInternal")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearSpearOutcome")]
	[Calls(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[Calls(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BearEncounter), Member = "EncounterWon")]
	[Calls(Type = typeof(BearEncounter), Member = "EncounterFailed")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BearEncounter), Member = "GetMissionObjectId")]
	private static void OnBearEncounterOutcome(BearEncounter.BearSpawnEncounterResult result, BearSpearStruggleOutcome struggleOutcome, BearEncounter bearEncounter, BearHuntAiRedux bearHuntReduxAi)
	{
	}

	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "SetPostStruggleBehavior")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "SetLastEncounter")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	private static BearEncounter FindBearEncounter(string missionObjectId)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BearHuntRedux()
	{
	}
}
