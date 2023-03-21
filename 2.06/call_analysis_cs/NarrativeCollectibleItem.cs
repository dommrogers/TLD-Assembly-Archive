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

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupWithNoInspectScreenEquip")]
	public void MaybeShowHudMessage()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateAvailableMementos")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshCollectibleCounters")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
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
