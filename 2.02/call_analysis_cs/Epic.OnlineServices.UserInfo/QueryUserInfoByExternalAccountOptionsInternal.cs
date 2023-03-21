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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public string ExternalAccountId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(QueryUserInfoByExternalAccountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryUserInfoByExternalAccountOptionsInternal), Member = "Set")]
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

	[Calls(Type = typeof(QueryUserInfoByExternalAccountOptionsInternal), Member = "set_LocalUserId")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryUserInfoByExternalAccountOptionsInternal), Member = "set_ExternalAccountId")]
	public void Set(QueryUserInfoByExternalAccountOptions other)
	{
	}

	[Calls(Type = typeof(QueryUserInfoByExternalAccountOptionsInternal), Member = "set_ExternalAccountId")]
	[CalledBy(Type = typeof(UserInfoInterface), Member = "QueryUserInfoByExternalAccount")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryUserInfoByExternalAccountOptionsInternal), Member = "set_LocalUserId")]
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
