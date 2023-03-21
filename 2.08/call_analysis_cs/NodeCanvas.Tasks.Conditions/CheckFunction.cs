using System;
using System.Reflection;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Conditions;

public class CheckFunction : ConditionTask, ISubParametersContainer
{
	protected ReflectedFunctionWrapper functionWrapper;

	protected BBParameter checkValue;

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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
		get
		{
			return null;
		}
	}

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 10)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		[Calls(Type = typeof(OperationTools), Member = "GetCompareString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(System.Text.StringBuilderCache), Member = "Acquire")]
		[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper")]
		[Calls(Type = typeof(System.Text.StringBuilderCache), Member = "Release")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 28)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private BBParameter[] NodeCanvas_002EFramework_002EISubParametersContainer_002EGetSubParameters()
	{
		return null;
	}

	[Calls(Type = typeof(Task), Member = "Error")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(BBParameter), Member = "CreateInstance")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectedFunctionWrapper), Member = "Create")]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override string OnInit()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BBParameter), Member = "CreateInstance")]
	[Calls(Type = typeof(ReflectedFunctionWrapper), Member = "Create")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SetMethod(MethodInfo method)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CheckFunction()
	{
	}
}
