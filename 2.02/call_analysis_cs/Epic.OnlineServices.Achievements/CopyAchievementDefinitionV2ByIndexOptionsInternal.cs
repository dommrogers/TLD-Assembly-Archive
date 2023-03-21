using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 8)]
internal struct CopyAchievementDefinitionV2ByIndexOptionsInternal : ISettable, IDisposable
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Set(CopyAchievementDefinitionV2ByIndexOptions other)
	{
	}

	[CalledBy(Type = typeof(AchievementsInterface), Member = "CopyAchievementDefinitionV2ByIndex")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
