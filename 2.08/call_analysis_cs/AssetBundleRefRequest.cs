using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class AssetBundleRefRequest
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract Object GetObject();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract T GetObject<T>() where T : Object;

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract bool IsLoaded();

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	public abstract float GetProgress();

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected AssetBundleRefRequest()
	{
	}
}
