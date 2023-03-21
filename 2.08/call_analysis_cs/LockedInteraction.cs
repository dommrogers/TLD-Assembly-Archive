using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.UI.Generics;

public class LockedInteraction : TimedHoldInteraction
{
	private PanelReference<Panel_HUD> m_HUD;

	private Lock _003CLock_003Ek__BackingField;

	private bool m_IsForcingLock;

	private float m_LockTimer;

	public Lock Lock
	{
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "Awake")]
	[CalledBy(Type = typeof(OpenClose), Member = "Awake")]
	[CalledBy(Type = typeof(LoadScene), Member = "Awake")]
	protected virtual void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "PerformHold")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetHoverText")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetInteractiveActionText")]
	[CalledBy(Type = typeof(OpenClose), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(OpenClose), Member = "PerformHold")]
	[CalledBy(Type = typeof(LoadScene), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(LoadScene), Member = "PerformHold")]
	protected bool IsLocked()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ContainerInteraction), Member = "PerformHold")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LoadScene), Member = "PerformHold")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CalledBy(Type = typeof(OpenClose), Member = "PerformHold")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[Calls(Type = typeof(Lock), Member = "PrepareForceLock")]
	[Calls(Type = typeof(Lock), Member = "CanForceLock")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	protected void PerformLockInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(LockedInteraction), Member = "FinishForceLock")]
	[CallsUnknownMethods(Count = 1)]
	protected override void UpdateHoldInteraction(float deltaTime)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	public override void CancelHold()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LockedInteraction), Member = "FinishForceLock")]
	[CallsUnknownMethods(Count = 1)]
	private void OnAnimatedInteractionComplete()
	{
	}

	[CalledBy(Type = typeof(LockedInteraction), Member = "OnAnimatedInteractionComplete")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LockedInteraction), Member = "UpdateHoldInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Lock), Member = "FinishForceLock")]
	private void FinishForceLock(bool complete)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public LockedInteraction()
	{
	}
}
