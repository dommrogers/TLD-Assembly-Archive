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
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public int charSize
	{
		[CallerCount(Count = 28)]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public int texWidth
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

	public int texHeight
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
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

	public int glyphCount
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public string spriteName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 55)]
		set
		{
		}
	}

	public List<BMGlyph> glyphs
	{
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CalledBy(Type = typeof(NGUIText), Member = "GetGlyph")]
	[CalledBy(Type = typeof(BMFont), Member = "GetGlyph")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BMGlyph), Member = "Trim")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public BMFont()
	{
	}
}
