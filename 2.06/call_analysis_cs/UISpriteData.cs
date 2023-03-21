using System;
using Cpp2ILInjected.CallAnalysis;

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
			return default(bool);
		}
	}

	public bool hasPadding
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void CopyFrom(UISpriteData sd)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 13)]
	public void CopyFromReduced(UISpriteData sd, float reductionFactor)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void CopyBorderFrom(UISpriteData sd)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(UIAtlas), Member = "Upgrade")]
	public UISpriteData()
	{
	}
}
