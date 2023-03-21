using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.UI.Generics;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_PassTime : ActionTask
{
	public BBParameter<int> wakingHour;

	public BBParameter<bool> useWakingHour;

	public BBParameter<int> minSleepingHours;

	public BBParameter<bool> suppressUI;

	public BBParameter<bool> fadeAudio;

	public BBParameter<float> sleepFadeOutSeconds;

	public BBParameter<float> totalDisplaySeconds;

	public BBParameter<string> messageId;

	public BBParameter<bool> usePassTimeFade;

	public BBParameter<bool> showCancelButton;

	public BBParameter<bool> invulnerable;

	private PanelReference<Panel_HUD> m_HUD;

	private bool previousFrostbiteState;

	private bool previousHypothermiaState;

	private bool previousInvulnerableState;

	private bool previousPassTimeUISupressedState;

	private bool previousLabelMessageState;

	private const float audioFadeDuration = 1f;

	[Calls(Type = typeof(Rest), Member = "BeginSleeping")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(FullScreenMessage), Member = "AddMessage")]
	[Calls(Type = typeof(AccelTimePopup), Member = "IsLabelMessageActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(AccelTimePopup), Member = "EnableLabelMessage")]
	[CallsUnknownMethods(Count = 5)]
	protected override void OnUpdate()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public Action_PassTime()
	{
	}
}
