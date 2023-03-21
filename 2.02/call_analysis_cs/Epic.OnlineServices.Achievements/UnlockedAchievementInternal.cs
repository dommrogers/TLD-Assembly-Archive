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
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(UnlockedAchievement), Member = "Set")]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(UnlockedAchievementInternal), Member = "Set")]
		[CalledBy(Type = typeof(UnlockedAchievementInternal), Member = "Set")]
		set
		{
		}
	}

	public DateTimeOffset? UnlockTime
	{
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(UnlockedAchievementInternal), Member = "Set")]
		[CalledBy(Type = typeof(UnlockedAchievementInternal), Member = "Set")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnlockedAchievementInternal), Member = "set_AchievementId")]
	[Calls(Type = typeof(UnlockedAchievementInternal), Member = "set_UnlockTime")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
