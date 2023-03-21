using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear;

public abstract class GearItemInventoryIconData : ScriptableObject
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	public abstract Texture2D GetInventoryIcon(GearItem item);

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	public abstract Texture2D GetInventoryIcon(float conditionPercent);

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	protected GearItemInventoryIconData()
	{
	}
}
