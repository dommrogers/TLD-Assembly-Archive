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

	public uint Rank
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

	public int Score
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
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
		[CallerCount(Count = 5)]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LeaderboardRecordInternal), Member = "get_UserId")]
	[Calls(Type = typeof(LeaderboardRecordInternal), Member = "get_UserDisplayName")]
	[CalledBy(Type = typeof(LeaderboardRecord), Member = "Set")]
	[CallsUnknownMethods(Count = 4)]
	internal void Set(LeaderboardRecordInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LeaderboardRecord), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public LeaderboardRecord()
	{
	}
}
