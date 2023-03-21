using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using SpecialEvents;
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

	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Initialize")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public void Reset()
	{
	}

	[Calls(Type = typeof(Panel_HUD), Member = "IsNonRadialOverlayActive")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	public bool ShouldShow()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	public void MaybeHideToxicFogWarning()
	{
	}

	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EntityWard), Member = "FindByGuid")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "GetWardTimeRemainingScale")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 62)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "ShowToxicFogIndicator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CallAnalysisFailed]
	private void ShowToxicFogIndicator(int level)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateToxicFogIndicatorLabel(int level)
	{
	}

	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "NowhereToHideAffliction")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateNowhereToHideEvent")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAfflictionUI")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Reset")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "MaybeHideToxicFogWarning")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Reset")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Reset")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Reset")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Reset")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	private static void MaybeSetRootActive(GameObject go, bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	public void NowhereToHideAffliction(bool enable)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAfflictionUI")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public void NowhereToHideAfflictionAlpha(float fearAmount, float anxietyAmount)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public HUDNowhereToHide()
	{
	}
}
