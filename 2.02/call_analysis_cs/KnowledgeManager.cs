using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class KnowledgeManager
{
	public static Dictionary<string, string> m_TrustDict;

	public static Dictionary<string, KnowledgeCateogry> m_KnowledgeDict;

	public static Dictionary<string, string> m_NameRefDict;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CallsUnknownMethods(Count = 7)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(Knowledge), Member = "UnlockSilent")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	[CalledBy(Type = typeof(Knowledge), Member = "UnlockSilent")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "GetHoverText")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Knowledge), Member = "Unlock")]
	public static bool KnowledgeIsUnlocked(string locID)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(NotificationFlagManager), Member = "AddNotification")]
	[CalledBy(Type = typeof(Knowledge), Member = "UnlockSilent")]
	[CalledBy(Type = typeof(Knowledge), Member = "Unlock")]
	[CalledBy(Type = typeof(Knowledge), Member = "UnlockSilent")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	public static void AddKnowledge(KnowledgeCateogry category, string nameLocID, string descLocID, bool showNotificationFlag = true)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void LinkTrustToKnowledge(string trustID, string locID)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public static void RemoveKnowledge(string locID)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshCachedKnowledgeUnlocks")]
	[CallsUnknownMethods(Count = 13)]
	public static List<string> GetListUnlockedKnowledgeOfType(KnowledgeCateogry knowledgeType)
	{
		return null;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "GetHoverText")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(KnowledgeManager), Member = "DumpKnowledgeToDebugLog")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "GenerateSubscreenData")]
	public static string GetNameIDFromDescID(string descLocID)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 4)]
	public static string GetTrustIDFromDescID(string descLocID)
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_knowledge_dump")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(KnowledgeManager), Member = "GetNameIDFromDescID")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	public static void DumpKnowledgeToDebugLog()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public static string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	public static void Deserialize(string text)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public KnowledgeManager()
	{
	}
}
