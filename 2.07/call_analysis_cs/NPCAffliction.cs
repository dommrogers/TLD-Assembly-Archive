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
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsAlternateRemedyComplete(int index)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool SupportAlternateTreatment()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetPerTypeIndex()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(NPCAffliction), Member = "GetWaterRequiredForTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyAlternateTreatment")]
	[CallsUnknownMethods(Count = 1)]
	public float GetTreatmentWaterVolumeLiters(NPC npc)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "OnTreatmentComplete")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "OnTreatmentComplete")]
	[Calls(Type = typeof(PlayerManager), Member = "RemoveFirstAidItem")]
	[Calls(Type = typeof(Inventory), Member = "RemoveUnits")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "PlayerHasRequiredRemedy")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "GetGearItemName")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "IsWaterSupply")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ApplyStandardRemedy(int remedyIndex, NPC npc)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "RemoveFirstAidItem")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "OnTreatmentComplete")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "OnTreatmentComplete")]
	[Calls(Type = typeof(Inventory), Member = "RemoveUnits")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "GetGearItemName")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "PlayerHasRequiredRemedy")]
	[Calls(Type = typeof(AfflictionRemedy), Member = "IsWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ApplyAlternateRemedy(int remedyIndex, NPC npc)
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "HasStandardTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "HasAlternateTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "GetAllAfflictions")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsTreated()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetWaterLitersUsed()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetRestHoursCompleted()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateAlternateTreatmentUI")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStandardTreatmentUI")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(NPCAffliction), Member = "GetTreatmentWaterVolumeLiters")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public float GetWaterRequiredForTreatment(NPC npc)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 1)]
	public NPCAfflictionSavedData Save()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public void Load(NPCAfflictionSavedData saveData)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "OnTreatmentComplete")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "ApplyWaterTreatment")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
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

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CanApplyTreatment")]
	[CallsUnknownMethods(Count = 1)]
	public bool RequiresRemdy()
	{
		return default(bool);
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public NPCAffliction()
	{
	}
}
