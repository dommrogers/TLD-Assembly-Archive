using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class NotificationFlag : MonoBehaviour
{
	public GameObject m_MiniTopNavBarNotifications;

	private static readonly int IsDestroyed;

	[CalledBy(Type = typeof(NotificationFlagManager), Member = "ShowNotificationFlagsOnMiniTopNavNar")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public GameObject GetNotificationFlags(PanelType panelType)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "ShowPanelCraftingSubCategoryNotificationIcon")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "MaybeShowNotificationFlagForNewBlueprintEntry")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "MaybeShowNotificationFlagForNewInventoryEntry")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ShowPanelLogMainCategoryNotificationIcon")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForNewCollectionEntry")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForNewKnowledgeEntry")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeShowNotificationFlagForKnowledgeSubCategories")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "HandleOnSubcategoryNotificationRemoved")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "ShowPanelMissionSubCategoryNotificationIcon")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MaybeShowNewMissionEntryNotificationFlagIcon")]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "ShowNotificationFlagsOnMiniTopNavNar")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public void ShowNotificationIcon(GameObject notificationPrefab, bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public NotificationFlag()
	{
	}
}
