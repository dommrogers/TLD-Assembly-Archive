using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Conditions;

public class CheckCSharpEventValue<T> : ConditionTask
{
	private Type targetType;

	private string eventName;

	private BBParameter<T> checkValue;

	public override Type agentType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetEvent")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTCreateDelegate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	protected override string OnInit()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ConditionTask), Member = "Flip")]
	[Calls(Type = typeof(Task), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 1)]
	public CheckCSharpEventValue()
	{
	}
}
