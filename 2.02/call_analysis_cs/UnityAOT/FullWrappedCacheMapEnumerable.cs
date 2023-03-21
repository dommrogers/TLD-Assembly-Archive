using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityAOT;

public abstract class FullWrappedCacheMapEnumerable<T> : IDisposable where T : IWrappedObject, new()
{
	protected WrappedCachedMap<T> m_map;

	protected IntPtr m_Self;

	protected KeyValuePair<T> m_current;

	public KeyValuePair<T> Current
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

	protected abstract KeyValuePair<T> CreateCurrentImpl(IntPtr self);

	protected abstract void DisposeChildImpl();

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public FullWrappedCacheMapEnumerable(WrappedCachedMap<T> map)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public bool MoveNext()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}
}
