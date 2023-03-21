using System;
using Cpp2ILInjected.CallAnalysis;
using UnityPlugin;

namespace UnityAOT;

public abstract class KeyValuePair<T> : IDisposable where T : IWrappedObject, new()
{
	protected IntPtr m_Self;

	protected string m_Key;

	protected T m_Value;

	public string Key
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
	}

	public T Value
	{
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return (T)null;
		}
	}

	public bool Ok
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public KeyValuePair(IntPtr self)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 2)]
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
