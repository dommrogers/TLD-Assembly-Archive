using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

public class CopyLeaderboardDefinitionByIndexOptions
{
	private uint _003CLeaderboardIndex_003Ek__BackingField;

	public uint LeaderboardIndex
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return 0u;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public CopyLeaderboardDefinitionByIndexOptions()
	{
	}
}
