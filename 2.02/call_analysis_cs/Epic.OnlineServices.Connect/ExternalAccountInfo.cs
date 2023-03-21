using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

public class ExternalAccountInfo : ISettable
{
	private ProductUserId _003CProductUserId_003Ek__BackingField;

	private string _003CDisplayName_003Ek__BackingField;

	private string _003CAccountId_003Ek__BackingField;

	private ExternalAccountType _003CAccountIdType_003Ek__BackingField;

	private DateTimeOffset? _003CLastLoginTime_003Ek__BackingField;

	public ProductUserId ProductUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		[CompilerGenerated]
		set
		{
		}
	}

	public string DisplayName
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		set
		{
		}
	}

	public string AccountId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CallerCount(Count = 41)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public ExternalAccountType AccountIdType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return default(ExternalAccountType);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public DateTimeOffset? LastLoginTime
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ExternalAccountInfo), Member = "Set")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(ExternalAccountInfoInternal), Member = "get_AccountId")]
	[Calls(Type = typeof(ExternalAccountInfoInternal), Member = "get_DisplayName")]
	[Calls(Type = typeof(ExternalAccountInfoInternal), Member = "get_ProductUserId")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	internal void Set(ExternalAccountInfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExternalAccountInfo), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ExternalAccountInfo()
	{
	}
}
