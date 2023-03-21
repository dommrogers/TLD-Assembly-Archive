using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

public class PlayerAchievement : ISettable
{
	private string _003CAchievementId_003Ek__BackingField;

	private double _003CProgress_003Ek__BackingField;

	private DateTimeOffset? _003CUnlockTime_003Ek__BackingField;

	private PlayerStatInfo[] _003CStatInfo_003Ek__BackingField;

	private string _003CDisplayName_003Ek__BackingField;

	private string _003CDescription_003Ek__BackingField;

	private string _003CIconURL_003Ek__BackingField;

	private string _003CFlavorText_003Ek__BackingField;

	public string AchievementId
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

	public double Progress
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0.0;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
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

	public PlayerStatInfo[] StatInfo
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
		[CallerCount(Count = 18)]
		set
		{
		}
	}

	public string DisplayName
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
		[CallerCount(Count = 46)]
		set
		{
		}
	}

	public string Description
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 19)]
		set
		{
		}
	}

	public string IconURL
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 18)]
		set
		{
		}
	}

	public string FlavorText
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 16)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(PlayerAchievement), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "get_AchievementId")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "get_StatInfo")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "get_DisplayName")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "get_Description")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "get_IconURL")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "get_FlavorText")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	internal void Set(PlayerAchievementInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAchievement), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public PlayerAchievement()
	{
	}
}
