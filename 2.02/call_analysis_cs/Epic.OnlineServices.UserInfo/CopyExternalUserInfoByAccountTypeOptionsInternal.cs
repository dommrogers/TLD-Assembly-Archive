using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UserInfo;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct CopyExternalUserInfoByAccountTypeOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_TargetUserId;

	private ExternalAccountType m_AccountType;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(CopyExternalUserInfoByAccountTypeOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyExternalUserInfoByAccountTypeOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public EpicAccountId TargetUserId
	{
		[CalledBy(Type = typeof(CopyExternalUserInfoByAccountTypeOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyExternalUserInfoByAccountTypeOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public ExternalAccountType AccountType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyExternalUserInfoByAccountTypeOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyExternalUserInfoByAccountTypeOptionsInternal), Member = "set_TargetUserId")]
	public void Set(CopyExternalUserInfoByAccountTypeOptions other)
	{
	}

	[CalledBy(Type = typeof(UserInfoInterface), Member = "CopyExternalUserInfoByAccountType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyExternalUserInfoByAccountTypeOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(CopyExternalUserInfoByAccountTypeOptionsInternal), Member = "set_TargetUserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Dispose()
	{
	}
}
