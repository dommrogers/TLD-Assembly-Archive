using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Leaderboards;

public class LeaderboardRecord : ISettable
{
	private ProductUserId _003CUserId_003Ek__BackingField;

	private uint _003CRank_003Ek__BackingField;

	private int _003CScore_003Ek__BackingField;

	private string _003CUserDisplayName_003Ek__BackingField;

	public ProductUserId UserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		set
		{
		}
	}

	public uint Rank
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
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

	public int Score
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string UserDisplayName
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(LeaderboardRecord), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LeaderboardRecordInternal), Member = "get_UserId")]
	[Calls(Type = typeof(LeaderboardRecordInternal), Member = "get_UserDisplayName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void Set(LeaderboardRecordInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LeaderboardRecord), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public LeaderboardRecord()
	{
	}
}
