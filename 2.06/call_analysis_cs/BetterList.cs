using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

public class BetterList<T>
{
	public delegate int CompareFunc(T left, T right);

	private sealed class _003CGetEnumerator_003Ed__2 : IEnumerator<T>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		public BetterList<T> _003C_003E4__this;

		private int _003Ci_003E5__2;

		private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return (T)null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
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

		[DeduplicatedMethod]
		[DebuggerHidden]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerStepThrough]
		[DebuggerHidden]
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

	public T[] buffer;

	public int size;

	public T Item
	{
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return (T)null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(BetterList<>._003CGetEnumerator_003Ed__2))]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	private void AllocateMore()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void Trim()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Release()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void Add(T item)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Insert(int index, T item)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public bool Contains(T item)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void RemoveAt(int index)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public T Pop()
	{
		return (T)null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public T[] ToArray()
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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
