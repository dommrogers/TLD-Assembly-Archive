using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_WaterCookingState : ConditionTask
{
	public LiquidQuality waterQuality;

	public CookingPotItem.CookingState targetState;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_WaterCookingState()
	{
	}
}
