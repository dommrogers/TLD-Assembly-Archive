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
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public int texWidth
	{
		[CalledBy(Type = typeof(NGUIText), Member = "Print")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public int texHeight
	{
		[CalledBy(Type = typeof(NGUIText), Member = "Print")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
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
			return false;
		}
	}

	public List<BMSymbol> symbols
	{
		[CalledBy(Type = typeof(UIFont), Member = "get_sprite")]
		[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIFont), Member = "RemoveSymbol")]
		[CalledBy(Type = typeof(UIFont), Member = "UsesSprite")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public UIAtlas atlas
	{
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIFont), Member = "MatchSymbol")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteMaterial")]
		[Calls(Type = typeof(UIFont), Member = "get_sprite")]
		[Calls(Type = typeof(UIFont), Member = "get_uvRect")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public Material material
	{
		[CalledBy(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
		[CalledBy(Type = typeof(UIFont), Member = "get_packedFontShader")]
		[CalledBy(Type = typeof(UIFont), Member = "get_texture")]
		[CalledBy(Type = typeof(UILabel), Member = "get_material")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Font), Member = "get_material")]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[Calls(Type = typeof(Material), Member = "set_mainTexture")]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteMaterial")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(UIFont), Member = "set_dynamicFont")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CallsUnknownMethods(Count = 1)]
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
			return false;
		}
	}

	public bool premultipliedAlphaShader
	{
		[CalledBy(Type = typeof(UIFont), Member = "get_premultipliedAlpha")]
		[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
		[CalledBy(Type = typeof(UILabel), Member = "ApplyShadow")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIFont), Member = "get_material")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[Calls(Type = typeof(UIAtlas), Member = "get_premultipliedAlpha")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public bool packedFontShader
	{
		[CalledBy(Type = typeof(UILabel), Member = "OnFill")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIFont), Member = "get_material")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public Texture2D texture
	{
		[CalledBy(Type = typeof(UIFont), Member = "Trim")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIFont), Member = "get_material")]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public Rect uvRect
	{
		[CalledBy(Type = typeof(NGUIText), Member = "Print")]
		[CalledBy(Type = typeof(UIFont), Member = "set_atlas")]
		[CalledBy(Type = typeof(UIFont), Member = "get_uvRect")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIFont), Member = "get_sprite")]
		[Calls(Type = typeof(UIFont), Member = "get_uvRect")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(Rect);
		}
		[CalledBy(Type = typeof(UIFont), Member = "set_uvRect")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIFont), Member = "get_sprite")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[Calls(Type = typeof(UIFont), Member = "set_uvRect")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public string spriteName
	{
		[CalledBy(Type = typeof(UIFont), Member = "UsesSprite")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public bool isValid
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public int size
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIFont), Member = "get_defaultSize")]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIFont), Member = "set_defaultSize")]
		set
		{
		}
	}

	public int defaultSize
	{
		[CalledBy(Type = typeof(UIPopupList), Member = "get_activeFontSize")]
		[CalledBy(Type = typeof(UIPopupList), Member = "get_activeFontScale")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnValidate")]
		[CalledBy(Type = typeof(UIFont), Member = "get_size")]
		[CalledBy(Type = typeof(UILabel), Member = "get_fontSize")]
		[CalledBy(Type = typeof(UILabel), Member = "UpgradeFrom265")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
		[CalledBy(Type = typeof(UIFont), Member = "set_size")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public UISpriteData sprite
	{
		[CalledBy(Type = typeof(UIFont), Member = "set_atlas")]
		[CalledBy(Type = typeof(UIFont), Member = "get_uvRect")]
		[CalledBy(Type = typeof(UIFont), Member = "set_uvRect")]
		[CalledBy(Type = typeof(UIFont), Member = "get_sprite")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(UIFont), Member = "UpdateUVRect")]
		[Calls(Type = typeof(UIFont), Member = "get_symbols")]
		[Calls(Type = typeof(UIFont), Member = "get_sprite")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
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
		[CalledBy(Type = typeof(UIFont), Member = "set_replacement")]
		[CalledBy(Type = typeof(FontManager), Member = "UpdateDummyFonts")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UIFont), Member = "set_replacement")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public bool isDynamic
	{
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnValidate")]
		[CalledBy(Type = typeof(UIFont), Member = "get_defaultSize")]
		[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
		[CalledBy(Type = typeof(UIFont), Member = "get_dynamicTexture")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public Font dynamicFont
	{
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnValidate")]
		[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
		[CalledBy(Type = typeof(UILabel), Member = "get_trueTypeFont")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "RenderFontTest")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIFont), Member = "set_material")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public FontStyle dynamicFontStyle
	{
		[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIPopupList), Member = "OnValidate")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(FontStyle);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	private Texture dynamicTexture
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(UILabel), Member = "get_fontSize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	public float GetFontSizeModifierValue()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(UIFont), Member = "UpdateUVRect")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIAtlas), Member = "get_texture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIFont), Member = "get_texture")]
	[Calls(Type = typeof(NGUIMath), Member = "ConvertToPixels")]
	[Calls(Type = typeof(BMGlyph), Member = "Trim")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void Trim()
	{
	}

	[CalledBy(Type = typeof(UIFont), Member = "CheckIfRelated")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	private bool References(UIFont font)
	{
		return false;
	}

	[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIFont), Member = "get_isDynamic")]
	[Calls(Type = typeof(UIFont), Member = "get_dynamicFont")]
	[Calls(Type = typeof(Font), Member = "get_fontNames")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIFont), Member = "References")]
	[CallsUnknownMethods(Count = 2)]
	public static bool CheckIfRelated(UIFont a, UIFont b)
	{
		return false;
	}

	[CalledBy(Type = typeof(UIFont), Member = "set_atlas")]
	[CalledBy(Type = typeof(UIFont), Member = "set_material")]
	[CalledBy(Type = typeof(UIFont), Member = "set_uvRect")]
	[CalledBy(Type = typeof(UIFont), Member = "set_spriteName")]
	[CalledBy(Type = typeof(UIFont), Member = "set_replacement")]
	[CalledBy(Type = typeof(UIFont), Member = "set_dynamicFont")]
	[CalledBy(Type = typeof(UIFont), Member = "set_dynamicFontStyle")]
	[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[CalledBy(Type = typeof(UIFont), Member = "AddSymbol")]
	[CalledBy(Type = typeof(UIFont), Member = "RemoveSymbol")]
	[CalledBy(Type = typeof(UIFont), Member = "RenameSymbol")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[Calls(Type = typeof(NGUITools), Member = "FindActive")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIFont), Member = "CheckIfRelated")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[Calls(Type = typeof(UIFont), Member = "get_symbols")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void MarkAsChanged()
	{
	}

	[CalledBy(Type = typeof(UIFont), Member = "get_sprite")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIAtlas), Member = "get_texture")]
	[Calls(Type = typeof(UIFont), Member = "Trim")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateUVRect()
	{
	}

	[CalledBy(Type = typeof(UIFont), Member = "AddSymbol")]
	[CalledBy(Type = typeof(UIFont), Member = "RemoveSymbol")]
	[CalledBy(Type = typeof(UIFont), Member = "RenameSymbol")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private BMSymbol GetSymbol(string sequence, bool createIfMissing)
	{
		return null;
	}

	[CalledBy(Type = typeof(NGUIText), Member = "GetSymbol")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIFont), Member = "get_atlas")]
	[Calls(Type = typeof(BMSymbol), Member = "Validate")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIFont), Member = "GetSymbol")]
	[Calls(Type = typeof(UIFont), Member = "get_symbols")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveSymbol(string sequence)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIFont), Member = "GetSymbol")]
	[Calls(Type = typeof(UIFont), Member = "MarkAsChanged")]
	public void RenameSymbol(string before, string after)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIFont), Member = "get_spriteName")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UIFont), Member = "get_symbols")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public bool UsesSprite(string s)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BMFont), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public UIFont()
	{
	}
}
