using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class BMSymbol
{
	private static ButtonLegendAtlas s_ButtonLegendAtlas;

	public string sequence;

	public string spriteName;

	private UISpriteData mSprite;

	private bool mIsValid;

	private int mLength;

	private int mOffsetX;

	private int mOffsetY;

	private int mWidth;

	private int mHeight;

	private int mAdvance;

	private Rect mUV;

	public int charIndex;

	public Color spriteColor;

	public int length
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public int offsetX
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
	}

	public int offsetY
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
	}

	public int width
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public int height
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public int advance
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public Rect uvRect
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Rect);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void MarkAsChanged()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(UIFont), Member = "MatchSymbol")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIAtlas), Member = "get_texture")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public bool Validate(UIAtlas atlas)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void SetUpBlankSymbol(int width, int height)
	{
	}

	[CallerCount(Count = 0)]
	public void SetIndexAndColor(int index, Color color)
	{
	}

	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 45)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UILabel), Member = "AddDynamicSymbolSprite")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(UIRoot), Member = "ReturnDynamicSymbolSpriteToPool")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 21)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(UIRoot), Member = "GetDynamicSymbolSpriteFromPool")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	public void SetSpriteLocation(UILabel label, Vector3 offsetPosition)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public BMSymbol()
	{
	}
}
