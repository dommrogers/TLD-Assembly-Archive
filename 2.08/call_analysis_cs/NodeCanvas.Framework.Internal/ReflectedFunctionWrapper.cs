using System;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;

namespace NodeCanvas.Framework.Internal;

public abstract class ReflectedFunctionWrapper : ReflectedWrapper
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ParameterInfo, Type> _003C_003E9__0_0;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal Type _003CCreate_003Eb__0_0(ParameterInfo p)
		{
			return null;
		}
	}

	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(ImplementedAction), Member = "SetMethod")]
	[CalledBy(Type = typeof(ImplementedAction), Member = "OnValidate")]
	[CalledBy(Type = typeof(GetProperty), Member = "SetMethod")]
	[CalledBy(Type = typeof(GetProperty), Member = "OnValidate")]
	[CalledBy(Type = typeof(CheckProperty), Member = "SetMethod")]
	[CalledBy(Type = typeof(CheckProperty), Member = "OnValidate")]
	[CalledBy(Type = typeof(CheckFunction), Member = "SetMethod")]
	[CalledBy(Type = typeof(CheckFunction), Member = "OnValidate")]
	[CalledBy(Type = typeof(ReflectedWrapper), Member = "Create")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	public new static ReflectedFunctionWrapper Create(MethodInfo method, IBlackboard bb)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract object Call();

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected ReflectedFunctionWrapper()
	{
	}
}
