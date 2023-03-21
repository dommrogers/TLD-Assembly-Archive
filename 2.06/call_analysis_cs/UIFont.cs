using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIFont : MonoBehaviour
{
	private Material mMat;

	private Rect mUVRect;

	private BMFont mFont;

	private UIAtlas mAtlas;

	private UIFont mReplacement;

	private List<BMSymbol> mSymbols;

	private Font mDynamicFont;

	private int mDynamicFontSize;

	private FontStyle mDynamicFontStyle;

	public float mFontSizePercentModifier;

	[NonSerialized]
	private UISpriteData mSprite;

	private int mPMA;

	private int mPacked;

	public BMFont bmFont
	{
		[CalledBy(Type = typeof(NGUIText), Member = "GetGlyph")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int texWidth
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public int texHeight
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return default(int);
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool hasSymbols
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public List<BMSymbol> symbols
	{
		[CalledBy(Type = typeof(UIFont), Member = "UsesSprite")]
		[CalledBy(Type = typeof(UIFont), Member = "RemoveSymbol")]
		[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIFont), Member = "get_sprite")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIFont), Member = "UsesSprite")]
		get
		{
			return null;
		}
	}

	public UIAtlas atlas
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIFont), Member = "MatchSymbol")]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[Calls(Type = typeof(UIFont), Member = "get_uvRect")]
		[Calls(Type = typeof(UIFont), Member = "get_sprite")]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteMaterial")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public Material material
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[Calls(Type = typeof(Material), Member = "set_mainTexture")]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteMaterial")]
		[CalledBy(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
		[Calls(Type = typeof(Font), Member = "get_material")]
		[CalledBy(Type = typeof(UIFont), Member = "get_packedFontShader")]
		[CalledBy(Type = typeof(UIFont), Member = "get_texture")]
		[CalledBy(Type = typeof(UILabel), Member = "get_material")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Font), Member = "get_material")]
		[Calls(Type = typeof(Font), Member = "get_material")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIFont), Member = "set_dynamicFont")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public bool premultipliedAlpha
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
		get
		{
			return default(bool);
		}
	}

	public bool premultipliedAlphaShader
	{
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(UIAtlas), Member = "get_premultipliedAlpha")]
		[CalledBy(Type = typeof(UIFont), Member = "get_premultipliedAlpha")]
		[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
		[CalledBy(Type = typeof(UILabel), Member = "ApplyShadow")]
		[CalledBy(Type = typeof(UILabel), Member = "ApplyShadow")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UIFont), Member = "get_material")]
		get
		{
			return default(bool);
		}
	}

	public bool packedFontShader
	{
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIFont), Member = "get_material")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return default(bool);
		}
	}

	public Texture2D texture
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIFont), Member = "get_material")]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[CalledBy(Type = typeof(UIFont), Member = "Trim")]
		[CalledBy(Type = typeof(UIFont), Member = "Trim")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return null;
		}
	}

	public Rect uvRect
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIFont), Member = "get_uvRect")]
		[CalledBy(Type = typeof(UIFont), Member = "set_atlas")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIFont), Member = "get_uvRect")]
		[Calls(Type = typeof(UIFont), Member = "get_sprite")]
		get
		{
			return default(Rect);
		}
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[Calls(Type = typeof(UIFont), Member = "get_sprite")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIFont), Member = "set_uvRect")]
		[CalledBy(Type = typeof(UIFont), Member = "set_uvRect")]
		set
		{
		}
	}

	public string spriteName
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIFont), Member = "UsesSprite")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		set
		{
		}
	}

	public bool isValid
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public int size
	{
		[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIFont), Member = "set_defaultSize")]
		set
		{
		}
	}

	public int defaultSize
	{
		[CalledBy(Type = typeof(UILabel), Member = "get_fontSize")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnValidate")]
		[CalledBy(Type = typeof(UIFont), Member = "get_size")]
		[CalledBy(Type = typeof(UILabel), Member = "UpgradeFrom265")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIPopupList), Member = "get_activeFontScale")]
		[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
		[CalledBy(Type = typeof(UIPopupList), Member = "get_activeFontSize")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 9)]
		get
		{
			return default(int);
		}
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIFont), Member = "set_size")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public UISpriteData sprite
	{
		[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
		[Calls(Type = typeof(UIFont), Member = "UpdateUVRect")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UIFont), Member = "get_symbols")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CalledBy(Type = typeof(UIFont), Member = "set_atlas")]
		[CalledBy(Type = typeof(UIFont), Member = "get_uvRect")]
		[CalledBy(Type = typeof(UIFont), Member = "set_uvRect")]
		[CalledBy(Type = typeof(UIFont), Member = "get_sprite")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
		[Calls(Type = typeof(UIFont), Member = "get_sprite")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return null;
		}
	}

	public UIFont replacement
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(FontManager), Member = "UpdateDummyFonts")]
		[CalledBy(Type = typeof(FontManager), Member = "UpdateDummyFonts")]
		[CalledBy(Type = typeof(UIFont), Member = "set_replacement")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIFont), Member = "set_replacement")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		set
		{
		}
	}

	public bool isDynamic
	{
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CalledBy(Type = typeof(UIFont), Member = "get_dynamicTexture")]
		[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
		[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
		[CalledBy(Type = typeof(UIFont), Member = "get_defaultSize")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnValidate")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return default(bool);
		}
	}

	public Font dynamicFont
	{
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
		[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
		[CalledBy(Type = typeof(UILabel), Member = "get_trueTypeFont")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnValidate")]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[Calls(Type = typeof(UIFont), Member = "set_material")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		set
		{
		}
	}

	public FontStyle dynamicFontStyle
	{
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnValidate")]
		get
		{
			return default(FontStyle);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		set
		{
		}
	}

	private Texture dynamicTexture
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(UILabel), Member = "get_fontSize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UILabel), Member = "get_fontSize")]
	public float GetFontSizeModifierValue()
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(UIFont), Member = "UpdateUVRect")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BMGlyph), Member = "Trim")]
	[Calls(Type = typeof(NGUIMath), Member = "ConvertToPixels")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIAtlas), Member = "get_texture")]
	[Calls(Type = typeof(UIFont), Member = "get_texture")]
	[Calls(Type = typeof(UIFont), Member = "get_texture")]
	private void Trim()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
	[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private bool References(UIFont font)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[Calls(Type = typeof(UIFont), Member = "References")]
	[Calls(Type = typeof(UIFont), Member = "References")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Font), Member = "get_fontNames")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Font), Member = "get_fontNames")]
	public static bool CheckIfRelated(UIFont a, UIFont b)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(UIFont), Member = "set_atlas")]
	[CalledBy(Type = typeof(UIFont), Member = "set_material")]
	[Calls(Type = typeof(UIFont), Member = "get_symbols")]
	[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[CalledBy(Type = typeof(UIFont), Member = "set_uvRect")]
	[Calls(Type = typeof(UIFont), Member = "get_symbols")]
	[CalledBy(Type = typeof(UIFont), Member = "set_spriteName")]
	[CalledBy(Type = typeof(UIFont), Member = "set_replacement")]
	[CalledBy(Type = typeof(UIFont), Member = "set_replacement")]
	[CalledBy(Type = typeof(UIFont), Member = "set_dynamicFont")]
	[CalledBy(Type = typeof(UIFont), Member = "set_dynamicFontStyle")]
	[CalledBy(Type = typeof(UIFont), Member = "AddSymbol")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[CalledBy(Type = typeof(UIFont), Member = "RenameSymbol")]
	[Calls(Type = typeof(UIFont), Member = "CheckIfRelated")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(UIFont), Member = "RemoveSymbol")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[CallsUnknownMethods(Count = 3)]
	public void MarkAsChanged()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIFont), Member = "Trim")]
	[CalledBy(Type = typeof(UIFont), Member = "get_sprite")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIAtlas), Member = "get_texture")]
	public void UpdateUVRect()
	{
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(UIFont), Member = "RenameSymbol")]
	[CalledBy(Type = typeof(UIFont), Member = "RemoveSymbol")]
	[CalledBy(Type = typeof(UIFont), Member = "AddSymbol")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 1)]
	private BMSymbol GetSymbol(string sequence, bool createIfMissing)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(BMSymbol), Member = "Validate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(NGUIText), Member = "GetSymbol")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIFont), Member = "get_atlas")]
	public BMSymbol MatchSymbol(string text, int offset, int textLength)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIFont), Member = "GetSymbol")]
	public void AddSymbol(string sequence, string spriteName)
	{
	}

	[Calls(Type = typeof(UIFont), Member = "GetSymbol")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIFont), Member = "get_symbols")]
	public void RemoveSymbol(string sequence)
	{
	}

	[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[Calls(Type = typeof(UIFont), Member = "GetSymbol")]
	[CallerCount(Count = 0)]
	public void RenameSymbol(string before, string after)
	{
	}

	[Calls(Type = typeof(UIFont), Member = "get_spriteName")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UIFont), Member = "get_symbols")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UIFont), Member = "get_symbols")]
	public bool UsesSprite(string s)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(BMFont), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public UIFont()
	{
	}
}
