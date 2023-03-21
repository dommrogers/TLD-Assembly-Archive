using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.UserInfo;

public class CopyExternalUserInfoByAccountTypeOptions
{
	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	private EpicAccountId _003CTargetUserId_003Ek__BackingField;

	private ExternalAccountType _003CAccountType_003Ek__BackingField;

	public EpicAccountId LocalUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CallerCount(Count = 101)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public EpicAccountId TargetUserId
	{
		[CallerCount(Count = 29)]
		[DeduplicatedMethod]
		[CompilerGenerated]
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

	public ExternalAccountType AccountType
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(ExternalAccountType);
		}
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public CopyExternalUserInfoByAccountTypeOptions()
	{
	}
}
