using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Serialization;

namespace NodeCanvas.Tasks.Actions;

public class ImplementedAction_Multiplatform : ActionTask
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<BBObjectParameter, object> _003C_003E9__11_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		internal object _003COnUpdate_003Eb__11_0(BBObjectParameter p)
		{
			return null;
		}
	}

	private SerializedMethodInfo method;

	private List<BBObjectParameter> parameters;

	private Status actionStatus;

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
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(Task), Member = "get_agentInfo")]
		[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(ImplementedAction_Multiplatform), Member = "SetMethod")]
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

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	protected override void OnStop()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BBObjectParameter), Member = "SetType")]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[CalledBy(Type = typeof(ImplementedAction_Multiplatform), Member = "OnValidate")]
	private void SetMethod(MethodInfo method)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ImplementedAction_Multiplatform()
	{
	}
}
