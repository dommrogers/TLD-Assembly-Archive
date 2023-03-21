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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyPlayerAchievementByIndexOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyPlayerAchievementByIndexOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	public uint AchievementIndex
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyPlayerAchievementByIndexOptionsInternal), Member = "set_UserId")]
	public void Set(CopyPlayerAchievementByIndexOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CopyPlayerAchievementByIndexOptionsInternal), Member = "set_UserId")]
	[CalledBy(Type = typeof(AchievementsInterface), Member = "CopyPlayerAchievementByIndex")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
