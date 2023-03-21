using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class NotificationFlag : MonoBehaviour
{
	public GameObject m_MiniTopNavBarNotifications;

	private static readonly int IsDestroyed;

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(NotificationFlagManager), Member = "ShowNotificationFlagsOnMiniTopNavNar")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public GameObject GetNotificationFlags(PanelType panelType)
	{
		return null;
	}

	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 6)]
	public void ShowNotificationIcon(GameObject notificationPrefab, bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public NotificationFlag()
	{
	}
}
