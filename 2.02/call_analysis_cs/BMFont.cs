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
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIFont), Member = "Trim")]
		[CalledBy(Type = typeof(UIFont), Member = "get_isValid")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(BMFont), Member = "Trim")]
		[CalledBy(Type = typeof(BMFont), Member = "get_glyphCount")]
		get
		{
			return default(bool);
		}
	}

	public int charSize
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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

	public int baseOffset
	{
		[CallerCount(Count = 2)]
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

	public int texWidth
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
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

	public int texHeight
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(BMFont), Member = "get_isValid")]
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
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		set
		{
		}
	}

	public List<BMGlyph> glyphs
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(BMFont), Member = "GetGlyph")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[CalledBy(Type = typeof(NGUIText), Member = "GetGlyph")]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 2)]
	public void Clear()
	{
	}

	[Calls(Type = typeof(BMGlyph), Member = "Trim")]
	[Calls(Type = typeof(BMFont), Member = "get_isValid")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}

	[CalledBy(Type = typeof(UIFont), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public BMFont()
	{
	}
}
