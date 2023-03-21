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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(Knowledge), Member = "UnlockSilent")]
	[CalledBy(Type = typeof(Knowledge), Member = "Unlock")]
	[CalledBy(Type = typeof(Knowledge), Member = "UnlockSilent")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CallsUnknownMethods(Count = 1)]
	public static bool KnowledgeIsUnlocked(string locID)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Knowledge), Member = "UnlockSilent")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	[CalledBy(Type = typeof(Knowledge), Member = "Unlock")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "AddNotification")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Knowledge), Member = "UnlockSilent")]
	[CallerCount(Count = 5)]
	public static void AddKnowledge(KnowledgeCateogry category, string nameLocID, string descLocID, bool showNotificationFlag = true)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void LinkTrustToKnowledge(string trustID, string locID)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void RemoveKnowledge(string locID)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	public static List<string> GetListUnlockedKnowledgeOfType(KnowledgeCateogry knowledgeType)
	{
		return null;
	}

	[CalledBy(Type = typeof(KnowledgeManager), Member = "DumpKnowledgeToDebugLog")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GenerateSubscreenData")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "InitializeInteraction")]
	public static string GetNameIDFromDescID(string descLocID)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsUnknownMethods(Count = 8)]
	public static string GetTrustIDFromDescID(string descLocID)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 37)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_knowledge_dump")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(KnowledgeManager), Member = "GetNameIDFromDescID")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public static void DumpKnowledgeToDebugLog()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public KnowledgeManager()
	{
	}
}
