using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Ecom;

public class CopyOfferByIndexOptions
{
	private EpicAccountId _003CLocalUserId_003Ek__BackingField;

	private uint _003COfferIndex_003Ek__BackingField;

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

	public uint OfferIndex
	{
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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
	public CopyOfferByIndexOptions()
	{
	}
}
