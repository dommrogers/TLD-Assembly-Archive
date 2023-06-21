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

	[CalledBy(Type = typeof(BearHuntRedux), Member = "Deserialize")]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 3)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "Reset")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(BearHuntRedux), Member = "UpdateMission")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "MaybeLoseMission")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bear_hunt_redux")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallerCount(Count = 4)]
	public static void End()
	{
	}

	[CallerCount(Count = 0)]
	public static bool IsActive()
	{
		return false;
	}

	[CallerCount(Count = 27)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsHuntedBear(BaseAi bai)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void OnPlayerDetected(BaseAi bai)
	{
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearSpawn")]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CallerCount(Count = 4)]
	public static bool IsBearSpawned()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static BaseAi GetSpawnedBear()
	{
		return null;
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearDespawn")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bearhuntredux_encounter_activate")]
	[CalledBy(Type = typeof(Action_ActivateBearEncounter), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BearHuntRedux), Member = "FindBearEncounter")]
	[Calls(Type = typeof(BearEncounter), Member = "GetCurrentActiveBearEncounterCountInScene")]
	[Calls(Type = typeof(BearEncounter), Member = "GetCurrentActiveBearEncounter")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(BearEncounter), Member = "Activate")]
	[Calls(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[CallsUnknownMethods(Count = 9)]
	public static bool ActivateEncounter(string missionObjectId, bool activate)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetBearEncounterInfo")]
	public static bool IsEncounterActivated(string missionObjectId)
	{
		return false;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bearhuntredux_encounter_last")]
	[CalledBy(Type = typeof(Action_SetBearEncounterLast), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BearHuntRedux), Member = "FindBearEncounter")]
	[Calls(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsUnknownMethods(Count = 5)]
	public static bool SetLastEncounter(string missionObjectId, bool isLast)
	{
		return false;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_bearhuntredux_encounter_poststrugglemode")]
	[CalledBy(Type = typeof(Action_SetBearEncounterPostStruggleBehavior), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BearHuntRedux), Member = "FindBearEncounter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsUnknownMethods(Count = 5)]
	public static bool SetPostStruggleBehavior(string missionObjectId, BearEncounter.PostStruggleBehavior postStruggleBehavior)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetBearEncounterInfo")]
	public static bool IsLastEncounter(string missionObjectId)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetBearEncounterInfo")]
	public static bool HasWonLatestEncounter(string missionObjectId)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static void SetPlayerDiesAfterSpearMiss(bool playerShouldDie)
	{
	}

	[CallerCount(Count = 0)]
	public static bool GetPlayerDiesAfterSpearMiss()
	{
		return false;
	}

	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "RetrieveSpawnedBear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private static BaseAi FindHuntBear()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void Win()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CallsUnknownMethods(Count = 1)]
	private static void OnBearSpearOutcomeInternal(BearEncounter.BearSpawnEncounterResult result, BearSpearStruggleOutcome struggleOutcome)
	{
	}

	[CalledBy(Type = typeof(BearHuntRedux), Member = "IsEncounterActivated")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "IsLastEncounter")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "HasWonLatestEncounter")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "GetOrCreateBearEncounterInfo")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[CalledBy(Type = typeof(TLD_IsLatestBearEncounterWon), Member = "OnCheck")]
	[CalledBy(Type = typeof(TLD_IsBearEncounterActivated), Member = "OnCheck")]
	[CalledBy(Type = typeof(TLD_IsBearEncounterLast), Member = "OnCheck")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	private static BearEncounterInfo GetBearEncounterInfo(string missionObjectId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetBearEncounterInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static BearEncounterInfo GetOrCreateBearEncounterInfo(string missionObjectId)
	{
		return null;
	}

	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "SetLastEncounter")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "SetPostStruggleBehavior")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BearEncounter), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(BearHuntRedux), Member = "GetBearEncounterInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void UpdateBearEncounterInfo(BearEncounter bearEncounter)
	{
	}

	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearSpearOutcome")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearSpearOutcomeInternal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BearEncounter), Member = "EncounterFailed")]
	[Calls(Type = typeof(BearEncounter), Member = "EncounterWon")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BearEncounter), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[Calls(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private static void OnBearEncounterOutcome(BearEncounter.BearSpawnEncounterResult result, BearSpearStruggleOutcome struggleOutcome, BearEncounter bearEncounter, BearHuntAiRedux bearHuntReduxAi)
	{
	}

	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "SetLastEncounter")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "SetPostStruggleBehavior")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
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
