using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear;

public class GearItemInventoryIconFoodData : GearItemInventoryIconData
{
	private Texture2D m_NormalTexture;

	private Texture2D m_OpenedTexture;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GearItemInventoryIconFoodData()
	{
	}
}
