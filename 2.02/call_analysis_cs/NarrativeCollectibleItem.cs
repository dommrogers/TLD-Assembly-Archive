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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void MaybeShowHudMessage()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public NarrativeCollectibleItem()
	{
	}
}
