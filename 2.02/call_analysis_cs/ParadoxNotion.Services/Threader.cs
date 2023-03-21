using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ParadoxNotion.Services;

public static class Threader
{
	private sealed class _003C_003Ec__DisplayClass1_0<T1>
	{
		public Action<T1> function;

		public T1 parameter1;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public _003C_003Ec__DisplayClass1_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal void _003CStartAction_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass2_0<T1, T2>
	{
		public Action<T1, T2> function;

		public T1 parameter1;

		public T2 parameter2;

		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CStartAction_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_0<T1, T2, T3>
	{
		public Action<T1, T2, T3> function;

		public T1 parameter1;

		public T2 parameter2;

		public T3 parameter3;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal void _003CStartAction_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass4_0<TResult>
	{
		public TResult result;

		public Func<TResult> function;

		public Action<TResult> callback;

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CStartFunction_003Eb__0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal void _003CStartFunction_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_0<TResult, T1>
	{
		public TResult result;

		public Func<T1, TResult> function;

		public T1 parameter1;

		public Action<TResult> callback;

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal void _003CStartFunction_003Eb__0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CStartFunction_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0<TResult, T1, T2>
	{
		public TResult result;

		public Func<T1, T2, TResult> function;

		public T1 parameter1;

		public T2 parameter2;

		public Action<TResult> callback;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CStartFunction_003Eb__0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal void _003CStartFunction_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0<TResult, T1, T2, T3>
	{
		public TResult result;

		public Func<T1, T2, T3, TResult> function;

		public T1 parameter1;

		public T2 parameter2;

		public T3 parameter3;

		public Action<TResult> callback;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CStartFunction_003Eb__0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CStartFunction_003Eb__1()
		{
		}
	}

	private sealed class _003CThreadUpdater_003Ed__9 : IDisposable, IEnumerator<object>, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Thread thread;

		public Action callback;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DeduplicatedMethod]
			[DebuggerHidden]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		public _003CThreadUpdater_003Ed__9(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Thread), Member = "get_ThreadState")]
		[Calls(Type = typeof(Thread), Member = "get_IsAlive")]
		[CallsUnknownMethods(Count = 3)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Thread), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Threader), Member = "Begin")]
	public static Thread StartAction(Action function, Action callback = null)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(Threader), Member = "Begin")]
	[Calls(Type = typeof(Thread), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static Thread StartAction<T1>(Action<T1> function, T1 parameter1, Action callback = null)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Thread), Member = ".ctor")]
	[Calls(Type = typeof(Threader), Member = "Begin")]
	[CallsUnknownMethods(Count = 23)]
	public static Thread StartAction<T1, T2>(Action<T1, T2> function, T1 parameter1, T2 parameter2, Action callback = null)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(Threader), Member = "Begin")]
	[Calls(Type = typeof(Thread), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static Thread StartAction<T1, T2, T3>(Action<T1, T2, T3> function, T1 parameter1, T2 parameter2, T3 parameter3, Action callback = null)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Thread), Member = ".ctor")]
	[Calls(Type = typeof(Threader), Member = "Begin")]
	[CallsUnknownMethods(Count = 30)]
	public static Thread StartFunction<TResult>(Func<TResult> function, Action<TResult> callback = null)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(Thread), Member = ".ctor")]
	[Calls(Type = typeof(Threader), Member = "Begin")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 2)]
	public static Thread StartFunction<TResult, T1>(Func<T1, TResult> function, T1 parameter1, Action<TResult> callback = null)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(Threader), Member = "Begin")]
	[Calls(Type = typeof(Thread), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 2)]
	public static Thread StartFunction<TResult, T1, T2>(Func<T1, T2, TResult> function, T1 parameter1, T2 parameter2, Action<TResult> callback = null)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Thread), Member = ".ctor")]
	[Calls(Type = typeof(Threader), Member = "Begin")]
	[CallsUnknownMethods(Count = 30)]
	public static Thread StartFunction<TResult, T1, T2, T3>(Func<T1, T2, T3, TResult> function, T1 parameter1, T2 parameter2, T3 parameter3, Action<TResult> callback = null)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Threader), Member = "StartFunction")]
	[CalledBy(Type = typeof(Threader), Member = "StartFunction")]
	[CalledBy(Type = typeof(Threader), Member = "StartFunction")]
	[CalledBy(Type = typeof(Threader), Member = "StartFunction")]
	[CalledBy(Type = typeof(Threader), Member = "StartAction")]
	[CalledBy(Type = typeof(Threader), Member = "StartAction")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CalledBy(Type = typeof(Threader), Member = "StartAction")]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(Thread), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Threader), Member = "StartAction")]
	[Calls(Type = typeof(Threader), Member = "ThreadUpdater")]
	private static void Begin(Thread thread, Action callback)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Threader), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	private static IEnumerator ThreadUpdater(Thread thread, Action callback)
	{
		return null;
	}
}
