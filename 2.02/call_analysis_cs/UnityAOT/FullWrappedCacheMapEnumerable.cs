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
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	protected abstract bool MoveNextImpl(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract IntPtr FirstImpl(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract KeyValuePair<T> CreateCurrentImpl(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract void DisposeChildImpl();

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public FullWrappedCacheMapEnumerable(WrappedCachedMap<T> map)
	{
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool MoveNext()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}
}
