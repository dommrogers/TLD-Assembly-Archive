using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct GetPlayerAchievementCountOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_UserId;

	public ProductUserId UserId
	{
		[CalledBy(Type = typeof(GetPlayerAchievementCountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetPlayerAchievementCountOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetPlayerAchievementCountOptionsInternal), Member = "set_UserId")]
	public void Set(GetPlayerAchievementCountOptions other)
	{
	}

	[CalledBy(Type = typeof(AchievementsInterface), Member = "GetPlayerAchievementCount")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GetPlayerAchievementCountOptionsInternal), Member = "set_UserId")]
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
