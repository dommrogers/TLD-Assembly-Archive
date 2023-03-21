using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace DataPlatform;

public class AchievementRewardList : WrappedCachedList<AchievementReward>
{
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AchievementRewardList(IntPtr self)
	{
		((WrappedCachedList<>)(object)this)._002Ector(default(IntPtr));
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AchievementRewardList()
	{
		((WrappedCachedList<>)(object)this)._002Ector(default(IntPtr));
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~AchievementRewardList()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override AchievementReward CreateIthElement(int i)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override void SetupLength()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected override void DisposeChild()
	{
	}
}
