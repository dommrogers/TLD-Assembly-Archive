using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

public class CopyPlayerAchievementByAchievementIdOptions
{
	private ProductUserId _003CUserId_003Ek__BackingField;

	private string _003CAchievementId_003Ek__BackingField;

	public ProductUserId UserId
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

	public string AchievementId
	{
		[CallerCount(Count = 29)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 71)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public CopyPlayerAchievementByAchievementIdOptions()
	{
	}
}
