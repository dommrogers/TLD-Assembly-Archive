using System;
using System.Linq;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;

namespace NodeCanvas.Framework.Internal;

public abstract class ReflectedActionWrapper : ReflectedWrapper
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ParameterInfo, Type> _003C_003E9__0_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal Type _003CCreate_003Eb__0_0(ParameterInfo p)
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(ReflectedWrapper), Member = "Create")]
	[CalledBy(Type = typeof(SetProperty), Member = "OnValidate")]
	[CalledBy(Type = typeof(SetProperty), Member = "SetMethod")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enumerable), Member = "Select")]
	[Calls(TypeFullName = "System.Linq.Buffer`1", Member = ".ctor")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	public new static ReflectedActionWrapper Create(MethodInfo method, IBlackboard bb)
	{
		return null;
	}

	public abstract void Call();

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected ReflectedActionWrapper()
	{
	}
}
