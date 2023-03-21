using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Serialization;
using ParadoxNotion.Services;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class ExecuteFunction_Multiplatform : ActionTask
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<BBObjectParameter, bool> _003C_003E9__13_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal bool _003COnInit_003Eb__13_0(BBObjectParameter p)
		{
			return default(bool);
		}
	}

	private sealed class _003CInternalCoroutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ExecuteFunction_Multiplatform _003C_003E4__this;

		public IEnumerator routine;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
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

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		public _003CInternalCoroutine_003Ed__16(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ActionTask), Member = "EndAction")]
		[CallsUnknownMethods(Count = 3)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 5)]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	protected SerializedMethodInfo method;

	protected List<BBObjectParameter> parameters;

	protected List<bool> parameterIsByRef;

	protected BBObjectParameter returnValue;

	private object[] args;

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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		get
		{
			return null;
		}
	}

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 18)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsDeduplicatedMethods(Count = 9)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ExecuteFunction_Multiplatform), Member = "SetMethod")]
	[Calls(Type = typeof(Task), Member = "Error")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	protected override string OnInit()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(ExecuteFunction_Multiplatform), Member = "InternalCoroutine")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	protected override void OnStop()
	{
	}

	[IteratorStateMachine(typeof(_003CInternalCoroutine_003Ed__16))]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(ExecuteFunction_Multiplatform), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 6)]
	private IEnumerator InternalCoroutine(IEnumerator routine)
	{
		return null;
	}

	[Calls(Type = typeof(BBObjectParameter), Member = ".ctor")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(ExecuteFunction_Multiplatform), Member = "OnValidate")]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[Calls(Type = typeof(BBObjectParameter), Member = "SetType")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	private void SetMethod(MethodInfo method)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ExecuteFunction_Multiplatform()
	{
	}
}
