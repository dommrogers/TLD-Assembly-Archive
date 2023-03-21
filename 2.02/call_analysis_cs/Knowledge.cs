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
	[CallerCount(Count = 7)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void UnlockSilent()
	{
	}

	[CalledBy(Type = typeof(Knowledge), Member = "UnlockWithNotification")]
	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "MaybeUnlockKnowledge")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_knowledge_unlock")]
	[CalledBy(Type = typeof(Action_UnlockKnowledge), Member = "OnExecute")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[Calls(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[Calls(Type = typeof(GearMessage), Member = "AddJournalQueueMessage")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void Unlock(string nameLocID, string descLocID, KnowledgeCateogry category, string subTitle, bool showNotificationFlag = true)
	{
	}

	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(KnowledgeManager), Member = "KnowledgeIsUnlocked")]
	[Calls(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void UnlockSilent(string nameLocID, string descLocID, KnowledgeCateogry category)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_knowledge_unlock")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static KnowledgeCateogry GetKnowledgeCategoryFromName(string name)
	{
		return default(KnowledgeCateogry);
	}

	[CalledBy(Type = typeof(DisplayLocationLabel), Member = "MaybeUnlockKnowledge")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_knowledge_unlock")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static string GetLocalizedKnowledgeCategoryName(KnowledgeCateogry category)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Knowledge()
	{
	}
}
