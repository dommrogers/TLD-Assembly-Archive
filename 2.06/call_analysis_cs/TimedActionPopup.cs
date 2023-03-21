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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimedActionPopup), Member = "Reset")]
	public void Awake()
	{
	}

	[Calls(Type = typeof(TimedActionPopup), Member = "Reset")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(TimedActionPopup), Member = "Reset")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(TimedActionPopup), Member = "SetPrompt")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[CallerCount(Count = 4)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(TimedActionPopup), Member = "Awake")]
	private void Reset()
	{
	}

	[CalledBy(Type = typeof(TimedActionPopup), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CallsUnknownMethods(Count = 1)]
	private void SetPrompt(string prompt, string action)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Action_TimedActionPopup), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimedActionPopup), Member = "Reset")]
	public void Setup(float displaytime, float holdtime, string prompt, InputManager.InputAction action)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public TimedActionPopup()
	{
	}
}
