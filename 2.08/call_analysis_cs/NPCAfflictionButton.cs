using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NPCAfflictionButton : MonoBehaviour
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

	private Action<NPCAfflictionButton> m_OnClickAction;

	private NPCAffliction m_Affliction;

	[CallerCount(Count = 0)]
	public void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetSelected")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnClick()
	{
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CheckForAfflictionListChange")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "CheckIfSelectedAfflictionHealed")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "PostTreatment")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "SetColor")]
	[CalledBy(Type = typeof(NPCAfflictionButton), Member = "OnClick")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectNPCAffliction")]
	public void SetSelected(bool selected)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshScrollList")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "GetColorBasedOnAffliction")]
	public void SetupAffliction(NPCAffliction affliction, Action<NPCAfflictionButton> onClickAction)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public NPCAffliction GetAffliction()
	{
		return null;
	}

	[CalledBy(Type = typeof(NPCAfflictionButton), Member = "SetColor")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateBodyIconActiveAnimation")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateBodyIconColors")]
	[CalledBy(Type = typeof(NPCAfflictionButton), Member = "SetupAffliction")]
	[CallAnalysisFailed]
	[CallerCount(Count = 4)]
	public Color GetColorBasedOnAffliction(AfflictionType afflictionType, bool isHovering)
	{
		return default(Color);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NPCAfflictionButton), Member = "GetColorBasedOnAffliction")]
	[CalledBy(Type = typeof(NPCAfflictionButton), Member = "SetSelected")]
	[CallsUnknownMethods(Count = 1)]
	private void SetColor(bool isSelected)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public NPCAfflictionButton()
	{
	}
}
