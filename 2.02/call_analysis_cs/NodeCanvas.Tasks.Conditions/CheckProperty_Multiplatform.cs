using System;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Serialization;

namespace NodeCanvas.Tasks.Conditions;

public class CheckProperty_Multiplatform : ConditionTask
{
	protected SerializedMethodInfo method;

	protected BBObjectParameter checkValue;

	protected CompareMethod comparison;

	private MethodInfo targetMethod
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public override Type agentType
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
		get
		{
			return null;
		}
	}

	protected override string info
	{
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "get_agentInfo")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(CheckProperty_Multiplatform), Member = "SetMethod")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Task), Member = "Error")]
	[CallsUnknownMethods(Count = 2)]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override string OnInit()
	{
		return null;
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(OperationTools), Member = "Compare")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 17)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(BBObjectParameter), Member = "SetType")]
	[CalledBy(Type = typeof(CheckProperty_Multiplatform), Member = "OnValidate")]
	[CallsUnknownMethods(Count = 9)]
	private void SetMethod(MethodInfo method)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CheckProperty_Multiplatform()
	{
	}
}
