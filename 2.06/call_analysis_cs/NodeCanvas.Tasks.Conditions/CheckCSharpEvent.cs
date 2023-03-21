using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Conditions;

public class CheckCSharpEvent : ConditionTask
{
	private Type targetType;

	private string eventName;

	public override Type agentType
	{
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetEvent")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTCreateDelegate")]
	protected override string OnInit()
	{
		return null;
	}

	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Raised()
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
	public CheckCSharpEvent()
	{
	}
}
public class CheckCSharpEvent<T> : ConditionTask
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
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetEvent")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTCreateDelegate")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	protected override string OnInit()
	{
		return null;
	}

	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Raised(T eventValue)
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
	public CheckCSharpEvent()
	{
	}
}
