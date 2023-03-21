using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class Cairn : MonoBehaviour
{
	public string m_BackerLookupNum;

	public int m_JournalEntryNumber;

	private PanelReference<Panel_HUD> m_HUD;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowCairnNotification")]
	[CallsUnknownMethods(Count = 1)]
	public void PerformInteraction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Cairn()
	{
	}
}
