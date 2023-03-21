using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear;

public class GearItemInventoryIconSimpleData : GearItemInventoryIconData
{
	private Texture2D m_Icon;

	[DeduplicatedMethod]
	[CallerCount(Count = 28)]
	public override Texture2D GetInventoryIcon(GearItem item)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 28)]
	public override Texture2D GetInventoryIcon(float condition)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public GearItemInventoryIconSimpleData()
	{
	}
}
