using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyUnlockedAchievementByAchievementIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_UserId;

	private IntPtr m_AchievementId;

	public ProductUserId UserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyUnlockedAchievementByAchievementIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyUnlockedAchievementByAchievementIdOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string AchievementId
	{
		[CalledBy(Type = typeof(CopyUnlockedAchievementByAchievementIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyUnlockedAchievementByAchievementIdOptionsInternal), Member = "Set")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyUnlockedAchievementByAchievementIdOptionsInternal), Member = "set_UserId")]
	[Calls(Type = typeof(CopyUnlockedAchievementByAchievementIdOptionsInternal), Member = "set_AchievementId")]
	public void Set(CopyUnlockedAchievementByAchievementIdOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CopyUnlockedAchievementByAchievementIdOptionsInternal), Member = "set_UserId")]
	[Calls(Type = typeof(CopyUnlockedAchievementByAchievementIdOptionsInternal), Member = "set_AchievementId")]
	[CalledBy(Type = typeof(AchievementsInterface), Member = "CopyUnlockedAchievementByAchievementId")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
