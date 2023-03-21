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
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Task), Member = "StartCoroutine")]
	[Calls(Type = typeof(ConditionTask), Member = "Flip")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(ConditionTask), Member = "Flip")]
	[Calls(Type = typeof(Task), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 14)]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public TLD_CheckEvent()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
