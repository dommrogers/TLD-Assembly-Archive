using System;
using Cpp2ILInjected.CallAnalysis;
using UnityPlugin;

namespace UnityAOT;

public abstract class StringKeyValuePair : IDisposable
{
	protected IntPtr m_Self;

	protected string m_Key;

	protected string m_Value;

	public string Key
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(StringKeyValuePair), Member = "get_Ok")]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CalledBy(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = ".ctor")]
		[CalledBy(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public string Value
	{
		[CalledBy(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = ".ctor")]
		[Calls(Type = typeof(StringKeyValuePair), Member = "get_Ok")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		get
		{
			return null;
		}
	}

	public bool Ok
	{
		[CalledBy(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = ".ctor")]
		[CalledBy(Type = typeof(StringKeyValuePair), Member = "get_Value")]
		[CalledBy(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(StringKeyValuePair), Member = "get_Key")]
		get
		{
			return default(bool);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 52)]
	public IntPtr GetNativePtr()
	{
		return default(IntPtr);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetNativePtr(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public StringKeyValuePair(IntPtr self)
	{
	}

	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract IntPtr GetKeyImpl(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract IntPtr GetValueImpl(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract void DisposeChildImpl();
}
