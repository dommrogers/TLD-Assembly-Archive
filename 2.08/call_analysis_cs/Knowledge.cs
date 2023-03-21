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
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public string GetLocID()
	{
		return null;
	}

	[Calls(Type = typeof(Knowledge), Member = "Unlock")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "MaybeUnlockKnowledge")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Knowledge), Member = "UnlockWithNotification")]
	[Calls(Type = typeof(GearMessage), Member = "AddJournalQueueMessage")]
	[Calls(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	public static void Unlock(string nameLocID, string descLocID, KnowledgeCateogry category, string subTitle, bool showNotificationFlag = true)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[Calls(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsUnknownMethods(Count = 1)]
	public static void UnlockSilent(string nameLocID, string descLocID, KnowledgeCateogry category)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_knowledge_unlock")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static KnowledgeCateogry GetKnowledgeCategoryFromName(string name)
	{
		return default(KnowledgeCateogry);
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_knowledge_unlock")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "MaybeUnlockKnowledge")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public static string GetLocalizedKnowledgeCategoryName(KnowledgeCateogry category)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Knowledge()
	{
	}
}
