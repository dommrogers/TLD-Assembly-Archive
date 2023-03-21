using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.AddressableAssets;

namespace TLD.Scenes;

[Serializable]
public class AssetReferenceRegionSpecification : AssetReferenceT<RegionSpecification>
{
	[Calls(Type = typeof(AssetReference), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public AssetReferenceRegionSpecification(string guid)
	{
		((AssetReferenceT<TObject>)(object)this)._002Ector((string)null);
	}
}
