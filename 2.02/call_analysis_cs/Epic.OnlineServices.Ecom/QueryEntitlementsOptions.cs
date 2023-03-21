using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

public class QueryEntitlementsOptions
{
	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	private string[] _003CEntitlementNames_003Ek__BackingField;

	private bool _003CIncludeRedeemed_003Ek__BackingField;

	public EpicAccountId LocalUserId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CallerCount(Count = 101)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	public string[] EntitlementNames
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

	public bool IncludeRedeemed
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public QueryEntitlementsOptions()
	{
	}
}
