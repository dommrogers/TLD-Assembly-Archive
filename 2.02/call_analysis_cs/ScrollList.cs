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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[Calls(Type = typeof(ScrollList), Member = "DoTweens")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[Calls(Type = typeof(ScrollList), Member = "DoTweens")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallerCount(Count = 23)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Next()
	{
	}

	[CallerCount(Count = 23)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsUnknownMethods(Count = 1)]
	public void Prev()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public int GetTweenTargetIndex()
	{
		return default(int);
	}

	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	public void SetTargetIndex(int index, bool animate = true)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsTweening()
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 25)]
	public void CreateList(int numObjects)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_SelectRegion), Member = "Initialize")]
	public void CreateFromList(List<GameObject> list)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Story), Member = "SetupJumpScrollList")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "OnScrollBarPositionChanged")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Start")]
	[CalledBy(Type = typeof(Panel_SelectRegion), Member = "SelectRegion")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
	[CalledBy(Type = typeof(ScrollList), Member = "SetTargetIndex")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[CalledBy(Type = typeof(ScrollList), Member = "Update")]
	[CalledBy(Type = typeof(ScrollList), Member = "Update")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshScale")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAlpha")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshPositioning")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(ScrollList), Member = "Update")]
	private void RefreshAll()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAll")]
	[Calls(Type = typeof(ScrollList), Member = "GetPositionForIndex")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ScrollList), Member = "GetPositionForIndex")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void RefreshPositioning()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAll")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ScrollList), Member = "GetAlphaForIndex")]
	[Calls(Type = typeof(ScrollList), Member = "GetAlphaForIndex")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private void RefreshAlpha()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAll")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void RefreshScale()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAll")]
	[CalledBy(Type = typeof(ScrollList), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ScrollList), Member = "SetObjectDepth")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(ScrollList), Member = "SetObjectDepth")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(ScrollList), Member = "SetObjectDepth")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	private void RefreshVisibility()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(ScrollList), Member = "DoScaleTween")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(ScrollList), Member = "DoScaleTween")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(ScrollList), Member = "Update")]
	[CalledBy(Type = typeof(ScrollList), Member = "Update")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(ScrollList), Member = "DoScaleTween")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(ScrollList), Member = "DoScaleTween")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Mathf), Member = "Abs")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ScrollList), Member = "GetAlphaForIndex")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(ScrollList), Member = "GetOffsetForIndex")]
	private void DoTweens(bool increasedIndex)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void SetObjectDepth(int objIndex, int depth)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Abs")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshPositioning")]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshPositioning")]
	private Vector3 GetPositionForIndex(int index)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAlpha")]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAlpha")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "Abs")]
	private float GetAlphaForIndex(int index)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	private Vector3 GetOffsetForIndex(int index, bool increasingIndex)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	private void DoScaleTween(int index, Vector3 fromVal, Vector3 toVal, float tweenTime)
	{
	}

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "Abs")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateDurationAllTweens()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void CreateOffsetVectors()
	{
	}

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	public void CleanUp()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 19)]
	public ScrollList()
	{
	}
}
