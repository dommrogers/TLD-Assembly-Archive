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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(ExternalUserInfo), Member = "Set")]
		[CalledBy(Type = typeof(ExternalUserInfo), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(ExternalUserInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(ExternalUserInfoInternal), Member = "Set")]
		set
		{
		}
	}

	public string DisplayName
	{
		[CalledBy(Type = typeof(ExternalUserInfo), Member = "Set")]
		[CalledBy(Type = typeof(ExternalUserInfo), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(ExternalUserInfoInternal), Member = "Set")]
		[CalledBy(Type = typeof(ExternalUserInfoInternal), Member = "Set")]
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

	[Calls(Type = typeof(ExternalUserInfoInternal), Member = "set_DisplayName")]
	[Calls(Type = typeof(ExternalUserInfoInternal), Member = "set_AccountId")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
