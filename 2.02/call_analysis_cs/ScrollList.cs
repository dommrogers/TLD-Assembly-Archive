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
	[Calls(Type = typeof(ScrollList), Member = "RefreshAll")]
	[Calls(Type = typeof(ScrollList), Member = "DoTweens")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CallerCount(Count = 23)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Next()
	{
	}

	[CallerCount(Count = 23)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Prev()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
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

	[CallAnalysisFailed]
	[CallerCount(Count = 26)]
	public void CreateList(int numObjects)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_SelectRegion), Member = "Initialize")]
	[CallerCount(Count = 1)]
	public void CreateFromList(List<GameObject> list)
	{
	}

	[CalledBy(Type = typeof(ScrollList), Member = "Update")]
	[CalledBy(Type = typeof(ScrollList), Member = "SetTargetIndex")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFuelSources")]
	[CalledBy(Type = typeof(Panel_SelectRegion), Member = "SelectRegion")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Start")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "OnScrollBarPositionChanged")]
	[CalledBy(Type = typeof(Panel_Story), Member = "SetupJumpScrollList")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ScrollList), Member = "RefreshPositioning")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshAlpha")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshScale")]
	[Calls(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshAll()
	{
	}

	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(ScrollList), Member = "GetPositionForIndex")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void RefreshPositioning()
	{
	}

	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(ScrollList), Member = "GetAlphaForIndex")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void RefreshAlpha()
	{
	}

	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void RefreshScale()
	{
	}

	[CalledBy(Type = typeof(ScrollList), Member = "Update")]
	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(ScrollList), Member = "SetObjectDepth")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void RefreshVisibility()
	{
	}

	[CalledBy(Type = typeof(ScrollList), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Abs")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(ScrollList), Member = "GetOffsetForIndex")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(ScrollList), Member = "GetAlphaForIndex")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(ScrollList), Member = "DoScaleTween")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 20)]
	private void DoTweens(bool increasedIndex)
	{
	}

	[CalledBy(Type = typeof(ScrollList), Member = "RefreshVisibility")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void SetObjectDepth(int objIndex, int depth)
	{
	}

	[CalledBy(Type = typeof(ScrollList), Member = "RefreshPositioning")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Abs")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	private Vector3 GetPositionForIndex(int index)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(ScrollList), Member = "RefreshAlpha")]
	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "Abs")]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetAlphaForIndex(int index)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private Vector3 GetOffsetForIndex(int index, bool increasingIndex)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(ScrollList), Member = "DoTweens")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void DoScaleTween(int index, Vector3 fromVal, Vector3 toVal, float tweenTime)
	{
	}

	[CallerCount(Count = 27)]
	[Calls(Type = typeof(Mathf), Member = "Abs")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateDurationAllTweens()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void CreateOffsetVectors()
	{
	}

	[CallerCount(Count = 32)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void CleanUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	public ScrollList()
	{
	}
}
