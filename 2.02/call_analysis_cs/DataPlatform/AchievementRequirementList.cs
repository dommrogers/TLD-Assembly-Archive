using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace DataPlatform;

public class AchievementRequirementList : WrappedCachedList<AchievementRequirement>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AchievementRequirementList(IntPtr self)
	{
		((WrappedCachedList<>)(object)this)._002Ector(default(IntPtr));
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AchievementRequirementList()
	{
		((WrappedCachedList<>)(object)this)._002Ector(default(IntPtr));
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	~AchievementRequirementList()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	protected override AchievementRequirement CreateIthElement(int i)
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
