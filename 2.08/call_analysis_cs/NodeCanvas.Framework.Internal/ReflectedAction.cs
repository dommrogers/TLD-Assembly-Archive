using System;
using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework.Internal;

[Serializable]
public class ReflectedAction : ReflectedActionWrapper
{
	private ActionCall call;

	[CallerCount(Count = 0)]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override void Init(object instance)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void Call()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ReflectedAction()
	{
	}
}
[Serializable]
public class ReflectedAction<T1> : ReflectedActionWrapper
{
	private ActionCall<T1> call;

	public BBParameter<T1> p1;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void Init(object instance)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void Call()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 2)]
	public ReflectedAction()
	{
	}
}
[Serializable]
public class ReflectedAction<T1, T2> : ReflectedActionWrapper
{
	private ActionCall<T1, T2> call;

	public BBParameter<T1> p1;

	public BBParameter<T2> p2;

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void Init(object instance)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public override void Call()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ReflectedAction()
	{
	}
}
[Serializable]
public class ReflectedAction<T1, T2, T3> : ReflectedActionWrapper
{
	private ActionCall<T1, T2, T3> call;

	public BBParameter<T1> p1;

	public BBParameter<T2> p2;

	public BBParameter<T3> p3;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 13)]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void Init(object instance)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void Call()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public ReflectedAction()
	{
	}
}
[Serializable]
public class ReflectedAction<T1, T2, T3, T4> : ReflectedActionWrapper
{
	private ActionCall<T1, T2, T3, T4> call;

	public BBParameter<T1> p1;

	public BBParameter<T2> p2;

	public BBParameter<T3> p3;

	public BBParameter<T4> p4;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 17)]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void Init(object instance)
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void Call()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ReflectedAction()
	{
	}
}
[Serializable]
public class ReflectedAction<T1, T2, T3, T4, T5> : ReflectedActionWrapper
{
	private ActionCall<T1, T2, T3, T4, T5> call;

	public BBParameter<T1> p1;

	public BBParameter<T2> p2;

	public BBParameter<T3> p3;

	public BBParameter<T4> p4;

	public BBParameter<T5> p5;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 21)]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void Init(object instance)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void Call()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public ReflectedAction()
	{
	}
}
[Serializable]
public class ReflectedAction<T1, T2, T3, T4, T5, T6> : ReflectedActionWrapper
{
	private ActionCall<T1, T2, T3, T4, T5, T6> call;

	public BBParameter<T1> p1;

	public BBParameter<T2> p2;

	public BBParameter<T3> p3;

	public BBParameter<T4> p4;

	public BBParameter<T5> p5;

	public BBParameter<T6> p6;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 25)]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override void Init(object instance)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public override void Call()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	public ReflectedAction()
	{
	}
}
