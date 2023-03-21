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
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
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
	protected abstract KeyValuePair<T> CreateCurrentImpl(IntPtr self);

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	protected abstract void DisposeChildImpl();

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public FullWrappedCacheMapEnumerable(WrappedCachedMap<T> map)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public bool MoveNext()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	public void Dispose()
	{
	}
}
