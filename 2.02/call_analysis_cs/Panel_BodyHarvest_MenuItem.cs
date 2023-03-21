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

	public float m_HarvestAmount;

	public float m_HarvestAmountAvailable;

	public float m_HarvestIncrements;

	public AmountType m_AmountType;

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CalledBy(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshLabel")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void RefreshWeightLabel()
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshLabel")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void RefreshUnitLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnChangeHarvestAmount")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshLabels")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshLabels")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshWeightLabel")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshUnitLabel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshLabels")]
	public void RefreshLabel()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvestMenuNavigation")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnChangeHarvestAmount")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnIncreaseHarvestAmount()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnChangeHarvestAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvestMenuNavigation")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnDecreaseMeatHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnDecreaseHideHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnDecreaseGutHarvest")]
	public void OnDecreaseHarvestAmount()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Panel_BodyHarvest_MenuItem()
	{
	}
}
