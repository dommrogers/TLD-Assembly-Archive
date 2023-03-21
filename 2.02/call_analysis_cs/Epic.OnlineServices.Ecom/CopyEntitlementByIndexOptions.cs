using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

public class CopyEntitlementByIndexOptions
{
	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	private uint _003CEntitlementIndex_003Ek__BackingField;

	public EpicAccountId LocalUserId
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

	public uint EntitlementIndex
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return default(uint);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public CopyEntitlementByIndexOptions()
	{
	}
}
