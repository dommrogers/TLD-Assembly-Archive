using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;

public class ContainerInteraction : LockedInteraction
{
	private Container m_Container;

	private bool m_IsOpeningContainer;

	public override bool CanInteract
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseHoldInteraction), Member = "get_CanInteract")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(bool);
		}
	}

	[Calls(Type = typeof(LockedInteraction), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "InitializeInteraction")]
	[Calls(Type = typeof(ContainerInteraction), Member = "GetHoverText")]
	[CallsUnknownMethods(Count = 1)]
	public override void InitializeInteraction()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(LockedInteraction), Member = "PerformLockInteraction")]
	[Calls(Type = typeof(SafeCracking), Member = "EnableSafeCrackingInterface")]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	[Calls(Type = typeof(Container), Member = "BeginContainerOpen")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Container), Member = "IsSafeLocked")]
	[Calls(Type = typeof(LockedInteraction), Member = "IsLocked")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "PerformHold")]
	public override bool PerformHold()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ContainerInteraction), Member = "GetHoverText")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Container), Member = "ShowContainerContents")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void TryContainerAgain()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Container), Member = "BeginContainerClose")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(Lock), Member = "FinishForceLock")]
	[CallsUnknownMethods(Count = 2)]
	public override void CancelHold()
	{
	}

	[Calls(Type = typeof(TimedHoldInteraction), Member = "EndHold")]
	[CallerCount(Count = 0)]
	protected override void EndHold()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "UpdateInteraction")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ContainerInteraction), Member = "GetInteractiveActionText")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ContainerInteraction), Member = "GetInteractiveActionText")]
	[Calls(Type = typeof(ContainerInteraction), Member = "GetInteractiveActionText")]
	[Calls(Type = typeof(Container), Member = "IsEmpty")]
	[Calls(Type = typeof(LockedInteraction), Member = "IsLocked")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ContainerInteraction), Member = "GetInteractiveActionText")]
	private string GetHoverText()
	{
		return null;
	}

	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetHoverText")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetHoverText")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetHoverText")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetHoverText")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Container), Member = "IsEmpty")]
	[Calls(Type = typeof(LockedInteraction), Member = "IsLocked")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private string GetInteractiveActionText()
	{
		return null;
	}

	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ContainerInteraction()
	{
	}
}
