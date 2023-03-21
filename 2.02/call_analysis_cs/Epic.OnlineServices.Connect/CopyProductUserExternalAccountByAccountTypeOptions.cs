using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

public class CopyProductUserExternalAccountByAccountTypeOptions
{
	private ProductUserId _003CTargetUserId_003Ek__BackingField;

	private ExternalAccountType _003CAccountIdType_003Ek__BackingField;

	public ProductUserId TargetUserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		set
		{
		}
	}

	public ExternalAccountType AccountIdType
	{
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(ExternalAccountType);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public CopyProductUserExternalAccountByAccountTypeOptions()
	{
	}
}
