using System;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Conditions;

public class CheckField : ConditionTask
{
	protected BBParameter checkValue;

	protected Type targetType;

	protected string fieldName;

	protected CompareMethod comparison;

	private FieldInfo field;

	public override Type agentType
	{
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	protected override string info
	{
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(Task), Member = "get_agentInfo")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetField")]
	[CallerCount(Count = 0)]
	protected override string OnInit()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(OperationTools), Member = "Compare")]
	[CallsUnknownMethods(Count = 16)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CheckField()
	{
	}
}
