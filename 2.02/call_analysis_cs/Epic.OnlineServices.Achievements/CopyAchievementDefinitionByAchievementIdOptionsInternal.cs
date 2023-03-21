using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 16)]
internal struct CopyAchievementDefinitionByAchievementIdOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_AchievementId;

	public string AchievementId
	{
		[CalledBy(Type = typeof(CopyAchievementDefinitionByAchievementIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CalledBy(Type = typeof(CopyAchievementDefinitionByAchievementIdOptionsInternal), Member = "Set")]
		set
		{
		}
	}

	[Calls(Type = typeof(CopyAchievementDefinitionByAchievementIdOptionsInternal), Member = "set_AchievementId")]
	[CallerCount(Count = 0)]
	public void Set(CopyAchievementDefinitionByAchievementIdOptions other)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CopyAchievementDefinitionByAchievementIdOptionsInternal), Member = "set_AchievementId")]
	[CalledBy(Type = typeof(AchievementsInterface), Member = "CopyAchievementDefinitionByAchievementId")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	public void Dispose()
	{
	}
}
