using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Friends;

public sealed class FriendsInterface : Handle
{
	public const int AcceptinviteApiLatest = 1;

	public const int AddnotifyfriendsupdateApiLatest = 1;

	public const int GetfriendatindexApiLatest = 1;

	public const int GetfriendscountApiLatest = 1;

	public const int GetstatusApiLatest = 1;

	public const int QueryfriendsApiLatest = 1;

	public const int RejectinviteApiLatest = 1;

	public const int SendinviteApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public FriendsInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FriendsInterface(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(AcceptInviteOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	public void AcceptInvite(AcceptInviteOptions options, object clientData, OnAcceptInviteCallback completionDelegate)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "TryAssignNotificationIdToCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AddNotifyFriendsUpdateOptionsInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	public ulong AddNotifyFriendsUpdate(AddNotifyFriendsUpdateOptions options, object clientData, OnFriendsUpdateCallback friendsUpdateHandler)
	{
		return default(ulong);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GetFriendAtIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public EpicAccountId GetFriendAtIndex(GetFriendAtIndexOptions options)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetFriendsCountOptionsInternal), Member = "Set")]
	public int GetFriendsCount(GetFriendsCountOptions options)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GetStatusOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public FriendsStatus GetStatus(GetStatusOptions options)
	{
		return default(FriendsStatus);
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryFriendsOptionsInternal), Member = "Set")]
	public void QueryFriends(QueryFriendsOptions options, object clientData, OnQueryFriendsCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(RejectInviteOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	public void RejectInvite(RejectInviteOptions options, object clientData, OnRejectInviteCallback completionDelegate)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryRemoveCallbackByNotificationId")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveNotifyFriendsUpdate(ulong notificationId)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "Set")]
	public void SendInvite(SendInviteOptions options, object clientData, OnSendInviteCallback completionDelegate)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	internal static void OnAcceptInviteCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnFriendsUpdateCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryFriendsCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnRejectInviteCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	internal static void OnSendInviteCallbackInternalImplementation(IntPtr data)
	{
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Friends_AcceptInvite(IntPtr handle, IntPtr options, IntPtr clientData, OnAcceptInviteCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern ulong EOS_Friends_AddNotifyFriendsUpdate(IntPtr handle, IntPtr options, IntPtr clientData, OnFriendsUpdateCallbackInternal friendsUpdateHandler);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern IntPtr EOS_Friends_GetFriendAtIndex(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern int EOS_Friends_GetFriendsCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern FriendsStatus EOS_Friends_GetStatus(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Friends_QueryFriends(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryFriendsCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Friends_RejectInvite(IntPtr handle, IntPtr options, IntPtr clientData, OnRejectInviteCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Friends_RemoveNotifyFriendsUpdate(IntPtr handle, ulong notificationId);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Friends_SendInvite(IntPtr handle, IntPtr options, IntPtr clientData, OnSendInviteCallbackInternal completionDelegate);
}
