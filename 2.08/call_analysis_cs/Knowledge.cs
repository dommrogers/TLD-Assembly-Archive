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

	[CalledBy(Type = typeof(Knowledge), Member = "UnlockWithNotification")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "MaybeUnlockKnowledge")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_knowledge_unlock")]
	[CalledBy(Type = typeof(Action_UnlockKnowledge), Member = "OnExecute")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[Calls(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[Calls(Type = typeof(GearMessage), Member = "AddJournalQueueMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Unlock(string nameLocID, string descLocID, KnowledgeCateogry category, string subTitle, bool showNotificationFlag = true)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[Calls(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void UnlockSilent(string nameLocID, string descLocID, KnowledgeCateogry category)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_knowledge_unlock")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 1)]
	public static KnowledgeCateogry GetKnowledgeCategoryFromName(string name)
	{
		return default(KnowledgeCateogry);
	}

	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "MaybeUnlockKnowledge")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_knowledge_unlock")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
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
