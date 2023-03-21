using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_BodyHarvest_MenuItem : Panel_Base
{
	public enum AmountType
	{
		Weight,
		Unit
	}

	private delegate void OnMethod();

	public GameObject m_Button_Increase;

	public GameObject m_Button_Decrease;

	public GameObject m_Background;

	public UILabel m_LabelItemAmount;

	public UITexture m_MeatTexture;

	public float m_HarvestAmount;

	public float m_HarvestAmountAvailable;

	public float m_HarvestIncrements;

	public AmountType m_AmountType;

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshLabel")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void RefreshWeightLabel()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshLabel")]
	[CallsUnknownMethods(Count = 23)]
	private void RefreshUnitLabel()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshLabels")]
	[CalledBy(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnChangeHarvestAmount")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshLabels")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshWeightLabel")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshUnitLabel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshLabels")]
	public void RefreshLabel()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsUnknownMethods(Count = 1)]
	public void MaybeRefreshTexture(GearItem gearItem, float carcassCondition)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshLabel")]
	[CalledBy(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnIncreaseHarvestAmount")]
	[CalledBy(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnDecreaseHarvestAmount")]
	private void OnChangeHarvestAmount(float increment)
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnIncreaseGutHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnIncreaseHideHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnIncreaseMeatHarvest")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnChangeHarvestAmount")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvestMenuNavigation")]
	public void OnIncreaseHarvestAmount()
	{
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnChangeHarvestAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvestMenuNavigation")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnDecreaseMeatHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnDecreaseHideHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnDecreaseGutHarvest")]
	public void OnDecreaseHarvestAmount()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Panel_BodyHarvest_MenuItem()
	{
	}
}
