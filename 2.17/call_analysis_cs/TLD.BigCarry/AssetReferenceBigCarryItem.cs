using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using UnityEngine.AddressableAssets;

namespace TLD.BigCarry;

[Serializable]
public class AssetReferenceBigCarryItem : AssetReferenceWithComponent<BigCarryItem>
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetReference), Member = ".ctor")]
	public AssetReferenceBigCarryItem(string guid)
	{
		((AssetReferenceWithComponent<TComponent>)(object)this)._002Ector((string)null);
	}
}
