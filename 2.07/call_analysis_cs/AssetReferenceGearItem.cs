using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using UnityEngine.AddressableAssets;

[Serializable]
public class AssetReferenceGearItem : AssetReferenceWithComponent<GearItem>
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetReference), Member = ".ctor")]
	public AssetReferenceGearItem(string guid)
	{
		((AssetReferenceWithComponent<TComponent>)(object)this)._002Ector((string)null);
	}
}
