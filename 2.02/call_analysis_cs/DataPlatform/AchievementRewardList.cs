using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace DataPlatform;

public class AchievementRewardList : WrappedCachedList<AchievementReward>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AchievementRewardList(IntPtr self)
	{
		((WrappedCachedList<>)(object)this)._002Ector((IntPtr)0);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WrappedCachedList<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public AchievementRewardList()
	{
		((WrappedCachedList<>)(object)this)._002Ector((IntPtr)0);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~AchievementRewardList()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	protected override AchievementReward CreateIthElement(int i)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void SetupLength()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected override void DisposeChild()
	{
	}
}
