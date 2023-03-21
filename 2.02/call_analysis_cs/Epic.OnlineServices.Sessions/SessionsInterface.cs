using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public sealed class SessionsInterface : Handle
{
	public const int AddnotifyjoinsessionacceptedApiLatest = 1;

	public const int AddnotifysessioninviteacceptedApiLatest = 1;

	public const int AddnotifysessioninvitereceivedApiLatest = 1;

	public const int AttributedataApiLatest = 1;

	public const int CopyactivesessionhandleApiLatest = 1;

	public const int CopysessionhandlebyinviteidApiLatest = 1;

	public const int CopysessionhandlebyuieventidApiLatest = 1;

	public const int CopysessionhandleforpresenceApiLatest = 1;

	public const int CreatesessionmodificationApiLatest = 3;

	public const int CreatesessionsearchApiLatest = 1;

	public const int DestroysessionApiLatest = 1;

	public const int DumpsessionstateApiLatest = 1;

	public const int EndsessionApiLatest = 1;

	public const int GetinvitecountApiLatest = 1;

	public const int GetinviteidbyindexApiLatest = 1;

	public const int InviteidMaxLength = 64;

	public const int IsuserinsessionApiLatest = 1;

	public const int JoinsessionApiLatest = 2;

	public const int MaxSearchResults = 200;

	public const int Maxregisteredplayers = 1000;

	public const int QueryinvitesApiLatest = 1;

	public const int RegisterplayersApiLatest = 1;

	public const int RejectinviteApiLatest = 1;

	public const string SearchBucketId = "bucket";

	public const string SearchEmptyServersOnly = "emptyonly";

	public const string SearchMinslotsavailable = "minslotsavailable";

	public const string SearchNonemptyServersOnly = "nonemptyonly";

	public const int SendinviteApiLatest = 1;

	public const int SessionattributeApiLatest = 1;

	public const int SessionattributedataApiLatest = 1;

	public const int StartsessionApiLatest = 1;

	public const int UnregisterplayersApiLatest = 1;

	public const int UpdatesessionApiLatest = 1;

	public const int UpdatesessionmodificationApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SessionsInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SessionsInterface(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(AddNotifyJoinSessionAcceptedOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryAssignNotificationIdToCallback")]
	[CallsUnknownMethods(Count = 9)]
	public ulong AddNotifyJoinSessionAccepted(AddNotifyJoinSessionAcceptedOptions options, object clientData, OnJoinSessionAcceptedCallback notificationFn)
	{
		return default(ulong);
	}

	[Calls(Type = typeof(Helper), Member = "TryAssignNotificationIdToCallback")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AddNotifySessionInviteAcceptedOptionsInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	public ulong AddNotifySessionInviteAccepted(AddNotifySessionInviteAcceptedOptions options, object clientData, OnSessionInviteAcceptedCallback notificationFn)
	{
		return default(ulong);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(AddNotifySessionInviteReceivedOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryAssignNotificationIdToCallback")]
	[CallsUnknownMethods(Count = 9)]
	public ulong AddNotifySessionInviteReceived(AddNotifySessionInviteReceivedOptions options, object clientData, OnSessionInviteReceivedCallback notificationFn)
	{
		return default(ulong);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CopyActiveSessionHandleOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	public Result CopyActiveSessionHandle(CopyActiveSessionHandleOptions options, out ActiveSession outSessionHandle)
	{
		outSessionHandle = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CopySessionHandleByInviteIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result CopySessionHandleByInviteId(CopySessionHandleByInviteIdOptions options, out SessionDetails outSessionHandle)
	{
		outSessionHandle = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CopySessionHandleByUiEventIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result CopySessionHandleByUiEventId(CopySessionHandleByUiEventIdOptions options, out SessionDetails outSessionHandle)
	{
		outSessionHandle = null;
		return default(Result);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopySessionHandleForPresenceOptionsInternal), Member = "Set")]
	public Result CopySessionHandleForPresence(CopySessionHandleForPresenceOptions options, out SessionDetails outSessionHandle)
	{
		outSessionHandle = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CreateSessionModificationOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result CreateSessionModification(CreateSessionModificationOptions options, out SessionModification outSessionModificationHandle)
	{
		outSessionModificationHandle = null;
		return default(Result);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CreateSessionSearchOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	public Result CreateSessionSearch(CreateSessionSearchOptions options, out SessionSearch outSessionSearchHandle)
	{
		outSessionSearchHandle = null;
		return default(Result);
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(DestroySessionOptionsInternal), Member = "Set")]
	public void DestroySession(DestroySessionOptions options, object clientData, OnDestroySessionCallback completionDelegate)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(DumpSessionStateOptionsInternal), Member = "Set")]
	[CallsUnknownMethods(Count = 1)]
	public Result DumpSessionState(DumpSessionStateOptions options)
	{
		return default(Result);
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(EndSessionOptionsInternal), Member = "Set")]
	[CallerCount(Count = 0)]
	public void EndSession(EndSessionOptions options, object clientData, OnEndSessionCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GetInviteCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public uint GetInviteCount(GetInviteCountOptions options)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(GetInviteIdByIndexOptionsInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalAllocate")]
	[CallerCount(Count = 0)]
	public Result GetInviteIdByIndex(GetInviteIdByIndexOptions options, out string outBuffer)
	{
		outBuffer = null;
		return default(Result);
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(IsUserInSessionOptionsInternal), Member = "Set")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	public Result IsUserInSession(IsUserInSessionOptions options)
	{
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(JoinSessionOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	public void JoinSession(JoinSessionOptions options, object clientData, OnJoinSessionCallback completionDelegate)
	{
	}

	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(QueryInvitesOptionsInternal), Member = "Set")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	public void QueryInvites(QueryInvitesOptions options, object clientData, OnQueryInvitesCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(RegisterPlayersOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	public void RegisterPlayers(RegisterPlayersOptions options, object clientData, OnRegisterPlayersCallback completionDelegate)
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRemoveCallbackByNotificationId")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void RemoveNotifyJoinSessionAccepted(ulong inId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRemoveCallbackByNotificationId")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveNotifySessionInviteAccepted(ulong inId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRemoveCallbackByNotificationId")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveNotifySessionInviteReceived(ulong inId)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "Set")]
	[CallerCount(Count = 0)]
	public void SendInvite(SendInviteOptions options, object clientData, OnSendInviteCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(StartSessionOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	public void StartSession(StartSessionOptions options, object clientData, OnStartSessionCallback completionDelegate)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnregisterPlayersOptionsInternal), Member = "Set")]
	public void UnregisterPlayers(UnregisterPlayersOptions options, object clientData, OnUnregisterPlayersCallback completionDelegate)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UpdateSessionOptionsInternal), Member = "Set")]
	public void UpdateSession(UpdateSessionOptions options, object clientData, OnUpdateSessionCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UpdateSessionModificationOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result UpdateSessionModification(UpdateSessionModificationOptions options, out SessionModification outSessionModificationHandle)
	{
		outSessionModificationHandle = null;
		return default(Result);
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnDestroySessionCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	internal static void OnEndSessionCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnJoinSessionAcceptedCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnJoinSessionCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	internal static void OnQueryInvitesCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	internal static void OnRegisterPlayersCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnRejectInviteCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnSendInviteCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	internal static void OnSessionInviteAcceptedCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnSessionInviteReceivedCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnStartSessionCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnUnregisterPlayersCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	internal static void OnUpdateSessionCallbackInternalImplementation(IntPtr data)
	{
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern ulong EOS_Sessions_AddNotifyJoinSessionAccepted(IntPtr handle, IntPtr options, IntPtr clientData, OnJoinSessionAcceptedCallbackInternal notificationFn);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern ulong EOS_Sessions_AddNotifySessionInviteAccepted(IntPtr handle, IntPtr options, IntPtr clientData, OnSessionInviteAcceptedCallbackInternal notificationFn);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static extern ulong EOS_Sessions_AddNotifySessionInviteReceived(IntPtr handle, IntPtr options, IntPtr clientData, OnSessionInviteReceivedCallbackInternal notificationFn);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern Result EOS_Sessions_CopyActiveSessionHandle(IntPtr handle, IntPtr options, ref IntPtr outSessionHandle);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Sessions_CopySessionHandleByInviteId(IntPtr handle, IntPtr options, ref IntPtr outSessionHandle);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Sessions_CopySessionHandleByUiEventId(IntPtr handle, IntPtr options, ref IntPtr outSessionHandle);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Sessions_CopySessionHandleForPresence(IntPtr handle, IntPtr options, ref IntPtr outSessionHandle);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Sessions_CreateSessionModification(IntPtr handle, IntPtr options, ref IntPtr outSessionModificationHandle);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Sessions_CreateSessionSearch(IntPtr handle, IntPtr options, ref IntPtr outSessionSearchHandle);

	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	internal static extern void EOS_Sessions_DestroySession(IntPtr handle, IntPtr options, IntPtr clientData, OnDestroySessionCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Sessions_DumpSessionState(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Sessions_EndSession(IntPtr handle, IntPtr options, IntPtr clientData, OnEndSessionCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_Sessions_GetInviteCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Sessions_GetInviteIdByIndex(IntPtr handle, IntPtr options, IntPtr outBuffer, ref int inOutBufferLength);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern Result EOS_Sessions_IsUserInSession(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	internal static extern void EOS_Sessions_JoinSession(IntPtr handle, IntPtr options, IntPtr clientData, OnJoinSessionCallbackInternal completionDelegate);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern void EOS_Sessions_QueryInvites(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryInvitesCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Sessions_RegisterPlayers(IntPtr handle, IntPtr options, IntPtr clientData, OnRegisterPlayersCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Sessions_RejectInvite(IntPtr handle, IntPtr options, IntPtr clientData, OnRejectInviteCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Sessions_RemoveNotifyJoinSessionAccepted(IntPtr handle, ulong inId);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Sessions_RemoveNotifySessionInviteAccepted(IntPtr handle, ulong inId);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Sessions_RemoveNotifySessionInviteReceived(IntPtr handle, ulong inId);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static extern void EOS_Sessions_SendInvite(IntPtr handle, IntPtr options, IntPtr clientData, OnSendInviteCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Sessions_StartSession(IntPtr handle, IntPtr options, IntPtr clientData, OnStartSessionCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Sessions_UnregisterPlayers(IntPtr handle, IntPtr options, IntPtr clientData, OnUnregisterPlayersCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Sessions_UpdateSession(IntPtr handle, IntPtr options, IntPtr clientData, OnUpdateSessionCallbackInternal completionDelegate);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern Result EOS_Sessions_UpdateSessionModification(IntPtr handle, IntPtr options, ref IntPtr outSessionModificationHandle);
}
