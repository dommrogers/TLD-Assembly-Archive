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

	[CalledBy(Type = typeof(NGUIText), Member = "GetGlyph")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[CallerCount(Count = 2)]
	public int GetKerning(int previousChar)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 10)]
	public void SetKerning(int previousChar, int amount)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BMFont), Member = "Trim")]
	[CalledBy(Type = typeof(UIFont), Member = "Trim")]
	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public BMGlyph()
	{
	}
}
