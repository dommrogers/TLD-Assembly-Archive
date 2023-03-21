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
		[CalledBy(Type = typeof(ExternalAccountInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ExternalAccountInfoInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string DisplayName
	{
		[CalledBy(Type = typeof(ExternalAccountInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ExternalAccountInfoInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string AccountId
	{
		[CalledBy(Type = typeof(ExternalAccountInfo), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ExternalAccountInfoInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ExternalAccountInfoInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(ExternalAccountInfoInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExternalAccountInfoInternal), Member = "set_ProductUserId")]
	[Calls(Type = typeof(ExternalAccountInfoInternal), Member = "set_DisplayName")]
	[Calls(Type = typeof(ExternalAccountInfoInternal), Member = "set_AccountId")]
	[Calls(Type = typeof(ExternalAccountInfoInternal), Member = "set_LastLoginTime")]
	public void Set(ExternalAccountInfo other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExternalAccountInfoInternal), Member = "Set")]
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
