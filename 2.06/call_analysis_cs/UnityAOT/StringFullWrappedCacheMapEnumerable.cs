using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityAOT;

public abstract class StringFullWrappedCacheMapEnumerable : IDisposable
{
	protected StringWrappedCachedMap m_map;

	protected IntPtr m_Self;

	protected StringKeyValuePair m_current;

	public StringKeyValuePair Current
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract bool MoveNextImpl(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract IntPtr FirstImpl(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract StringKeyValuePair CreateCurrentImpl(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract void DisposeChildImpl();

	[Calls(Type = typeof(StringWrappedCachedMap), Member = "SetValue")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(StringKeyValuePair), Member = "get_Value")]
	[Calls(Type = typeof(StringKeyValuePair), Member = "get_Key")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public StringFullWrappedCacheMapEnumerable(StringWrappedCachedMap map)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StringKeyValuePair), Member = "get_Key")]
	[Calls(Type = typeof(StringKeyValuePair), Member = "get_Value")]
	[Calls(Type = typeof(StringWrappedCachedMap), Member = "SetValue")]
	[CalledBy(Type = typeof(StringWrappedCachedMap), Member = "get_Keys")]
	[CalledBy(Type = typeof(StringWrappedCachedMap), Member = "get_Values")]
	[CallsUnknownMethods(Count = 1)]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
