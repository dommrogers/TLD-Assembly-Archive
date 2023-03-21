using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RockCacheRegionListItem : MonoBehaviour
{
	public UIWidget m_FadeOnDeselectWidget;

	public GameObject m_SelectedObj;

	public GameObject m_UnselectedObj;

	public float m_DeslectedAlphaValue;

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetSelected(bool selected)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public RockCacheRegionListItem()
	{
	}
}
