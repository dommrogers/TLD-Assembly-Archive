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
		[CalledBy(Type = typeof(CopyAchievementDefinitionByAchievementIdOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CopyAchievementDefinitionByAchievementIdOptionsInternal), Member = "set_AchievementId")]
	public void Set(CopyAchievementDefinitionByAchievementIdOptions other)
	{
	}

	[CalledBy(Type = typeof(AchievementsInterface), Member = "CopyAchievementDefinitionByAchievementId")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CopyAchievementDefinitionByAchievementIdOptionsInternal), Member = "set_AchievementId")]
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
