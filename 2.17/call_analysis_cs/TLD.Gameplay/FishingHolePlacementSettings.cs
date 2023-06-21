using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using UnityEngine;

namespace TLD.Gameplay;

public class FishingHolePlacementSettings : ScriptableObject
{
	private AssetReferenceWithComponent<IceFishingHole> m_IceFishingHoleReference;

	public float m_BuildRangeMin;

	public float m_BuildRangeMax;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetHelper), Member = "TryInstantiateAsset")]
	[Calls(Type = typeof(IceFishingHole), Member = "SetToPlacementMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public IceFishingHole Instantiate()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public FishingHolePlacementSettings()
	{
	}
}
