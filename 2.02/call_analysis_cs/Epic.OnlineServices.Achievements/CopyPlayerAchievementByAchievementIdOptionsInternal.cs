using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyPlayerAchievementByAchievementIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_UserId;

	private IntPtr m_AchievementId;

	public ProductUserId UserId
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyPlayerAchievementByAchievementIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyPlayerAchievementByAchievementIdOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public string AchievementId
	{
		[CalledBy(Type = typeof(CopyPlayerAchievementByAchievementIdOptionsInternal), Member = "Set")]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyPlayerAchievementByAchievementIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[Calls(Type = typeof(CopyPlayerAchievementByAchievementIdOptionsInternal), Member = "set_AchievementId")]
	[Calls(Type = typeof(CopyPlayerAchievementByAchievementIdOptionsInternal), Member = "set_UserId")]
	[CallerCount(Count = 0)]
	public void Set(CopyPlayerAchievementByAchievementIdOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CopyPlayerAchievementByAchievementIdOptionsInternal), Member = "set_UserId")]
	[Calls(Type = typeof(CopyPlayerAchievementByAchievementIdOptionsInternal), Member = "set_AchievementId")]
	[CalledBy(Type = typeof(AchievementsInterface), Member = "CopyPlayerAchievementByAchievementId")]
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
