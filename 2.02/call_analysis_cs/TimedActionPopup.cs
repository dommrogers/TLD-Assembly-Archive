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
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(TimedActionPopup), Member = "Reset")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(TimedActionPopup), Member = "SetPrompt")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnControllerScene(bool isController)
	{
	}

	[CalledBy(Type = typeof(TimedActionPopup), Member = "Update")]
	[CalledBy(Type = typeof(TimedActionPopup), Member = "Awake")]
	[CalledBy(Type = typeof(TimedActionPopup), Member = "Update")]
	[CallAnalysisFailed]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(TimedActionPopup), Member = "Setup")]
	private void Reset()
	{
	}

	[CalledBy(Type = typeof(TimedActionPopup), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void SetPrompt(string prompt, string action)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TimedActionPopup), Member = "Reset")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Action_TimedActionPopup), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	public void Setup(float displaytime, float holdtime, string prompt, InputManager.InputAction action)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public TimedActionPopup()
	{
	}
}
