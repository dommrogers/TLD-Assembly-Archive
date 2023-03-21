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
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CalledBy(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = ".ctor")]
		[CalledBy(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public string Value
	{
		[CalledBy(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(StringFullWrappedCacheMapEnumerable), Member = ".ctor")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		get
		{
			return null;
		}
	}

	public bool Ok
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 98)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract IntPtr GetKeyImpl(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract IntPtr GetValueImpl(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract void DisposeChildImpl();
}
