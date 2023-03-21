using System;
using System.Collections.Generic;
using System.Linq;
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

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
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
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "get_agentInfo")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Task), Member = "Error")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ImplementedAction_Multiplatform), Member = "SetMethod")]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	protected override string OnInit()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	protected override void OnStop()
	{
	}

	[Calls(Type = typeof(BBParameter), Member = "ResolveReference")]
	[CalledBy(Type = typeof(ImplementedAction_Multiplatform), Member = "OnValidate")]
	[Calls(Type = typeof(BBObjectParameter), Member = "SetType")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void SetMethod(MethodInfo method)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public ImplementedAction_Multiplatform()
	{
	}
}
