using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIWrapContent : MonoBehaviour
{
	public delegate void OnInitializeItem(GameObject go, int wrapIndex, int realIndex);

	public int itemSize;

	public bool cullContent;

	public int minIndex;

	public int maxIndex;

	public OnInitializeItem onInitializeItem;

	private Transform mTrans;

	private UIPanel mPanel;

	private UIScrollView mScroll;

	private bool mHorizontal;

	private bool mFirstTime;

	private List<Transform> mChildren;

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIWrapContent), Member = "WrapContent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWrapContent), Member = "SortBasedOnScrollMovement")]
	protected virtual void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWrapContent), Member = "WrapContent")]
	protected virtual void OnMove(UIPanel panel)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(UIWrapContent), Member = "Start")]
	[ContextMenu("Sort Based on Scroll Movement")]
	[Calls(Type = typeof(UIWrapContent), Member = "ResetChildPositions")]
	[Calls(Type = typeof(UIWrapContent), Member = "CacheScrollView")]
	[CallerCount(Count = 1)]
	public void SortBasedOnScrollMovement()
	{
	}

	[CallerCount(Count = 0)]
	[ContextMenu("Sort Alphabetically")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UIWrapContent), Member = "ResetChildPositions")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UIWrapContent), Member = "CacheScrollView")]
	public void SortAlphabetically()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(UIWrapContent), Member = "SortBasedOnScrollMovement")]
	[CalledBy(Type = typeof(UIWrapContent), Member = "SortAlphabetically")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	protected bool CacheScrollView()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIWrapContent), Member = "SortAlphabetically")]
	[CalledBy(Type = typeof(UIWrapContent), Member = "SortBasedOnScrollMovement")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void ResetChildPositions()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UICamera), Member = "IsPressed")]
	[CalledBy(Type = typeof(UIWrapContent), Member = "Start")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(UICamera), Member = "IsPressed")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(UIWrapContent), Member = "OnMove")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	public void WrapContent()
	{
	}

	[CallerCount(Count = 0)]
	private void OnValidate()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	protected virtual void UpdateItem(Transform item, int index)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public UIWrapContent()
	{
	}
}
