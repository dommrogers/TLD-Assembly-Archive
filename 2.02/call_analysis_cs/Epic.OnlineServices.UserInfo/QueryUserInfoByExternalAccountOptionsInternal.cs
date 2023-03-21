using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UserInfo;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct QueryUserInfoByExternalAccountOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_ExternalAccountId;

	private ExternalAccountType m_AccountType;

	public EpicAccountId LocalUserId
	{
		[CalledBy(Type = typeof(QueryUserInfoByExternalAccountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryUserInfoByExternalAccountOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string ExternalAccountId
	{
		[CalledBy(Type = typeof(QueryUserInfoByExternalAccountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryUserInfoByExternalAccountOptionsInternal), Member = "Set")]
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
	[Calls(Type = typeof(QueryUserInfoByExternalAccountOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryUserInfoByExternalAccountOptionsInternal), Member = "set_ExternalAccountId")]
	public void Set(QueryUserInfoByExternalAccountOptions other)
	{
	}

	[CalledBy(Type = typeof(UserInfoInterface), Member = "QueryUserInfoByExternalAccount")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryUserInfoByExternalAccountOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryUserInfoByExternalAccountOptionsInternal), Member = "set_ExternalAccountId")]
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
