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
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(StatsManager.SetStatDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 15)]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(StatsManager.SetStatDelegate), Member = ".ctor")]
	[CallsUnknownMethods(Count = 15)]
	protected override void OnStop()
	{
	}

	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	private void OnIncrementStat(StatID id, float amount)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	private void OnSetStat(StatID id, float previous, float current)
	{
	}

	[CallerCount(Count = 0)]
	public Action_TrackStat()
	{
	}
}
