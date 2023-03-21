using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
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
		[CallerCount(Count = 3)]
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
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		public _003CInternalCoroutine_003Ed__16(int _003C_003E1__state)
		{
		}

		[DeduplicatedMethod]
		[DebuggerHidden]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(ActionTask), Member = "EndAction")]
		[CallerCount(Count = 0)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
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
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		get
		{
			return null;
		}
	}

	protected override string info
	{
		[Calls(Type = typeof(System.Text.StringBuilderCache), Member = "Acquire")]
		[CallsUnknownMethods(Count = 28)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(System.Text.StringBuilderCache), Member = "Release")]
		[Calls(Type = typeof(StringBuilder), Member = "AppendFormatHelper")]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Task), Member = "Error")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(ExecuteFunction_Multiplatform), Member = "SetMethod")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 9)]
	protected override string OnInit()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	protected override void OnStop()
	{
	}

	[IteratorStateMachine(typeof(_003CInternalCoroutine_003Ed__16))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator InternalCoroutine(IEnumerator routine)
	{
		return null;
	}

	[Calls(Type = typeof(BBObjectParameter), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ExecuteFunction_Multiplatform), Member = "OnValidate")]
	[Calls(Type = typeof(BBParameter), Member = "ResolveReference")]
	[Calls(Type = typeof(BBObjectParameter), Member = "SetType")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	private void SetMethod(MethodInfo method)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ExecuteFunction_Multiplatform()
	{
	}
}
