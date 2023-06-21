using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Conditions;

public class CheckStaticCSharpEvent : ConditionTask
{
	private Type targetType;

	private string eventName;

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
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
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
	public CheckStaticCSharpEvent()
	{
	}
}
public class CheckStaticCSharpEvent<T> : ConditionTask
{
	private Type targetType;

	private string eventName;

	private BBParameter<T> saveAs;

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
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
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
	public CheckStaticCSharpEvent()
	{
	}
}
