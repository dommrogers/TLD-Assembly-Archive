using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class Skill_Gunsmithing : Skill
{
	[Serializable]
	public struct SkillTier
	{
		public int m_CraftedAmmoCondition;

		public float m_HarvestAmmoSuccessChance;

		public float m_MillingRepairSuccessChance;

		public float m_MillingRepairCondition;
	}

	public List<SkillTier> m_SkillTiers;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SkillsManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 8)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Skill), Member = "SetPoints")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	public override string GetTierBenefits(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	public int GetAmmoCraftingCondition()
	{
		return default(int);
	}

	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[CallerCount(Count = 0)]
	public float GetMillingRepairCondition()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	public float GetMillingRepairSuccessChance()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	public bool RollAmmoHarvestSuccess()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool RollMillingRepairSuccess()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Skill_Gunsmithing), Member = "RollAmmoHarvestSuccess")]
	[CalledBy(Type = typeof(Skill_Gunsmithing), Member = "GetMillingRepairSuccessChance")]
	[CalledBy(Type = typeof(Skill_Gunsmithing), Member = "GetMillingRepairCondition")]
	[CalledBy(Type = typeof(Skill_Gunsmithing), Member = "GetAmmoCraftingCondition")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RollForRepairSuccess")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "ApplyCondition")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CheckForHarvestSuccess")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "DetermineConditionImprovement")]
	[CalledBy(Type = typeof(Skill_Gunsmithing), Member = "RollMillingRepairSuccess")]
	private SkillTier GetCurrentTier()
	{
		return default(SkillTier);
	}

	[Calls(Type = typeof(Skill), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public Skill_Gunsmithing()
	{
	}
}
