using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct CopyAchievementDefinitionV2ByAchievementIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_AchievementId;

	public string AchievementId
	{
		[CalledBy(Type = typeof(CopyAchievementDefinitionV2ByAchievementIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyAchievementDefinitionV2ByAchievementIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyAchievementDefinitionV2ByAchievementIdOptionsInternal), Member = "set_AchievementId")]
	public void Set(CopyAchievementDefinitionV2ByAchievementIdOptions other)
	{
	}

	[CalledBy(Type = typeof(AchievementsInterface), Member = "CopyAchievementDefinitionV2ByAchievementId")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyAchievementDefinitionV2ByAchievementIdOptionsInternal), Member = "set_AchievementId")]
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
