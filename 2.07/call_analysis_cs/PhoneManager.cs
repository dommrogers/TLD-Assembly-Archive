using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using TLD.Serialization;
using UnityEngine;

public class PhoneManager
{
	public static bool s_Debug;

	private static PhoneManagerSaveData s_PhoneManagerSaveData;

	private static List<Phone> s_Phones;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void Add(Phone phone)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Remove(Phone phone)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CalledBy(Type = typeof(PhoneManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	public static string Serialize()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PhoneManager), Member = "Reset")]
	[CallerCount(Count = 0)]
	public static void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public static bool IsConversationComplete(DTContainer dtContainer, int index)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsSequenceComplete(DTContainer dtContainer)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[CallsUnknownMethods(Count = 4)]
	private static DialogueSequenceProgressionInfo GetDialogueSequenceProgressionInfo(string uniqueId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(TLD_CheckPhoneRingCycle), Member = "OnCheck")]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[CalledBy(Type = typeof(PhoneManager), Member = "HasPhoneStartedRinging")]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetRingCycleCount")]
	[CalledBy(Type = typeof(Phone), Member = "GetRingCycleCount")]
	[CalledBy(Type = typeof(Phone), Member = "Update")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	private static PhoneSaveDataInfo GetPhoneSaveInfo(string missionId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PhoneManager), Member = "IncrementRingCycleCount")]
	[CalledBy(Type = typeof(PhoneManager), Member = "StopRinging")]
	[CalledBy(Type = typeof(PhoneManager), Member = "StartRinging")]
	[CalledBy(Type = typeof(Phone), Member = "StopPhoneRinging")]
	[CalledBy(Type = typeof(Phone), Member = "StartPhoneRinging")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateWaitingNextCall")]
	[CalledBy(Type = typeof(Phone), Member = "StopRinging")]
	[Calls(Type = typeof(PhoneManager), Member = "GetPhoneSaveInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	private static PhoneSaveDataInfo GetOrCreatePhoneSaveDataInfo(string missionId)
	{
		return null;
	}

	[CalledBy(Type = typeof(TLD_IsConversationComplete), Member = "OnCheck")]
	[CalledBy(Type = typeof(TLD_IsSequenceComplete), Member = "OnCheck")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PhoneManager), Member = "ResetDialogueTreeIndex")]
	[CalledBy(Type = typeof(Action_SelectNextPhoneDT), Member = "OnExecute")]
	[CalledBy(Type = typeof(PhoneManager), Member = "SelectNextDialogueTree")]
	[CalledBy(Type = typeof(Action_ResetPhoneDT), Member = "OnExecute")]
	[CalledBy(Type = typeof(PhoneManager), Member = "IsSequenceComplete")]
	[CalledBy(Type = typeof(PhoneManager), Member = "IsConversationComplete")]
	[CalledBy(Type = typeof(Phone), Member = "MaybeAssignDTController")]
	[Calls(Type = typeof(PhoneManager), Member = "GetDialogueSequenceProgressionInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetCurrentDialogueTreeIndex")]
	[CallerCount(Count = 10)]
	private static DialogueSequenceProgressionInfo GetOrCreateDialogueSequenceProgressionInfo(string uniqueId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public static int GetCurrentDialogueTreeIndex(Phone phone)
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[CalledBy(Type = typeof(Phone), Member = "OnPhoneHangup")]
	[CalledBy(Type = typeof(Phone), Member = "OnPhoneHangupComplete")]
	[CallsUnknownMethods(Count = 1)]
	public static void SelectNextDialogueTree(DTContainer dtContainer)
	{
	}

	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void ResetDialogueTreeIndex(DTContainer dtContainer)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	public static void StartRinging(string missionId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	public static void StopRinging(string missionId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PhoneManager), Member = "GetPhoneSaveInfo")]
	public static bool HasPhoneStartedRinging(string missionId)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	public static void IncrementRingCycleCount(string missionId)
	{
	}

	[Calls(Type = typeof(PhoneManager), Member = "GetPhoneSaveInfo")]
	[CallerCount(Count = 0)]
	public static int GetRingCycleCount(string missionId)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[CallsUnknownMethods(Count = 139)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(PhoneManager), Member = "GetPhoneSaveInfo")]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(PhoneManager), Member = "GetDialogueSequenceProgressionInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Phone), Member = "GetDebugText")]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetDebugText()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PhoneManager()
	{
	}
}
