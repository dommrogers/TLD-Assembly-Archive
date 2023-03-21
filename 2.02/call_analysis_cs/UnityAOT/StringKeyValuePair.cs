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
		[CalledBy(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = ".ctor")]
		[CalledBy(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StringKeyValuePair), Member = "get_Ok")]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public string Value
	{
		[CalledBy(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = ".ctor")]
		[CalledBy(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StringKeyValuePair), Member = "get_Ok")]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public bool Ok
	{
		[CalledBy(Type = typeof(StringKeyValuePair), Member = "get_Key")]
		[CalledBy(Type = typeof(StringKeyValuePair), Member = "get_Value")]
		[CalledBy(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = ".ctor")]
		[CalledBy(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 59)]
	public IntPtr GetNativePtr()
	{
		return (IntPtr)0;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Dispose()
	{
	}

	protected abstract IntPtr GetKeyImpl(IntPtr self);

	protected abstract IntPtr GetValueImpl(IntPtr self);

	protected abstract void DisposeChildImpl();
}
