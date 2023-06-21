using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Missions;
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
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CompilerGenerated]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public event Action<NotificationFlagInfo> m_SubcategoryNotificationRemoved
	{
		[CompilerGenerated]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CompilerGenerated]
		[CalledBy(Type = typeof(NotificationFlagManager), Member = "UnsubscribeEvents")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
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
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "AddPanels")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "SubscribeToEvents")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(ActiveMissionManager), Member = "AddMission")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "AddObjective")]
	[CallerCount(Count = 2)]
	public void AddNotification(PanelType panelType, MainCategory mainCategory, SubCategory subCategory, string nameId, GearItem gearItem = null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotificationFlagManager), Member = "ShowNotificationFlagsOnMiniTopNavNar")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnNewNotificationAdded(NotificationFlagInfo nfi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "ShowNotificationFlagsOnMiniTopNavNar")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void HandleOnNotificationSelected(string key, NotificationFlagInfo nfi)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(NotificationFlagManager), Member = "OnNewNotificationAdded")]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "HandleOnNotificationSelected")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(NotificationFlag), Member = "GetNotificationFlags")]
	[Calls(Type = typeof(NotificationFlag), Member = "ShowNotificationIcon")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void ShowNotificationFlagsOnMiniTopNavNar(PanelType panelType, bool enable)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "Start")]
	[CallerCount(Count = 1)]
	private void AddPanels()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void AddPanelIfNotNull(Panel_Base panel)
	{
	}

	[CalledBy(Type = typeof(NotificationFlagManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_NotificationAdded")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "add_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 16)]
	private void SubscribeToEvents()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_NotificationAdded")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "remove_m_SubcategoryNotificationRemoved")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 16)]
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
