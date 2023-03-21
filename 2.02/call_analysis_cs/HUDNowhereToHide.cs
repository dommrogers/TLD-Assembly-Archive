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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideConditionRelatedLabels")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsNonRadialOverlayActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool ShouldShow()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void MaybeHideToxicFogWarning()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetPercentInCurrentRegion")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "ShowToxicFogIndicator")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "FindFirstDecalOfType")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(EntityWard), Member = "FindByGuid")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "GetWardTimeRemainingScale")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 62)]
	private void Update()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CallerCount(Count = 1)]
	private void ShowToxicFogIndicator(int level)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetSecondsInCurrentRegion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetTimeSecondsToFillUpCurrentRegion")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 17)]
	private void UpdateToxicFogIndicatorLabel(int level)
	{
	}

	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Reset")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "MaybeHideToxicFogWarning")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
	[CalledBy(Type = typeof(HUDNowhereToHide), Member = "NowhereToHideAffliction")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateNowhereToHideEvent")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAfflictionUI")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static void MaybeSetRootActive(GameObject go, bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDNowhereToHide), Member = "MaybeSetRootActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void NowhereToHideAffliction(bool enable)
	{
	}

	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "UpdateAfflictionUI")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public void NowhereToHideAfflictionAlpha(float fearAmount, float anxietyAmount)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HUDNowhereToHide()
	{
	}
}
