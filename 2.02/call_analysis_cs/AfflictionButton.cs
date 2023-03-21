using Cpp2ILInjected.CallAnalysis;
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

	private bool m_Selected;

	private int m_Index;

	[Calls(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(AfflictionButton), Member = "SetSelected")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "SelectAffliction")]
	[CallsUnknownMethods(Count = 1)]
	private void OnClick()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "SetSelected")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	private void SetColor(bool isSelected)
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckForAfflictionListChange")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "CheckIfSelectedAfflictionHealed")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectAffliction")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "OnClick")]
	[Calls(Type = typeof(AfflictionButton), Member = "SetColor")]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public void SetSelected(bool selected)
	{
	}

	[Calls(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void SetCauseAndEffect(string causeStr, AfflictionType affType, AfflictionBodyArea location, int index, string effectName, string spriteName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetIndex()
	{
		return default(int);
	}

	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "SetColor")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "SetCauseAndEffect")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateCoverFlowColor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateSelectedAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconActiveAnimation")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateBodyIconColors")]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[CallerCount(Count = 6)]
	public Color GetColorBasedOnAffliction(AfflictionType m_AfflictionType, bool isHovering)
	{
		return default(Color);
	}

	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallsUnknownMethods(Count = 47)]
	[CalledBy(Type = typeof(AfflictionButton), Member = "SetCauseAndEffect")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "Update")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetTimeRemainingNormalized")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostTimeRemainingHours")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetTimeRemainingNormalized")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(IntestinalParasites), Member = "GetCurrentRisk")]
	[Calls(Type = typeof(CabinFever), Member = "GetCurrentRisk")]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskValue")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InfectionRisk), Member = "GetCurrentRisk")]
	private void UpdateFillBar()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetAfflictionIndex()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AfflictionButton()
	{
	}
}
