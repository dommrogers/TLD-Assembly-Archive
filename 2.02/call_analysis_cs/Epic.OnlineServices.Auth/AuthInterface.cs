using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Auth;

public sealed class AuthInterface : Handle
{
	public const int AccountfeaturerestrictedinfoApiLatest = 1;

	public const int AddnotifyloginstatuschangedApiLatest = 1;

	public const int CopyuserauthtokenApiLatest = 1;

	public const int CredentialsApiLatest = 3;

	public const int DeletepersistentauthApiLatest = 2;

	public const int LinkaccountApiLatest = 1;

	public const int LoginApiLatest = 2;

	public const int LogoutApiLatest = 1;

	public const int PingrantinfoApiLatest = 2;

	public const int TokenApiLatest = 2;

	public const int VerifyuserauthApiLatest = 1;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public AuthInterface()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AuthInterface(IntPtr innerHandle)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "TryAssignNotificationIdToCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AddNotifyLoginStatusChangedOptionsInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	public ulong AddNotifyLoginStatusChanged(AddNotifyLoginStatusChangedOptions options, object clientData, OnLoginStatusChangedCallback notification)
	{
		return default(ulong);
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(CopyUserAuthTokenOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
	[CallsUnknownMethods(Count = 2)]
	public Result CopyUserAuthToken(CopyUserAuthTokenOptions options, EpicAccountId localUserId, out Token outUserAuthToken)
	{
		outUserAuthToken = null;
		return default(Result);
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(DeletePersistentAuthOptionsInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public void DeletePersistentAuth(DeletePersistentAuthOptions options, object clientData, OnDeletePersistentAuthCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public EpicAccountId GetLoggedInAccountByIndex(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetLoggedInAccountsCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
	[CallsUnknownMethods(Count = 1)]
	public LoginStatus GetLoginStatus(EpicAccountId localUserId)
	{
		return default(LoginStatus);
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LinkAccountOptionsInternal), Member = "Set")]
	public void LinkAccount(LinkAccountOptions options, object clientData, OnLinkAccountCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(LoginOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	public void Login(LoginOptions options, object clientData, OnLoginCallback completionDelegate)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LogoutOptionsInternal), Member = "Set")]
	public void Logout(LogoutOptions options, object clientData, OnLogoutCallback completionDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryRemoveCallbackByNotificationId")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveNotifyLoginStatusChanged(ulong inId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(VerifyUserAuthOptionsInternal), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "AddCallback")]
	[Calls(Type = typeof(Helper), Member = "TryRelease")]
	[CallsUnknownMethods(Count = 9)]
	public void VerifyUserAuth(VerifyUserAuthOptions options, object clientData, OnVerifyUserAuthCallback completionDelegate)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	internal static void OnDeletePersistentAuthCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnLinkAccountCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 5)]
	internal static void OnLogoutCallbackInternalImplementation(IntPtr data)
	{
	}

	[MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal static void OnVerifyUserAuthCallbackInternalImplementation(IntPtr data)
	{
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern ulong EOS_Auth_AddNotifyLoginStatusChanged(IntPtr handle, IntPtr options, IntPtr clientData, OnLoginStatusChangedCallbackInternal notification);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern Result EOS_Auth_CopyUserAuthToken(IntPtr handle, IntPtr options, IntPtr localUserId, ref IntPtr outUserAuthToken);

	[PreserveSig]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	internal static extern void EOS_Auth_DeletePersistentAuth(IntPtr handle, IntPtr options, IntPtr clientData, OnDeletePersistentAuthCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern IntPtr EOS_Auth_GetLoggedInAccountByIndex(IntPtr handle, int index);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern int EOS_Auth_GetLoggedInAccountsCount(IntPtr handle);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern LoginStatus EOS_Auth_GetLoginStatus(IntPtr handle, IntPtr localUserId);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Auth_LinkAccount(IntPtr handle, IntPtr options, IntPtr clientData, OnLinkAccountCallbackInternal completionDelegate);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static extern void EOS_Auth_Login(IntPtr handle, IntPtr options, IntPtr clientData, OnLoginCallbackInternal completionDelegate);

	[PreserveSig]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static extern void EOS_Auth_Logout(IntPtr handle, IntPtr options, IntPtr clientData, OnLogoutCallbackInternal completionDelegate);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Auth_Token_Release(IntPtr authToken);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static extern void EOS_Auth_RemoveNotifyLoginStatusChanged(IntPtr handle, ulong inId);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static extern void EOS_Auth_VerifyUserAuth(IntPtr handle, IntPtr options, IntPtr clientData, OnVerifyUserAuthCallbackInternal completionDelegate);
}
