using System;
using System.Reflection;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Actions;

public class ExecuteStaticFunction : ActionTask, ISubParametersContainer
{
	protected ReflectedWrapper functionWrapper;

	private MethodInfo targetMethod
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	protected override string info
	{
		[CallsUnknownMethods(Count = 28)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(System.Text.StringBuilderCache), Member = "Release")]
		[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper")]
		[Calls(Type = typeof(System.Text.StringBuilderCache), Member = "Acquire")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Task), Member = "Error")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectedWrapper), Member = "Create")]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 1)]
	protected override string OnInit()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(ReflectedWrapper), Member = "Create")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void SetMethod(MethodInfo method)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ExecuteStaticFunction()
	{
	}
}
