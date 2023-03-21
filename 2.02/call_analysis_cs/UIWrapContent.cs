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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWrapContent), Member = "SortBasedOnScrollMovement")]
	[Calls(Type = typeof(UIWrapContent), Member = "WrapContent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	protected virtual void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWrapContent), Member = "WrapContent")]
	protected virtual void OnMove(UIPanel panel)
	{
	}

	[CalledBy(Type = typeof(UIWrapContent), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIWrapContent), Member = "CacheScrollView")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UIWrapContent), Member = "ResetChildPositions")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 23)]
	public void SortBasedOnScrollMovement()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWrapContent), Member = "CacheScrollView")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UIWrapContent), Member = "ResetChildPositions")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 16)]
	public void SortAlphabetically()
	{
	}

	[CalledBy(Type = typeof(UIWrapContent), Member = "SortBasedOnScrollMovement")]
	[CalledBy(Type = typeof(UIWrapContent), Member = "SortAlphabetically")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	protected bool CacheScrollView()
	{
		return false;
	}

	[CalledBy(Type = typeof(UIWrapContent), Member = "SortBasedOnScrollMovement")]
	[CalledBy(Type = typeof(UIWrapContent), Member = "SortAlphabetically")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void ResetChildPositions()
	{
	}

	[CalledBy(Type = typeof(UIWrapContent), Member = "Start")]
	[CalledBy(Type = typeof(UIWrapContent), Member = "OnMove")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UICamera), Member = "IsPressed")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 38)]
	public void WrapContent()
	{
	}

	[CallerCount(Count = 0)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	protected virtual void UpdateItem(Transform item, int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public UIWrapContent()
	{
	}
}
