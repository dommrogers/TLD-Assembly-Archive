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
	protected abstract StringDoubleKeyValuePair CreateCurrentImpl(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract void DisposeChildImpl();

	[Calls(Type = typeof(StringDoubleWrappedCachedMap), Member = "SetValue")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(StringDoubleKeyValuePair), Member = "get_Value")]
	[Calls(Type = typeof(StringDoubleKeyValuePair), Member = "get_Key")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public StringDoubleFullWrappedCacheMapEnumerable(StringDoubleWrappedCachedMap map)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StringDoubleKeyValuePair), Member = "get_Key")]
	[Calls(Type = typeof(StringDoubleKeyValuePair), Member = "get_Value")]
	[Calls(Type = typeof(StringDoubleWrappedCachedMap), Member = "SetValue")]
	[CalledBy(Type = typeof(StringDoubleWrappedCachedMap), Member = "get_Keys")]
	[CalledBy(Type = typeof(StringDoubleWrappedCachedMap), Member = "get_Values")]
	[CallsUnknownMethods(Count = 1)]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Dispose()
	{
	}
}
