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

	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(StatusBar), Member = "ToggleAll")]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatusBar), Member = "ToggleAll")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatusBar), Member = "Update")]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(StatusBar), Member = "SetSpriteColors")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStatusBars")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CalledBy(Type = typeof(StatusBar), Member = "OnEnable")]
	[Calls(Type = typeof(StatusBar), Member = "SetActiveBacksplash")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(StatusBar), Member = "SetArrowBools")]
	[Calls(Type = typeof(StatusBar), Member = "SetArrowActiveStates")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StatusBar), Member = "UpdateForceShow")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void Update()
	{
	}

	[Calls(Type = typeof(StatusBar), Member = "SetArrowBools")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatusBar), Member = "GetRateOfChange")]
	public int GetNumFreezingEffectArrows()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_ShowHUDStatusBar), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	public void ForceShowForSeconds(float secondsToFadeIn, float secondsToShow, float secondsToFadeOut)
	{
	}

	[CallerCount(Count = 0)]
	public void MarkAsChildOfHUD()
	{
	}

	[Calls(Type = typeof(StatusBar), Member = "ShouldFadeOut")]
	[Calls(Type = typeof(StatusBar), Member = "SetAlpha")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(StatusBar), Member = "Update")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallerCount(Count = 1)]
	private void SetSpriteColors(float fillValue)
	{
	}

	[Calls(Type = typeof(StatusBar), Member = "GetFillValue")]
	[Calls(Type = typeof(FireManager), Member = "PointInRadiusOfBurningFire")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	protected virtual bool ShouldBeHidden()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(StatusBar), Member = "GetNumFreezingEffectArrows")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(StatusBar), Member = "Update")]
	private void SetArrowBools(float rateOfChange)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(StatusBar), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	private void SetArrowActiveStates()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(StatusBar), Member = "Awake")]
	[CalledBy(Type = typeof(StatusBar), Member = "Awake")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ToggleAll(GameObject[] objects, bool toggleVal)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(StatusBar), Member = "ShouldBeHidden")]
	[CalledBy(Type = typeof(StatusBar), Member = "GetReverseFillValue")]
	private float GetFillValue()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual float GetFillValueThirst()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected virtual float GetFillValueHunger()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual float GetReverseFillValueFatigue()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	protected virtual float GetRateOfChangeThirst()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[Calls(Type = typeof(PlayerManager), Member = "FreezingBuffActive")]
	[CallsUnknownMethods(Count = 7)]
	protected virtual bool IsBuffActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	protected virtual bool ShouldShowBuffedFillSprite()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "HasAffliction")]
	[CallsUnknownMethods(Count = 4)]
	protected virtual bool IsDebuffActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(StatusBar), Member = "Update")]
	private void UpdateForceShow()
	{
	}

	[CalledBy(Type = typeof(StatusBar), Member = "SetSpriteColors")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(TweenAlpha), Member = "get_value")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
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
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
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
