using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

public sealed class LobbyInterface : Handle
{
	public const int AddnotifyjoinlobbyacceptedApiLatest = 1;

	public const int AddnotifylobbyinviteacceptedApiLatest = 1;

	public const int AddnotifylobbyinvitereceivedApiLatest = 1;

	public const int AddnotifylobbymemberstatusreceivedApiLatest = 1;

	public const int AddnotifylobbymemberupdatereceivedApiLatest = 1;

	public const int AddnotifylobbyupdatereceivedApiLatest = 1;

	public const int AttributeApiLatest = 1;

	public const int AttributedataApiLatest = 1;

	public const int CopylobbydetailshandleApiLatest = 1;

	public const int CopylobbydetailshandlebyinviteidApiLatest = 1;

	public const int CopylobbydetailshandlebyuieventidApiLatest = 1;

	public const int CreatelobbyApiLatest = 2;

	public const int CreatelobbysearchApiLatest = 1;

	public const int DestroylobbyApiLatest = 1;

	public const int GetinvitecountApiLatest = 1;

	public const int GetinviteidbyindexApiLatest = 1;

	public const int InviteidMaxLength = 64;

	public const int JoinlobbyApiLatest = 2;

	public const int KickmemberApiLatest = 1;

	public const int LeavelobbyApiLatest = 1;

	public const int MaxLobbies = 4;

	public const int MaxLobbyMembers = 64;

	public const int MaxSearchResults = 200;

	public const int PromotememberApiLatest = 1;

	public const int QueryinvitesApiLatest = 1;

	public const int RejectinviteApiLatest = 1;

	public const string SearchMincurrentmembers = "mincurrentmembers";

	public const string SearchMinslotsavailable = "minslotsavailable";

	public const int SendinviteApiLatest = 1;

	public const int UpdatelobbyApiLatest = 1;

	public const int UpdatelobbymodificationApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public LobbyInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LobbyInterface(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(AddNotifyJoinLobbyAcceptedOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryAssignNotificationIdToCallback")]
	[CallsUnknownMethods(Count = 9)]
	public ulong AddNotifyJoinLobbyAccepted(AddNotifyJoinLobbyAcceptedOptions options, object clientData, OnJoinLobbyAcceptedCallback notificationFn)
	{
		return default(ulong);
	}

	[Calls(Type = typeof(Helper), Member = "TryAssignNotificationIdToCallback")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(AddNotifyLobbyInviteAcceptedOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallerCount(Count = 0)]
	public ulong AddNotifyLobbyInviteAccepted(AddNotifyLobbyInviteAcceptedOptions options, object clientData, OnLobbyInviteAcceptedCallback notificationFn)
	{
		return default(ulong);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(AddNotifyLobbyInviteReceivedOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryAssignNotificationIdToCallback")]
	[CallsUnknownMethods(Count = 9)]
	public ulong AddNotifyLobbyInviteReceived(AddNotifyLobbyInviteReceivedOptions options, object clientData, OnLobbyInviteReceivedCallback notificationFn)
	{
		return default(ulong);
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "TryAssignNotificationIdToCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(AddNotifyLobbyMemberStatusReceivedOptionsInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public ulong AddNotifyLobbyMemberStatusReceived(AddNotifyLobbyMemberStatusReceivedOptions options, object clientData, OnLobbyMemberStatusReceivedCallback notificationFn)
	{
		return default(ulong);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(AddNotifyLobbyMemberUpdateReceivedOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryAssignNotificationIdToCallback")]
	[CallsUnknownMethods(Count = 9)]
	public ulong AddNotifyLobbyMemberUpdateReceived(AddNotifyLobbyMemberUpdateReceivedOptions options, object clientData, OnLobbyMemberUpdateReceivedCallback notificationFn)
	{
		return default(ulong);
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "TryAssignNotificationIdToCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(AddNotifyLobbyUpdateReceivedOptionsInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	public ulong AddNotifyLobbyUpdateReceived(AddNotifyLobbyUpdateReceivedOptions options, object clientData, OnLobbyUpdateReceivedCallback notificationFn)
	{
		return default(ulong);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CopyLobbyDetailsHandleOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyLobbyDetailsHandle(CopyLobbyDetailsHandleOptions options, out LobbyDetails outLobbyDetailsHandle)
	{
		outLobbyDetailsHandle = null;
		return default(Result);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CopyLobbyDetailsHandleByInviteIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	public Result CopyLobbyDetailsHandleByInviteId(CopyLobbyDetailsHandleByInviteIdOptions options, out LobbyDetails outLobbyDetailsHandle)
	{
		outLobbyDetailsHandle = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CopyLobbyDetailsHandleByUiEventIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyLobbyDetailsHandleByUiEventId(CopyLobbyDetailsHandleByUiEventIdOptions options, out LobbyDetails outLobbyDetailsHandle)
	{
		outLobbyDetailsHandle = null;
		return default(Result);
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CreateLobbyOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsUnknownMethods(Count = 9)]
	public void CreateLobby(CreateLobbyOptions options, object clientData, OnCreateLobbyCallback completionDelegate)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(CreateLobbySearchOptionsInternal), Member = "Set")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	public Result CreateLobbySearch(CreateLobbySearchOptions options, out LobbySearch outLobbySearchHandle)
	{
		outLobbySearchHandle = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(DestroyLobbyOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	public void DestroyLobby(DestroyLobbyOptions options, object clientData, OnDestroyLobbyCallback completionDelegate)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GetInviteCountOptionsInternal), Member = "Set")]
	public uint GetInviteCount(GetInviteCountOptions options)
	{
		return default(uint);
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GetInviteIdByIndexOptionsInternal), Member = "Set")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalAllocate")]
	public Result GetInviteIdByIndex(GetInviteIdByIndexOptions options, out string outBuffer)
	{
		outBuffer = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(JoinLobbyOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	public void JoinLobby(JoinLobbyOptions options, object clientData, OnJoinLobbyCallback completionDelegate)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KickMemberOptionsInternal), Member = "Set")]
	public void KickMember(KickMemberOptions options, object clientData, OnKickMemberCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(LeaveLobbyOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	public void LeaveLobby(LeaveLobbyOptions options, object clientData, OnLeaveLobbyCallback completionDelegate)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PromoteMemberOptionsInternal), Member = "Set")]
	public void PromoteMember(PromoteMemberOptions options, object clientData, OnPromoteMemberCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(QueryInvitesOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	public void QueryInvites(QueryInvitesOptions options, object clientData, OnQueryInvitesCallback completionDelegate)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(RejectInviteOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	public void RejectInvite(RejectInviteOptions options, object clientData, OnRejectInviteCallback completionDelegate)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRemoveCallbackByNotificationId")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveNotifyJoinLobbyAccepted(ulong inId)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRemoveCallbackByNotificationId")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void RemoveNotifyLobbyInviteAccepted(ulong inId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRemoveCallbackByNotificationId")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveNotifyLobbyInviteReceived(ulong inId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRemoveCallbackByNotificationId")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveNotifyLobbyMemberStatusReceived(ulong inId)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryRemoveCallbackByNotificationId")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void RemoveNotifyLobbyMemberUpdateReceived(ulong inId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRemoveCallbackByNotificationId")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveNotifyLobbyUpdateReceived(ulong inId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(SendInviteOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	public void SendInvite(SendInviteOptions options, object clientData, OnSendInviteCallback completionDelegate)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UpdateLobbyOptionsInternal), Member = "Set")]
	public void UpdateLobby(UpdateLobbyOptions options, object clientData, OnUpdateLobbyCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UpdateLobbyModificationOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result UpdateLobbyModification(UpdateLobbyModificationOptions options, out LobbyModification outLobbyModificationHandle)
	{
		outLobbyModificationHandle = null;
		return default(Result);
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnCreateLobbyCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	internal static void OnDestroyLobbyCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnJoinLobbyAcceptedCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnJoinLobbyCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	internal static void OnKickMemberCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	internal static void OnLeaveLobbyCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnLobbyInviteAcceptedCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnLobbyInviteReceivedCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	internal static void OnLobbyMemberStatusReceivedCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnLobbyMemberUpdateReceivedCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnLobbyUpdateReceivedCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	internal static void OnPromoteMemberCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	internal static void OnQueryInvitesCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnRejectInviteCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnSendInviteCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnUpdateLobbyCallbackInternalImplementation(IntPtr data)
	{
	}

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern ulong EOS_Lobby_AddNotifyJoinLobbyAccepted(IntPtr handle, IntPtr options, IntPtr clientData, OnJoinLobbyAcceptedCallbackInternal notificationFn);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern ulong EOS_Lobby_AddNotifyLobbyInviteAccepted(IntPtr handle, IntPtr options, IntPtr clientData, OnLobbyInviteAcceptedCallbackInternal notificationFn);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern ulong EOS_Lobby_AddNotifyLobbyInviteReceived(IntPtr handle, IntPtr options, IntPtr clientData, OnLobbyInviteReceivedCallbackInternal notificationFn);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern ulong EOS_Lobby_AddNotifyLobbyMemberStatusReceived(IntPtr handle, IntPtr options, IntPtr clientData, OnLobbyMemberStatusReceivedCallbackInternal notificationFn);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern ulong EOS_Lobby_AddNotifyLobbyMemberUpdateReceived(IntPtr handle, IntPtr options, IntPtr clientData, OnLobbyMemberUpdateReceivedCallbackInternal notificationFn);

	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern ulong EOS_Lobby_AddNotifyLobbyUpdateReceived(IntPtr handle, IntPtr options, IntPtr clientData, OnLobbyUpdateReceivedCallbackInternal notificationFn);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern Result EOS_Lobby_CopyLobbyDetailsHandle(IntPtr handle, IntPtr options, ref IntPtr outLobbyDetailsHandle);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Lobby_CopyLobbyDetailsHandleByInviteId(IntPtr handle, IntPtr options, ref IntPtr outLobbyDetailsHandle);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Lobby_CopyLobbyDetailsHandleByUiEventId(IntPtr handle, IntPtr options, ref IntPtr outLobbyDetailsHandle);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Lobby_CreateLobby(IntPtr handle, IntPtr options, IntPtr clientData, OnCreateLobbyCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Lobby_CreateLobbySearch(IntPtr handle, IntPtr options, ref IntPtr outLobbySearchHandle);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Lobby_DestroyLobby(IntPtr handle, IntPtr options, IntPtr clientData, OnDestroyLobbyCallbackInternal completionDelegate);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern uint EOS_Lobby_GetInviteCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Lobby_GetInviteIdByIndex(IntPtr handle, IntPtr options, IntPtr outBuffer, ref int inOutBufferLength);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Lobby_JoinLobby(IntPtr handle, IntPtr options, IntPtr clientData, OnJoinLobbyCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Lobby_KickMember(IntPtr handle, IntPtr options, IntPtr clientData, OnKickMemberCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Lobby_LeaveLobby(IntPtr handle, IntPtr options, IntPtr clientData, OnLeaveLobbyCallbackInternal completionDelegate);

	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	internal static extern void EOS_Lobby_PromoteMember(IntPtr handle, IntPtr options, IntPtr clientData, OnPromoteMemberCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Lobby_QueryInvites(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryInvitesCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Lobby_RejectInvite(IntPtr handle, IntPtr options, IntPtr clientData, OnRejectInviteCallbackInternal completionDelegate);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(LobbyDetails), Member = "CopyAttributeByIndex")]
	[CalledBy(Type = typeof(LobbyDetails), Member = "CopyAttributeByKey")]
	[CalledBy(Type = typeof(LobbyDetails), Member = "CopyMemberAttributeByIndex")]
	[CalledBy(Type = typeof(LobbyDetails), Member = "CopyMemberAttributeByKey")]
	internal static extern void EOS_Lobby_Attribute_Release(IntPtr lobbyAttribute);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern void EOS_Lobby_RemoveNotifyJoinLobbyAccepted(IntPtr handle, ulong inId);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Lobby_RemoveNotifyLobbyInviteAccepted(IntPtr handle, ulong inId);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Lobby_RemoveNotifyLobbyInviteReceived(IntPtr handle, ulong inId);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Lobby_RemoveNotifyLobbyMemberStatusReceived(IntPtr handle, ulong inId);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Lobby_RemoveNotifyLobbyMemberUpdateReceived(IntPtr handle, ulong inId);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern void EOS_Lobby_RemoveNotifyLobbyUpdateReceived(IntPtr handle, ulong inId);

	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	internal static extern void EOS_Lobby_SendInvite(IntPtr handle, IntPtr options, IntPtr clientData, OnSendInviteCallbackInternal completionDelegate);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern void EOS_Lobby_UpdateLobby(IntPtr handle, IntPtr options, IntPtr clientData, OnUpdateLobbyCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Lobby_UpdateLobbyModification(IntPtr handle, IntPtr options, ref IntPtr outLobbyModificationHandle);
}
