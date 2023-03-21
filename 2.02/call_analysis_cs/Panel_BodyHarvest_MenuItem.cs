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

	[CalledBy(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshLabel")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshWeightLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshLabel")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	private void RefreshUnitLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "RefreshLabels")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnChangeHarvestAmount")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshUnitLabel")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshWeightLabel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void RefreshLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnIncreaseHarvestAmount")]
	[CalledBy(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnDecreaseHarvestAmount")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "RefreshLabel")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnChangeHarvestAmount(float increment)
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvestMenuNavigation")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnIncreaseMeatHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnIncreaseHideHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnIncreaseGutHarvest")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnChangeHarvestAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnIncreaseHarvestAmount()
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateHarvestMenuNavigation")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnDecreaseMeatHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnDecreaseHideHarvest")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnDecreaseGutHarvest")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "OnChangeHarvestAmount")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnDecreaseHarvestAmount()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Panel_BodyHarvest_MenuItem()
	{
	}
}
