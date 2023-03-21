using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityAOT;

public abstract class StringDoubleFullWrappedCacheMapEnumerable : IDisposable
{
	protected StringDoubleWrappedCachedMap m_map;

	protected IntPtr m_Self;

	protected StringDoubleKeyValuePair m_current;

	public StringDoubleKeyValuePair Current
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
	protected abstract StringDoubleKeyValuePair CreateCurrentImpl(IntPtr self);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	protected abstract void DisposeChildImpl();

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(StringDoubleKeyValuePair), Member = "get_Ok")]
	[Calls(Type = typeof(StringDoubleKeyValuePair), Member = "get_Key")]
	[Calls(Type = typeof(StringDoubleKeyValuePair), Member = "get_Ok")]
	[Calls(Type = typeof(StringDoubleWrappedCachedMap), Member = "SetValue")]
	[CallsUnknownMethods(Count = 1)]
	public StringDoubleFullWrappedCacheMapEnumerable(StringDoubleWrappedCachedMap map)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(StringDoubleWrappedCachedMap), Member = "get_Values")]
	[Calls(Type = typeof(StringDoubleWrappedCachedMap), Member = "SetValue")]
	[Calls(Type = typeof(StringDoubleKeyValuePair), Member = "get_Ok")]
	[CalledBy(Type = typeof(StringDoubleWrappedCachedMap), Member = "get_Keys")]
	[Calls(Type = typeof(StringDoubleKeyValuePair), Member = "get_Ok")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringDoubleKeyValuePair), Member = "get_Key")]
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
