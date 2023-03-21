using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Connect;

public class QueryProductUserIdMappingsOptions
{
	private ProductUserId _003CLocalUserId_003Ek__BackingField;

	private ExternalAccountType _003CAccountIdType_DEPRECATED_003Ek__BackingField;

	private ProductUserId[] _003CProductUserIds_003Ek__BackingField;

	public ProductUserId LocalUserId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		[CompilerGenerated]
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

	public ExternalAccountType AccountIdType_DEPRECATED
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
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

	public ProductUserId[] ProductUserIds
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

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public QueryProductUserIdMappingsOptions()
	{
	}
}
