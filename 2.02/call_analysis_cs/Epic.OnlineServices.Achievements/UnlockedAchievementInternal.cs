using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct UnlockedAchievementInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_AchievementId;

	private long m_UnlockTime;

	public string AchievementId
	{
		[CalledBy(Type = typeof(UnlockedAchievement), Member = "Set")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(UnlockedAchievementInternal), Member = "Set")]
		[CalledBy(Type = typeof(UnlockedAchievementInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CalledBy(Type = typeof(UnlockedAchievementInternal), Member = "Set")]
		[CalledBy(Type = typeof(UnlockedAchievementInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnlockedAchievementInternal), Member = "set_AchievementId")]
	[Calls(Type = typeof(UnlockedAchievementInternal), Member = "set_UnlockTime")]
	public void Set(UnlockedAchievement other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnlockedAchievementInternal), Member = "set_AchievementId")]
	[Calls(Type = typeof(UnlockedAchievementInternal), Member = "set_UnlockTime")]
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
