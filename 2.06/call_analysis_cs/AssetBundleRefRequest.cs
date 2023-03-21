using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class AssetBundleRefRequest
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract Object GetObject();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract T GetObject<T>() where T : Object;

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract bool IsLoaded();

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	public abstract float GetProgress();

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	protected AssetBundleRefRequest()
	{
	}
}
