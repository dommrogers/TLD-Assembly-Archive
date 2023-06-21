using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using UnityEngine.AddressableAssets;

namespace TLD.Gameplay;

[Serializable]
public class AssetReferenceCustomSpawnedItem : AssetReferenceWithComponent<CustomSpawnedItem>
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetReference), Member = ".ctor")]
	public AssetReferenceCustomSpawnedItem(string guid)
	{
		((AssetReferenceWithComponent<TComponent>)(object)this)._002Ector((string)null);
	}
}
