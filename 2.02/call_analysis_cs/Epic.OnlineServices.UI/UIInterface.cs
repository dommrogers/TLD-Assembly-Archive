using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UI;

public sealed class UIInterface : Handle
{
	public const int AcknowledgecorrelationidApiLatest = 1;

	public const int AcknowledgeeventidApiLatest = 1;

	public const int AddnotifydisplaysettingsupdatedApiLatest = 1;

	public const int EventidInvalid = 0;

	public const int GetfriendsvisibleApiLatest = 1;

	public const int GettogglefriendskeyApiLatest = 1;

	public const int HidefriendsApiLatest = 1;

	public const int SetdisplaypreferenceApiLatest = 1;

	public const int SettogglefriendskeyApiLatest = 1;

	public const int ShowfriendsApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public UIInterface()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UIInterface(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(AcknowledgeEventIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result AcknowledgeEventId(AcknowledgeEventIdOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(AddNotifyDisplaySettingsUpdatedOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryAssignNotificationIdToCallback")]
	[CallsUnknownMethods(Count = 9)]
	public ulong AddNotifyDisplaySettingsUpdated(AddNotifyDisplaySettingsUpdatedOptions options, object clientData, OnDisplaySettingsUpdatedCallback notificationFn)
	{
		return default(ulong);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetFriendsVisibleOptionsInternal), Member = "Set")]
	public bool GetFriendsVisible(GetFriendsVisibleOptions options)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public NotificationLocation GetNotificationLocationPreference()
	{
		return default(NotificationLocation);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GetToggleFriendsKeyOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public KeyCombination GetToggleFriendsKey(GetToggleFriendsKeyOptions options)
	{
		return default(KeyCombination);
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(HideFriendsOptionsInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public void HideFriends(HideFriendsOptions options, object clientData, OnHideFriendsCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsValidKeyCombination(KeyCombination keyCombination)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRemoveCallbackByNotificationId")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveNotifyDisplaySettingsUpdated(ulong id)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SetDisplayPreferenceOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	public Result SetDisplayPreference(SetDisplayPreferenceOptions options)
	{
		return default(Result);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SetToggleFriendsKeyOptionsInternal), Member = "Set")]
	public Result SetToggleFriendsKey(SetToggleFriendsKeyOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(ShowFriendsOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	public void ShowFriends(ShowFriendsOptions options, object clientData, OnShowFriendsCallback completionDelegate)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	internal static void OnDisplaySettingsUpdatedCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnHideFriendsCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnShowFriendsCallbackInternalImplementation(IntPtr data)
	{
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_UI_AcknowledgeEventId(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern ulong EOS_UI_AddNotifyDisplaySettingsUpdated(IntPtr handle, IntPtr options, IntPtr clientData, OnDisplaySettingsUpdatedCallbackInternal notificationFn);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern int EOS_UI_GetFriendsVisible(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern NotificationLocation EOS_UI_GetNotificationLocationPreference(IntPtr handle);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern KeyCombination EOS_UI_GetToggleFriendsKey(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_UI_HideFriends(IntPtr handle, IntPtr options, IntPtr clientData, OnHideFriendsCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern int EOS_UI_IsValidKeyCombination(IntPtr handle, KeyCombination keyCombination);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_UI_RemoveNotifyDisplaySettingsUpdated(IntPtr handle, ulong id);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_UI_SetDisplayPreference(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_UI_SetToggleFriendsKey(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern void EOS_UI_ShowFriends(IntPtr handle, IntPtr options, IntPtr clientData, OnShowFriendsCallbackInternal completionDelegate);
}
