using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
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

	private bool previousFrostbiteState;

	private bool previousHypothermiaState;

	private bool previousInvulnerableState;

	private bool previousPassTimeUISupressedState;

	private bool previousLabelMessageState;

	private const float audioFadeDuration = 1f;

	[CallsUnknownMethods(Count = 59)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(FullScreenMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(AccelTimePopup), Member = "IsLabelMessageActive")]
	[Calls(Type = typeof(Rest), Member = "BeginSleeping")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AccelTimePopup), Member = "EnableLabelMessage")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 17)]
	protected override void OnUpdate()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public Action_PassTime()
	{
	}
}
