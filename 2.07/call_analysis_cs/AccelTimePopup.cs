using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

public class AccelTimePopup : MonoBehaviour
{
	private class GenericTimeAcceleratorProvider : IAccelerateTimeProvider
	{
		public Func<bool> m_IsAcceleratingTime;

		public Func<string> m_GetActionText;

		public Func<string> m_GetSpriteName;

		public Func<Action> m_GetCancelAction;

		[CallerCount(Count = 0)]
		public bool IsAcceleratingTime()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		public string GetActionText()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		public string GetSpriteName()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		public Action GetCancelAction()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public UIPanel GetPanelToFade()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public UIProgressBar GetActionProgress()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public UIWidget GetWidgetToFade()
		{
			return null;
		}

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public void StartAcceleratingTime()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public void StopAcceleratingTime()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public GenericTimeAcceleratorProvider()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<bool> _003C_003E9__30_0;

		public static Func<string> _003C_003E9__30_1;

		public static Func<bool> _003C_003E9__30_4;

		public static Func<string> _003C_003E9__30_5;

		public static Func<bool> _003C_003E9__30_8;

		public static Func<string> _003C_003E9__30_9;

		public static Func<Action> _003C_003E9__30_11;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[Calls(Type = typeof(AccelTimePopup), Member = "GetControlMode")]
		[CallerCount(Count = 0)]
		internal bool _003CAwake_003Eb__30_0()
		{
			return default(bool);
		}

		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallerCount(Count = 0)]
		internal string _003CAwake_003Eb__30_1()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AccelTimePopup), Member = "GetControlMode")]
		internal bool _003CAwake_003Eb__30_4()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		internal string _003CAwake_003Eb__30_5()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		internal bool _003CAwake_003Eb__30_8()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		internal string _003CAwake_003Eb__30_9()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal Action _003CAwake_003Eb__30_11()
		{
			return null;
		}
	}

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

	public string m_IconNameDeployingRope;

	public string m_IconNameTakingRope;

	public string m_IconNameMappingLocalArea;

	private Panel_HUD m_HUD;

	private PanelReference<Panel_GenericProgressBar> m_ProgressBar;

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

	private List<IAccelerateTimeProvider> m_accelerators;

	private List<IAccelerateTimeProvider> m_nonPanelAccelerators;

	private IAccelerateTimeProvider m_activeAccelerator;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 8)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AccelTimePopup), Member = "SetActive")]
	private void ForceDisable()
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AccelTimePopup), Member = "IsLabelMessageActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "ForceDisable")]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "Update")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_timeofday_display")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "CanUserCancelAction")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOff")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CameraFade), Member = "GetTargetAlpha")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(InterfaceManager), Member = "InitializeAndActivateTimeWidget")]
	[Calls(Type = typeof(InterfaceManager), Member = "SetTimeWidgetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public void SetActive(bool active, bool fadeIn)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[CallsUnknownMethods(Count = 1)]
	public void OnCancel()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void SetLabelMessageLocIdAndDuration(string localizationId, float duration, float fadeduration, float delay)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Rest.PassTimeHelper), Member = "OnSleepEnd")]
	[CalledBy(Type = typeof(Action_PassTime), Member = "OnUpdate")]
	[CallsUnknownMethods(Count = 3)]
	public void EnableLabelMessage(bool enabled)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_PassTime), Member = "OnExecute")]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Rest.PassTimeHelper), Member = "PassTime")]
	public bool IsLabelMessageActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void SupressPassTimeUI(bool isSuppressed)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsPassTimeUISuppressed()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(_003C_003Ec), Member = "<Awake>b__30_0")]
	[CalledBy(Type = typeof(_003C_003Ec), Member = "<Awake>b__30_4")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private static PlayerControlMode GetControlMode()
	{
		return default(PlayerControlMode);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AccelTimePopup()
	{
	}
}
