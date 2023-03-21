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
		[Calls(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
	}

	public Dictionary<string, string>.ValueCollection Values
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
	}

	public string Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	protected abstract string LookupElementImpl(IntPtr self, string key);

	protected abstract void SetupLengthImpl(IntPtr self);

	protected abstract void DisposeChildImpl();

	protected abstract bool HasKeyImpl(IntPtr self, string key);

	protected abstract StringFullWrappedCacheMapEnumerable CreateIteratorImpl(IntPtr self);

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public bool HasKey(string key)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 9)]
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

	[CalledBy(Type = typeof(StringWrappedCachedMap), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 35)]
	public IntPtr GetNativePtr()
	{
		return (IntPtr)0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Dispose()
	{
	}

	[CalledBy(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = ".ctor")]
	[CalledBy(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SetValue(string key, string val)
	{
	}
}
