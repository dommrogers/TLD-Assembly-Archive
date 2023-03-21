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
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(NGUIText), Member = "GetGlyph")]
		[CalledBy(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int texWidth
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int texHeight
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public bool hasSymbols
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public List<BMSymbol> symbols
	{
		[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIFont), Member = "RemoveSymbol")]
		[CalledBy(Type = typeof(UIFont), Member = "UsesSprite")]
		[CalledBy(Type = typeof(UIFont), Member = "UsesSprite")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIFont), Member = "get_sprite")]
		[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CallerCount(Count = 6)]
		get
		{
			return null;
		}
	}

	public UIAtlas atlas
	{
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(UIFont), Member = "MatchSymbol")]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[Calls(Type = typeof(UIFont), Member = "get_uvRect")]
		[Calls(Type = typeof(UIFont), Member = "get_sprite")]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteMaterial")]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public Material material
	{
		[Calls(Type = typeof(Font), Member = "get_material")]
		[Calls(Type = typeof(Material), Member = "set_mainTexture")]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[Calls(Type = typeof(Font), Member = "get_material")]
		[Calls(Type = typeof(Font), Member = "get_material")]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteMaterial")]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
		[CalledBy(Type = typeof(UIFont), Member = "get_texture")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UILabel), Member = "get_material")]
		[CalledBy(Type = typeof(UIFont), Member = "get_packedFontShader")]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIFont), Member = "set_dynamicFont")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
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
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Contains")]
		[CalledBy(Type = typeof(UIFont), Member = "get_premultipliedAlpha")]
		[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
		[CalledBy(Type = typeof(UILabel), Member = "ApplyShadow")]
		[CalledBy(Type = typeof(UILabel), Member = "ApplyShadow")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(UIFont), Member = "get_material")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UIAtlas), Member = "get_premultipliedAlpha")]
		get
		{
			return default(bool);
		}
	}

	public bool packedFontShader
	{
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
		[Calls(Type = typeof(string), Member = "Contains")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(UIFont), Member = "get_material")]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public Texture2D texture
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIFont), Member = "Trim")]
		[CalledBy(Type = typeof(UIFont), Member = "Trim")]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[Calls(Type = typeof(UIFont), Member = "get_material")]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
	}

	public Rect uvRect
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIFont), Member = "get_sprite")]
		[CalledBy(Type = typeof(UIFont), Member = "get_uvRect")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UIFont), Member = "get_uvRect")]
		[CalledBy(Type = typeof(UIFont), Member = "set_atlas")]
		get
		{
			return default(Rect);
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIFont), Member = "set_uvRect")]
		[Calls(Type = typeof(UIFont), Member = "get_sprite")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIFont), Member = "set_uvRect")]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public string spriteName
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIFont), Member = "UsesSprite")]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool isValid
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public int size
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(UIFont), Member = "set_defaultSize")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int defaultSize
	{
		[CalledBy(Type = typeof(UIPopupList), Member = "get_activeFontScale")]
		[CalledBy(Type = typeof(UIPopupList), Member = "get_activeFontSize")]
		[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
		[CallerCount(Count = 9)]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UIFont), Member = "get_size")]
		[CalledBy(Type = typeof(UILabel), Member = "get_fontSize")]
		[CalledBy(Type = typeof(UILabel), Member = "UpgradeFrom265")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnValidate")]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIFont), Member = "set_size")]
		set
		{
		}
	}

	public UISpriteData sprite
	{
		[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(UIFont), Member = "get_sprite")]
		[CalledBy(Type = typeof(UIFont), Member = "set_uvRect")]
		[CalledBy(Type = typeof(UIFont), Member = "get_uvRect")]
		[CalledBy(Type = typeof(UIFont), Member = "set_atlas")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[Calls(Type = typeof(UIFont), Member = "get_symbols")]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UIFont), Member = "get_sprite")]
		[Calls(Type = typeof(UIFont), Member = "UpdateUVRect")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
		get
		{
			return null;
		}
	}

	public UIFont replacement
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(FontManager), Member = "UpdateDummyFonts")]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(FontManager), Member = "UpdateDummyFonts")]
		[CalledBy(Type = typeof(UIFont), Member = "set_replacement")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[Calls(Type = typeof(UIFont), Member = "set_replacement")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public bool isDynamic
	{
		[CalledBy(Type = typeof(UIPopupList), Member = "OnValidate")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CalledBy(Type = typeof(UIFont), Member = "get_dynamicTexture")]
		[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
		[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
		[CalledBy(Type = typeof(UIFont), Member = "get_defaultSize")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIFont), Member = "get_isDynamic")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
		get
		{
			return default(bool);
		}
	}

	public Font dynamicFont
	{
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(UILabel), Member = "get_trueTypeFont")]
		[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
		[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnValidate")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIFont), Member = "set_material")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public FontStyle dynamicFontStyle
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnValidate")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		get
		{
			return default(FontStyle);
		}
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		set
		{
		}
	}

	private Texture dynamicTexture
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UILabel), Member = "get_fontSize")]
	[CalledBy(Type = typeof(UILabel), Member = "get_fontSize")]
	[CallerCount(Count = 2)]
	public float GetFontSizeModifierValue()
	{
		return default(float);
	}

	[Calls(Type = typeof(UIFont), Member = "get_texture")]
	[Calls(Type = typeof(UIAtlas), Member = "get_texture")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BMGlyph), Member = "Trim")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(UIFont), Member = "UpdateUVRect")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UIFont), Member = "get_texture")]
	[Calls(Type = typeof(NGUIMath), Member = "ConvertToPixels")]
	private void Trim()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
	[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
	[CallsUnknownMethods(Count = 1)]
	private bool References(UIFont font)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Font), Member = "get_fontNames")]
	[Calls(Type = typeof(UIFont), Member = "References")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	[Calls(Type = typeof(UIFont), Member = "References")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Font), Member = "get_fontNames")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	[CallerCount(Count = 1)]
	public static bool CheckIfRelated(UIFont a, UIFont b)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UIFont), Member = "set_atlas")]
	[CalledBy(Type = typeof(UIFont), Member = "set_material")]
	[CalledBy(Type = typeof(UIFont), Member = "set_uvRect")]
	[CalledBy(Type = typeof(UIFont), Member = "set_spriteName")]
	[CalledBy(Type = typeof(UIFont), Member = "set_replacement")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(UIFont), Member = "set_dynamicFont")]
	[CalledBy(Type = typeof(UIFont), Member = "set_dynamicFontStyle")]
	[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[CalledBy(Type = typeof(UIFont), Member = "AddSymbol")]
	[CalledBy(Type = typeof(UIFont), Member = "RemoveSymbol")]
	[CalledBy(Type = typeof(UIFont), Member = "RenameSymbol")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIFont), Member = "set_replacement")]
	[Calls(Type = typeof(UIFont), Member = "get_symbols")]
	[Calls(Type = typeof(UIFont), Member = "CheckIfRelated")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(UIFont), Member = "get_symbols")]
	public void MarkAsChanged()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIFont), Member = "get_sprite")]
	[Calls(Type = typeof(UIFont), Member = "Trim")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIAtlas), Member = "get_texture")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void UpdateUVRect()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(UIFont), Member = "RemoveSymbol")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIFont), Member = "AddSymbol")]
	[CalledBy(Type = typeof(UIFont), Member = "RenameSymbol")]
	private BMSymbol GetSymbol(string sequence, bool createIfMissing)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIFont), Member = "get_atlas")]
	[Calls(Type = typeof(BMSymbol), Member = "Validate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(NGUIText), Member = "GetSymbol")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	public BMSymbol MatchSymbol(string text, int offset, int textLength)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIFont), Member = "GetSymbol")]
	[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[CallsUnknownMethods(Count = 1)]
	public void AddSymbol(string sequence, string spriteName)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[Calls(Type = typeof(UIFont), Member = "get_symbols")]
	[Calls(Type = typeof(UIFont), Member = "GetSymbol")]
	[CallerCount(Count = 0)]
	public void RemoveSymbol(string sequence)
	{
	}

	[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[Calls(Type = typeof(UIFont), Member = "GetSymbol")]
	[CallerCount(Count = 0)]
	public void RenameSymbol(string before, string after)
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIFont), Member = "get_spriteName")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UIFont), Member = "get_symbols")]
	[Calls(Type = typeof(UIFont), Member = "get_symbols")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public bool UsesSprite(string s)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public UIFont()
	{
	}
}
