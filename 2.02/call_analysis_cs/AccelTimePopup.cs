using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class AccelTimePopup : MonoBehaviour
{
	public RopeAnchorPoint m_ActiveRopeAnchorPoint;

	public UILabel m_Label_Action;

	public UILabel m_Label_Message;

	public UISprite m_Sprite_Action;

	public UIProgressBar m_Slider;

	public GameObject m_RestingObject;

	public GameObject m_ActionObject;

	public GameObject m_BackButtonObject;

	public float m_NonFullFadeValue;

	public float m_NonFullFadeDuration;

	public GameObject m_TimeWidgetPos;

	public string m_IconNameHarvestCarcass;

	public string m_IconNameCrafting;

	public string m_IconNameBoiling;

	public string m_IconNameCooking;

	public string m_IconNameHeatingUp;

	public string m_IconNameMelting;

	public string m_IconNamePurifyingWater;

	public string m_IconNameHarvestingItem;

	public string m_IconNameRepairingItem;

	public string m_IconNameCleaningRifle;

	public string m_IconNameSharpening;

	public string m_IconNameResearching;

	public string m_IconNameBreakingDown;

	public string m_IconNameDeployingRope;

	public string m_IconNameTakingRope;

	public string m_IconNameBuildingSnowShelter;

	public string m_IconNameRepairingSnowShelter;

	public string m_IconNameHarvestingSnowShelter;

	public string m_IconNameBuildingLeanTo;

	public string m_IconNameRepairingLeanTo;

	public string m_IconNameHarvestingLeanTo;

	public string m_IconNameRotatingLeanTo;

	public string m_IconNameMappingLocalArea;

	private Action m_CancelCallback;

	private bool m_Active;

	private UIProgressBar m_SliderFromPanel;

	private UIPanel m_PanelToFade;

	private UIWidget m_WidgetToFade;

	private float m_MessageDuration;

	private float m_MessageFadeDuration;

	private float m_MessageTimer;

	private float m_MessageStartFadeoutTime;

	private float m_MessageDelay;

	private bool m_IsPassTimeUISuppressed;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AccelTimePopup), Member = "SetActive")]
	private void ForceDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[Calls(Type = typeof(AccelTimePopup), Member = "IsLabelMessageActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(AccelTimePopup), Member = "ForceDisable")]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "Update")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_timeofday_display")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIPanel), Member = "set_depth")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOff")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(CameraFade), Member = "GetTargetAlpha")]
	[Calls(Type = typeof(UIWidget), Member = "get_color")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "CanUserCancelAction")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(AccelTimePopup), Member = "HarvestInProgress")]
	[Calls(Type = typeof(Panel_Repair), Member = "RepairInProgress")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "IsCrafting")]
	[Calls(Type = typeof(Panel_SnowShelterInteract), Member = "IsDismantling")]
	[Calls(Type = typeof(Panel_LeanToInteract), Member = "IsRotating")]
	[Calls(Type = typeof(PassTime), Member = "IsPassingTime")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "IsHarvesting")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "IsRepairing")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "IsCleaning")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "IsSharpening")]
	[Calls(Type = typeof(Panel_Inventory_Examine), Member = "IsReading")]
	[Calls(Type = typeof(UILabel), Member = "get_text")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 307)]
	public void SetActive(bool active, bool fadeIn)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void OnCancel()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetLabelMessageLocIdAndDuration(string localizationId, float duration, float fadeduration, float delay)
	{
	}

	[CalledBy(Type = typeof(Rest.PassTimeHelper), Member = "OnSleepEnd")]
	[CalledBy(Type = typeof(Action_PassTime), Member = "OnUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void EnableLabelMessage(bool enabled)
	{
	}

	[CalledBy(Type = typeof(Rest.PassTimeHelper), Member = "PassTime")]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "Update")]
	[CalledBy(Type = typeof(Action_PassTime), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public bool IsLabelMessageActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void SupressPassTimeUI(bool isSuppressed)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public bool IsPassTimeUISuppressed()
	{
		return false;
	}

	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Harvest), Member = "HarvestInProgress")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool HarvestInProgress()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AccelTimePopup()
	{
	}
}
