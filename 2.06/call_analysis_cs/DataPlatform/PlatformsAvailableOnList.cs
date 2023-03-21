using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace DataPlatform;

public class PlatformsAvailableOnList : WrappedCachedList<string>
{
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public PlatformsAvailableOnList(IntPtr self)
	{
		((WrappedCachedList<>)(object)this)._002Ector(default(IntPtr));
	}

	[CallerCount(Count = 0)]
	public PlatformsAvailableOnList()
	{
		((WrappedCachedList<>)(object)this)._002Ector(default(IntPtr));
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~PlatformsAvailableOnList()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected override string CreateIthElement(int i)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void SetupLength()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void DisposeChild()
	{
	}
}
