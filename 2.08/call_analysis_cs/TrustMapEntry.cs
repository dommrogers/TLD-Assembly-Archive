using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class TrustMapEntry : MonoBehaviour
{
	private PanelReference<Panel_Log> m_LogPanel;

	public GameObject m_LockedUnselected;

	public GameObject m_LockedSelected;

	public GameObject m_UnlockedUnselected;

	public GameObject m_UnlockedSelected;

	private bool m_IsLocked;

	private bool m_IsSelected;

	private int m_Index;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Log), Member = "OnTrustMapClicked")]
	[CallsUnknownMethods(Count = 1)]
	public void TrustMapClicked()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetIndex(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	public void SetLocked(bool isLocked)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	public void SetSelected(bool isSelected)
	{
	}

	[CalledBy(Type = typeof(TrustMapEntry), Member = "SetLocked")]
	[CalledBy(Type = typeof(TrustMapEntry), Member = "SetSelected")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetupTrustMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshTrustMapSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DeselectAllTrustMapEntries")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void RefreshObjects()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TrustMapEntry()
	{
	}
}
