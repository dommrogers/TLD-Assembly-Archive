using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using UnityEngine.AddressableAssets;

namespace TLD.Cooking;

[Serializable]
public class AssetReferenceCookingPot : AssetReferenceWithComponent<CookingPotItem>
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetReference), Member = ".ctor")]
	public AssetReferenceCookingPot(string guid)
	{
		((AssetReferenceWithComponent<TComponent>)(object)this)._002Ector((string)null);
	}
}
