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
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIWrapContent), Member = "WrapContent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWrapContent), Member = "SortBasedOnScrollMovement")]
	protected virtual void Start()
	{
	}

	[Calls(Type = typeof(UIWrapContent), Member = "WrapContent")]
	[CallerCount(Count = 0)]
	protected virtual void OnMove(UIPanel panel)
	{
	}

	[CallerCount(Count = 1)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(UIWrapContent), Member = "Start")]
	[Calls(Type = typeof(UIWrapContent), Member = "ResetChildPositions")]
	[Calls(Type = typeof(UIWrapContent), Member = "CacheScrollView")]
	public void SortBasedOnScrollMovement()
	{
	}

	[Calls(Type = typeof(UIWrapContent), Member = "CacheScrollView")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[Calls(Type = typeof(UIWrapContent), Member = "ResetChildPositions")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void SortAlphabetically()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(UIWrapContent), Member = "SortBasedOnScrollMovement")]
	[CalledBy(Type = typeof(UIWrapContent), Member = "SortAlphabetically")]
	[CallsUnknownMethods(Count = 5)]
	protected bool CacheScrollView()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(UIWrapContent), Member = "SortBasedOnScrollMovement")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIWrapContent), Member = "SortAlphabetically")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void ResetChildPositions()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(UICamera), Member = "IsPressed")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(UIWrapContent), Member = "Start")]
	[CalledBy(Type = typeof(UIWrapContent), Member = "OnMove")]
	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UICamera), Member = "IsPressed")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 2)]
	public void WrapContent()
	{
	}

	[CallerCount(Count = 0)]
	private void OnValidate()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	protected virtual void UpdateItem(Transform item, int index)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UIWrapContent()
	{
	}
}
