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
		[CallsUnknownMethods(Count = 8)]
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
			[CallsUnknownMethods(Count = 3)]
			get
			{
				return default(TEntry);
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 3)]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[CalledBy(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
		[CalledBy(Type = typeof(PriorityQueue<>), Member = "GetEnumerator")]
		[CalledBy(Type = typeof(PriorityQueue<>), Member = "System.Collections.IEnumerable.GetEnumerator")]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		public Enumerator(PriorityQueue<TEntry> priorityQueue)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public void Dispose()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Queue<>.Enumerator), Member = "MoveNext")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 13)]
		public bool MoveNext()
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		public void Reset()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<PriorityQueueEntry> _003C_003E9__6_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CEnqueue_003Eb__6_0(PriorityQueueEntry a, PriorityQueueEntry b)
		{
			return 0;
		}
	}

	private List<PriorityQueueEntry> m_Queues;

	public int Count
	{
		[DeduplicatedMethod]
		[CalledBy(Type = typeof(HUDMessage), Member = "Update")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return 0;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public bool Contains(TEntry entry)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(HUDMessage), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public TEntry Dequeue()
	{
		return default(TEntry);
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 40)]
	public void Enqueue(TEntry entry)
	{
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(HUDMessage), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public TEntry Peek()
	{
		return default(TEntry);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PriorityQueue<>.Enumerator), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public IEnumerator<TEntry> GetEnumerator()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PriorityQueue<>.Enumerator), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public PriorityQueue()
	{
	}
}
