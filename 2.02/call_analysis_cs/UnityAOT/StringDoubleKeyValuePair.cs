using System;
using Cpp2ILInjected.CallAnalysis;
using UnityPlugin;

namespace UnityAOT;

public abstract class StringDoubleKeyValuePair : IDisposable
{
	protected IntPtr m_Self;

	protected string m_Key;

	protected double m_Value;

	public string Key
	{
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CalledBy(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = ".ctor")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StringDoubleKeyValuePair), Member = "get_Ok")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		get
		{
			return null;
		}
	}

	public double Value
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(StringDoubleKeyValuePair), Member = "get_Ok")]
		get
		{
			return default(double);
		}
	}

	public bool Ok
	{
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(StringDoubleKeyValuePair), Member = "get_Key")]
		[CalledBy(Type = typeof(StringDoubleKeyValuePair), Member = "get_Value")]
		[CalledBy(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = ".ctor")]
		[CalledBy(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = ".ctor")]
		[CalledBy(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CalledBy(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = "MoveNext")]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetNativePtr(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public StringDoubleKeyValuePair(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	public void Dispose()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract IntPtr GetKeyImpl(IntPtr self);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	protected abstract double GetValueImpl(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract void DisposeChildImpl();
}
