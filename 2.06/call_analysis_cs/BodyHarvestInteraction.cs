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
		[Calls(Type = typeof(BodyHarvestInteraction), Member = "CheckCanInteract")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BodyHarvestInteraction), Member = "GetHoverText")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "InitializeInteraction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public override void InitializeInteraction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BodyHarvestInteraction), Member = "UpdateInteraction")]
	[CalledBy(Type = typeof(BodyHarvestInteraction), Member = "InitializeInteraction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(int), Member = "ToString")]
	private string GetHoverText()
	{
		return null;
	}

	[CalledBy(Type = typeof(BodyHarvestInteraction), Member = "get_CanInteract")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	private bool CheckCanInteract()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BodyHarvestInteraction), Member = "GetHoverText")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallerCount(Count = 0)]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CheckIfResourcesLeft")]
	[Calls(Type = typeof(BodyHarvest), Member = "InteractWithBodyHarvest")]
	[CallsUnknownMethods(Count = 1)]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	public BodyHarvestInteraction()
	{
	}
}
