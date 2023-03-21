using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityAOT;

public abstract class WrappedCachedMap<T> : IDisposable, IWrappedObject where T : IWrappedObject, new()
{
	public uint Length;

	protected IntPtr m_Self;

	protected Dictionary<string, T> m_Results;

	public Dictionary<string, T>.KeyCollection Keys
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public Dictionary<string, T>.ValueCollection Values
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public T Item
	{
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return (T)null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract T LookupElementImpl(IntPtr self, string key);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract void SetupLengthImpl(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract void DisposeChildImpl();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract bool HasKeyImpl(IntPtr self, string key);

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	protected abstract FullWrappedCacheMapEnumerable<T> CreateIteratorImpl(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasKey(string key)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public WrappedCachedMap(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WrappedCachedMap()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 44)]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	public void Dispose()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetValue(string key, T val)
	{
	}
}
