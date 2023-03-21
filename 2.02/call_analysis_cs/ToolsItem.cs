using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ToolsItem : MonoBehaviour
{
	public enum ToolType
	{
		All,
		CraftOnly,
		RepairOnly
	}

	public enum CuttingToolType
	{
		None,
		HackSaw,
		Hatchet,
		Hammer,
		Knife
	}

	public float m_CraftingAndRepairSkillModifier;

	public float m_CraftingAndRepairTimeModifier;

	public bool m_CanOnlyCraftAndRepairClothes;

	public ToolType m_ToolType;

	public CuttingToolType m_CuttingToolType;

	public float m_DegradePerHourCrafting;

	public bool m_AppearInStoryOnly;

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ToolsItem()
	{
	}
}
