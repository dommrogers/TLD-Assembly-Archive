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
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	public static void Remove(Phone phone)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CalledBy(Type = typeof(PhoneManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public static string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PhoneManager), Member = "Reset")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	public static void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsConversationComplete(DTContainer dtContainer, int index)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsSequenceComplete(DTContainer dtContainer)
	{
		return false;
	}

	[CalledBy(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 4)]
	private static DialogueSequenceProgressionInfo GetDialogueSequenceProgressionInfo(string uniqueId)
	{
		return null;
	}

	[CalledBy(Type = typeof(Phone), Member = "Update")]
	[CalledBy(Type = typeof(Phone), Member = "GetRingCycleCount")]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	[CalledBy(Type = typeof(PhoneManager), Member = "HasPhoneStartedRinging")]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetRingCycleCount")]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetDebugText")]
	[CalledBy(Type = typeof(TLD_CheckPhoneRingCycle), Member = "OnCheck")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 4)]
	private static PhoneSaveDataInfo GetPhoneSaveInfo(string missionId)
	{
		return null;
	}

	[CalledBy(Type = typeof(Phone), Member = "StopRinging")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateWaitingNextCall")]
	[CalledBy(Type = typeof(Phone), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(Phone), Member = "StartPhoneRinging")]
	[CalledBy(Type = typeof(Phone), Member = "StopPhoneRinging")]
	[CalledBy(Type = typeof(PhoneManager), Member = "StartRinging")]
	[CalledBy(Type = typeof(PhoneManager), Member = "StopRinging")]
	[CalledBy(Type = typeof(PhoneManager), Member = "IncrementRingCycleCount")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(PhoneManager), Member = "GetPhoneSaveInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static PhoneSaveDataInfo GetOrCreatePhoneSaveDataInfo(string missionId)
	{
		return null;
	}

	[CalledBy(Type = typeof(Phone), Member = "MaybeAssignDTController")]
	[CalledBy(Type = typeof(PhoneManager), Member = "IsConversationComplete")]
	[CalledBy(Type = typeof(PhoneManager), Member = "IsSequenceComplete")]
	[CalledBy(Type = typeof(PhoneManager), Member = "GetCurrentDialogueTreeIndex")]
	[CalledBy(Type = typeof(PhoneManager), Member = "SelectNextDialogueTree")]
	[CalledBy(Type = typeof(PhoneManager), Member = "ResetDialogueTreeIndex")]
	[CalledBy(Type = typeof(TLD_IsConversationComplete), Member = "OnCheck")]
	[CalledBy(Type = typeof(TLD_IsSequenceComplete), Member = "OnCheck")]
	[CalledBy(Type = typeof(Action_ResetPhoneDT), Member = "OnExecute")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(PhoneManager), Member = "GetDialogueSequenceProgressionInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static DialogueSequenceProgressionInfo GetOrCreateDialogueSequenceProgressionInfo(string uniqueId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[CallsUnknownMethods(Count = 1)]
	public static int GetCurrentDialogueTreeIndex(Phone phone)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Phone), Member = "OnPhoneHangup")]
	[CalledBy(Type = typeof(Phone), Member = "OnPhoneHangupComplete")]
	[CalledBy(Type = typeof(Action_SelectNextPhoneDT), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[CallsUnknownMethods(Count = 1)]
	public static void SelectNextDialogueTree(DTContainer dtContainer)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreateDialogueSequenceProgressionInfo")]
	[CallsUnknownMethods(Count = 1)]
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
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PhoneManager), Member = "GetOrCreatePhoneSaveDataInfo")]
	public static void IncrementRingCycleCount(string missionId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PhoneManager), Member = "GetPhoneSaveInfo")]
	public static int GetRingCycleCount(string missionId)
	{
		return 0;
	}

	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Phone), Member = "GetMissionObjectId")]
	[Calls(Type = typeof(Phone), Member = "GetDebugText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PhoneManager), Member = "GetDialogueSequenceProgressionInfo")]
	[Calls(Type = typeof(PhoneManager), Member = "GetPhoneSaveInfo")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 81)]
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
