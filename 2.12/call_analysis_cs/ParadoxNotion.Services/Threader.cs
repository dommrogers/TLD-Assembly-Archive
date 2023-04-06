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
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass1_0()
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

	private sealed class _003C_003Ec__DisplayClass2_0<T1, T2>
	{
		public Action<T1, T2> function;

		public T1 parameter1;

		public T2 parameter2;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass3_0()
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

	private sealed class _003C_003Ec__DisplayClass4_0<TResult>
	{
		public TResult result;

		public Func<TResult> function;

		public Action<TResult> callback;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass5_0()
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

	private sealed class _003C_003Ec__DisplayClass6_0<TResult, T1, T2>
	{
		public TResult result;

		public Func<T1, T2, TResult> function;

		public T1 parameter1;

		public T2 parameter2;

		public Action<TResult> callback;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
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
		[CallerCount(Count = 6)]
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

	private sealed class _003CThreadUpdater_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Thread thread;

		public Action callback;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CThreadUpdater_003Ed__9(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Thread), Member = "GetState")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper")]
	[Calls(Type = typeof(Threader), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Thread StartAction(Action function, Action callback = null)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper")]
	[Calls(Type = typeof(Threader), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static Thread StartAction<T1>(Action<T1> function, T1 parameter1, Action callback = null)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper")]
	[Calls(Type = typeof(Threader), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static Thread StartAction<T1, T2>(Action<T1, T2> function, T1 parameter1, T2 parameter2, Action callback = null)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper")]
	[Calls(Type = typeof(Threader), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static Thread StartAction<T1, T2, T3>(Action<T1, T2, T3> function, T1 parameter1, T2 parameter2, T3 parameter3, Action callback = null)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper")]
	[Calls(Type = typeof(Threader), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static Thread StartFunction<TResult>(Func<TResult> function, Action<TResult> callback = null)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper")]
	[Calls(Type = typeof(Threader), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static Thread StartFunction<TResult, T1>(Func<T1, TResult> function, T1 parameter1, Action<TResult> callback = null)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper")]
	[Calls(Type = typeof(Threader), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static Thread StartFunction<TResult, T1, T2>(Func<T1, T2, TResult> function, T1 parameter1, T2 parameter2, Action<TResult> callback = null)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper")]
	[Calls(Type = typeof(Threader), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static Thread StartFunction<TResult, T1, T2, T3>(Func<T1, T2, T3, TResult> function, T1 parameter1, T2 parameter2, T3 parameter3, Action<TResult> callback = null)
	{
		return null;
	}

	[CalledBy(Type = typeof(Threader), Member = "StartAction")]
	[CalledBy(Type = typeof(Threader), Member = "StartAction")]
	[CalledBy(Type = typeof(Threader), Member = "StartAction")]
	[CalledBy(Type = typeof(Threader), Member = "StartAction")]
	[CalledBy(Type = typeof(Threader), Member = "StartFunction")]
	[CalledBy(Type = typeof(Threader), Member = "StartFunction")]
	[CalledBy(Type = typeof(Threader), Member = "StartFunction")]
	[CalledBy(Type = typeof(Threader), Member = "StartFunction")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Thread), Member = "Start")]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	private static void Begin(Thread thread, Action callback)
	{
	}

	[IteratorStateMachine(typeof(_003CThreadUpdater_003Ed__9))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static IEnumerator ThreadUpdater(Thread thread, Action callback)
	{
		return null;
	}
}
