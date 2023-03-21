using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RockCacheRegionListItem : MonoBehaviour
{
	public UIWidget m_FadeOnDeselectWidget;

	public GameObject m_SelectedObj;

	public GameObject m_UnselectedObj;

	public float m_DeslectedAlphaValue;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SetSelected(bool selected)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public RockCacheRegionListItem()
	{
	}
}
