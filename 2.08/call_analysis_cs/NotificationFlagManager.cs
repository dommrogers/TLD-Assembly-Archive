using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class NotificationFlagManager : MonoBehaviour
{
	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	private PanelReference<Panel_Clothing> m_ClothingPanel;

	private PanelReference<Panel_Crafting> m_CraftingPanel;

	private PanelReference<Panel_FirstAid> m_FirstAidPanel;

	private PanelReference<Panel_Inventory> m_InventoryPanel;

	private PanelReference<Panel_Log> m_LogPanel;

	private PanelReference<Panel_Map> m_MapPanel;

	private PanelReference<Panel_MissionsStory> m_MissionsStoryPanel;

	public List<Panel_Base> m_Panels;

	private static Dictionary<string, NotificationFlagInfo> m_NotificationData;

	private NotificationSaveData m_NotificationSaveData;

	public event Action<NotificationFlagInfo> m_NotificationAdded
	{
		[CompilerGenerated]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		[CompilerGenerated]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		remove
		{
		}
	}

	public event Action<NotificationFlagInfo> m_SubcategoryNotificationRemoved
	{
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
		add
		{
		}
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
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
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NotificationFlagManager), Member = "AddPanels")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddObjective")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "ShowNotificationFlagsOnMiniTopNavNar")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddMission")]
	public void AddNotification(PanelType panelType, MainCategory mainCategory, SubCategory subCategory, string nameId, GearItem gearItem = null)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NotificationFlagManager), Member = "ShowNotificationFlagsOnMiniTopNavNar")]
	[CallsUnknownMethods(Count = 1)]
	public void OnNewNotificationAdded(NotificationFlagInfo nfi)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NotificationFlagManager), Member = "ShowNotificationFlagsOnMiniTopNavNar")]
	public void HandleOnNotificationSelected(string key, NotificationFlagInfo nfi)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NotificationFlagManager), Member = "AddNotification")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 4)]
	public void Deserialize(string text)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NotificationFlag), Member = "GetNotificationFlags")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "AddNotification")]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "OnNewNotificationAdded")]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "HandleOnNotificationSelected")]
	[CallsUnknownMethods(Count = 5)]
	private void ShowNotificationFlagsOnMiniTopNavNar(PanelType panelType, bool enable)
	{
	}

	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "Start")]
	private void AddPanels()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void AddPanelIfNotNull(Panel_Base panel)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "Start")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_NotificationAdded")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_NotificationAdded")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_NotificationAdded")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_NotificationAdded")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	private void SubscribeToEvents()
	{
	}

	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_SubcategoryNotificationRemoved")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_NotificationAdded")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_NotificationAdded")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_NotificationAdded")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_NotificationAdded")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	private void UnsubscribeEvents()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public NotificationFlagManager()
	{
	}
}
