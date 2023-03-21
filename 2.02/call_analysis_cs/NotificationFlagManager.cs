using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NotificationFlagManager : MonoBehaviour
{
	public List<Panel_Base> m_Panels;

	private static Dictionary<string, NotificationFlagInfo> m_NotificationData;

	private NotificationSaveData m_NotificationSaveData;

	public event Action<NotificationFlagInfo> m_NotificationAdded
	{
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		add
		{
		}
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CompilerGenerated]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		remove
		{
		}
	}

	public event Action<NotificationFlagInfo> m_SubcategoryNotificationRemoved
	{
		[CompilerGenerated]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		remove
		{
		}
	}

	public event Action<NotificationFlagInfo> m_MaincategoryNotificationRemoved
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NotificationFlagManager), Member = "AddPanels")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddObjective")]
	[CalledBy(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "ShowNotificationFlagsOnMiniTopNavNar")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddMission")]
	public void AddNotification(PanelType panelType, MainCategory mainCategory, SubCategory subCategory, string nameId, GearItem gearItem = null)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NotificationFlagManager), Member = "ShowNotificationFlagsOnMiniTopNavNar")]
	[CallsUnknownMethods(Count = 2)]
	public void OnNewNotificationAdded(NotificationFlagInfo nfi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(NotificationFlagManager), Member = "ShowNotificationFlagsOnMiniTopNavNar")]
	[CallsUnknownMethods(Count = 8)]
	public void HandleOnNotificationSelected(string key, NotificationFlagInfo nfi)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NotificationFlagManager), Member = "AddNotification")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 4)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "HandleOnNotificationSelected")]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "AddNotification")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "OnNewNotificationAdded")]
	[Calls(Type = typeof(NotificationFlag), Member = "GetNotificationFlags")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	private void ShowNotificationFlagsOnMiniTopNavNar(PanelType panelType, bool enable)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	private void AddPanels()
	{
	}

	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "Start")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_NotificationAdded")]
	[CallsUnknownMethods(Count = 105)]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_NotificationAdded")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_NotificationAdded")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_NotificationAdded")]
	private void SubscribeToEvents()
	{
	}

	[CallsUnknownMethods(Count = 105)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_NotificationAdded")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_NotificationAdded")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_NotificationAdded")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_NotificationAdded")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	private void UnsubscribeEvents()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(NotificationSaveData), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public NotificationFlagManager()
	{
	}
}
