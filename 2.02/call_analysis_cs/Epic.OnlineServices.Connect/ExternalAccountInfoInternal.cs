using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

[StructLayout(0, Pack = 8, Size = 48)]
internal struct ExternalAccountInfoInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_ProductUserId;

	private IntPtr m_DisplayName;

	private IntPtr m_AccountId;

	private ExternalAccountType m_AccountIdType;

	private long m_LastLoginTime;

	public ProductUserId ProductUserId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(ExternalAccountInfo), Member = "Set")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(ExternalAccountInfoInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string DisplayName
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(ExternalAccountInfo), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(ExternalAccountInfoInternal), Member = "Set")]
		set
		{
		}
	}

	public string AccountId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(ExternalAccountInfo), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ExternalAccountInfoInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public ExternalAccountType AccountIdType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
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

	public DateTimeOffset? LastLoginTime
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(ExternalAccountInfoInternal), Member = "Set")]
		set
		{
		}
	}

	[CalledBy(Type = typeof(ExternalAccountInfoInternal), Member = "Set")]
	[Calls(Type = typeof(ExternalAccountInfoInternal), Member = "set_LastLoginTime")]
	[Calls(Type = typeof(ExternalAccountInfoInternal), Member = "set_AccountId")]
	[Calls(Type = typeof(ExternalAccountInfoInternal), Member = "set_ProductUserId")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExternalAccountInfoInternal), Member = "set_DisplayName")]
	public void Set(ExternalAccountInfo other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExternalAccountInfoInternal), Member = "Set")]
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
