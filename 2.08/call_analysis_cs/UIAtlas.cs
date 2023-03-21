using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIAtlas : MonoBehaviour
{
	[Serializable]
	private class Sprite
	{
		public string name;

		public Rect outer;

		public Rect inner;

		public bool rotated;

		public float paddingLeft;

		public float paddingRight;

		public float paddingTop;

		public float paddingBottom;

		public bool hasPadding
		{
			[CallerCount(Count = 0)]
			get
			{
				return default(bool);
			}
		}

		[CallerCount(Count = 0)]
		public Sprite()
		{
		}
	}

	private enum Coordinates
	{
		Pixels,
		TexCoords
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UISpriteData> _003C_003E9__30_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal int _003CSortAlphabetically_003Eb__30_0(UISpriteData s1, UISpriteData s2)
		{
			return default(int);
		}
	}

	public string missingTextureSpriteName;

	private Material material;

	private List<UISpriteData> mSprites;

	private float mPixelSize;

	private UIAtlas mReplacement;

	private Coordinates mCoordinates;

	private List<Sprite> sprites;

	private int mPMA;

	private Dictionary<string, int> mSpriteIndices;

	public Material spriteMaterial
	{
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(UIAtlas), Member = "get_premultipliedAlpha")]
		[CalledBy(Type = typeof(UIFont), Member = "set_atlas")]
		[CalledBy(Type = typeof(UIFont), Member = "get_material")]
		[CalledBy(Type = typeof(UISprite), Member = "get_material")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		set
		{
		}
	}

	public bool premultipliedAlpha
	{
		[Calls(Type = typeof(string), Member = "Contains")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteMaterial")]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
		[CalledBy(Type = typeof(UISprite), Member = "get_premultipliedAlpha")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public List<UISpriteData> spriteList
	{
		[CalledBy(Type = typeof(UIAtlas), Member = "GetRandomSprite")]
		[CalledBy(Type = typeof(UISprite), Member = "set_atlas")]
		[CalledBy(Type = typeof(UISprite), Member = "set_atlas")]
		[CalledBy(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[CalledBy(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[CalledBy(Type = typeof(UISpriteAnimation), Member = "RebuildSpriteList")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(UIAtlas), Member = "Upgrade")]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public Texture texture
	{
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[CalledBy(Type = typeof(BMSymbol), Member = "Validate")]
		[CalledBy(Type = typeof(UIFont), Member = "Trim")]
		[CalledBy(Type = typeof(UIFont), Member = "UpdateUVRect")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public float pixelSize
	{
		[CalledBy(Type = typeof(UIPopupList), Member = "GetHighlightPosition")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIStretch), Member = "Update")]
		[CalledBy(Type = typeof(UISprite), Member = "get_pixelSize")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CallerCount(Count = 4)]
		get
		{
			return default(float);
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public UIAtlas replacement
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 16)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(InterfaceManager), Member = "LoadReplacementAtlases")]
		[CalledBy(Type = typeof(UIAtlas), Member = "set_replacement")]
		[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[Calls(Type = typeof(UIAtlas), Member = "set_replacement")]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(InterfaceManager), Member = "ResetReplacementAtlases")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(InterfaceManager), Member = "OnDestroy")]
		set
		{
		}
	}

	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(UIImageButton), Member = "SetSprite")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(BMSymbol), Member = "Validate")]
	[CalledBy(Type = typeof(NGUITools), Member = "AddSprite")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetRandomSprite")]
	[CalledBy(Type = typeof(UIFont), Member = "get_sprite")]
	[CalledBy(Type = typeof(UIFont), Member = "get_sprite")]
	[CalledBy(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[CalledBy(Type = typeof(UISprite), Member = "OnFill")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UIAtlas), Member = "MarkSpriteListAsChanged")]
	[Calls(Type = typeof(UIAtlas), Member = "MarkSpriteListAsChanged")]
	[Calls(Type = typeof(UIAtlas), Member = "Upgrade")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(UIAtlas), Member = "MarkSpriteListAsChanged")]
	public UISpriteData GetSprite(string name)
	{
		return null;
	}

	[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	public string GetRandomSprite(string startsWith)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetSprite")]
	public void MarkSpriteListAsChanged()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SortAlphabetically()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UIAtlas), Member = "Upgrade")]
	[Calls(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[CallsUnknownMethods(Count = 3)]
	public BetterList<string> GetListOfSprites()
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[Calls(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(UIAtlas), Member = "Upgrade")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public BetterList<string> GetListOfSprites(string match)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIAtlas), Member = "CheckIfRelated")]
	[CalledBy(Type = typeof(UIAtlas), Member = "CheckIfRelated")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool References(UIAtlas atlas)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UIAtlas), Member = "References")]
	[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
	[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIAtlas), Member = "References")]
	[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
	public static bool CheckIfRelated(UIAtlas a, UIAtlas b)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UIFont), Member = "get_atlas")]
	[Calls(Type = typeof(UIFont), Member = "set_atlas")]
	[Calls(Type = typeof(UIFont), Member = "set_atlas")]
	[Calls(Type = typeof(UIFont), Member = "get_atlas")]
	[Calls(Type = typeof(UIAtlas), Member = "CheckIfRelated")]
	[CalledBy(Type = typeof(UIAtlas), Member = "set_spriteMaterial")]
	[Calls(Type = typeof(UIAtlas), Member = "CheckIfRelated")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(UIAtlas), Member = "set_replacement")]
	[CalledBy(Type = typeof(UIAtlas), Member = "set_replacement")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[CalledBy(Type = typeof(UIAtlas), Member = "set_spriteMaterial")]
	[CalledBy(Type = typeof(UIAtlas), Member = "set_pixelSize")]
	[Calls(Type = typeof(UIFont), Member = "get_atlas")]
	[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UIAtlas), Member = "CheckIfRelated")]
	[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ResourcesAPI), Member = "get_ActiveAPI")]
	public void MarkAsChanged()
	{
	}

	[Calls(Type = typeof(NGUIMath), Member = "ConvertToPixels")]
	[Calls(Type = typeof(UISpriteData), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UIAtlas), Member = "Upgrade")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[Calls(Type = typeof(NGUIMath), Member = "ConvertToPixels")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[CalledBy(Type = typeof(UIAtlas), Member = "Upgrade")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(UIAtlas), Member = "get_spriteList")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool Upgrade()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UISDAtlas), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public UIAtlas()
	{
	}
}
