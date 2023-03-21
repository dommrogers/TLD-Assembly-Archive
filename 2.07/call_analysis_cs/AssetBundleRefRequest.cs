using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class AssetBundleRefRequest
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	public abstract Object GetObject();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	public abstract T GetObject<T>() where T : Object;

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	public abstract bool IsLoaded();

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	public abstract float GetProgress();

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected AssetBundleRefRequest()
	{
	}
}
