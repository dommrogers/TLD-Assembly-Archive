using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;

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
	[CallerCount(Count = 12)]
	public void SetFireplaceHost(FireplaceInteraction fireplaceHost)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(CookingSlot), Member = "CanCookingSlotBeUsed")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(CookingSlot), Member = "CanCookingSlotBeUsed")]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "ShowActionPicker")]
	[CallsUnknownMethods(Count = 2)]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "MaybeUpdateCookingSlot")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CookingSlot), Member = "PerformInteraction")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(CookingSlot), Member = "UpdateInteraction")]
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
