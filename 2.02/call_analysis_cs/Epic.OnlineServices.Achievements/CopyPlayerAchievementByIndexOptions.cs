using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

public class CopyPlayerAchievementByIndexOptions
{
	private ProductUserId _003CUserId_003Ek__BackingField;

	private uint _003CAchievementIndex_003Ek__BackingField;

	public ProductUserId UserId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
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

	public uint AchievementIndex
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
	public CopyPlayerAchievementByIndexOptions()
	{
	}
}
