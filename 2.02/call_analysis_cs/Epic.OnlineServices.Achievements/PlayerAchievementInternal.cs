using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 80)]
internal struct PlayerAchievementInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_AchievementId;

	private double m_Progress;

	private long m_UnlockTime;

	private int m_StatInfoCount;

	private IntPtr m_StatInfo;

	private IntPtr m_DisplayName;

	private IntPtr m_Description;

	private IntPtr m_IconURL;

	private IntPtr m_FlavorText;

	public string AchievementId
	{
		[CalledBy(Type = typeof(PlayerAchievement), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(PlayerAchievementInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public double Progress
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0.0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public DateTimeOffset? UnlockTime
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(PlayerAchievementInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public PlayerStatInfo[] StatInfo
	{
		[CalledBy(Type = typeof(PlayerAchievement), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 5)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(PlayerAchievementInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public string DisplayName
	{
		[CalledBy(Type = typeof(PlayerAchievement), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(PlayerAchievementInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string Description
	{
		[CalledBy(Type = typeof(PlayerAchievement), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(PlayerAchievementInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string IconURL
	{
		[CalledBy(Type = typeof(PlayerAchievement), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(PlayerAchievementInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string FlavorText
	{
		[CalledBy(Type = typeof(PlayerAchievement), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(PlayerAchievementInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(PlayerAchievementInternal), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "set_AchievementId")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "set_UnlockTime")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "set_StatInfo")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "set_DisplayName")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "set_Description")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "set_IconURL")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "set_FlavorText")]
	public void Set(PlayerAchievement other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
