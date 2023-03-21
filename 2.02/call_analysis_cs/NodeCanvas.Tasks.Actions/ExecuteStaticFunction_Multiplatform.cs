using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Serialization;

namespace NodeCanvas.Tasks.Actions;

public class ExecuteStaticFunction_Multiplatform : ActionTask
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<BBObjectParameter, object> _003C_003E9__9_0;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal object _003COnExecute_003Eb__9_0(BBObjectParameter p)
		{
			return null;
		}
	}

	protected SerializedMethodInfo method;

	protected List<BBObjectParameter> parameters;

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

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 8)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsUnknownMethods(Count = 25)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Task), Member = "Error")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ExecuteStaticFunction_Multiplatform), Member = "SetMethod")]
	[CallerCount(Count = 0)]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 1)]
	protected override string OnInit()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 9)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(ExecuteStaticFunction_Multiplatform), Member = "OnValidate")]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[Calls(Type = typeof(BBObjectParameter), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(BBObjectParameter), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	private void SetMethod(MethodInfo method)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public ExecuteStaticFunction_Multiplatform()
	{
	}
}
