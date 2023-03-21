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
	[CalledBy(Type = typeof(Action_BearHuntRedux), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public static void Begin()
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "UpdateMission")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "MaybeLoseMission")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bear_hunt_redux")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	public static void End()
	{
	}

	[CallerCount(Count = 0)]
	public static bool IsActive()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 27)]
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

	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearSpawn")]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearSpawn")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static bool IsBearSpawned()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static BaseAi GetSpawnedBear()
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearDespawn")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CallsUnknownMethods(Count = 1)]
	public static void OnBearSpearOutcome(BearEncounter.BearSpawnEncounterResult result, BearSpearStruggleOutcome struggleOutcome)
	{
	}

	[CallerCount(Count = 0)]
	public static void SaveCheckpoint()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void RetrieveSpawnedBear()
	{
	}

	[CalledBy(Type = typeof(Action_ActivateBearEncounter), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bearhuntredux_encounter_activate")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[Calls(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[Calls(Type = typeof(BearEncounter), Member = "Activate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BearEncounter), Member = "GetCurrentActiveBearEncounter")]
	[Calls(Type = typeof(BearEncounter), Member = "GetCurrentActiveBearEncounterCountInScene")]
	[Calls(Type = typeof(BearHuntRedux), Member = "FindBearEncounter")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Action_SetBearEncounterLast), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bearhuntredux_encounter_last")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BearHuntRedux), Member = "FindBearEncounter")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	public static bool SetLastEncounter(string missionObjectId, bool isLast)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Action_SetBearEncounterPostStruggleBehavior), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bearhuntredux_encounter_poststrugglemode")]
	[Calls(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "FindBearEncounter")]
	[CallerCount(Count = 2)]
	public static bool SetPostStruggleBehavior(string missionObjectId, BearEncounter.PostStruggleBehavior postStruggleBehavior)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetBearEncounterInfo")]
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

	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetDebugText()
	{
		return null;
	}

	[Calls(Type = typeof(BearHuntRedux), Member = "End")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private static void MaybeLoseMission()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	private static void MaybeSaveCheckpoint()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static void OnBearSpearOutcomeInternal(BearEncounter.BearSpawnEncounterResult result, BearSpearStruggleOutcome struggleOutcome)
	{
	}

	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "IsEncounterActivated")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "IsLastEncounter")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "HasWonLatestEncounter")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "GetOrCreateBearEncounterInfo")]
	[CalledBy(Type = typeof(TLD_IsLatestBearEncounterWon), Member = "OnCheck")]
	[CalledBy(Type = typeof(TLD_IsBearEncounterActivated), Member = "OnCheck")]
	[CalledBy(Type = typeof(TLD_IsBearEncounterLast), Member = "OnCheck")]
	[CallsUnknownMethods(Count = 3)]
	private static BearEncounterInfo GetBearEncounterInfo(string missionObjectId)
	{
		return null;
	}

	[CalledBy(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetBearEncounterInfo")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static BearEncounterInfo GetOrCreateBearEncounterInfo(string missionObjectId)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BearEncounter), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetOrCreateBearEncounterInfo")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "SetLastEncounter")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "SetPostStruggleBehavior")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CallsUnknownMethods(Count = 1)]
	private static void UpdateBearEncounterInfo(BearEncounter bearEncounter)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearSpearOutcomeInternal")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearSpearOutcome")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[Calls(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[Calls(Type = typeof(BearEncounter), Member = "EncounterFailed")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BearEncounter), Member = "EncounterWon")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BearEncounter), Member = "GetMissionObjectId")]
	private static void OnBearEncounterOutcome(BearEncounter.BearSpawnEncounterResult result, BearSpearStruggleOutcome struggleOutcome, BearEncounter bearEncounter, BearHuntAiRedux bearHuntReduxAi)
	{
	}

	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "SetPostStruggleBehavior")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "SetLastEncounter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static BearEncounter FindBearEncounter(string missionObjectId)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public BearHuntRedux()
	{
	}
}
