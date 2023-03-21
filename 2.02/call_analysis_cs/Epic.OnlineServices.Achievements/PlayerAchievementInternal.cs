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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(PlayerAchievementInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 1)]
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
			return default(double);
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(PlayerAchievementInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public PlayerStatInfo[] StatInfo
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 5)]
		[CalledBy(Type = typeof(PlayerAchievement), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(PlayerAchievementInternal), Member = "Set")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public string DisplayName
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(PlayerAchievement), Member = "Set")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(PlayerAchievementInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string Description
	{
		[CalledBy(Type = typeof(PlayerAchievement), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(PlayerAchievementInternal), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string IconURL
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(PlayerAchievement), Member = "Set")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(PlayerAchievementInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public string FlavorText
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(PlayerAchievement), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(PlayerAchievementInternal), Member = "Set")]
		set
		{
		}
	}

	[CalledBy(Type = typeof(PlayerAchievementInternal), Member = "Set")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "set_FlavorText")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "set_IconURL")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "set_Description")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "set_UnlockTime")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "set_StatInfo")]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "set_AchievementId")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "set_DisplayName")]
	public void Set(PlayerAchievement other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerAchievementInternal), Member = "Set")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
