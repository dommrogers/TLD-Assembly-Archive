using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 4)]
internal struct AddNotifyAchievementsUnlockedOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Set(AddNotifyAchievementsUnlockedOptions other)
	{
	}

	[CalledBy(Type = typeof(Helper), Member = "TryMarshalSet")]
	[CalledBy(Type = typeof(AchievementsInterface), Member = "AddNotifyAchievementsUnlocked")]
	[CallerCount(Count = 2)]
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
