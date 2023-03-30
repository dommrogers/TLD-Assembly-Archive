using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;

public class LockedInteraction : TimedHoldInteraction
{
	private PanelReference<Panel_HUD> m_HUD;

	private Lock _003CLock_003Ek__BackingField;

	private bool m_IsForcingLock;

	private float m_LockTimer;

	public Lock Lock
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(ContainerInteraction), Member = "Awake")]
	[CalledBy(Type = typeof(OpenClose), Member = "Awake")]
	[CalledBy(Type = typeof(LoadScene), Member = "Awake")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	protected virtual void Awake()
	{
	}

	[CalledBy(Type = typeof(ContainerInteraction), Member = "PerformHold")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetHoverText")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetInteractiveActionText")]
	[CalledBy(Type = typeof(OpenClose), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(OpenClose), Member = "PerformHold")]
	[CalledBy(Type = typeof(LoadScene), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(LoadScene), Member = "PerformHold")]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	protected bool IsLocked()
	{
		return false;
	}

	[CalledBy(Type = typeof(ContainerInteraction), Member = "PerformHold")]
	[CalledBy(Type = typeof(OpenClose), Member = "PerformHold")]
	[CalledBy(Type = typeof(LoadScene), Member = "PerformHold")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Lock), Member = "CanForceLock")]
	[Calls(Type = typeof(Lock), Member = "PrepareForceLock")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected void PerformLockInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LockedInteraction), Member = "FinishForceLock")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected override void UpdateHoldInteraction(float deltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void CancelHold()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(LockedInteraction), Member = "FinishForceLock")]
	[CallsUnknownMethods(Count = 1)]
	private void OnAnimatedInteractionComplete()
	{
	}

	[CalledBy(Type = typeof(LockedInteraction), Member = "UpdateHoldInteraction")]
	[CalledBy(Type = typeof(LockedInteraction), Member = "OnAnimatedInteractionComplete")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(Lock), Member = "FinishForceLock")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
