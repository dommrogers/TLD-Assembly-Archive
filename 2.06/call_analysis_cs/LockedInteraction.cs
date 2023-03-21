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
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(ContainerInteraction), Member = "Awake")]
	[CalledBy(Type = typeof(OpenClose), Member = "Awake")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void Awake()
	{
	}

	[CalledBy(Type = typeof(LoadScene), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(OpenClose), Member = "PerformHold")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LoadScene), Member = "PerformHold")]
	[CalledBy(Type = typeof(OpenClose), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetHoverText")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "PerformHold")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetInteractiveActionText")]
	protected bool IsLocked()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(LoadScene), Member = "PerformHold")]
	[CalledBy(Type = typeof(OpenClose), Member = "PerformHold")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "PerformHold")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "StartAnimatedInteraction")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Lock), Member = "PrepareForceLock")]
	[Calls(Type = typeof(Lock), Member = "CanForceLock")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	protected void PerformLockInteraction()
	{
	}

	[Calls(Type = typeof(LockedInteraction), Member = "FinishForceLock")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void UpdateHoldInteraction(float deltaTime)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Lock), Member = "FinishForceLock")]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LockedInteraction), Member = "OnAnimatedInteractionComplete")]
	[CalledBy(Type = typeof(LockedInteraction), Member = "UpdateHoldInteraction")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Lock), Member = "FinishForceLock")]
	private void FinishForceLock(bool complete)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	public LockedInteraction()
	{
	}
}
