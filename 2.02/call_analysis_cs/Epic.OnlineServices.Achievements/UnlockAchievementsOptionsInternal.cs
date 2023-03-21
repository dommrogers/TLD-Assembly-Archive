using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 32)]
internal struct UnlockAchievementsOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_UserId;

	private IntPtr m_AchievementIds;

	private uint m_AchievementsCount;

	public ProductUserId UserId
	{
		[CalledBy(Type = typeof(UnlockAchievementsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(UnlockAchievementsOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public string[] AchievementIds
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(UnlockAchievementsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(UnlockAchievementsOptionsInternal), Member = "Set")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnlockAchievementsOptionsInternal), Member = "set_UserId")]
	[Calls(Type = typeof(UnlockAchievementsOptionsInternal), Member = "set_AchievementIds")]
	public void Set(UnlockAchievementsOptions other)
	{
	}

	[Calls(Type = typeof(UnlockAchievementsOptionsInternal), Member = "set_AchievementIds")]
	[Calls(Type = typeof(UnlockAchievementsOptionsInternal), Member = "set_UserId")]
	[CalledBy(Type = typeof(AchievementsInterface), Member = "UnlockAchievements")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
