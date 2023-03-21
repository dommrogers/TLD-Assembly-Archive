using System;
using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework.Internal;

[Serializable]
public class ReflectedFunction<TResult> : ReflectedFunctionWrapper
{
	private FunctionCall<TResult> call;

	public BBParameter<TResult> result;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void Init(object instance)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override object Call()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(TypeFullName = "ParadoxNotion.Internal.AOTDummy.NodeCanvas_Framework_Internal_ReflectedFunction_Collision", Member = ".ctor")]
	[CalledBy(TypeFullName = "ParadoxNotion.Internal.AOTDummy.NodeCanvas_Framework_Internal_ReflectedFunction_Collision2D", Member = ".ctor")]
	[CalledBy(TypeFullName = "ParadoxNotion.Internal.AOTDummy.NodeCanvas_Framework_Internal_ReflectedFunction_Space", Member = ".ctor")]
	[CalledBy(TypeFullName = "ParadoxNotion.Internal.AOTDummy.NodeCanvas_Framework_Internal_ReflectedFunction_SpawnLocation", Member = ".ctor")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public ReflectedFunction()
	{
	}
}
[Serializable]
public class ReflectedFunction<TResult, T1> : ReflectedFunctionWrapper
{
	private FunctionCall<T1, TResult> call;

	public BBParameter<T1> p1;

	public BBParameter<TResult> result;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void Init(object instance)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public override object Call()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	public ReflectedFunction()
	{
	}
}
[Serializable]
public class ReflectedFunction<TResult, T1, T2> : ReflectedFunctionWrapper
{
	private FunctionCall<T1, T2, TResult> call;

	public BBParameter<T1> p1;

	public BBParameter<T2> p2;

	public BBParameter<TResult> result;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void Init(object instance)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public override object Call()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 24)]
	public ReflectedFunction()
	{
	}
}
[Serializable]
public class ReflectedFunction<TResult, T1, T2, T3> : ReflectedFunctionWrapper
{
	private FunctionCall<T1, T2, T3, TResult> call;

	public BBParameter<T1> p1;

	public BBParameter<T2> p2;

	public BBParameter<T3> p3;

	public BBParameter<TResult> result;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void Init(object instance)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public override object Call()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 32)]
	public ReflectedFunction()
	{
	}
}
[Serializable]
public class ReflectedFunction<TResult, T1, T2, T3, T4> : ReflectedFunctionWrapper
{
	private FunctionCall<T1, T2, T3, T4, TResult> call;

	public BBParameter<T1> p1;

	public BBParameter<T2> p2;

	public BBParameter<T3> p3;

	public BBParameter<T4> p4;

	public BBParameter<TResult> result;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void Init(object instance)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public override object Call()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 40)]
	public ReflectedFunction()
	{
	}
}
[Serializable]
public class ReflectedFunction<TResult, T1, T2, T3, T4, T5> : ReflectedFunctionWrapper
{
	private FunctionCall<T1, T2, T3, T4, T5, TResult> call;

	public BBParameter<T1> p1;

	public BBParameter<T2> p2;

	public BBParameter<T3> p3;

	public BBParameter<T4> p4;

	public BBParameter<T5> p5;

	public BBParameter<TResult> result;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 25)]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void Init(object instance)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public override object Call()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 48)]
	public ReflectedFunction()
	{
	}
}
[Serializable]
public class ReflectedFunction<TResult, T1, T2, T3, T4, T5, T6> : ReflectedFunctionWrapper
{
	private FunctionCall<T1, T2, T3, T4, T5, T6, TResult> call;

	public BBParameter<T1> p1;

	public BBParameter<T2> p2;

	public BBParameter<T3> p3;

	public BBParameter<T4> p4;

	public BBParameter<T5> p5;

	public BBParameter<T6> p6;

	public BBParameter<TResult> result;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 29)]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void Init(object instance)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public override object Call()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 56)]
	public ReflectedFunction()
	{
	}
}
