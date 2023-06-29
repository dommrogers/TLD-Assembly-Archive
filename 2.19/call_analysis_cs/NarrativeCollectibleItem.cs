using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NarrativeCollectibleItem : MonoBehaviour
{
	public enum CollectibleType
	{
		Story,
		Note,
		Matchbook,
		Postcard,
		Recipe
	}

	public CollectibleType m_Type;

	public string m_NarrativeTextLocID;

	public int m_JournalEntryNumber;

	public NGUIText.Alignment m_TextAlignment;

	public bool m_ShowDuringInspect;

	public LocalizedString m_HudMessageOnPickup;

	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenEquip")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void MaybeShowHudMessage()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateAvailableMementos")]
	[CalledBy(Type = typeof(Panel_Log), Member = "IsActiveMemento")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshCollectibleCounters")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsMementoItem()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public NarrativeCollectibleItem()
	{
	}
}
