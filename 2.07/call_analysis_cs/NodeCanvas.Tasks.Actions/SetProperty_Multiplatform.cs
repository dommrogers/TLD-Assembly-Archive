using System;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Serialization;

namespace NodeCanvas.Tasks.Actions;

public class SetProperty_Multiplatform : ActionTask
{
	protected SerializedMethodInfo method;

	protected BBObjectParameter parameter;

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
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		get
		{
			return null;
		}
	}

	protected override string info
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(Task), Member = "get_agentInfo")]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BBObjectParameter), Member = "SetType")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Task), Member = "Error")]
	[CallsUnknownMethods(Count = 2)]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override string OnInit()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(ReflectionTools), Member = "SingleTempArgsArray")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BBObjectParameter), Member = "SetType")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void SetMethod(MethodInfo method)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SetProperty_Multiplatform()
	{
	}
}
