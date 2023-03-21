using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SelectRegionItem : MonoBehaviour
{
	public GameObject m_Highlight;

	public GameRegion m_Region;

	public AnimationStateRef m_PlayOnSelect;

	public AnimationStateRef m_PlayOnDeselect;

	public SelectRegionItem m_OnLeftItem;

	public SelectRegionItem m_OnRightItem;

	public SelectRegionItem m_OnUpItem;

	public SelectRegionItem m_OnDownItem;

	private AnimatedAlpha[] m_AnimatedAlphas;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void ResetAnimatedAlphas()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public SelectRegionItem()
	{
	}
}
