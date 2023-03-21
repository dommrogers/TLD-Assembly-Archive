using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using UnityEngine;

public class PhoneManager
{
	public static bool s_Debug;

	private static PhoneManagerSaveData s_PhoneManagerSaveData;

	private static List<Phone> s_Phones;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void Add(Phone phone)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void Remove(Phone phone)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CalledBy(Type = typeof(PhoneManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 3)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public static string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PhoneManager), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsConversationComplete(DTContainer dtContainer, int index)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsSequenceComplete(DTContainer dtContainer)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private static DialogueSequenceProgressionInfo GetDialogueSequenceProgressionInfo(string uniqueId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetRingCycleCount")]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[CalledBy(Type = typeof(PhoneManager), Member = "HasPhoneStartedRinging")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Phone), Member = "Update")]
	private static PhoneSaveDataInfo GetPhoneSaveInfo(string missionId)
	{
		return null;
	}

	[CalledBy(Type = typeof(PhoneManager), Member = "StartRinging")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PhoneManager), Member = "IncrementRingCycleCount")]
	[CalledBy(Type = typeof(PhoneManager), Member = "StopRinging")]
	[CalledBy(Type = typeof(Phone), Member = "StartPhoneRinging")]
	[Calls(Type = typeof(PhoneManager), Member = "GetPhoneSaveInfo")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateWaitingNextCall")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	private static PhoneSaveDataInfo GetOrCreatePhoneSaveDataInfo(string missionId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Action_ResetPhoneDT), Member = "OnExecute")]
	[CalledBy(Type = typeof(TLD_IsSequenceComplete), Member = "OnCheck")]
	[CalledBy(Type = typeof(TLD_IsConversationComplete), Member = "OnCheck")]
	[CalledBy(Type = typeof(PhoneManager), Member = "SelectNextDialogueTree")]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetCurrentDialogueTreeIndex")]
	[CalledBy(Type = typeof(PhoneManager), Member = "ResetDialogueTreeIndex")]
	[CalledBy(Type = typeof(PhoneManager), Member = "IsConversationComplete")]
	[CalledBy(Type = typeof(Phone), Member = "MaybeAssignDTController")]
	[Calls(Type = typeof(PhoneManager), Member = "GetDialogueSequenceProgressionInfo")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(PhoneManager), Member = "IsSequenceComplete")]
	private static DialogueSequenceProgressionInfo GetOrCreateDialogueSequenceProgressionInfo(string uniqueId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[CallsUnknownMethods(Count = 2)]
	public static int GetCurrentDialogueTreeIndex(Phone phone)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Action_SelectNextPhoneDT), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Phone), Member = "OnPhoneHangupComplete")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public static void SelectNextDialogueTree(DTContainer dtContainer)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetDialogueTreeIndex(DTContainer dtContainer)
	{
	}

	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void StartRinging(string missionId)
	{
	}

	[CalledBy(Type = typeof(Phone), Member = "StopPhoneRinging")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[CalledBy(Type = typeof(Phone), Member = "StopRinging")]
	public static void StopRinging(string missionId)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PhoneManager), Member = "GetPhoneSaveInfo")]
	[CallerCount(Count = 0)]
	public static bool HasPhoneStartedRinging(string missionId)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	public static void IncrementRingCycleCount(string missionId)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PhoneManager), Member = "GetPhoneSaveInfo")]
	[CalledBy(Type = typeof(Phone), Member = "GetRingCycleCount")]
	[CalledBy(Type = typeof(TLD_CheckPhoneRingCycle), Member = "OnCheck")]
	public static int GetRingCycleCount(string missionId)
	{
		return default(int);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[CallsUnknownMethods(Count = 78)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(PhoneManager), Member = "GetPhoneSaveInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Phone), Member = "GetDebugText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PhoneManager), Member = "GetDialogueSequenceProgressionInfo")]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	public static string GetDebugText()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PhoneManager()
	{
	}
}
