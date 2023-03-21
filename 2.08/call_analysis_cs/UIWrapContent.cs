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
	[Calls(Type = typeof(UIWrapContent), Member = "SortBasedOnScrollMovement")]
	[Calls(Type = typeof(UIWrapContent), Member = "WrapContent")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected virtual void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWrapContent), Member = "WrapContent")]
	protected virtual void OnMove(UIPanel panel)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UIWrapContent), Member = "CacheScrollView")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[ContextMenu("Sort Based on Scroll Movement")]
	[Calls(Type = typeof(UIWrapContent), Member = "ResetChildPositions")]
	[CalledBy(Type = typeof(UIWrapContent), Member = "Start")]
	[CallsUnknownMethods(Count = 5)]
	public void SortBasedOnScrollMovement()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UIWrapContent), Member = "CacheScrollView")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UIWrapContent), Member = "ResetChildPositions")]
	[ContextMenu("Sort Alphabetically")]
	public void SortAlphabetically()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(UIWrapContent), Member = "SortBasedOnScrollMovement")]
	[CalledBy(Type = typeof(UIWrapContent), Member = "SortAlphabetically")]
	[CallsUnknownMethods(Count = 3)]
	protected bool CacheScrollView()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(UIWrapContent), Member = "SortBasedOnScrollMovement")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIWrapContent), Member = "SortAlphabetically")]
	private void ResetChildPositions()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CallsDeduplicatedMethods(Count = 18)]
	[CalledBy(Type = typeof(UIWrapContent), Member = "Start")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UICamera), Member = "IsPressed")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UICamera), Member = "IsPressed")]
	[CalledBy(Type = typeof(UIWrapContent), Member = "OnMove")]
	[CallerCount(Count = 2)]
	public void WrapContent()
	{
	}

	[CallerCount(Count = 0)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	protected virtual void UpdateItem(Transform item, int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public UIWrapContent()
	{
	}
}
