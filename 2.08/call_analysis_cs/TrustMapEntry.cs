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
	[CallsDeduplicatedMethods(Count = 1)]
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

	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	[CallerCount(Count = 0)]
	public void SetLocked(bool isLocked)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrustMapEntry), Member = "RefreshObjects")]
	public void SetSelected(bool isSelected)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshTrustMapSelection")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DeselectAllTrustMapEntries")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshTrustMapSelection")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetupTrustMap")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetupTrustMap")]
	[CalledBy(Type = typeof(TrustMapEntry), Member = "SetSelected")]
	[CalledBy(Type = typeof(TrustMapEntry), Member = "SetLocked")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	private void RefreshObjects()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TrustMapEntry()
	{
	}
}
