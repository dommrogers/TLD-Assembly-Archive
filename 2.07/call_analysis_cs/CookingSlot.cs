using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.UI.Generics;

public class CookingSlot : BaseInteraction
{
	public GearPlacePoint m_GearPlacePoint;

	private PanelReference<Panel_ActionPicker> m_ActionPicker;

	private FireplaceInteraction m_FireplaceHost;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 13)]
	public void SetFireplaceHost(FireplaceInteraction fireplaceHost)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(CookingSlot), Member = "CanCookingSlotBeUsed")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[Calls(Type = typeof(CookingSlot), Member = "CanCookingSlotBeUsed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(CookingSlot), Member = "UpdateInteraction")]
	[CalledBy(Type = typeof(CookingSlot), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingSlot")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanCookingSlotBeUsed()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	public CookingSlot()
	{
	}
}
