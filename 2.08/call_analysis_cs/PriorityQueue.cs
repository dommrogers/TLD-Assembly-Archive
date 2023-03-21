using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class PriorityQueue<TEntry> : IEnumerable<TEntry>, IEnumerable where TEntry : IPrioritizable
{
	private class PriorityQueueEntry
	{
		private const int s_DefaultEntriesCapacity = 4;

		public readonly int m_Priority;

		public readonly Queue<TEntry> m_Entries;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public PriorityQueueEntry(int Priority)
		{
		}
	}

	public struct Enumerator : IEnumerator, IDisposable, IEnumerator<TEntry>
	{
		private PriorityQueue<TEntry> m_Queue;

		private int m_PriorityIndex;

		private Queue<TEntry>.Enumerator m_CurrentEnumerator;

		public TEntry Current
		{
			[CallsUnknownMethods(Count = 4)]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			get
			{
				return (TEntry)null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		public Enumerator(PriorityQueue<TEntry> priorityQueue)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public void Dispose()
		{
		}

		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 16)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool MoveNext()
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		public void Reset()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<PriorityQueueEntry> _003C_003E9__6_0;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal int _003CEnqueue_003Eb__6_0(PriorityQueueEntry a, PriorityQueueEntry b)
		{
			return default(int);
		}
	}

	private List<PriorityQueueEntry> m_Queues;

	public int Count
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public bool Contains(TEntry entry)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public TEntry Dequeue()
	{
		return (TEntry)null;
	}

	[CallsUnknownMethods(Count = 17)]
	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	public void Enqueue(TEntry entry)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public TEntry Peek()
	{
		return (TEntry)null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public IEnumerator<TEntry> GetEnumerator()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public PriorityQueue()
	{
	}
}
