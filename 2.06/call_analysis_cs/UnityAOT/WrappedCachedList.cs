using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityAOT;

public abstract class WrappedCachedList<T> : IEnumerable<T>, IDisposable, IWrappedObject, IEnumerable
{
	private sealed class _003CGetEnumerator_003Ed__4 : IEnumerator<T>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		public WrappedCachedList<T> _003C_003E4__this;

		private int _003Ci_003E5__2;

		private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			[DebuggerHidden]
			get
			{
				return (T)null;
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
		public _003CGetEnumerator_003Ed__4(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public uint Length;

	protected IntPtr m_Self;

	protected T[] m_Results;

	public T Item
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return (T)null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract T CreateIthElement(int i);

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	protected abstract void SetupLength();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract void DisposeChild();

	[IteratorStateMachine(typeof(WrappedCachedList<>._003CGetEnumerator_003Ed__4))]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public WrappedCachedList(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WrappedCachedList()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 44)]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
