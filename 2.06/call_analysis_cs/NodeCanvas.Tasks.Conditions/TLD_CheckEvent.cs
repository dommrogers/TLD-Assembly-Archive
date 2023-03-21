using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Conditions;

public class TLD_CheckEvent : ConditionTask<GraphOwner>
{
	public BBParameter<string> eventName;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[CallerCount(Count = 0)]
	public TLD_CheckEvent()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
public class TLD_CheckEvent<T> : ConditionTask<GraphOwner>
{
	public BBParameter<string> eventName;

	public BBParameter<T> saveEventValue;

	protected override string info
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TLD_CheckEvent()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
