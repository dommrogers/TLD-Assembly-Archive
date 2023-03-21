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
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[Calls(Type = typeof(Knowledge), Member = "Unlock")]
	[CallerCount(Count = 1)]
	public void UnlockWithNotification(string subTitle)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[Calls(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[CallsUnknownMethods(Count = 3)]
	public void UnlockSilent()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_knowledge_unlock")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "MaybeUnlockKnowledge")]
	[CalledBy(Type = typeof(Knowledge), Member = "UnlockWithNotification")]
	[CalledBy(Type = typeof(Action_UnlockKnowledge), Member = "OnExecute")]
	[Calls(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GearMessage), Member = "AddJournalQueueMessage")]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void Unlock(string nameLocID, string descLocID, KnowledgeCateogry category, string subTitle, bool showNotificationFlag = true)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[Calls(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	[CallsUnknownMethods(Count = 1)]
	public static void UnlockSilent(string nameLocID, string descLocID, KnowledgeCateogry category)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_knowledge_unlock")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static KnowledgeCateogry GetKnowledgeCategoryFromName(string name)
	{
		return default(KnowledgeCateogry);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_knowledge_unlock")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "MaybeUnlockKnowledge")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public static string GetLocalizedKnowledgeCategoryName(KnowledgeCateogry category)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public Knowledge()
	{
	}
}
