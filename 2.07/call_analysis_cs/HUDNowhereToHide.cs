using System;
using Cpp2ILInjected.CallAnalysis;
using SpecialEvents;
using TLD.Gameplay.Challenges.DarkWalker;
using TLD.UI.Generics;
using UnityEngine;

public class HUDNowhereToHide : MonoBehaviour
{
	[Serializable]
	public struct GlyphData
	{
		public NowhereToHide.GlyphTypes m_Type;

		public LocalizedString m_Name;

		public string m_Texture;
	}

	public Panel_HUD m_HUD;

	private PanelReference<Panel_Loading> m_Loading;

	public ToxicFogConfig m_ToxicFogConfig;

	public UISprite m_LureGlyphProgressSprite;

	public GameObject m_LureGlyphRoot;

	public UISprite m_WardGlyphProgressSprite;

	public GameObject m_WardGlyphRoot;

	public UILabel m_EntityDistanceLabel;

	public GameObject m_EntityDistanceRoot;

	public UILabel m_StartCountdownLabel;

	public GameObject m_StartCountdownRoot;

	public GameObject m_ToxicFogWarningRoot;

	public float m_ToxicFogWarningThreshold;

	public GameObject m_ToxicFogIndicatorLevel1;

	public GameObject m_ToxicFogIndicatorLevel2;

	public GameObject m_ToxicFogIndicatorLevel3;

	public UILabel m_ToxicFogIndicatorLabel;

	public GameObject m_AfflictionRoot;

	public UITexture m_NowhereToHideMould;

	public float m_WardIndicatorInactiveFadeValue;

	private Material m_MouldMaterial;

	private static readonly int s_AnxietyAmountID;

	private static readonly int s_FearAmountID;

	private bool m_IsLureActive;

	private bool m_IsWardActive;

	private int m_ToxicFogSecondsRemaining;

	private UIWidget[] m_WardIndicatorWidgets;

	private float[] m_WardIndicatorWidgetAlphas;

	private bool m_HasShownToxicFogWarning;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Start()
	{
	}

	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Initialize")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void Reset()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsNonRadialOverlayActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	public bool ShouldShow()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	public void MaybeHideToxicFogWarning()
	{
	}

	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "ShowToxicFogIndicator")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EntityWard), Member = "FindByGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "GetWardTimeRemainingScale")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	private void ShowToxicFogIndicator(int level)
	{
	}

	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentScene")]
	private void UpdateToxicFogIndicatorLabel(int level)
	{
	}

	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAfflictionUI")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateNowhereToHideEvent")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "NowhereToHideAffliction")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Reset")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Reset")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Reset")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Reset")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Reset")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "MaybeHideToxicFogWarning")]
	private static void MaybeSetRootActive(GameObject go, bool enabled)
	{
	}

	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[CallerCount(Count = 0)]
	public void NowhereToHideAffliction(bool enable)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAfflictionUI")]
	[CallsUnknownMethods(Count = 1)]
	public void NowhereToHideAfflictionAlpha(float fearAmount, float anxietyAmount)
	{
	}

	[CallerCount(Count = 0)]
	public HUDNowhereToHide()
	{
	}
}
