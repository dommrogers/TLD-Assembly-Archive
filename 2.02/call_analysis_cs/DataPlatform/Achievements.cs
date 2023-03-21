using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace DataPlatform;

public class Achievements : WrappedCachedList<Achievement>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Achievements(IntPtr self)
	{
		((WrappedCachedList<>)(object)this)._002Ector(default(IntPtr));
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Achievements()
	{
		((WrappedCachedList<>)(object)this)._002Ector(default(IntPtr));
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	protected override Achievement CreateIthElement(int i)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected override void SetupLength()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected override void DisposeChild()
	{
	}
}
