using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityAOT;

public abstract class StringWrappedCachedMap : IDisposable
{
	public uint Length;

	protected IntPtr m_Self;

	protected Dictionary<string, string> m_Results;

	public Dictionary<string, string>.KeyCollection Keys
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
	}

	public Dictionary<string, string>.ValueCollection Values
	{
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		get
		{
			return null;
		}
	}

	public string Item
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	protected abstract string LookupElementImpl(IntPtr self, string key);

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
	protected abstract StringFullWrappedCacheMapEnumerable CreateIteratorImpl(IntPtr self);

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public bool HasKey(string key)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	public Dictionary<string, string> GetDictionary()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringWrappedCachedMap), Member = "SetNativePtr")]
	public StringWrappedCachedMap(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public StringWrappedCachedMap()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(StringWrappedCachedMap), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 29)]
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
	[CalledBy(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = ".ctor")]
	[CalledBy(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	public void SetValue(string key, string val)
	{
	}
}
