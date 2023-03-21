using System;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Actions;

public class GetProperty : ActionTask, ISubParametersContainer
{
	protected ReflectedFunctionWrapper functionWrapper;

	private MethodInfo targetMethod
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public override Type agentType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Task), Member = "get_agentInfo")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
		[CallsDeduplicatedMethods(Count = 4)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReflectedFunctionWrapper), Member = "Create")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Task), Member = "Error")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	protected override string OnInit()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ReflectedFunctionWrapper), Member = "Create")]
	private void SetMethod(MethodInfo method)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GetProperty()
	{
	}
}
