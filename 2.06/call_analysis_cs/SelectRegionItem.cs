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
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Texture2D GetMiniMap()
	{
		return null;
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnMiniMapLoaded(AsyncOperationHandle<Texture2D> obj)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SelectRegionItem), Member = "PlayAnimation")]
	public void Show()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SelectRegionItem), Member = "PlayAnimation")]
	[CallsUnknownMethods(Count = 1)]
	public void Hide()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SelectRegionItem), Member = "PlayAnimation")]
	[CallsUnknownMethods(Count = 1)]
	public void Select(bool isSelected)
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsAnimationStatePlaying")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsAnimationStatePlaying")]
	[Calls(Type = typeof(Utils), Member = "IsAnimationStatePlaying")]
	[Calls(Type = typeof(Utils), Member = "IsAnimationStatePlaying")]
	public bool IsAnyAnimationInProgress()
	{
		return default(bool);
	}

	[Calls(Type = typeof(SelectRegionItem), Member = "PatchUpReference")]
	[Calls(Type = typeof(SelectRegionItem), Member = "PatchUpReference")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SelectRegionItem), Member = "PatchUpReference")]
	[Calls(Type = typeof(SelectRegionItem), Member = "PatchUpReference")]
	public void PatchUpReferences(List<SelectRegionItem> items)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void AttachEventHandler(EventDelegate.Callback callback)
	{
	}

	[CalledBy(Type = typeof(SelectRegionItem), Member = "Select")]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "Hide")]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "Show")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "PlayAnimation")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateAnimation")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateAnimation")]
	private void PlayAnimation(string stateName)
	{
	}

	[CalledBy(Type = typeof(SelectRegionItem), Member = "PatchUpReferences")]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "PatchUpReferences")]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "PatchUpReferences")]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "PatchUpReferences")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnSelectRegionItemInstantiated")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnSelectRegionItemInstantiated")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnSelectRegionItemInstantiated")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnSelectRegionItemInstantiated")]
	private void PatchUpReference(List<SelectRegionItem> items, RegionSpecification target, out SelectRegionItem memberReference)
	{
		memberReference = null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 21)]
	public SelectRegionItem()
	{
	}
}
