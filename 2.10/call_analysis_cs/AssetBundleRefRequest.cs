using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class AssetBundleRefRequest
{
	public abstract Object GetObject();

	public abstract T GetObject<T>() where T : Object;

	public abstract bool IsLoaded();

	public abstract float GetProgress();

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected AssetBundleRefRequest()
	{
	}
}
