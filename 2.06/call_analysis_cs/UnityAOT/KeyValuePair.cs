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
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public T Value
	{
		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetNativePtr(IntPtr self)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public KeyValuePair(IntPtr self)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
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
