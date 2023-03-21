using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ScrollList : MonoBehaviour
{
	public enum ScaleFactor
	{
		Linear,
		Exponential
	}

	public GameObject m_PrefabObject;

	public Vector2 m_OffsetOneAway;

	public Vector2 m_OffsetOthers;

	public int m_NumVisibleBefore;

	public int m_NumVisibleAfter;

	public float m_SizeBehindCenter;

	public float m_SizeFadeAway;

	public float m_AlphaScaleValue;

	public ScaleFactor m_AlphaScaleFactor;

	public float m_TweenTime;

	public UITweener.Method m_TweenMethod;

	public bool m_AddButtonsToObjects;

	public GameObject m_CallbackObject;

	public string m_CallbackMessage;

	public Vector3 m_ButtonColliderOffset;

	public Vector3 m_ButtonColliderSize;

	public bool m_IgnoreDepth;

	public bool m_AddDoubleClick;

	public List<EventDelegate> m_OnDoubleClick;

	public List<GameObject> m_ScrollObjects;

	private List<int> m_DepthList;

	private int m_SelectedIndex;

	private int m_TargetIndex;

	private int m_TweenStartIndex;

	private Vector3 m_OffsetOthers3D;

	private Vector3 m_OffsetOneAway3D;

	private float m_TimeLeftOnTween;

	private bool m_IsTweening;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[Calls(Type = typeof(ScrollList), Member = "DoTweens")]
	[Calls(Type = typeof(ScrollList), Member = "DoTweens")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	public void Next()
	{
	}

	[CallerCount(Count = 23)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsUnknownMethods(Count = 1)]
	public void Prev()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public int GetTweenTargetIndex()
	{
		return default(int);
	}

	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallerCount(Count = 0)]
	public void SetTargetIndex(int index, bool animate = true)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsTweening()
	{
		return default(bool);
	}

	[Calls(Type = typeof(ScrollListButton), Member = "SetCallback")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAlpha")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshPositioning")]
	[Calls(Type = typeof(ScrollListButton), Member = "SetCallback")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshScale")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 45)]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public void CreateList(int numObjects)
	{
	}

	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshScale")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAlpha")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshPositioning")]
	[Calls(Type = typeof(ScrollListButton), Member = "SetCallback")]
	[Calls(Type = typeof(ScrollListButton), Member = "SetCallback")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 35)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public void CreateFromList(List<GameObject> list)
	{
	}

	[CalledBy(Type = typeof(ScrollList), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "OnScrollBarPositionChanged")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Start")]
	[CalledBy(Type = typeof(ScrollList), Member = "SetTargetIndex")]
	[CalledBy(Type = typeof(ScrollList), Member = "Update")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshScale")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAlpha")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshPositioning")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(ScrollList), Member = "Update")]
	private void RefreshAll()
	{
	}

	[Calls(Type = typeof(ScrollList), Member = "GetPositionForIndex")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAll")]
	[CalledBy(Type = typeof(ScrollList), Member = "CreateFromList")]
	[CalledBy(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(ScrollList), Member = "GetPositionForIndex")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void RefreshPositioning()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
	[Calls(Type = typeof(ScrollList), Member = "GetAlphaForIndex")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAll")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(ScrollList), Member = "GetAlphaForIndex")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(ScrollList), Member = "CreateFromList")]
	private void RefreshAlpha()
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(ScrollList), Member = "CreateList")]
	[CalledBy(Type = typeof(ScrollList), Member = "CreateFromList")]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAll")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
	[CallsUnknownMethods(Count = 5)]
	private void RefreshScale()
	{
	}

	[CalledBy(Type = typeof(ScrollList), Member = "CreateFromList")]
	[CalledBy(Type = typeof(ScrollList), Member = "CreateList")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ScrollList), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAll")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(ScrollList), Member = "SetObjectDepth")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(ScrollList), Member = "SetObjectDepth")]
	[Calls(Type = typeof(ScrollList), Member = "SetObjectDepth")]
	private void RefreshVisibility()
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CalledBy(Type = typeof(ScrollList), Member = "Update")]
	[Calls(Type = typeof(ScrollList), Member = "DoScaleTween")]
	[Calls(Type = typeof(ScrollList), Member = "DoScaleTween")]
	[Calls(Type = typeof(ScrollList), Member = "DoScaleTween")]
	[Calls(Type = typeof(ScrollList), Member = "DoScaleTween")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(ScrollList), Member = "GetAlphaForIndex")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(ScrollList), Member = "GetOffsetForIndex")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(ScrollList), Member = "Update")]
	[CallsUnknownMethods(Count = 10)]
	private void DoTweens(bool increasedIndex)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	private void SetObjectDepth(int objIndex, int depth)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshPositioning")]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshPositioning")]
	private Vector3 GetPositionForIndex(int index)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAlpha")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAlpha")]
	private float GetAlphaForIndex(int index)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	private Vector3 GetOffsetForIndex(int index, bool increasingIndex)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void DoScaleTween(int index, Vector3 fromVal, Vector3 toVal, float tweenTime)
	{
	}

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateDurationAllTweens()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void CreateOffsetVectors()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void CleanUp()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ScrollList()
	{
	}
}
