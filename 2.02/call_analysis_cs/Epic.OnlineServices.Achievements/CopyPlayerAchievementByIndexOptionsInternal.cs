using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct CopyPlayerAchievementByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_UserId;

	private uint m_AchievementIndex;

	public ProductUserId UserId
	{
		[CalledBy(Type = typeof(CopyPlayerAchievementByIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyPlayerAchievementByIndexOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(CopyPlayerAchievementByIndexOptionsInternal), Member = "set_UserId")]
	public void Set(CopyPlayerAchievementByIndexOptions other)
	{
	}

	[CalledBy(Type = typeof(AchievementsInterface), Member = "CopyPlayerAchievementByIndex")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyPlayerAchievementByIndexOptionsInternal), Member = "set_UserId")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Dispose()
	{
	}
}
