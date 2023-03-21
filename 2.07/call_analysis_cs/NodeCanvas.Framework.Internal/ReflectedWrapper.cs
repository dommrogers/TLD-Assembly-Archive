using System;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using ParadoxNotion.Serialization;

namespace NodeCanvas.Framework.Internal;

public abstract class ReflectedWrapper
{
	protected delegate void ActionCall();

	protected delegate void ActionCall<T1>(T1 a);

	protected delegate void ActionCall<T1, T2>(T1 a, T2 b);

	protected delegate void ActionCall<T1, T2, T3>(T1 a, T2 b, T3 c);

	protected delegate void ActionCall<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d);

	protected delegate void ActionCall<T1, T2, T3, T4, T5>(T1 a, T2 b, T3 c, T4 d, T5 e);

	protected delegate void ActionCall<T1, T2, T3, T4, T5, T6>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);

	protected delegate TResult FunctionCall<TResult>();

	protected delegate TResult FunctionCall<T1, TResult>(T1 a);

	protected delegate TResult FunctionCall<T1, T2, TResult>(T1 a, T2 b);

	protected delegate TResult FunctionCall<T1, T2, T3, TResult>(T1 a, T2 b, T3 c);

	protected delegate TResult FunctionCall<T1, T2, T3, T4, TResult>(T1 a, T2 b, T3 c, T4 d);

	protected delegate TResult FunctionCall<T1, T2, T3, T4, T5, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e);

	protected delegate TResult FunctionCall<T1, T2, T3, T4, T5, T6, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);

	protected SerializedMethodInfo _targetMethod;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ReflectedWrapper()
	{
	}

	[CalledBy(Type = typeof(ExecuteStaticFunction), Member = "SetMethod")]
	[CalledBy(Type = typeof(ExecuteFunction), Member = "SetMethod")]
	[CalledBy(Type = typeof(ExecuteFunction), Member = "OnValidate")]
	[Calls(Type = typeof(ReflectedActionWrapper), Member = "Create")]
	[CalledBy(Type = typeof(ExecuteStaticFunction), Member = "OnValidate")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReflectedFunctionWrapper), Member = "Create")]
	[CallerCount(Count = 4)]
	public static ReflectedWrapper Create(MethodInfo method, IBlackboard bb)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BBParameter), Member = "ResolveReference")]
	[CallsUnknownMethods(Count = 2)]
	public void SetVariablesBB(IBlackboard bb)
	{
	}

	[CallerCount(Count = 0)]
	public bool HasChanged()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public MethodInfo GetMethod()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public string GetMethodString()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	public abstract BBParameter[] GetVariables();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	public abstract void Init(object instance);
}
