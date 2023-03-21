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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CalledBy(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = ".ctor")]
		[CalledBy(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public double Value
	{
		[CalledBy(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = "MoveNext")]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(StringDoubleFullWrappedCacheMapEnumerable), Member = ".ctor")]
		get
		{
			return default(double);
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

	[CallerCount(Count = 98)]
	[DeduplicatedMethod]
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
	public StringDoubleKeyValuePair(IntPtr self)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	public void Dispose()
	{
	}

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	protected abstract IntPtr GetKeyImpl(IntPtr self);

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	protected abstract double GetValueImpl(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract void DisposeChildImpl();
}
