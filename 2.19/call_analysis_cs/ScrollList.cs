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

	private readonly List<int> m_DepthList;

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
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[Calls(Type = typeof(ScrollList), Member = "DoTweens")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsUnknownMethods(Count = 1)]
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
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	public void SetTargetIndex(int index, bool animate = true)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsTweening()
	{
		return false;
	}

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(ScrollListButton), Member = "SetCallback")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshPositioning")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAlpha")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshScale")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallsUnknownMethods(Count = 29)]
	public void CreateList(int numObjects)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(ScrollListButton), Member = "SetCallback")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshPositioning")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAlpha")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshScale")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 24)]
	public void CreateFromList(List<GameObject> list)
	{
	}

	[CalledBy(Type = typeof(ScrollList), Member = "Update")]
	[CalledBy(Type = typeof(ScrollList), Member = "SetTargetIndex")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Start")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "OnScrollBarPositionChanged")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ScrollList), Member = "RefreshPositioning")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAlpha")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshScale")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshAll()
	{
	}

	[CalledBy(Type = typeof(ScrollList), Member = "CreateList")]
	[CalledBy(Type = typeof(ScrollList), Member = "CreateFromList")]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAll")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(ScrollList), Member = "GetPositionForIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void RefreshPositioning()
	{
	}

	[CalledBy(Type = typeof(ScrollList), Member = "CreateList")]
	[CalledBy(Type = typeof(ScrollList), Member = "CreateFromList")]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAll")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(ScrollList), Member = "GetAlphaForIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshAlpha()
	{
	}

	[CalledBy(Type = typeof(ScrollList), Member = "CreateList")]
	[CalledBy(Type = typeof(ScrollList), Member = "CreateFromList")]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAll")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void RefreshScale()
	{
	}

	[CalledBy(Type = typeof(ScrollList), Member = "Update")]
	[CalledBy(Type = typeof(ScrollList), Member = "CreateList")]
	[CalledBy(Type = typeof(ScrollList), Member = "CreateFromList")]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAll")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(ScrollList), Member = "SetObjectDepth")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	private void RefreshVisibility()
	{
	}

	[CalledBy(Type = typeof(ScrollList), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(ScrollList), Member = "GetOffsetForIndex")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(ScrollList), Member = "GetAlphaForIndex")]
	[Calls(Type = typeof(ScrollList), Member = "DoScaleTween")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void DoTweens(bool increasedIndex)
	{
	}

	[CalledBy(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void SetObjectDepth(int objIndex, int depth)
	{
	}

	[CalledBy(Type = typeof(ScrollList), Member = "RefreshPositioning")]
	[CallerCount(Count = 2)]
	private Vector3 GetPositionForIndex(int index)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAlpha")]
	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[CallerCount(Count = 3)]
	private float GetAlphaForIndex(int index)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[CallerCount(Count = 1)]
	private Vector3 GetOffsetForIndex(int index, bool increasingIndex)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void DoScaleTween(int index, Vector3 fromVal, Vector3 toVal, float tweenTime)
	{
	}

	[CallerCount(Count = 29)]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateDurationAllTweens()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void CreateOffsetVectors()
	{
	}

	[CallerCount(Count = 31)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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
