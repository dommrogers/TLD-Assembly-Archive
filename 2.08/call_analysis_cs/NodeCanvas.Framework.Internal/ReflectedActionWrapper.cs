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

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(SetProperty), Member = "OnValidate")]
	[CalledBy(Type = typeof(ReflectedWrapper), Member = "Create")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(SetProperty), Member = "SetMethod")]
	[CallsUnknownMethods(Count = 9)]
	public new static ReflectedActionWrapper Create(MethodInfo method, IBlackboard bb)
	{
		return null;
	}

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	public abstract void Call();

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	protected ReflectedActionWrapper()
	{
	}
}
