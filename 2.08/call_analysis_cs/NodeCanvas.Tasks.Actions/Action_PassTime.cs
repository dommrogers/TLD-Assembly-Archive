using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.UI.Generics;

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

	[Calls(Type = typeof(FullScreenMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Rest), Member = "BeginSleeping")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(AccelTimePopup), Member = "IsLabelMessageActive")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AccelTimePopup), Member = "EnableLabelMessage")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	public Action_PassTime()
	{
	}
}
