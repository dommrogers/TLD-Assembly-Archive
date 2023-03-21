using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using UnityEngine.AddressableAssets;

namespace TLD;

[Serializable]
public class AssetReferenceAnimalPrefab : AssetReferenceWithComponent<BaseAi>
{
	[Calls(Type = typeof(AssetReference), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public AssetReferenceAnimalPrefab(string guid)
	{
		((AssetReferenceWithComponent<TComponent>)(object)this)._002Ector((string)null);
	}
}
