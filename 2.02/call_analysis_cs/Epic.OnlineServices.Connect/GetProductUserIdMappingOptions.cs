using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

public class GetProductUserIdMappingOptions
{
	private ProductUserId _003CLocalUserId_003Ek__BackingField;

	private ExternalAccountType _003CAccountIdType_003Ek__BackingField;

	private ProductUserId _003CTargetProductUserId_003Ek__BackingField;

	public ProductUserId LocalUserId
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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return default(ExternalAccountType);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		set
		{
		}
	}

	public ProductUserId TargetProductUserId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public GetProductUserIdMappingOptions()
	{
	}
}
