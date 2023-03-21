using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UserInfo;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct CopyExternalUserInfoByAccountIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	private IntPtr m_AccountId;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public EpicAccountId TargetUserId
	{
		[CalledBy(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public string AccountId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "set_TargetUserId")]
	[Calls(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "set_AccountId")]
	public void Set(CopyExternalUserInfoByAccountIdOptions other)
	{
	}

	[CalledBy(Type = typeof(UserInfoInterface), Member = "CopyExternalUserInfoByAccountId")]
	[Calls(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "set_AccountId")]
	[Calls(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "set_TargetUserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "set_LocalUserId")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
