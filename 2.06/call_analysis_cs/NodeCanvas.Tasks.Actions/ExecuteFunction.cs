using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class ExecuteFunction : ActionTask, ISubParametersContainer, IReflectedWrapper
{
	private sealed class _003CInternalCoroutine_003Ed__14 : IDisposable, IEnumerator<object>, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ExecuteFunction _003C_003E4__this;

		public IEnumerator routine;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CInternalCoroutine_003Ed__14(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(ActionTask), Member = "EndAction")]
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	protected ReflectedWrapper functionWrapper;

	private bool routineRunning;

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
		[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	protected override string info
	{
		[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsUnknownMethods(Count = 18)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private MemberInfo NodeCanvas_002EFramework_002EIReflectedWrapper_002EGetMemberInfo()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private BBParameter[] NodeCanvas_002EFramework_002EISubParametersContainer_002EGetSubParameters()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ReflectedWrapper), Member = "Create")]
	[Calls(Type = typeof(Task), Member = "Error")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallsUnknownMethods(Count = 1)]
	protected override string OnInit()
	{
		return null;
	}

	[Calls(Type = typeof(Task), Member = "StartCoroutine")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ExecuteFunction), Member = "InternalCoroutine")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override void OnStop()
	{
	}

	[IteratorStateMachine(typeof(_003CInternalCoroutine_003Ed__14))]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(ExecuteFunction), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 6)]
	private IEnumerator InternalCoroutine(IEnumerator routine)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectedWrapper), Member = "Create")]
	private void SetMethod(MethodInfo method)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ExecuteFunction()
	{
	}
}
