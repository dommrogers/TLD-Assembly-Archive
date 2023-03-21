using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Cairn : MonoBehaviour
{
	public string m_BackerLookupNum;

	public int m_JournalEntryNumber;

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowCairnNotification")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public Cairn()
	{
	}
}
