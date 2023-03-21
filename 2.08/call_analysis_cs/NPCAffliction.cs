using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class NPCAffliction
{
	public enum TreatmentSelected
	{
		None,
		Standard,
		Alternate
	}

	public AfflictionDefinition m_Definition;

	public AfflictionBodyArea m_Location;

	public string m_CauseLocId;

	[NonSerialized]
	public TreatmentSelected m_TreatmentSelected;

	private bool m_Remedy1Complete;

	private bool m_Remedy2Complete;

	private bool m_AlternateRemedy1Complete;

	private bool m_AlternateRemedy2Complete;

	private float m_WaterLiters;

	private float m_RestHours;

	private int m_PerTypeIndex;

	[CallerCount(Count = 0)]
	public bool IsRemedyComplete(int index)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsAlternateRemedyComplete(int index)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool SupportAlternateTreatment()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetPerTypeIndex()
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetPerTypeIndex(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public AfflictionRemedy GetStandardRemedy(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public AfflictionRemedy GetAlternateRemedy(int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(NPCAffliction), Member = "GetWaterRequiredForTreatment")]
	[CallsUnknownMethods(Count = 1)]
	public float GetTreatmentWaterVolumeLiters(NPC npc)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "OnTreatmentComplete")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AfflictionRemedy), Member = "IsWaterSupply")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "PlayerHasRequiredRemedy")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "GetGearItemName")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "RemoveUnits")]
	[Calls(Type = typeof(PlayerManager), Member = "RemoveFirstAidItem")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyStandardRemedy(int remedyIndex, NPC npc)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "OnTreatmentComplete")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AfflictionRemedy), Member = "IsWaterSupply")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "PlayerHasRequiredRemedy")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "GetGearItemName")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "RemoveUnits")]
	[Calls(Type = typeof(PlayerManager), Member = "RemoveFirstAidItem")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyAlternateRemedy(int remedyIndex, NPC npc)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "GetAllAfflictions")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsTreated()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetWaterLitersUsed()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetRestHoursCompleted()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(NPCAffliction), Member = "GetTreatmentWaterVolumeLiters")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStandardTreatmentUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAlternateTreatmentUI")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetWaterRequiredForTreatment(NPC npc)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 1)]
	public NPCAfflictionSavedData Save()
	{
		return null;
	}

	[CalledBy(Type = typeof(NPCAfflictions), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Load(NPCAfflictionSavedData saveData)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyWaterTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "OnTreatmentComplete")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CallsUnknownMethods(Count = 1)]
	public void UseWater(NPC npc, float waterLiters)
	{
	}

	[CallerCount(Count = 0)]
	private void RestHours(float restHours)
	{
	}

	[CallerCount(Count = 0)]
	private void UseStandardRemedy(int remedyIndex)
	{
	}

	[CallerCount(Count = 0)]
	private void UseAlternateRemedy(int remedyIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool RequiresRemdy()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public NPCAffliction()
	{
	}
}
