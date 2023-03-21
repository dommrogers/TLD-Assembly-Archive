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

		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public PriorityQueueEntry(int Priority)
		{
		}
	}

	public struct Enumerator : IEnumerator<TEntry>, IEnumerator, IDisposable
	{
		private PriorityQueue<TEntry> m_Queue;

		private int m_PriorityIndex;

		private Queue<TEntry>.Enumerator m_CurrentEnumerator;

		public TEntry Current
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
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

		[CallsUnknownMethods(Count = 7)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		public Enumerator(PriorityQueue<TEntry> priorityQueue)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public void Dispose()
		{
		}

		[CallsUnknownMethods(Count = 15)]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public bool MoveNext()
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CEnqueue_003Eb__6_0(PriorityQueueEntry a, PriorityQueueEntry b)
		{
			return default(int);
		}
	}

	private List<PriorityQueueEntry> m_Queues;

	public int Count
	{
		[CallsDeduplicatedMethods(Count = 3)]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return default(int);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public bool Contains(TEntry entry)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public TEntry Dequeue()
	{
		return (TEntry)null;
	}

	[CallsUnknownMethods(Count = 32)]
	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	public void Enqueue(TEntry entry)
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public TEntry Peek()
	{
		return (TEntry)null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public IEnumerator<TEntry> GetEnumerator()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PriorityQueue()
	{
	}
}
