using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear;

public abstract class GearItemInventoryIconData : ScriptableObject
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract Texture2D GetInventoryIcon(GearItem item);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract Texture2D GetInventoryIcon(float conditionPercent);

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected GearItemInventoryIconData()
	{
	}
}
