using System;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace DataPlatform;

public class StatEventList : WrappedCachedList<StatEvent>
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public StatEventList(IntPtr self)
	{
		((WrappedCachedList<>)(object)this)._002Ector(default(IntPtr));
	}

	[CallerCount(Count = 0)]
	public StatEventList()
	{
		((WrappedCachedList<>)(object)this)._002Ector(default(IntPtr));
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~StatEventList()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatsManagerPlugin), Member = "StatsManager_DoWork_GetAt")]
	[Calls(Type = typeof(StatsManagerPlugin), Member = "StatsManager_DoWork_GetAt")]
	[CallsUnknownMethods(Count = 6)]
	protected override StatEvent CreateIthElement(int i)
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override void DisposeChild()
	{
	}
}
