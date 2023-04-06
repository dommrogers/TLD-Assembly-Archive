using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine.Events;

namespace NodeCanvas.Tasks.Conditions;

public class CheckUnityEvent : ConditionTask
{
	private Type targetType;

	private string eventName;

	public override Type agentType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		get
		{
			return null;
		}
	}

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
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetField")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	protected override string OnInit()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	public void Raised()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	protected override bool OnCheck()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CheckUnityEvent()
	{
	}
}
public class CheckUnityEvent<T> : ConditionTask
{
	private Type targetType;

	private string eventName;

	private BBParameter<T> saveAs;

	public override Type agentType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		get
		{
			return null;
		}
	}

	protected override string info
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format")]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetField")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	protected override string OnInit()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Raised(T eventValue)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	protected override bool OnCheck()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CheckUnityEvent()
	{
	}
}
