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
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
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

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public _003CGetEnumerator_003Ed__2(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[DebuggerHidden]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
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
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 5)]
		get
		{
			return (T)null;
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[DebuggerStepThrough]
	[DebuggerHidden]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 2)]
	private void AllocateMore()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
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

	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 24)]
	public void Add(T item)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void Insert(int index, T item)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "Equals")]
	public bool Contains(T item)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(int), Member = "Equals")]
	[DeduplicatedMethod]
	public int IndexOf(T item)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 11)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool Remove(T item)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 9)]
	public void RemoveAt(int index)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public T Pop()
	{
		return (T)null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public T[] ToArray()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public void Sort(CompareFunc comparer)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 1)]
	public BetterList()
	{
	}
}
