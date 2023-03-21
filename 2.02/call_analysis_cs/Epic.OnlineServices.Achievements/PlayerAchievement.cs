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

	public double Progress
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(double);
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
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 41)]
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
		[CallerCount(Count = 17)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public string IconURL
	{
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 14)]
		set
		{
		}
	}

	public string FlavorText
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 10)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 15)]
		set
		{
		}
	}

	[Calls(Type = typeof(PlayerAchievementInternal), Member = "get_IconURL")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "get_FlavorText")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "get_StatInfo")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerAchievement), Member = "Set")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "get_Description")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "get_AchievementId")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "get_DisplayName")]
	[CallsDeduplicatedMethods(Count = 2)]
	internal void Set(PlayerAchievementInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAchievement), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PlayerAchievement()
	{
	}
}
