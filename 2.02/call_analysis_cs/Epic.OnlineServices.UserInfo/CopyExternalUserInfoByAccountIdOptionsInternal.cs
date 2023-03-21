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
		[CalledBy(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public EpicAccountId TargetUserId
	{
		[CalledBy(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string AccountId
	{
		[CalledBy(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "set_TargetUserId")]
	[Calls(Type = typeof(CopyExternalUserInfoByAccountIdOptionsInternal), Member = "set_AccountId")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
