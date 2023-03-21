using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UserInfo;

public class ExternalUserInfo : ISettable
{
	private ExternalAccountType _003CAccountType_003Ek__BackingField;

	private string _003CAccountId_003Ek__BackingField;

	private string _003CDisplayName_003Ek__BackingField;

	public ExternalAccountType AccountType
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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

	public string AccountId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CallerCount(Count = 71)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public string DisplayName
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		set
		{
		}
	}

	[Calls(Type = typeof(ExternalUserInfoInternal), Member = "get_DisplayName")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExternalUserInfoInternal), Member = "get_AccountId")]
	[CallsUnknownMethods(Count = 3)]
	internal void Set(ExternalUserInfoInternal? other)
	{
	}

	[Calls(Type = typeof(ExternalUserInfoInternal), Member = "get_DisplayName")]
	[Calls(Type = typeof(ExternalUserInfoInternal), Member = "get_AccountId")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public ExternalUserInfo()
	{
	}
}
