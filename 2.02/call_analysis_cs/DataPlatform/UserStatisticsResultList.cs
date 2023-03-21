using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace DataPlatform;

public class UserStatisticsResultList : WrappedCachedList<UserStatisticsResult>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public UserStatisticsResultList(IntPtr self)
	{
		((WrappedCachedList<>)(object)this)._002Ector((IntPtr)0);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WrappedCachedList<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public UserStatisticsResultList()
	{
		((WrappedCachedList<>)(object)this)._002Ector((IntPtr)0);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~UserStatisticsResultList()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	protected override UserStatisticsResult CreateIthElement(int i)
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
