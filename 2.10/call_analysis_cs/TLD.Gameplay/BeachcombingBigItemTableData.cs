using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay;

public class BeachcombingBigItemTableData : RandomTableData<AssetReferenceCustomSpawnedItem>
{
	private List<BeachcombingBigItemLocation> m_Locations;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RandomTableData<>), Member = "FilterEntries")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void FilterItemsForLocations(List<BeachcombingBigItemLocation> locations)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BeachcombingBigItemTableData), Member = "ShouldFilterOutForLocation")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override bool ShouldFilterOutItem(AssetReferenceCustomSpawnedItem item)
	{
		return false;
	}

	[CalledBy(Type = typeof(BeachcombingBigItemTableData), Member = "ShouldFilterOutItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BeachcombingBigItemLocation), Member = "IsReferenceAllowed")]
	[CallsUnknownMethods(Count = 3)]
	private bool ShouldFilterOutForLocation(AssetReferenceCustomSpawnedItem item)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RandomTableData<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public BeachcombingBigItemTableData()
	{
		((RandomTableData<>)(object)this)._002Ector();
	}
}
