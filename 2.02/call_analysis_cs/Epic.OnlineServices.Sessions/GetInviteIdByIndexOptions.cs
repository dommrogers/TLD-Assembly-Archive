using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Sessions;

public class GetInviteIdByIndexOptions
{
	private ProductUserId _003CLocalUserId_003Ek__BackingField;

	private uint _003CIndex_003Ek__BackingField;

	public ProductUserId LocalUserId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		[CompilerGenerated]
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

	public uint Index
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public GetInviteIdByIndexOptions()
	{
	}
}
