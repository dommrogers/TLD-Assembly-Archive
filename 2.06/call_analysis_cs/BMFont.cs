using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class BMFont
{
	private int mSize;

	private int mBase;

	private int mWidth;

	private int mHeight;

	private string mSpriteName;

	private List<BMGlyph> mSaved;

	private Dictionary<int, BMGlyph> mDict;

	public bool isValid
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public int charSize
	{
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public int baseOffset
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return default(int);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int texWidth
	{
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public int texHeight
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public int glyphCount
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	public string spriteName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		get
		{
			return null;
		}
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public List<BMGlyph> glyphs
	{
		[CallerCount(Count = 58)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(NGUIText), Member = "GetGlyph")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CalledBy(Type = typeof(BMFont), Member = "GetGlyph")]
	[CalledBy(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	public BMGlyph GetGlyph(int index, bool createIfMissing)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BMFont), Member = "GetGlyph")]
	public BMGlyph GetGlyph(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BMGlyph), Member = "Trim")]
	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}

	[CalledBy(Type = typeof(UIFont), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 1)]
	public BMFont()
	{
	}
}
