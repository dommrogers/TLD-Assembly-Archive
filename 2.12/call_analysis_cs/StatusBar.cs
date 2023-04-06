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
	[Calls(Type = typeof(StatusBar), Member = "ToggleAll")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatusBar), Member = "Update")]
	private void OnEnable()
	{
	}

	[CalledBy(Type = typeof(StatusBar), Member = "OnEnable")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateStatusBars")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StatusBar), Member = "UpdateForceShow")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(StatusBar), Member = "SetArrowBools")]
	[Calls(Type = typeof(StatusBar), Member = "SetArrowActiveStates")]
	[Calls(Type = typeof(StatusBar), Member = "SetSpriteColors")]
	[Calls(Type = typeof(StatusBar), Member = "SetActiveBacksplash")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 10)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatusBar), Member = "GetRateOfChange")]
	[Calls(Type = typeof(StatusBar), Member = "SetArrowBools")]
	[CallsUnknownMethods(Count = 2)]
	public int GetNumFreezingEffectArrows()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Action_ShowHUDStatusBar), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ForceShowForSeconds(float secondsToFadeIn, float secondsToShow, float secondsToFadeOut)
	{
	}

	[CallerCount(Count = 0)]
	public void MarkAsChildOfHUD()
	{
	}

	[CalledBy(Type = typeof(StatusBar), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(StatusBar), Member = "ShouldFadeOut")]
	[Calls(Type = typeof(StatusBar), Member = "SetAlpha")]
	[CallsUnknownMethods(Count = 14)]
	private void SetSpriteColors(float fillValue)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggleWIthWolf")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(FireManager), Member = "PointInRadiusOfBurningFire")]
	[Calls(Type = typeof(StatusBar), Member = "GetFillValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	protected virtual bool ShouldBeHidden()
	{
		return false;
	}

	[CalledBy(Type = typeof(StatusBar), Member = "Update")]
	[CalledBy(Type = typeof(StatusBar), Member = "GetNumFreezingEffectArrows")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void SetArrowBools(float rateOfChange)
	{
	}

	[CalledBy(Type = typeof(StatusBar), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void SetArrowActiveStates()
	{
	}

	[CalledBy(Type = typeof(StatusBar), Member = "Awake")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ToggleAll(GameObject[] objects, bool toggleVal)
	{
	}

	[CalledBy(Type = typeof(StatusBar), Member = "ShouldBeHidden")]
	[CalledBy(Type = typeof(StatusBar), Member = "GetReverseFillValue")]
	[CallerCount(Count = 2)]
	private float GetFillValue()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual float GetFillValueThirst()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual float GetFillValueHunger()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual float GetFillValueCold()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual float GetFillValueFatigue()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual float GetFillValueCondition()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatusBar), Member = "GetFillValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetReverseFillValue()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual float GetReverseFillValueFatigue()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[CallsUnknownMethods(Count = 1)]
	protected virtual float GetReverseFillValueCondition()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual float GetBuffFillValue()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[CallsUnknownMethods(Count = 4)]
	protected virtual float GetBuffFillValueCondition()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(StatusBar), Member = "GetNumFreezingEffectArrows")]
	[CallerCount(Count = 1)]
	private float GetRateOfChange()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	protected virtual float GetRateOfChangeThirst()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	protected virtual float GetRateOfChangeHunger()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	protected virtual float GetRateOfChangeCold()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	protected virtual float GetRateOfChangeFatigue()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[Calls(Type = typeof(PlayerManager), Member = "FreezingBuffActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	protected virtual bool IsBuffActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "GetAdjustedMaxHP")]
	[CallsUnknownMethods(Count = 3)]
	protected virtual bool ShouldShowBuffedFillSprite()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "HasAffliction")]
	[CallsUnknownMethods(Count = 4)]
	protected virtual bool IsDebuffActive()
	{
		return false;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(StatusBar), Member = "Update")]
	[CallerCount(Count = 1)]
	private void UpdateForceShow()
	{
	}

	[CalledBy(Type = typeof(StatusBar), Member = "SetSpriteColors")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TweenAlpha), Member = "get_value")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	private void SetAlpha(float alphaVal, float duration)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void UpdateBacksplash(float fillValue)
	{
	}

	[CalledBy(Type = typeof(StatusBar), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	private void SetActiveBacksplash(GameObject activeBacksplash)
	{
	}

	[CalledBy(Type = typeof(StatusBar), Member = "SetSpriteColors")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldFadeOut(float fillValue)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private int GetNumActiveArrows()
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public StatusBar()
	{
	}
}
