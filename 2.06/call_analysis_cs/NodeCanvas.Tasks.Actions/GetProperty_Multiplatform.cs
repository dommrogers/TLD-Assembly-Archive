using System;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Serialization;

namespace NodeCanvas.Tasks.Actions;

public class GetProperty_Multiplatform : ActionTask
{
	protected SerializedMethodInfo method;

	protected BBObjectParameter returnValue;

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
		get
		{
			return null;
		}
	}

	protected override string info
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(Task), Member = "get_agentInfo")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GetProperty_Multiplatform), Member = "SetMethod")]
	[Calls(Type = typeof(Task), Member = "Error")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override string OnInit()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BBObjectParameter), Member = "SetType")]
	[CalledBy(Type = typeof(GetProperty_Multiplatform), Member = "OnValidate")]
	[CallsUnknownMethods(Count = 6)]
	private void SetMethod(MethodInfo method)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GetProperty_Multiplatform()
	{
	}
}
