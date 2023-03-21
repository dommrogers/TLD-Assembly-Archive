using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

public sealed class PresenceInterface : Handle
{
	public const int AddnotifyjoingameacceptedApiLatest = 2;

	public const int AddnotifyonpresencechangedApiLatest = 1;

	public const int CopypresenceApiLatest = 2;

	public const int CreatepresencemodificationApiLatest = 1;

	public const int DataMaxKeyLength = 64;

	public const int DataMaxKeys = 32;

	public const int DataMaxValueLength = 255;

	public const int DatarecordApiLatest = 1;

	public const int DeletedataApiLatest = 1;

	public const int GetjoininfoApiLatest = 1;

	public const int HaspresenceApiLatest = 1;

	public const int InfoApiLatest = 2;

	public const int QuerypresenceApiLatest = 1;

	public const int RichTextMaxValueLength = 255;

	public const int SetdataApiLatest = 1;

	public const int SetpresenceApiLatest = 1;

	public const int SetrawrichtextApiLatest = 1;

	public const int SetstatusApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PresenceInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PresenceInterface(IntPtr innerHandle)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "TryAssignNotificationIdToCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(AddNotifyJoinGameAcceptedOptionsInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public ulong AddNotifyJoinGameAccepted(AddNotifyJoinGameAcceptedOptions options, object clientData, OnJoinGameAcceptedCallback notificationFn)
	{
		return default(ulong);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(AddNotifyOnPresenceChangedOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryAssignNotificationIdToCallback")]
	[CallsUnknownMethods(Count = 9)]
	public ulong AddNotifyOnPresenceChanged(AddNotifyOnPresenceChangedOptions options, object clientData, OnPresenceChangedCallback notificationHandler)
	{
		return default(ulong);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyPresenceOptionsInternal), Member = "Set")]
	public Result CopyPresence(CopyPresenceOptions options, out Info outPresence)
	{
		outPresence = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CreatePresenceModificationOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result CreatePresenceModification(CreatePresenceModificationOptions options, out PresenceModification outPresenceModificationHandle)
	{
		outPresenceModificationHandle = null;
		return default(Result);
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalAllocate")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(GetJoinInfoOptionsInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	public Result GetJoinInfo(GetJoinInfoOptions options, out string outBuffer)
	{
		outBuffer = null;
		return default(Result);
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(HasPresenceOptionsInternal), Member = "Set")]
	[CallsUnknownMethods(Count = 1)]
	public bool HasPresence(HasPresenceOptions options)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryPresenceOptionsInternal), Member = "Set")]
	public void QueryPresence(QueryPresenceOptions options, object clientData, OnQueryPresenceCompleteCallback completionDelegate)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryRemoveCallbackByNotificationId")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void RemoveNotifyJoinGameAccepted(ulong inId)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRemoveCallbackByNotificationId")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveNotifyOnPresenceChanged(ulong notificationId)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SetPresenceOptionsInternal), Member = "Set")]
	public void SetPresence(SetPresenceOptions options, object clientData, SetPresenceCompleteCallback completionDelegate)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnJoinGameAcceptedCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnPresenceChangedCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryPresenceCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	internal static void SetPresenceCompleteCallbackInternalImplementation(IntPtr data)
	{
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern ulong EOS_Presence_AddNotifyJoinGameAccepted(IntPtr handle, IntPtr options, IntPtr clientData, OnJoinGameAcceptedCallbackInternal notificationFn);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern ulong EOS_Presence_AddNotifyOnPresenceChanged(IntPtr handle, IntPtr options, IntPtr clientData, OnPresenceChangedCallbackInternal notificationHandler);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Presence_CopyPresence(IntPtr handle, IntPtr options, ref IntPtr outPresence);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Presence_CreatePresenceModification(IntPtr handle, IntPtr options, ref IntPtr outPresenceModificationHandle);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Presence_GetJoinInfo(IntPtr handle, IntPtr options, IntPtr outBuffer, ref int inOutBufferLength);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern int EOS_Presence_HasPresence(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Presence_QueryPresence(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryPresenceCompleteCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Presence_Info_Release(IntPtr presenceInfo);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Presence_RemoveNotifyJoinGameAccepted(IntPtr handle, ulong inId);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Presence_RemoveNotifyOnPresenceChanged(IntPtr handle, ulong notificationId);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Presence_SetPresence(IntPtr handle, IntPtr options, IntPtr clientData, SetPresenceCompleteCallbackInternal completionDelegate);
}
