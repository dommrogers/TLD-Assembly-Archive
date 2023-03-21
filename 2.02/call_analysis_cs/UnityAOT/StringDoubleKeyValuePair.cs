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
		[CalledBy(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = ".ctor")]
		[CalledBy(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StringDoubleKeyValuePair), Member = "get_Ok")]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	public double Value
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringDoubleKeyValuePair), Member = "get_Ok")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return 0.0;
		}
	}

	public bool Ok
	{
		[CalledBy(Type = typeof(StringDoubleKeyValuePair), Member = "get_Key")]
		[CalledBy(Type = typeof(StringDoubleKeyValuePair), Member = "get_Value")]
		[CalledBy(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = ".ctor")]
		[CalledBy(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallerCount(Count = 6)]
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
	public StringDoubleKeyValuePair(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Dispose()
	{
	}

	protected abstract IntPtr GetKeyImpl(IntPtr self);

	protected abstract double GetValueImpl(IntPtr self);

	protected abstract void DisposeChildImpl();
}
