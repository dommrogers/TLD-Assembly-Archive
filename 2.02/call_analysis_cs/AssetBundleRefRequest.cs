using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class AssetBundleRefRequest
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract Object GetObject();

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	public abstract T GetObject<T>() where T : Object;

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	public abstract bool IsLoaded();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract float GetProgress();

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	protected AssetBundleRefRequest()
	{
	}
}
