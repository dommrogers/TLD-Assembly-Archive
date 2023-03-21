using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NarrativeCollectibleItem : MonoBehaviour
{
	public enum CollectibleType
	{
		Story,
		Note,
		Matchbook,
		Postcard
	}

	public CollectibleType m_Type;

	public string m_NarrativeTextLocID;

	public int m_JournalEntryNumber;

	public NGUIText.Alignment m_TextAlignment;

	public bool m_ShowDuringInspect;

	public LocalizedString m_HudMessageOnPickup;

	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenEquip")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void MaybeShowHudMessage()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateAvailableMementos")]
	[CalledBy(Type = typeof(Panel_Log), Member = "IsActiveMemento")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshCollectibleCounters")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsMementoItem()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public NarrativeCollectibleItem()
	{
	}
}
