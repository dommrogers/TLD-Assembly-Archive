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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(GetPlayerAchievementCountOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(GetPlayerAchievementCountOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(GetPlayerAchievementCountOptionsInternal), Member = "set_UserId")]
	[CallerCount(Count = 0)]
	public void Set(GetPlayerAchievementCountOptions other)
	{
	}

	[CalledBy(Type = typeof(AchievementsInterface), Member = "GetPlayerAchievementCount")]
	[Calls(Type = typeof(GetPlayerAchievementCountOptionsInternal), Member = "set_UserId")]
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
