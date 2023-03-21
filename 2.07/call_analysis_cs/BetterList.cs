using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

public class BetterList<T>
{
	public delegate int CompareFunc(T left, T right);

	private sealed class _003CGetEnumerator_003Ed__2 : IDisposable, IEnumerator<T>, IEnumerator
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		public BetterList<T> _003C_003E4__this;

		private int _003Ci_003E5__2;

		private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return (T)null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallsUnknownMethods(Count = 1)]
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CGetEnumerator_003Ed__2(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerStepThrough]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public T[] buffer;

	public int size;

	public T Item
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return (T)null;
		}
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[DebuggerHidden]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(BetterList<>._003CGetEnumerator_003Ed__2))]
	[DebuggerStepThrough]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[CallsUnknownMethods(Count = 2)]
	private void AllocateMore()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void Trim()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Clear()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Release()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Add(T item)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Insert(int index, T item)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 4)]
	public bool Contains(T item)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public int IndexOf(T item)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool Remove(T item)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void RemoveAt(int index)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public T Pop()
	{
		return (T)null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public T[] ToArray()
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 2)]
	public void Sort(CompareFunc comparer)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public BetterList()
	{
	}
}
