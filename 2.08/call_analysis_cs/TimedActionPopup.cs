using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class TimedActionPopup : MonoBehaviour
{
	public ButtonPrompt m_ButtonPrompt;

	public UISprite m_ProgressSprite;

	private bool _003Cm_ActionTriggered_003Ek__BackingField;

	private InputManager.InputAction m_Action;

	private float m_DisplayElapsed;

	private float m_DisplayTime;

	private float m_HoldElapsed;

	private float m_HoldTime;

	private string m_LocalizedText;

	private string m_PromptKey;

	private bool m_UpdateButton;

	public bool m_ActionTriggered
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Calls(Type = typeof(TimedActionPopup), Member = "Reset")]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(TimedActionPopup), Member = "Reset")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(TimedActionPopup), Member = "Reset")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TimedActionPopup), Member = "SetPrompt")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnControllerScene(bool isController)
	{
	}

	[CalledBy(Type = typeof(TimedActionPopup), Member = "Setup")]
	[CalledBy(Type = typeof(TimedActionPopup), Member = "Update")]
	[CalledBy(Type = typeof(TimedActionPopup), Member = "Update")]
	[CalledBy(Type = typeof(TimedActionPopup), Member = "Awake")]
	[CallerCount(Count = 4)]
	[CallAnalysisFailed]
	private void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CalledBy(Type = typeof(TimedActionPopup), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void SetPrompt(string prompt, string action)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_TimedActionPopup), Member = "OnExecute")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimedActionPopup), Member = "Reset")]
	public void Setup(float displaytime, float holdtime, string prompt, InputManager.InputAction action)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TimedActionPopup()
	{
	}
}
