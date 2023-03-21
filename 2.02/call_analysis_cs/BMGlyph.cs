using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class BMGlyph
{
	public int index;

	public int x;

	public int y;

	public int width;

	public int height;

	public int offsetX;

	public int offsetY;

	public int advance;

	public int channel;

	public List<int> kerning;

	[CalledBy(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[CalledBy(Type = typeof(NGUIText), Member = "GetGlyph")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetKerning(int previousChar)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 23)]
	public void SetKerning(int previousChar, int amount)
	{
	}

	[CalledBy(Type = typeof(BMFont), Member = "Trim")]
	[CalledBy(Type = typeof(UIFont), Member = "Trim")]
	[CallerCount(Count = 2)]
	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public BMGlyph()
	{
	}
}
