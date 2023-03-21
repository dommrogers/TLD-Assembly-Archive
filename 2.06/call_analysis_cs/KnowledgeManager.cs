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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void LinkTrustToKnowledge(string trustID, string locID)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void RemoveKnowledge(string locID)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[CallsUnknownMethods(Count = 16)]
	public static List<string> GetListUnlockedKnowledgeOfType(KnowledgeCateogry knowledgeType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(KnowledgeManager), Member = "DumpKnowledgeToDebugLog")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GenerateSubscreenData")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "InitializeInteraction")]
	public static string GetNameIDFromDescID(string descLocID)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 5)]
	public static string GetTrustIDFromDescID(string descLocID)
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_knowledge_dump")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(KnowledgeManager), Member = "GetNameIDFromDescID")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public static void DumpKnowledgeToDebugLog()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 6)]
	public static string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static void Deserialize(string text)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public KnowledgeManager()
	{
	}
}
