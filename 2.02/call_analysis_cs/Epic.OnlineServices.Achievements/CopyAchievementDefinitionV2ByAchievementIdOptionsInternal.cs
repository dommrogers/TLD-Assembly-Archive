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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyAchievementDefinitionV2ByAchievementIdOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(CopyAchievementDefinitionV2ByAchievementIdOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyAchievementDefinitionV2ByAchievementIdOptionsInternal), Member = "set_AchievementId")]
	public void Set(CopyAchievementDefinitionV2ByAchievementIdOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CopyAchievementDefinitionV2ByAchievementIdOptionsInternal), Member = "set_AchievementId")]
	[CalledBy(Type = typeof(AchievementsInterface), Member = "CopyAchievementDefinitionV2ByAchievementId")]
	public void Set(object other)
	{
	}

	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
