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
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
	}

	protected abstract bool MoveNextImpl(IntPtr self);

	protected abstract IntPtr FirstImpl(IntPtr self);

	protected abstract StringDoubleKeyValuePair CreateCurrentImpl(IntPtr self);

	protected abstract void DisposeChildImpl();

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringDoubleKeyValuePair), Member = "get_Ok")]
	[Calls(Type = typeof(StringDoubleKeyValuePair), Member = "get_Key")]
	[Calls(Type = typeof(StringDoubleWrappedCachedMap), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public StringDoubleFullWrappedCacheMapEnumerable(StringDoubleWrappedCachedMap map)
	{
	}

	[CalledBy(Type = typeof(StringDoubleWrappedCachedMap), Member = "get_Keys")]
	[CalledBy(Type = typeof(StringDoubleWrappedCachedMap), Member = "get_Values")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringDoubleKeyValuePair), Member = "get_Ok")]
	[Calls(Type = typeof(StringDoubleKeyValuePair), Member = "get_Key")]
	[Calls(Type = typeof(StringDoubleWrappedCachedMap), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public bool MoveNext()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Dispose()
	{
	}
}
