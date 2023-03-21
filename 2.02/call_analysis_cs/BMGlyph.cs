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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[CalledBy(Type = typeof(NGUIText), Member = "GetGlyph")]
	public int GetKerning(int previousChar)
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	public void SetKerning(int previousChar, int amount)
	{
	}

	[CalledBy(Type = typeof(BMFont), Member = "Trim")]
	[CalledBy(Type = typeof(UIFont), Member = "Trim")]
	[CallerCount(Count = 2)]
	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public BMGlyph()
	{
	}
}
