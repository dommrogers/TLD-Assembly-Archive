using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 8)]
internal struct CopyAchievementDefinitionByIndexOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private uint m_AchievementIndex;

	public uint AchievementIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Set(CopyAchievementDefinitionByIndexOptions other)
	{
	}

	[CalledBy(Type = typeof(AchievementsInterface), Member = "CopyAchievementDefinitionByIndex")]
	[CallerCount(Count = 1)]
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
