using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Scenes;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class SelectRegionItem : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public RegionSpecification target;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass37_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CPatchUpReference_003Eb__0(SelectRegionItem item)
		{
			return default(bool);
		}
	}

	private Animator m_Animator;

	public GameObject m_Highlight;

	private Transform m_MapTransform;

	private AnimationCurve m_MapTransitionCurve;

	private AnimationStateRef m_ShowAnimation;

	private AnimationStateRef m_HideAnimation;

	private AnimationStateRef m_SelectAnimation;

	private AnimationStateRef m_DeselectAnimation;

	public SelectRegionItem m_OnLeftItem;

	public SelectRegionItem m_OnRightItem;

	public SelectRegionItem m_OnUpItem;

	public SelectRegionItem m_OnDownItem;

	private RegionSpecification m_RegionSpec;

	private UIButton m_Button;

	private RegionSpecification m_OnLeftRegion;

	private RegionSpecification m_OnRightRegion;

	private RegionSpecification m_OnUpRegion;

	private RegionSpecification m_OnDownRegion;

	private AsyncOperationHandle<Texture2D> m_miniMapOperation;

	private Vector3 m_MapStartPosition;

	private Vector3 m_MapEndPosition;

	private float m_MapTransitionTime;

	public RegionSpecification Region
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public Texture2D GetMiniMap()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnValidate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnMiniMapLoaded(AsyncOperationHandle<Texture2D> obj)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SelectRegionItem), Member = "PlayAnimation")]
	[CallsUnknownMethods(Count = 1)]
	public void Show()
	{
	}

	[Calls(Type = typeof(SelectRegionItem), Member = "PlayAnimation")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Hide()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SelectRegionItem), Member = "PlayAnimation")]
	[Calls(Type = typeof(SelectRegionItem), Member = "PlayAnimation")]
	[CallsUnknownMethods(Count = 1)]
	public void Select(bool isSelected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsAnimationStatePlaying")]
	[Calls(Type = typeof(Utils), Member = "IsAnimationStatePlaying")]
	[Calls(Type = typeof(Utils), Member = "IsAnimationStatePlaying")]
	[Calls(Type = typeof(Utils), Member = "IsAnimationStatePlaying")]
	public bool IsAnyAnimationInProgress()
	{
		return default(bool);
	}

	[Calls(Type = typeof(SelectRegionItem), Member = "PatchUpReference")]
	[Calls(Type = typeof(SelectRegionItem), Member = "PatchUpReference")]
	[Calls(Type = typeof(SelectRegionItem), Member = "PatchUpReference")]
	[Calls(Type = typeof(SelectRegionItem), Member = "PatchUpReference")]
	[CallerCount(Count = 0)]
	public void PatchUpReferences(List<SelectRegionItem> items)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsUnknownMethods(Count = 1)]
	public void AttachEventHandler(EventDelegate.Callback callback)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "Select")]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "Select")]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "Hide")]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "Show")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "PlayAnimation")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "PlayAnimation")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateAnimation")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	private void PlayAnimation(string stateName)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "PatchUpReferences")]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "PatchUpReferences")]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "PatchUpReferences")]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "PatchUpReferences")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnSelectRegionItemInstantiated")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnSelectRegionItemInstantiated")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnSelectRegionItemInstantiated")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnSelectRegionItemInstantiated")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	private void PatchUpReference(List<SelectRegionItem> items, RegionSpecification target, out SelectRegionItem memberReference)
	{
		memberReference = null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public SelectRegionItem()
	{
	}
}
