using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class Knowledge : MonoBehaviour
{
	public KnowledgeCateogry m_KnowledgeCategory;

	public LocalizedString m_LocalizedName;

	public LocalizedString m_LocalizedDescription;

	public string m_Description
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public string GetLocID()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Knowledge), Member = "Unlock")]
	[CallsUnknownMethods(Count = 1)]
	public void UnlockWithNotification(string subTitle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[Calls(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[CallsUnknownMethods(Count = 1)]
	public void UnlockSilent()
	{
	}

	[CalledBy(Type = typeof(Action_UnlockKnowledge), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_knowledge_unlock")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "MaybeUnlockKnowledge")]
	[Calls(Type = typeof(GearMessage), Member = "AddJournalQueueMessage")]
	[CalledBy(Type = typeof(Knowledge), Member = "UnlockWithNotification")]
	[Calls(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	public static void Unlock(string nameLocID, string descLocID, KnowledgeCateogry category, string subTitle, bool showNotificationFlag = true)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	public static void UnlockSilent(string nameLocID, string descLocID, KnowledgeCateogry category)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_knowledge_unlock")]
	[CallsUnknownMethods(Count = 1)]
	public static KnowledgeCateogry GetKnowledgeCategoryFromName(string name)
	{
		return default(KnowledgeCateogry);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_knowledge_unlock")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "MaybeUnlockKnowledge")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 4)]
	public static string GetLocalizedKnowledgeCategoryName(KnowledgeCateogry category)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Knowledge()
	{
	}
}
