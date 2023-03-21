using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;

public class WildlifeItemInteraction : SimpleInteraction
{
	private BaseAi m_BaseAi;

	private WildlifeItem m_WildlifeItem;

	private BodyHarvest m_BodyHarvest;

	public override bool CanInteract
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseInteraction), Member = "InitializeInteraction")]
	public override void InitializeInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(WildlifeItem), Member = "SpawnCarcass")]
	[Calls(Type = typeof(GearItem), Member = "PerformInteraction")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(WildlifeItem), Member = "PickupWildlifeItem")]
	[CallsUnknownMethods(Count = 2)]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public WildlifeItemInteraction()
	{
	}
}
