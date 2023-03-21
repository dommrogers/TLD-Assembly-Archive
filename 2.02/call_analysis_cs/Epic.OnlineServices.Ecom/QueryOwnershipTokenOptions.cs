using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

public class QueryOwnershipTokenOptions
{
	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	private string[] _003CCatalogItemIds_003Ek__BackingField;

	private string _003CCatalogNamespace_003Ek__BackingField;

	public EpicAccountId LocalUserId
	{
		[CallerCount(Count = 52)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	public string[] CatalogItemIds
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

	public string CatalogNamespace
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CallerCount(Count = 41)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public QueryOwnershipTokenOptions()
	{
	}
}
