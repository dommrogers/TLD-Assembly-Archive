using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

public abstract class AkBaseArray<T> : IDisposable
{
	private int _003CCapacity_003Ek__BackingField;

	private IntPtr m_Buffer;

	public int Capacity
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	protected abstract int StructureSize
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	public T Item
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return (T)null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal")]
	[CallsUnknownMethods(Count = 1)]
	public AkBaseArray(int capacity)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	public void Dispose()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	~AkBaseArray()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int Count()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void ReleaseAllocatedMemoryFromReferenceAtIntPtr(IntPtr address)
	{
	}

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	protected abstract T CreateNewReferenceFromIntPtr(IntPtr address);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract void CloneIntoReferenceFromIntPtr(IntPtr address, T other);

	[CallerCount(Count = 29)]
	[DeduplicatedMethod]
	public IntPtr GetBuffer()
	{
		return default(IntPtr);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	protected IntPtr GetObjectPtr(int index)
	{
		return default(IntPtr);
	}
}
