using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class KnowledgeManager
{
	public static Dictionary<string, string> m_TrustDict;

	public static Dictionary<string, KnowledgeCateogry> m_KnowledgeDict;

	public static Dictionary<string, string> m_NameRefDict;

	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	[CalledBy(Type = typeof(Knowledge), Member = "UnlockSilent")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Knowledge), Member = "UnlockSilent")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "InitializeInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Knowledge), Member = "Unlock")]
	public static bool KnowledgeIsUnlocked(string locID)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NotificationFlagManager), Member = "AddNotification")]
	[CalledBy(Type = typeof(Knowledge), Member = "UnlockSilent")]
	[CalledBy(Type = typeof(Knowledge), Member = "Unlock")]
	[CalledBy(Type = typeof(Knowledge), Member = "UnlockSilent")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	public static void AddKnowledge(KnowledgeCateogry category, string nameLocID, string descLocID, bool showNotificationFlag = true)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void LinkTrustToKnowledge(string trustID, string locID)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void RemoveKnowledge(string locID)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	public static List<string> GetListUnlockedKnowledgeOfType(KnowledgeCateogry knowledgeType)
	{
		return null;
	}

	[CalledBy(Type = typeof(KnowledgeManager), Member = "DumpKnowledgeToDebugLog")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GenerateSubscreenData")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetNameIDFromDescID(string descLocID)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static string GetTrustIDFromDescID(string descLocID)
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_knowledge_dump")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(KnowledgeManager), Member = "GetNameIDFromDescID")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 37)]
	public static void DumpKnowledgeToDebugLog()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public static string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallsUnknownMethods(Count = 1)]
	public static void Deserialize(string text)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public KnowledgeManager()
	{
	}
}
