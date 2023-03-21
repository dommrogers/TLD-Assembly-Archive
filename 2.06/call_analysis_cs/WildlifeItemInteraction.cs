using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;

public class WildlifeItemInteraction : SimpleInteraction
{
	private BaseAi m_BaseAi;

	private WildlifeItem m_WildlifeItem;

	private BodyHarvest m_BodyHarvest;

	public override bool CanInteract
	{
		[CallsUnknownMethods(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseInteraction), Member = "InitializeInteraction")]
	[CallsUnknownMethods(Count = 2)]
	public override void InitializeInteraction()
	{
	}

	[Calls(Type = typeof(WildlifeItem), Member = "PickupWildlifeItem")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(GearItem), Member = "PerformInteraction")]
	[Calls(Type = typeof(WildlifeItem), Member = "SpawnCarcass")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	public WildlifeItemInteraction()
	{
	}
}
