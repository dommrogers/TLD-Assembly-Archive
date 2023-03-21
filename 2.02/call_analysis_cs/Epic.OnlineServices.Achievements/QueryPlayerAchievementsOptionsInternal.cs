using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct QueryPlayerAchievementsOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_UserId;

	public ProductUserId UserId
	{
		[CalledBy(Type = typeof(QueryPlayerAchievementsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(QueryPlayerAchievementsOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(QueryPlayerAchievementsOptionsInternal), Member = "set_UserId")]
	[CallerCount(Count = 0)]
	public void Set(QueryPlayerAchievementsOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QueryPlayerAchievementsOptionsInternal), Member = "set_UserId")]
	[CalledBy(Type = typeof(AchievementsInterface), Member = "QueryPlayerAchievements")]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Dispose()
	{
	}
}
