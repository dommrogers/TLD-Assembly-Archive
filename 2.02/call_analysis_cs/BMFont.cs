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
		[CalledBy(Type = typeof(BMFont), Member = "get_glyphCount")]
		[CalledBy(Type = typeof(BMFont), Member = "Trim")]
		[CalledBy(Type = typeof(UIFont), Member = "get_isValid")]
		[CalledBy(Type = typeof(UIFont), Member = "Trim")]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public int charSize
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int baseOffset
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int texWidth
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return 0;
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
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int glyphCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BMFont), Member = "get_isValid")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	public string spriteName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		set
		{
		}
	}

	public List<BMGlyph> glyphs
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(BMFont), Member = "GetGlyph")]
	[CalledBy(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
	[CalledBy(Type = typeof(NGUIText), Member = "GetGlyph")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallerCount(Count = 4)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 21)]
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
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BMFont), Member = "get_isValid")]
	[Calls(Type = typeof(BMGlyph), Member = "Trim")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}

	[CalledBy(Type = typeof(UIFont), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	public BMFont()
	{
	}
}
