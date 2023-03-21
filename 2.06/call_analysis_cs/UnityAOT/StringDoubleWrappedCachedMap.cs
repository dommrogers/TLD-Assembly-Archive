using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityAOT;

public abstract class StringDoubleWrappedCachedMap : IDisposable
{
	public uint Length;

	protected IntPtr m_Self;

	protected Dictionary<string, double> m_Results;

	public Dictionary<string, double>.KeyCollection Keys
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public Dictionary<string, double>.ValueCollection Values
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public double Item
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(double);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract double LookupElementImpl(IntPtr self, string key);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract void SetupLengthImpl(IntPtr self);

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	protected abstract void DisposeChildImpl();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract bool HasKeyImpl(IntPtr self, string key);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract StringDoubleFullWrappedCacheMapEnumerable CreateIteratorImpl(IntPtr self);

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasKey(string key)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 23)]
	public Dictionary<string, double> GetDictionary()
	{
		return null;
	}

	[Calls(Type = typeof(StringDoubleWrappedCachedMap), Member = "SetNativePtr")]
	[CallerCount(Count = 0)]
	public StringDoubleWrappedCachedMap(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	public StringDoubleWrappedCachedMap()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(StringDoubleWrappedCachedMap), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 44)]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	public void Dispose()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = ".ctor")]
	[CallerCount(Count = 2)]
	public void SetValue(string key, double val)
	{
	}
}
