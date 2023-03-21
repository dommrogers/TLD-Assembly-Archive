using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class Cairn : MonoBehaviour
{
	public string m_BackerLookupNum;

	public int m_JournalEntryNumber;

	private PanelReference<Panel_HUD> m_HUD;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowCairnNotification")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void PerformInteraction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Cairn()
	{
	}
}
