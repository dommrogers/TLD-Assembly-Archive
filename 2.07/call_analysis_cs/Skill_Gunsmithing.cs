using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;

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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
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

	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	public bool RollAmmoHarvestSuccess()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(Skill_Gunsmithing), Member = "GetCurrentTier")]
	[CallerCount(Count = 0)]
	public bool RollMillingRepairSuccess()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Skill_Gunsmithing), Member = "RollMillingRepairSuccess")]
	[CalledBy(Type = typeof(Skill_Gunsmithing), Member = "RollAmmoHarvestSuccess")]
	[CalledBy(Type = typeof(Skill_Gunsmithing), Member = "GetMillingRepairSuccessChance")]
	[CalledBy(Type = typeof(Skill_Gunsmithing), Member = "GetMillingRepairCondition")]
	[CalledBy(Type = typeof(Skill_Gunsmithing), Member = "GetAmmoCraftingCondition")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RollForRepairSuccess")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "DetermineConditionImprovement")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "BeginRepair")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "ApplyCondition")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CheckForHarvestSuccess")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
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
