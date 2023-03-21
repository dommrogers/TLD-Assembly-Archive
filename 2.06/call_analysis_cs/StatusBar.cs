using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.UI.Generics;
using UnityEngine;

public class StatusBar : MonoBehaviour
{
	public enum StatusBarType
	{
		Cold,
		Hunger,
		Thirst,
		Fatigue,
		Condition
	}

	public StatusBarType m_StatusBarType;

	public GameObject m_HierarchyRoot;

	public GameObject[] m_UpArrows;

	public GameObject[] m_DownArrows;

	public float m_MediumThreshold;

	public float m_HighThreshold;

	public UISprite m_OuterBoxSprite;

	public float m_AlphaWhenHUDFadedOut;

	public float m_ThresholdHUDFadeOut;

	public float m_ThresholdCritical;

	public UISprite m_FillSprite;

	public UISprite m_ReverseFillSprite;

	public UISprite m_BuffFillSprite;

	public UISprite m_SpriteWhenEmpty;

	public GameObject m_BuffObject;

	public GameObject m_DebuffObject;

	public Vector2 m_FillValueRangeActive;

	public float m_FillSpriteOffset;

	public GameObject m_BacksplashDepleted;

	public GameObject m_BacksplashCritical;

	public GameObject m_BacksplashDebuff;

	public GameObject m_BacksplashBuff;

	public GameObject m_BacksplashNormal;

	public GameObject m_NoBuffFillObject;

	public GameObject m_BuffFillObject;

	public bool m_IsOnHUD;

	private PanelReference<Panel_Actions> m_Actions;

	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	private PanelReference<Panel_HUD> m_HUD;

	private bool[] m_UpArrowsEnabled;

	private bool[] m_DownArrowsEnabled;

	private bool m_ForceShow;

	private float m_ForceShowStartTime;

	private float m_ForceShowSecondsToFadeIn;

	private float m_ForceShowSecondsToShow;

	private float m_ForceShowSecondsToFadeOut;

	private TweenAlpha m_TweenAlpha;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(StatusBar), Member = "ToggleAll")]
	[Calls(Type = typeof(StatusBar), Member = "ToggleAll")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsUnknownMethods(Count = 9)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(StatusBar), Member = "Update")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStatusBars")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CalledBy(Type = typeof(StatusBar), Member = "OnEnable")]
	[Calls(Type = typeof(StatusBar), Member = "SetActiveBacksplash")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(StatusBar), Member = "SetSpriteColors")]
	[Calls(Type = typeof(StatusBar), Member = "SetArrowActiveStates")]
	[Calls(Type = typeof(StatusBar), Member = "SetArrowBools")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 21)]
	[Calls(Type = typeof(StatusBar), Member = "UpdateForceShow")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatusBar), Member = "GetRateOfChange")]
	[Calls(Type = typeof(StatusBar), Member = "SetArrowBools")]
	[CallsUnknownMethods(Count = 2)]
	public int GetNumFreezingEffectArrows()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_ShowHUDStatusBar), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void ForceShowForSeconds(float secondsToFadeIn, float secondsToShow, float secondsToFadeOut)
	{
	}

	[CallerCount(Count = 0)]
	public void MarkAsChildOfHUD()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(StatusBar), Member = "Update")]
	[Calls(Type = typeof(StatusBar), Member = "SetAlpha")]
	[Calls(Type = typeof(StatusBar), Member = "ShouldFadeOut")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	private void SetSpriteColors(float fillValue)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(StatusBar), Member = "GetFillValue")]
	[Calls(Type = typeof(FireManager), Member = "PointInRadiusOfBurningFire")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	protected virtual bool ShouldBeHidden()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(StatusBar), Member = "Update")]
	[CalledBy(Type = typeof(StatusBar), Member = "GetNumFreezingEffectArrows")]
	[CallsUnknownMethods(Count = 2)]
	private void SetArrowBools(float rateOfChange)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(StatusBar), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void SetArrowActiveStates()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(StatusBar), Member = "Awake")]
	[CalledBy(Type = typeof(StatusBar), Member = "Awake")]
	[CallsUnknownMethods(Count = 3)]
	private void ToggleAll(GameObject[] objects, bool toggleVal)
	{
	}

	[CalledBy(Type = typeof(StatusBar), Member = "ShouldBeHidden")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(StatusBar), Member = "GetReverseFillValue")]
	private float GetFillValue()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected virtual float GetFillValueThirst()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual float GetFillValueHunger()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual float GetFillValueCold()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual float GetFillValueFatigue()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual float GetFillValueCondition()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StatusBar), Member = "GetFillValue")]
	private float GetReverseFillValue()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected virtual float GetReverseFillValueFatigue()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[CallsUnknownMethods(Count = 1)]
	protected virtual float GetReverseFillValueCondition()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual float GetBuffFillValue()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[CallsUnknownMethods(Count = 4)]
	protected virtual float GetBuffFillValueCondition()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(StatusBar), Member = "GetNumFreezingEffectArrows")]
	private float GetRateOfChange()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	protected virtual float GetRateOfChangeThirst()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	protected virtual float GetRateOfChangeHunger()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	protected virtual float GetRateOfChangeCold()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	protected virtual float GetRateOfChangeFatigue()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[Calls(Type = typeof(PlayerManager), Member = "FreezingBuffActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallsUnknownMethods(Count = 7)]
	protected virtual bool IsBuffActive()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	protected virtual bool ShouldShowBuffedFillSprite()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Condition), Member = "HasAffliction")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	protected virtual bool IsDebuffActive()
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(StatusBar), Member = "Update")]
	private void UpdateForceShow()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(StatusBar), Member = "SetSpriteColors")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenAlpha), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	private void SetAlpha(float alphaVal, float duration)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void UpdateBacksplash(float fillValue)
	{
	}

	[CalledBy(Type = typeof(StatusBar), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void SetActiveBacksplash(GameObject activeBacksplash)
	{
	}

	[CalledBy(Type = typeof(StatusBar), Member = "SetSpriteColors")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private bool ShouldFadeOut(float fillValue)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private int GetNumActiveArrows()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public StatusBar()
	{
	}
}
