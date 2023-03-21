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
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
	}

	protected abstract bool MoveNextImpl(IntPtr self);

	protected abstract IntPtr FirstImpl(IntPtr self);

	protected abstract StringKeyValuePair CreateCurrentImpl(IntPtr self);

	protected abstract void DisposeChildImpl();

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringKeyValuePair), Member = "get_Key")]
	[Calls(Type = typeof(StringKeyValuePair), Member = "get_Value")]
	[Calls(Type = typeof(StringWrappedCachedMap), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public StringFullWrappedCacheMapEnumerable(StringWrappedCachedMap map)
	{
	}

	[CalledBy(Type = typeof(StringWrappedCachedMap), Member = "get_Keys")]
	[CalledBy(Type = typeof(StringWrappedCachedMap), Member = "get_Values")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringKeyValuePair), Member = "get_Key")]
	[Calls(Type = typeof(StringKeyValuePair), Member = "get_Value")]
	[Calls(Type = typeof(StringWrappedCachedMap), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool MoveNext()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
