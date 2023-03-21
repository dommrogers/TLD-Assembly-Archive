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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LockedInteraction), Member = "Awake")]
	protected override void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "InitializeInteraction")]
	[Calls(Type = typeof(ContainerInteraction), Member = "GetHoverText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override void InitializeInteraction()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(LockedInteraction), Member = "PerformLockInteraction")]
	[Calls(Type = typeof(SafeCracking), Member = "EnableSafeCrackingInterface")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Container), Member = "BeginContainerOpen")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Container), Member = "IsSafeLocked")]
	[Calls(Type = typeof(LockedInteraction), Member = "IsLocked")]
	[Calls(Type = typeof(MapDetail), Member = "Unlock")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "PerformHold")]
	public override bool PerformHold()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(ContainerInteraction), Member = "GetHoverText")]
	[CallsUnknownMethods(Count = 1)]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Container), Member = "ShowContainerContents")]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void TryContainerAgain()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Container), Member = "BeginContainerClose")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public override void CancelHold()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "EndHold")]
	protected override void EndHold()
	{
	}

	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjectiveIndex")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "UpdateInteraction")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "InitializeInteraction")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Container), Member = "IsEmpty")]
	[Calls(Type = typeof(ContainerInteraction), Member = "GetInteractiveActionText")]
	[Calls(Type = typeof(ContainerInteraction), Member = "GetInteractiveActionText")]
	[Calls(Type = typeof(ContainerInteraction), Member = "GetInteractiveActionText")]
	[Calls(Type = typeof(ContainerInteraction), Member = "GetInteractiveActionText")]
	[Calls(Type = typeof(LockedInteraction), Member = "IsLocked")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private string GetHoverText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetHoverText")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetHoverText")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetHoverText")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "GetHoverText")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ContainerInteraction()
	{
	}
}
