using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear;

public abstract class GearItemInventoryIconData : ScriptableObject
{
	public abstract Texture2D GetInventoryIcon(GearItem item);

	public abstract Texture2D GetInventoryIcon(float conditionPercent);

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	protected GearItemInventoryIconData()
	{
	}
}
