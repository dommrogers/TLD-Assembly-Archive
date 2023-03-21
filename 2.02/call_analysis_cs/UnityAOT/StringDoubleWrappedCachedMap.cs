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
		[Calls(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		get
		{
			return null;
		}
	}

	public Dictionary<string, double>.ValueCollection Values
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
	}

	public double Item
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return default(double);
		}
	}

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	protected abstract double LookupElementImpl(IntPtr self, string key);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract void SetupLengthImpl(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract void DisposeChildImpl();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract bool HasKeyImpl(IntPtr self, string key);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract StringDoubleFullWrappedCacheMapEnumerable CreateIteratorImpl(IntPtr self);

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public bool HasKey(string key)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	public Dictionary<string, double> GetDictionary()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringDoubleWrappedCachedMap), Member = "SetNativePtr")]
	public StringDoubleWrappedCachedMap(IntPtr self)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public StringDoubleWrappedCachedMap()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(StringDoubleWrappedCachedMap), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[CallerCount(Count = 29)]
	[DeduplicatedMethod]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	public void Dispose()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = ".ctor")]
	[CalledBy(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	public void SetValue(string key, double val)
	{
	}
}
