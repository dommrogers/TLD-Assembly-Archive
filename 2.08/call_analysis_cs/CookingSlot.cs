using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.UI.Generics;

public class CookingSlot : BaseInteraction
{
	public GearPlacePoint m_GearPlacePoint;

	private PanelReference<Panel_ActionPicker> m_ActionPicker;

	private FireplaceInteraction m_FireplaceHost;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 26)]
	public void SetFireplaceHost(FireplaceInteraction fireplaceHost)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(CookingSlot), Member = "CanCookingSlotBeUsed")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CookingSlot), Member = "CanCookingSlotBeUsed")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override bool PerformInteraction()
	{
		return false;
	}

	[CalledBy(Type = typeof(CookingSlot), Member = "UpdateInteraction")]
	[CalledBy(Type = typeof(CookingSlot), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingSlot")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public bool CanCookingSlotBeUsed()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	public CookingSlot()
	{
	}
}
