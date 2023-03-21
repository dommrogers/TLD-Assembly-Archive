using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

public sealed class ConnectInterface : Handle
{
	public const int AddnotifyauthexpirationApiLatest = 1;

	public const int AddnotifyloginstatuschangedApiLatest = 1;

	public const int CopyproductuserexternalaccountbyaccountidApiLatest = 1;

	public const int CopyproductuserexternalaccountbyaccounttypeApiLatest = 1;

	public const int CopyproductuserexternalaccountbyindexApiLatest = 1;

	public const int CopyproductuserinfoApiLatest = 1;

	public const int CreatedeviceidApiLatest = 1;

	public const int CreatedeviceidDevicemodelMaxLength = 64;

	public const int CreateuserApiLatest = 1;

	public const int CredentialsApiLatest = 1;

	public const int DeletedeviceidApiLatest = 1;

	public const int ExternalAccountIdMaxLength = 256;

	public const int ExternalaccountinfoApiLatest = 1;

	public const int GetexternalaccountmappingApiLatest = 1;

	public const int GetexternalaccountmappingsApiLatest = 1;

	public const int GetproductuserexternalaccountcountApiLatest = 1;

	public const int GetproductuseridmappingApiLatest = 1;

	public const int LinkaccountApiLatest = 1;

	public const int LoginApiLatest = 2;

	public const int OnauthexpirationcallbackApiLatest = 1;

	public const int QueryexternalaccountmappingsApiLatest = 1;

	public const int QueryexternalaccountmappingsMaxAccountIds = 128;

	public const int QueryproductuseridmappingsApiLatest = 2;

	public const int TimeUndefined = -1;

	public const int TransferdeviceidaccountApiLatest = 1;

	public const int UnlinkaccountApiLatest = 1;

	public const int UserlogininfoApiLatest = 1;

	public const int UserlogininfoDisplaynameMaxLength = 32;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ConnectInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ConnectInterface(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(AddNotifyAuthExpirationOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryAssignNotificationIdToCallback")]
	[CallsUnknownMethods(Count = 9)]
	public ulong AddNotifyAuthExpiration(AddNotifyAuthExpirationOptions options, object clientData, OnAuthExpirationCallback notification)
	{
		return default(ulong);
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryAssignNotificationIdToCallback")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(AddNotifyLoginStatusChangedOptionsInternal), Member = "Set")]
	[CallerCount(Count = 0)]
	public ulong AddNotifyLoginStatusChanged(AddNotifyLoginStatusChangedOptions options, object clientData, OnLoginStatusChangedCallback notification)
	{
		return default(ulong);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CopyProductUserExternalAccountByAccountIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(ConnectInterface), Member = "EOS_Connect_ExternalAccountInfo_Release")]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyProductUserExternalAccountByAccountId(CopyProductUserExternalAccountByAccountIdOptions options, out ExternalAccountInfo outExternalAccountInfo)
	{
		outExternalAccountInfo = null;
		return default(Result);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CopyProductUserExternalAccountByAccountTypeOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(ConnectInterface), Member = "EOS_Connect_ExternalAccountInfo_Release")]
	public Result CopyProductUserExternalAccountByAccountType(CopyProductUserExternalAccountByAccountTypeOptions options, out ExternalAccountInfo outExternalAccountInfo)
	{
		outExternalAccountInfo = null;
		return default(Result);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ConnectInterface), Member = "EOS_Connect_ExternalAccountInfo_Release")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CopyProductUserExternalAccountByIndexOptionsInternal), Member = "Set")]
	public Result CopyProductUserExternalAccountByIndex(CopyProductUserExternalAccountByIndexOptions options, out ExternalAccountInfo outExternalAccountInfo)
	{
		outExternalAccountInfo = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(CopyProductUserInfoOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(ConnectInterface), Member = "EOS_Connect_ExternalAccountInfo_Release")]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyProductUserInfo(CopyProductUserInfoOptions options, out ExternalAccountInfo outExternalAccountInfo)
	{
		outExternalAccountInfo = null;
		return default(Result);
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CreateDeviceIdOptionsInternal), Member = "Set")]
	public void CreateDeviceId(CreateDeviceIdOptions options, object clientData, OnCreateDeviceIdCallback completionDelegate)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CreateUserOptionsInternal), Member = "Set")]
	public void CreateUser(CreateUserOptions options, object clientData, OnCreateUserCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(DeleteDeviceIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	public void DeleteDeviceId(DeleteDeviceIdOptions options, object clientData, OnDeleteDeviceIdCallback completionDelegate)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GetExternalAccountMappingsOptionsInternal), Member = "Set")]
	public ProductUserId GetExternalAccountMapping(GetExternalAccountMappingsOptions options)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public ProductUserId GetLoggedInUserByIndex(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetLoggedInUsersCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
	[CallsUnknownMethods(Count = 1)]
	public LoginStatus GetLoginStatus(ProductUserId localUserId)
	{
		return default(LoginStatus);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GetProductUserExternalAccountCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public uint GetProductUserExternalAccountCount(GetProductUserExternalAccountCountOptions options)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GetProductUserIdMappingOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalAllocate")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 1)]
	public Result GetProductUserIdMapping(GetProductUserIdMappingOptions options, out string outBuffer)
	{
		outBuffer = null;
		return default(Result);
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LinkAccountOptionsInternal), Member = "Set")]
	public void LinkAccount(LinkAccountOptions options, object clientData, OnLinkAccountCallback completionDelegate)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LoginOptionsInternal), Member = "Set")]
	public void Login(LoginOptions options, object clientData, OnLoginCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(QueryExternalAccountMappingsOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	public void QueryExternalAccountMappings(QueryExternalAccountMappingsOptions options, object clientData, OnQueryExternalAccountMappingsCallback completionDelegate)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryProductUserIdMappingsOptionsInternal), Member = "Set")]
	public void QueryProductUserIdMappings(QueryProductUserIdMappingsOptions options, object clientData, OnQueryProductUserIdMappingsCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRemoveCallbackByNotificationId")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveNotifyAuthExpiration(ulong inId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRemoveCallbackByNotificationId")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveNotifyLoginStatusChanged(ulong inId)
	{
	}

	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TransferDeviceIdAccountOptionsInternal), Member = "Set")]
	public void TransferDeviceIdAccount(TransferDeviceIdAccountOptions options, object clientData, OnTransferDeviceIdAccountCallback completionDelegate)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnlinkAccountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	public void UnlinkAccount(UnlinkAccountOptions options, object clientData, OnUnlinkAccountCallback completionDelegate)
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	internal static void OnAuthExpirationCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	internal static void OnCreateDeviceIdCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnCreateUserCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnDeleteDeviceIdCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnLinkAccountCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	internal static void OnLoginCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnLoginStatusChangedCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryExternalAccountMappingsCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	internal static void OnQueryProductUserIdMappingsCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnTransferDeviceIdAccountCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnUnlinkAccountCallbackInternalImplementation(IntPtr data)
	{
	}

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern ulong EOS_Connect_AddNotifyAuthExpiration(IntPtr handle, IntPtr options, IntPtr clientData, OnAuthExpirationCallbackInternal notification);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern ulong EOS_Connect_AddNotifyLoginStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, OnLoginStatusChangedCallbackInternal notification);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Connect_CopyProductUserExternalAccountByAccountId(IntPtr handle, IntPtr options, ref IntPtr outExternalAccountInfo);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Connect_CopyProductUserExternalAccountByAccountType(IntPtr handle, IntPtr options, ref IntPtr outExternalAccountInfo);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Connect_CopyProductUserExternalAccountByIndex(IntPtr handle, IntPtr options, ref IntPtr outExternalAccountInfo);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern Result EOS_Connect_CopyProductUserInfo(IntPtr handle, IntPtr options, ref IntPtr outExternalAccountInfo);

	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	internal static extern void EOS_Connect_CreateDeviceId(IntPtr handle, IntPtr options, IntPtr clientData, OnCreateDeviceIdCallbackInternal completionDelegate);

	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	internal static extern void EOS_Connect_CreateUser(IntPtr handle, IntPtr options, IntPtr clientData, OnCreateUserCallbackInternal completionDelegate);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern void EOS_Connect_DeleteDeviceId(IntPtr handle, IntPtr options, IntPtr clientData, OnDeleteDeviceIdCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern IntPtr EOS_Connect_GetExternalAccountMapping(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern IntPtr EOS_Connect_GetLoggedInUserByIndex(IntPtr handle, int index);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern int EOS_Connect_GetLoggedInUsersCount(IntPtr handle);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern LoginStatus EOS_Connect_GetLoginStatus(IntPtr handle, IntPtr localUserId);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_Connect_GetProductUserExternalAccountCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Connect_GetProductUserIdMapping(IntPtr handle, IntPtr options, IntPtr outBuffer, ref int inOutBufferLength);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static extern void EOS_Connect_LinkAccount(IntPtr handle, IntPtr options, IntPtr clientData, OnLinkAccountCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Connect_Login(IntPtr handle, IntPtr options, IntPtr clientData, OnLoginCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Connect_QueryExternalAccountMappings(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryExternalAccountMappingsCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Connect_QueryProductUserIdMappings(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryProductUserIdMappingsCallbackInternal completionDelegate);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConnectInterface), Member = "CopyProductUserInfo")]
	[CalledBy(Type = typeof(ConnectInterface), Member = "CopyProductUserExternalAccountByIndex")]
	[CalledBy(Type = typeof(ConnectInterface), Member = "CopyProductUserExternalAccountByAccountId")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(ConnectInterface), Member = "CopyProductUserExternalAccountByAccountType")]
	internal static extern void EOS_Connect_ExternalAccountInfo_Release(IntPtr externalAccountInfo);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Connect_RemoveNotifyAuthExpiration(IntPtr handle, ulong inId);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Connect_RemoveNotifyLoginStatusChanged(IntPtr handle, ulong inId);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Connect_TransferDeviceIdAccount(IntPtr handle, IntPtr options, IntPtr clientData, OnTransferDeviceIdAccountCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Connect_UnlinkAccount(IntPtr handle, IntPtr options, IntPtr clientData, OnUnlinkAccountCallbackInternal completionDelegate);
}
