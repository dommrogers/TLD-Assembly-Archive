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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(StatsManager.SetStatDelegate), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(StatsManager.SetStatDelegate), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	protected override void OnStop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[CallsUnknownMethods(Count = 2)]
	private void OnIncrementStat(StatID id, float amount)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[CallsUnknownMethods(Count = 2)]
	private void OnSetStat(StatID id, float previous, float current)
	{
	}

	[CallerCount(Count = 0)]
	public Action_TrackStat()
	{
	}
}
