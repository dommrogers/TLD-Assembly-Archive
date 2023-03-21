using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class UISpriteData
{
	public string name;

	public int x;

	public int y;

	public int width;

	public int height;

	public int borderLeft;

	public int borderRight;

	public int borderTop;

	public int borderBottom;

	public int paddingLeft;

	public int paddingRight;

	public int paddingTop;

	public int paddingBottom;

	public bool hasBorder
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public bool hasPadding
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	[CallerCount(Count = 0)]
	public void SetRect(int x, int y, int width, int height)
	{
	}

	[CallerCount(Count = 0)]
	public void SetPadding(int left, int bottom, int right, int top)
	{
	}

	[CallerCount(Count = 0)]
	public void SetBorder(int left, int bottom, int right, int top)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void CopyFrom(UISpriteData sd)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void CopyFromReduced(UISpriteData sd, float reductionFactor)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void CopyBorderFrom(UISpriteData sd)
	{
	}

	[CalledBy(Type = typeof(UIAtlas), Member = "Upgrade")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public UISpriteData()
	{
	}
}
