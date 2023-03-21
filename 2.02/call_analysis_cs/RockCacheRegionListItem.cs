using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RockCacheRegionListItem : MonoBehaviour
{
	public UIWidget m_FadeOnDeselectWidget;

	public GameObject m_SelectedObj;

	public GameObject m_UnselectedObj;

	public float m_DeslectedAlphaValue;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void SetSelected(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public RockCacheRegionListItem()
	{
	}
}
