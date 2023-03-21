using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyUnlockedAchievementByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_UserId;

	private uint m_AchievementIndex;

	public ProductUserId UserId
	{
		[CalledBy(Type = typeof(CopyUnlockedAchievementByIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyUnlockedAchievementByIndexOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		set
		{
		}
	}

	public uint AchievementIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyUnlockedAchievementByIndexOptionsInternal), Member = "set_UserId")]
	public void Set(CopyUnlockedAchievementByIndexOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CopyUnlockedAchievementByIndexOptionsInternal), Member = "set_UserId")]
	[CalledBy(Type = typeof(AchievementsInterface), Member = "CopyUnlockedAchievementByIndex")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
