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
		[Calls(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public Dictionary<string, double>.ValueCollection Values
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
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
			return 0.0;
		}
	}

	protected abstract double LookupElementImpl(IntPtr self, string key);

	protected abstract void SetupLengthImpl(IntPtr self);

	protected abstract void DisposeChildImpl();

	protected abstract bool HasKeyImpl(IntPtr self, string key);

	protected abstract StringDoubleFullWrappedCacheMapEnumerable CreateIteratorImpl(IntPtr self);

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasKey(string key)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 27)]
	public Dictionary<string, double> GetDictionary()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringDoubleWrappedCachedMap), Member = "SetNativePtr")]
	public StringDoubleWrappedCachedMap(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	public StringDoubleWrappedCachedMap()
	{
	}

	[CalledBy(Type = typeof(StringDoubleWrappedCachedMap), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 53)]
	public IntPtr GetNativePtr()
	{
		return (IntPtr)0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}

	[CalledBy(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = ".ctor")]
	[CalledBy(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetValue(string key, double val)
	{
	}
}
