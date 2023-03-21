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
		[CompilerGenerated]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
		[CallerCount(Count = 4)]
		add
		{
		}
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		[CompilerGenerated]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public event Action<NotificationFlagInfo> m_MaincategoryNotificationRemoved
	{
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	[Calls(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NotificationFlagManager), Member = "AddPanels")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(KnowledgeManager), Member = "AddKnowledge")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddObjective")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NotificationFlagManager), Member = "ShowNotificationFlagsOnMiniTopNavNar")]
	[CallsUnknownMethods(Count = 6)]
	public void HandleOnNotificationSelected(string key, NotificationFlagInfo nfi)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "HandleOnNotificationSelected")]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "OnNewNotificationAdded")]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "AddNotification")]
	[Calls(Type = typeof(NotificationFlag), Member = "GetNotificationFlags")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	private void ShowNotificationFlagsOnMiniTopNavNar(PanelType panelType, bool enable)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
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
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_NotificationAdded")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_NotificationAdded")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_NotificationAdded")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_NotificationAdded")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 1)]
	private void SubscribeToEvents()
	{
	}

	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_NotificationAdded")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_SubcategoryNotificationRemoved")]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_NotificationAdded")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_NotificationAdded")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_NotificationAdded")]
	[CallerCount(Count = 0)]
	private void UnsubscribeEvents()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public NotificationFlagManager()
	{
	}
}
