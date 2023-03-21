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
		[CalledBy(Type = typeof(NGUIText), Member = "GetGlyphWidth")]
		[CalledBy(Type = typeof(NGUIText), Member = "GetGlyph")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public int texWidth
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return default(int);
		}
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		set
		{
		}
	}

	public int texHeight
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return default(bool);
		}
	}

	public List<BMSymbol> symbols
	{
		[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIFont), Member = "RemoveSymbol")]
		[CalledBy(Type = typeof(UIFont), Member = "UsesSprite")]
		[CalledBy(Type = typeof(UIFont), Member = "UsesSprite")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(UIFont), Member = "get_sprite")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 6)]
		get
		{
			return null;
		}
	}

	public UIAtlas atlas
	{
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIFont), Member = "MatchSymbol")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteMaterial")]
		[Calls(Type = typeof(UIFont), Member = "get_uvRect")]
		[Calls(Type = typeof(UIFont), Member = "get_sprite")]
		set
		{
		}
	}

	public Material material
	{
		[Calls(Type = typeof(Font), Member = "get_material")]
		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Font), Member = "get_material")]
		[CalledBy(Type = typeof(UIFont), Member = "get_texture")]
		[CalledBy(Type = typeof(UIFont), Member = "get_packedFontShader")]
		[CalledBy(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteMaterial")]
		[Calls(Type = typeof(Material), Member = "set_mainTexture")]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(UILabel), Member = "get_material")]
		[Calls(Type = typeof(Font), Member = "get_material")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(UIFont), Member = "set_dynamicFont")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIFont), Member = "get_material")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(UIFont), Member = "get_premultipliedAlpha")]
		[CalledBy(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
		[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
		[CalledBy(Type = typeof(UILabel), Member = "ApplyShadow")]
		[CalledBy(Type = typeof(UILabel), Member = "ApplyShadow")]
		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[Calls(Type = typeof(UIAtlas), Member = "get_premultipliedAlpha")]
		get
		{
			return default(bool);
		}
	}

	public bool packedFontShader
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
		[CalledBy(Type = typeof(UIFont), Member = "get_packedFontShader")]
		[Calls(Type = typeof(UIFont), Member = "get_packedFontShader")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIFont), Member = "get_material")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 3)]
		get
		{
			return default(bool);
		}
	}

	public Texture2D texture
	{
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIFont), Member = "get_material")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(UIFont), Member = "Trim")]
		[CalledBy(Type = typeof(UIFont), Member = "Trim")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public Rect uvRect
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIFont), Member = "get_sprite")]
		[Calls(Type = typeof(UIFont), Member = "get_uvRect")]
		[CalledBy(Type = typeof(UIFont), Member = "set_atlas")]
		[CalledBy(Type = typeof(UIFont), Member = "get_uvRect")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return default(Rect);
		}
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIFont), Member = "get_sprite")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[Calls(Type = typeof(UIFont), Member = "set_uvRect")]
		[CalledBy(Type = typeof(UIFont), Member = "set_uvRect")]
		set
		{
		}
	}

	public string spriteName
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(UIFont), Member = "UsesSprite")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		set
		{
		}
	}

	public bool isValid
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(BMFont), Member = "get_isValid")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[Calls(Type = typeof(UIFont), Member = "set_defaultSize")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int defaultSize
	{
		[CalledBy(Type = typeof(UIPopupList), Member = "OnValidate")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIPopupList), Member = "get_activeFontScale")]
		[CalledBy(Type = typeof(UIPopupList), Member = "get_activeFontSize")]
		[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 9)]
		[CalledBy(Type = typeof(UILabel), Member = "get_fontSize")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIFont), Member = "get_size")]
		[CalledBy(Type = typeof(UILabel), Member = "UpgradeFrom265")]
		get
		{
			return default(int);
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(UIFont), Member = "set_size")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public UISpriteData sprite
	{
		[CalledBy(Type = typeof(UIFont), Member = "get_uvRect")]
		[Calls(Type = typeof(UIFont), Member = "get_symbols")]
		[Calls(Type = typeof(UIFont), Member = "UpdateUVRect")]
		[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIFont), Member = "get_sprite")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 11)]
		[CalledBy(Type = typeof(UIFont), Member = "set_atlas")]
		[CalledBy(Type = typeof(UIFont), Member = "get_sprite")]
		[CalledBy(Type = typeof(UIFont), Member = "set_uvRect")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		get
		{
			return null;
		}
	}

	public UIFont replacement
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIFont), Member = "set_replacement")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIFont), Member = "set_replacement")]
		[CalledBy(Type = typeof(FontManager), Member = "UpdateDummyFonts")]
		[CalledBy(Type = typeof(FontManager), Member = "UpdateDummyFonts")]
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 3)]
		set
		{
		}
	}

	public bool isDynamic
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIFont), Member = "get_dynamicTexture")]
		[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
		[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
		[CalledBy(Type = typeof(UIFont), Member = "get_defaultSize")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnValidate")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public Font dynamicFont
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "OnSelectionUpdate")]
		[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "OnSelectionUpdate")]
		[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CalledBy(Type = typeof(UILabel), Member = "get_trueTypeFont")]
		[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
		[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnValidate")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UIFont), Member = "set_material")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		set
		{
		}
	}

	public FontStyle dynamicFontStyle
	{
		[CalledBy(Type = typeof(UIPopupList), Member = "OnValidate")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(FontStyle);
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		set
		{
		}
	}

	private Texture dynamicTexture
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UILabel), Member = "get_fontSize")]
	[CalledBy(Type = typeof(UILabel), Member = "get_fontSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public float GetFontSizeModifierValue()
	{
		return default(float);
	}

	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(NGUIMath), Member = "ConvertToPixels")]
	[CalledBy(Type = typeof(UIFont), Member = "UpdateUVRect")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BMGlyph), Member = "Trim")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(BMFont), Member = "get_isValid")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UIFont), Member = "get_texture")]
	[Calls(Type = typeof(UIFont), Member = "get_texture")]
	[Calls(Type = typeof(UIAtlas), Member = "get_texture")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void Trim()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
	[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private bool References(UIFont font)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Font), Member = "get_fontNames")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[Calls(Type = typeof(Font), Member = "get_fontNames")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIFont), Member = "References")]
	[Calls(Type = typeof(UIFont), Member = "References")]
	[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static bool CheckIfRelated(UIFont a, UIFont b)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UIFont), Member = "set_atlas")]
	[CalledBy(Type = typeof(UIFont), Member = "set_material")]
	[CalledBy(Type = typeof(UIFont), Member = "set_uvRect")]
	[CalledBy(Type = typeof(UIFont), Member = "set_spriteName")]
	[CalledBy(Type = typeof(UIFont), Member = "set_replacement")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(UIFont), Member = "RenameSymbol")]
	[CalledBy(Type = typeof(UIFont), Member = "RemoveSymbol")]
	[CalledBy(Type = typeof(UIFont), Member = "AddSymbol")]
	[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[CalledBy(Type = typeof(UIFont), Member = "set_dynamicFontStyle")]
	[CalledBy(Type = typeof(UIFont), Member = "set_dynamicFont")]
	[CalledBy(Type = typeof(UIFont), Member = "set_replacement")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UIFont), Member = "get_symbols")]
	[Calls(Type = typeof(UIFont), Member = "get_symbols")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[Calls(Type = typeof(UIFont), Member = "CheckIfRelated")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	public void MarkAsChanged()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIAtlas), Member = "get_texture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIFont), Member = "get_sprite")]
	[Calls(Type = typeof(UIFont), Member = "Trim")]
	public void UpdateUVRect()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(UIFont), Member = "AddSymbol")]
	[CalledBy(Type = typeof(UIFont), Member = "RemoveSymbol")]
	[CalledBy(Type = typeof(UIFont), Member = "RenameSymbol")]
	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private BMSymbol GetSymbol(string sequence, bool createIfMissing)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(NGUIText), Member = "GetSymbol")]
	[Calls(Type = typeof(BMSymbol), Member = "Validate")]
	[Calls(Type = typeof(UIFont), Member = "get_atlas")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public BMSymbol MatchSymbol(string text, int offset, int textLength)
	{
		return null;
	}

	[Calls(Type = typeof(UIFont), Member = "GetSymbol")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
	public void AddSymbol(string sequence, string spriteName)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIFont), Member = "GetSymbol")]
	[Calls(Type = typeof(UIFont), Member = "get_symbols")]
	[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void RemoveSymbol(string sequence)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[Calls(Type = typeof(UIFont), Member = "GetSymbol")]
	public void RenameSymbol(string before, string after)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIFont), Member = "get_spriteName")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(UIFont), Member = "get_symbols")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIFont), Member = "get_symbols")]
	public bool UsesSprite(string s)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BMFont), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public UIFont()
	{
	}
}
