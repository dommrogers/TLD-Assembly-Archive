using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using UnityEngine;

public class BodyHarvestInteraction : SimpleInteraction
{
	private BodyHarvest m_BodyHarvest;

	private string m_BodyName;

	private int m_LastFrozenPercentage;

	public override bool CanInteract
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BodyHarvestInteraction), Member = "CheckCanInteract")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "InitializeInteraction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BodyHarvestInteraction), Member = "GetHoverText")]
	[CallsUnknownMethods(Count = 2)]
	public override void InitializeInteraction()
	{
	}

	[CalledBy(Type = typeof(BodyHarvestInteraction), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(BodyHarvestInteraction), Member = "UpdateInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
	private string GetHoverText()
	{
		return null;
	}

	[CalledBy(Type = typeof(BodyHarvestInteraction), Member = "get_CanInteract")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 2)]
	private bool CheckCanInteract()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(BodyHarvestInteraction), Member = "GetHoverText")]
	[CallsUnknownMethods(Count = 3)]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CheckIfResourcesLeft")]
	[Calls(Type = typeof(BodyHarvest), Member = "InteractWithBodyHarvest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override bool PerformInteraction()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	public BodyHarvestInteraction()
	{
	}
}
