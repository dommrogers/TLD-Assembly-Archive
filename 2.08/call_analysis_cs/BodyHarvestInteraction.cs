using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;

public class BodyHarvestInteraction : SimpleInteraction
{
	private BodyHarvest m_BodyHarvest;

	private string m_BodyName;

	private int m_LastFrozenPercentage;

	public override bool CanInteract
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(BodyHarvestInteraction), Member = "CheckCanInteract")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(BodyHarvestInteraction), Member = "GetHoverText")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "InitializeInteraction")]
	public override void InitializeInteraction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BodyHarvestInteraction), Member = "UpdateInteraction")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(BodyHarvestInteraction), Member = "InitializeInteraction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Replace")]
	private string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(BodyHarvestInteraction), Member = "get_CanInteract")]
	[CallsUnknownMethods(Count = 2)]
	private bool CheckCanInteract()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(BodyHarvestInteraction), Member = "GetHoverText")]
	[CallsUnknownMethods(Count = 3)]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_BodyHarvest), Member = "CheckIfResourcesLeft")]
	[Calls(Type = typeof(BodyHarvest), Member = "InteractWithBodyHarvest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
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
