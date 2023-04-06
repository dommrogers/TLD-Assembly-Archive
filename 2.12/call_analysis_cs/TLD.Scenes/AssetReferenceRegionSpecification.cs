using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.AddressableAssets;

namespace TLD.Scenes;

[Serializable]
public class AssetReferenceRegionSpecification : AssetReferenceT<RegionSpecification>
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetReference), Member = ".ctor")]
	public AssetReferenceRegionSpecification(string guid)
	{
		((AssetReferenceT<TObject>)(object)this)._002Ector((string)null);
	}
}
