using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

public class UnlockedAchievement : ISettable
{
	private string _003CAchievementId_003Ek__BackingField;

	private DateTimeOffset? _003CUnlockTime_003Ek__BackingField;

	public string AchievementId
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

	public DateTimeOffset? UnlockTime
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnlockedAchievementInternal), Member = "get_AchievementId")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CalledBy(Type = typeof(UnlockedAchievement), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	internal void Set(UnlockedAchievementInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnlockedAchievement), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public UnlockedAchievement()
	{
	}
}
