using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Lobby;

public class LobbyDetailsCopyMemberAttributeByIndexOptions
{
	private ProductUserId _003CTargetUserId_003Ek__BackingField;

	private uint _003CAttrIndex_003Ek__BackingField;

	public ProductUserId TargetUserId
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

	public uint AttrIndex
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
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
	public LobbyDetailsCopyMemberAttributeByIndexOptions()
	{
	}
}
