using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear;

public abstract class GearItemInventoryIconData : ScriptableObject
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract Texture2D GetInventoryIcon(GearItem item);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	public abstract Texture2D GetInventoryIcon(float conditionPercent);

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	protected GearItemInventoryIconData()
	{
	}
}
