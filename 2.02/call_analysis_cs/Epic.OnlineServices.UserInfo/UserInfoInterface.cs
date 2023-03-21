using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UserInfo;

public sealed class UserInfoInterface : Handle
{
	public const int CopyexternaluserinfobyaccountidApiLatest = 1;

	public const int CopyexternaluserinfobyaccounttypeApiLatest = 1;

	public const int CopyexternaluserinfobyindexApiLatest = 1;

	public const int CopyuserinfoApiLatest = 2;

	public const int ExternaluserinfoApiLatest = 1;

	public const int GetexternaluserinfocountApiLatest = 1;

	public const int MaxDisplaynameCharacters = 16;

	public const int MaxDisplaynameUtf8Length = 64;

	public const int QueryuserinfoApiLatest = 1;

	public const int QueryuserinfobydisplaynameApiLatest = 1;

	public const int QueryuserinfobyexternalaccountApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public UserInfoInterface()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UserInfoInterface(IntPtr innerHandle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(UserInfoInterface), Member = "EOS_UserInfo_ExternalUserInfo_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyExternalUserInfoByAccountId(CopyExternalUserInfoByAccountIdOptions options, out ExternalUserInfo outExternalUserInfo)
	{
		outExternalUserInfo = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyExternalUserInfoByAccountTypeOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(UserInfoInterface), Member = "EOS_UserInfo_ExternalUserInfo_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyExternalUserInfoByAccountType(CopyExternalUserInfoByAccountTypeOptions options, out ExternalUserInfo outExternalUserInfo)
	{
		outExternalUserInfo = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyExternalUserInfoByIndexOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(UserInfoInterface), Member = "EOS_UserInfo_ExternalUserInfo_Release")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public Result CopyExternalUserInfoByIndex(CopyExternalUserInfoByIndexOptions options, out ExternalUserInfo outExternalUserInfo)
	{
		outExternalUserInfo = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyUserInfoOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public Result CopyUserInfo(CopyUserInfoOptions options, out UserInfoData outUserInfo)
	{
		outUserInfo = null;
		return default(Result);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetExternalUserInfoCountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public uint GetExternalUserInfoCount(GetExternalUserInfoCountOptions options)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryUserInfoOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void QueryUserInfo(QueryUserInfoOptions options, object clientData, OnQueryUserInfoCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryUserInfoByDisplayNameOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void QueryUserInfoByDisplayName(QueryUserInfoByDisplayNameOptions options, object clientData, OnQueryUserInfoByDisplayNameCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryUserInfoByExternalAccountOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void QueryUserInfoByExternalAccount(QueryUserInfoByExternalAccountOptions options, object clientData, OnQueryUserInfoByExternalAccountCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryUserInfoByDisplayNameCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryUserInfoByExternalAccountCallbackInternalImplementation(IntPtr data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnQueryUserInfoCallbackInternalImplementation(IntPtr data)
	{
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_UserInfo_CopyExternalUserInfoByAccountId(IntPtr handle, IntPtr options, ref IntPtr outExternalUserInfo);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_UserInfo_CopyExternalUserInfoByAccountType(IntPtr handle, IntPtr options, ref IntPtr outExternalUserInfo);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_UserInfo_CopyExternalUserInfoByIndex(IntPtr handle, IntPtr options, ref IntPtr outExternalUserInfo);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_UserInfo_CopyUserInfo(IntPtr handle, IntPtr options, ref IntPtr outUserInfo);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern uint EOS_UserInfo_GetExternalUserInfoCount(IntPtr handle, IntPtr options);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_UserInfo_QueryUserInfo(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryUserInfoCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_UserInfo_QueryUserInfoByDisplayName(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryUserInfoByDisplayNameCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_UserInfo_QueryUserInfoByExternalAccount(IntPtr handle, IntPtr options, IntPtr clientData, OnQueryUserInfoByExternalAccountCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_UserInfo_Release(IntPtr userInfo);

	[PreserveSig]
	[CalledBy(Type = typeof(UserInfoInterface), Member = "CopyExternalUserInfoByAccountId")]
	[CalledBy(Type = typeof(UserInfoInterface), Member = "CopyExternalUserInfoByAccountType")]
	[CalledBy(Type = typeof(UserInfoInterface), Member = "CopyExternalUserInfoByIndex")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_UserInfo_ExternalUserInfo_Release(IntPtr externalUserInfo);
}
