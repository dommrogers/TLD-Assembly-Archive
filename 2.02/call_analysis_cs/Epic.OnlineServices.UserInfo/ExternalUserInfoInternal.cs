using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UserInfo;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct ExternalUserInfoInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private ExternalAccountType m_AccountType;

	private IntPtr m_AccountId;

	private IntPtr m_DisplayName;

	public ExternalAccountType AccountType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(ExternalAccountType);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string AccountId
	{
		[CalledBy(Type = typeof(ExternalUserInfo), Member = "Set")]
		[CalledBy(Type = typeof(ExternalUserInfo), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ExternalUserInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(ExternalUserInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string DisplayName
	{
		[CalledBy(Type = typeof(ExternalUserInfo), Member = "Set")]
		[CalledBy(Type = typeof(ExternalUserInfo), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ExternalUserInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(ExternalUserInfoInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExternalUserInfoInternal), Member = "set_AccountId")]
	[Calls(Type = typeof(ExternalUserInfoInternal), Member = "set_DisplayName")]
	public void Set(ExternalUserInfo other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExternalUserInfoInternal), Member = "set_AccountId")]
	[Calls(Type = typeof(ExternalUserInfoInternal), Member = "set_DisplayName")]
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
