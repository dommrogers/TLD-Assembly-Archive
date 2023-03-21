using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.Stats;

namespace NodeCanvas.Tasks.Actions;

public class Action_TrackStat : ActionTask
{
	public StatID Stat;

	public float UnitScale;

	public BBParameter<float> StoreValue;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(StatsManager.SetStatDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(StatsManager.SetStatDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 5)]
	protected override void OnStop()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	[CallerCount(Count = 0)]
	private void OnIncrementStat(StatID id, float amount)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	[CallsUnknownMethods(Count = 3)]
	private void OnSetStat(StatID id, float previous, float current)
	{
	}

	[CallerCount(Count = 0)]
	public Action_TrackStat()
	{
	}
}
