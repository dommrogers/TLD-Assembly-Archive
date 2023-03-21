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
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract bool MoveNextImpl(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract IntPtr FirstImpl(IntPtr self);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	protected abstract StringKeyValuePair CreateCurrentImpl(IntPtr self);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	protected abstract void DisposeChildImpl();

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StringKeyValuePair), Member = "get_Ok")]
	[Calls(Type = typeof(StringKeyValuePair), Member = "get_Key")]
	[Calls(Type = typeof(StringKeyValuePair), Member = "get_Value")]
	[Calls(Type = typeof(StringWrappedCachedMap), Member = "SetValue")]
	[CallsUnknownMethods(Count = 1)]
	public StringFullWrappedCacheMapEnumerable(StringWrappedCachedMap map)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(StringWrappedCachedMap), Member = "get_Values")]
	[Calls(Type = typeof(StringWrappedCachedMap), Member = "SetValue")]
	[Calls(Type = typeof(StringKeyValuePair), Member = "get_Value")]
	[CalledBy(Type = typeof(StringWrappedCachedMap), Member = "get_Keys")]
	[Calls(Type = typeof(StringKeyValuePair), Member = "get_Ok")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringKeyValuePair), Member = "get_Key")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	public void Dispose()
	{
	}
}
