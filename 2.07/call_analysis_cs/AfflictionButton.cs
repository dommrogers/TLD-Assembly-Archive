using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class AfflictionButton : MonoBehaviour
{
	public UISprite m_SpriteEffect;

	public UISprite m_SpriteRiskFill;

	public UILabel m_LabelEffect;

	public UILabel m_LabelCause;

	public Color m_NegativeColor;

	public Color m_NegativeColorHover;

	public Color m_RiskColor;

	public Color m_RiskColorHover;

	public Color m_BeneficialColor;

	public Color m_BeneficialColorHover;

	public Color m_CauseColor;

	public Color m_CauseColorHover;

	public float m_BGAlphaWhenSelected;

	public AfflictionType m_AfflictionType;

	public AfflictionBodyArea m_AfflictionLocation;

	public Animator m_AnimatorBuffBar;

	public UISprite m_FillSpriteBuffBar;

	public Transform m_SizeModifierBuffBar;

	public Animator m_AnimatorAfflictionBar;

	public UISprite m_FillSpriteAfflictionBar;

	public Transform m_SizeModifierAfflictionBar;

	public float m_FillSpriteOffset;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private bool m_Selected;

	private int m_Index;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SelectAffliction")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AfflictionButton), Member = "SetSelected")]
	private void OnClick()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "SetSelected")]
	[CallsUnknownMethods(Count = 1)]
	private void SetColor(bool isSelected)
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckForAfflictionListChange")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckIfSelectedAfflictionHealed")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AfflictionButton), Member = "OnClick")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetColor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectAffliction")]
	public void SetSelected(bool selected)
	{
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[Calls(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public void SetCauseAndEffect(string causeStr, AfflictionType affType, AfflictionBodyArea location, int index, string effectName, string spriteName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public int GetIndex()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconColors")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconActiveAnimation")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateSelectedAffliction")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "SetCauseAndEffect")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateCoverFlowColor")]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(AfflictionButton), Member = "SetColor")]
	public Color GetColorBasedOnAffliction(AfflictionType m_AfflictionType, bool isHovering)
	{
		return default(Color);
	}

	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostTimeRemainingHours")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(AfflictionButton), Member = "SetCauseAndEffect")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetTimeRemainingNormalized")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskValue")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InfectionRisk), Member = "GetCurrentRisk")]
	[Calls(Type = typeof(CabinFever), Member = "GetCurrentRisk")]
	[Calls(Type = typeof(Headache), Member = "GetActiveHoursRemaining")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	private void UpdateFillBar()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public int GetAfflictionIndex()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AfflictionButton()
	{
	}
}
