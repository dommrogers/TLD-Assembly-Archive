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

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal Type _003CCreate_003Eb__0_0(ParameterInfo p)
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(CheckFunction), Member = "SetMethod")]
	[CalledBy(Type = typeof(CheckProperty), Member = "SetMethod")]
	[CalledBy(Type = typeof(GetProperty), Member = "OnValidate")]
	[CalledBy(Type = typeof(ReflectedWrapper), Member = "Create")]
	[CalledBy(Type = typeof(ImplementedAction), Member = "OnValidate")]
	[CalledBy(Type = typeof(ImplementedAction), Member = "SetMethod")]
	[CallsUnknownMethods(Count = 34)]
	[CalledBy(Type = typeof(GetProperty), Member = "SetMethod")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	public new static ReflectedFunctionWrapper Create(MethodInfo method, IBlackboard bb)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract object Call();

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected ReflectedFunctionWrapper()
	{
	}
}
