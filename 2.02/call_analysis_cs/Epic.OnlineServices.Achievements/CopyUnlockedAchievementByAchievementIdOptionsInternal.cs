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
		[CalledBy(Type = typeof(CopyUnlockedAchievementByAchievementIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyUnlockedAchievementByAchievementIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string AchievementId
	{
		[CalledBy(Type = typeof(CopyUnlockedAchievementByAchievementIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyUnlockedAchievementByAchievementIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(AchievementsInterface), Member = "CopyUnlockedAchievementByAchievementId")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyUnlockedAchievementByAchievementIdOptionsInternal), Member = "set_UserId")]
	[Calls(Type = typeof(CopyUnlockedAchievementByAchievementIdOptionsInternal), Member = "set_AchievementId")]
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
