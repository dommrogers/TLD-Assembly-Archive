using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class NotificationFlag : MonoBehaviour
{
	public GameObject m_MiniTopNavBarNotifications;

	private static readonly int IsDestroyed;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "ShowNotificationFlagsOnMiniTopNavNar")]
	[CallsUnknownMethods(Count = 5)]
	public GameObject GetNotificationFlags(PanelType panelType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "ShowNotificationFlagsOnMiniTopNavNar")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MaybeShowNewMissionEntryNotificationFlagIcon")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MaybeShowNewMissionEntryNotificationFlagIcon")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "ShowPanelMissionSubCategoryNotificationIcon")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "ShowPanelMissionSubCategoryNotificationIcon")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "HandleOnSubcategoryNotificationRemoved")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForKnowledgeSubCategories")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForKnowledgeSubCategories")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForNewKnowledgeEntry")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForNewKnowledgeEntry")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "HandleOnSubcategoryNotificationRemoved")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForNewCollectionEntry")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ShowPanelLogMainCategoryNotificationIcon")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "MaybeShowNotificationFlagForNewInventoryEntry")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "MaybeShowNotificationFlagForNewInventoryEntry")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "MaybeShowNotificationFlagForNewBlueprintEntry")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "MaybeShowNotificationFlagForNewBlueprintEntry")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ShowPanelCraftingSubCategoryNotificationIcon")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 19)]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForNewCollectionEntry")]
	public void ShowNotificationIcon(GameObject notificationPrefab, bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public NotificationFlag()
	{
	}
}
