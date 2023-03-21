using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.Cloud;

public class CyclicalList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	private struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private int currentIndex;

		private CyclicalList<T> list;

		public T Current
		{
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 5)]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return (T)null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 6)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public Enumerator(CyclicalList<T> list)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public void Dispose()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public bool MoveNext()
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public void Reset()
		{
		}
	}

	private int count;

	private T[] items;

	private int nextPointer;

	public int Capacity
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	public int Count
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(int);
		}
	}

	public bool IsReadOnly
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public T Item
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return (T)null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public CyclicalList(int capacity)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 2)]
	public void Add(T item)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Clear()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public bool Contains(T item)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public void CopyTo(T[] array, int arrayIndex)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public T GetNextEviction()
	{
		return (T)null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	private int GetPointer(int index)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 3)]
	public int IndexOf(T item)
	{
		return default(int);
	}

	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Insert(int index, T item)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool Remove(T item)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveAt(int index)
	{
	}
}
