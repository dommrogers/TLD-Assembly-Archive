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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
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
		[CalledBy(Type = typeof(UIFont), Member = "get_material")]
		[CalledBy(Type = typeof(UIAtlas), Member = "get_premultipliedAlpha")]
		[CalledBy(Type = typeof(UIFont), Member = "set_atlas")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UISprite), Member = "get_material")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		set
		{
		}
	}

	public bool premultipliedAlpha
	{
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteMaterial")]
		[CalledBy(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UISprite), Member = "get_premultipliedAlpha")]
		[CallerCount(Count = 2)]
		get
		{
			return default(bool);
		}
	}

	public List<UISpriteData> spriteList
	{
		[Calls(Type = typeof(UIAtlas), Member = "Upgrade")]
		[CalledBy(Type = typeof(UIAtlas), Member = "GetRandomSprite")]
		[CalledBy(Type = typeof(UISprite), Member = "set_atlas")]
		[CalledBy(Type = typeof(UISprite), Member = "set_atlas")]
		[CalledBy(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[CalledBy(Type = typeof(UISpriteAnimation), Member = "RebuildSpriteList")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 6)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public Texture texture
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIFont), Member = "UpdateUVRect")]
		[CalledBy(Type = typeof(UIFont), Member = "Trim")]
		[CalledBy(Type = typeof(BMSymbol), Member = "Validate")]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 3)]
		get
		{
			return null;
		}
	}

	public float pixelSize
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(UISprite), Member = "get_pixelSize")]
		[CalledBy(Type = typeof(UIStretch), Member = "Update")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(UIPopupList), Member = "GetHighlightPosition")]
		get
		{
			return default(float);
		}
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public UIAtlas replacement
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 18)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(InterfaceManager), Member = "ResetReplacementAtlases")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIAtlas), Member = "set_replacement")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(InterfaceManager), Member = "LoadReplacementAtlases")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(InterfaceManager), Member = "OnDestroy")]
		[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIAtlas), Member = "set_replacement")]
		set
		{
		}
	}

	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(BMSymbol), Member = "Validate")]
	[CalledBy(Type = typeof(UIImageButton), Member = "SetSprite")]
	[CalledBy(Type = typeof(NGUITools), Member = "AddSprite")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetRandomSprite")]
	[CalledBy(Type = typeof(UIFont), Member = "get_sprite")]
	[CalledBy(Type = typeof(UIFont), Member = "get_sprite")]
	[CalledBy(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[CalledBy(Type = typeof(UISprite), Member = "OnFill")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UIAtlas), Member = "MarkSpriteListAsChanged")]
	[Calls(Type = typeof(UIAtlas), Member = "MarkSpriteListAsChanged")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UIAtlas), Member = "Upgrade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UIAtlas), Member = "MarkSpriteListAsChanged")]
	public UISpriteData GetSprite(string name)
	{
		return null;
	}

	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public string GetRandomSprite(string startsWith)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CallerCount(Count = 3)]
	public void MarkSpriteListAsChanged()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void SortAlphabetically()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[Calls(Type = typeof(UIAtlas), Member = "Upgrade")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public BetterList<string> GetListOfSprites()
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(UIAtlas), Member = "Upgrade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	public BetterList<string> GetListOfSprites(string match)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIAtlas), Member = "CheckIfRelated")]
	[CalledBy(Type = typeof(UIAtlas), Member = "CheckIfRelated")]
	private bool References(UIAtlas atlas)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UIAtlas), Member = "References")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIAtlas), Member = "References")]
	[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
	[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
	public static bool CheckIfRelated(UIAtlas a, UIAtlas b)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIFont), Member = "get_atlas")]
	[Calls(Type = typeof(UIAtlas), Member = "CheckIfRelated")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[Calls(Type = typeof(UIFont), Member = "set_atlas")]
	[Calls(Type = typeof(UIFont), Member = "set_atlas")]
	[CalledBy(Type = typeof(UIAtlas), Member = "set_spriteMaterial")]
	[CalledBy(Type = typeof(UIAtlas), Member = "set_spriteMaterial")]
	[CalledBy(Type = typeof(UIAtlas), Member = "set_pixelSize")]
	[CalledBy(Type = typeof(UIAtlas), Member = "set_replacement")]
	[CalledBy(Type = typeof(UIAtlas), Member = "set_replacement")]
	[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIFont), Member = "get_atlas")]
	[Calls(Type = typeof(UIAtlas), Member = "CheckIfRelated")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(ResourcesAPI), Member = "get_ActiveAPI")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UIAtlas), Member = "CheckIfRelated")]
	[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UIFont), Member = "get_atlas")]
	public void MarkAsChanged()
	{
	}

	[Calls(Type = typeof(NGUIMath), Member = "ConvertToPixels")]
	[Calls(Type = typeof(NGUIMath), Member = "ConvertToPixels")]
	[Calls(Type = typeof(UISpriteData), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UIAtlas), Member = "Upgrade")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CalledBy(Type = typeof(UIAtlas), Member = "get_spriteList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[CalledBy(Type = typeof(UIAtlas), Member = "Upgrade")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	private bool Upgrade()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(UISDAtlas), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public UIAtlas()
	{
	}
}
