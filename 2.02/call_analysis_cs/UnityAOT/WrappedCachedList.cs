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
			[DebuggerHidden]
			[CallerCount(Count = 29)]
			get
			{
				return (T)null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 29)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		public _003CGetEnumerator_003Ed__4(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
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
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return (T)null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract T CreateIthElement(int i);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract void SetupLength();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract void DisposeChild();

	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WrappedCachedList(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
	[CallerCount(Count = 29)]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
