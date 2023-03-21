using System;
using System.Collections.Generic;
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

		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "CompareTo")]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(UIAtlas), Member = "get_premultipliedAlpha")]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UISprite), Member = "get_material")]
		[CalledBy(Type = typeof(UIFont), Member = "set_atlas")]
		[CalledBy(Type = typeof(UIFont), Member = "get_material")]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		set
		{
		}
	}

	public bool premultipliedAlpha
	{
		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(UISprite), Member = "get_premultipliedAlpha")]
		[CalledBy(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
		[CalledBy(Type = typeof(UIAtlas), Member = "get_premultipliedAlpha")]
		[Calls(Type = typeof(UIAtlas), Member = "get_premultipliedAlpha")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteMaterial")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return default(bool);
		}
	}

	public List<UISpriteData> spriteList
	{
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(UISpriteAnimation), Member = "RebuildSpriteList")]
		[CalledBy(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[CalledBy(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[CalledBy(Type = typeof(UISprite), Member = "set_atlas")]
		[CalledBy(Type = typeof(UISprite), Member = "set_atlas")]
		[CalledBy(Type = typeof(UIAtlas), Member = "GetRandomSprite")]
		[Calls(Type = typeof(UIAtlas), Member = "Upgrade")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public Texture texture
	{
		[CalledBy(Type = typeof(BMSymbol), Member = "Validate")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[CalledBy(Type = typeof(UIFont), Member = "Trim")]
		[CalledBy(Type = typeof(UIFont), Member = "UpdateUVRect")]
		get
		{
			return null;
		}
	}

	public float pixelSize
	{
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(UIPopupList), Member = "GetHighlightPosition")]
		[CalledBy(Type = typeof(UISprite), Member = "get_pixelSize")]
		[CalledBy(Type = typeof(UIStretch), Member = "Update")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public UIAtlas replacement
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIAtlas), Member = "set_replacement")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(InterfaceManager), Member = "ResetReplacementAtlases")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(UIAtlas), Member = "set_replacement")]
		[CalledBy(Type = typeof(InterfaceManager), Member = "OnDestroy")]
		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(InterfaceManager), Member = "LoadReplacementAtlases")]
		set
		{
		}
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIAtlas), Member = "MarkSpriteListAsChanged")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CalledBy(Type = typeof(UIImageButton), Member = "SetSprite")]
	[CalledBy(Type = typeof(UIFont), Member = "get_sprite")]
	[CalledBy(Type = typeof(UIFont), Member = "get_sprite")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetRandomSprite")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CalledBy(Type = typeof(NGUITools), Member = "AddSprite")]
	[CalledBy(Type = typeof(BMSymbol), Member = "Validate")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[Calls(Type = typeof(UIAtlas), Member = "MarkSpriteListAsChanged")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(UIAtlas), Member = "MarkSpriteListAsChanged")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(UISprite), Member = "OnFill")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIAtlas), Member = "Upgrade")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public UISpriteData GetSprite(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 14)]
	public string GetRandomSprite(string startsWith)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CallsDeduplicatedMethods(Count = 3)]
	public void MarkSpriteListAsChanged()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	public void SortAlphabetically()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[Calls(Type = typeof(UIAtlas), Member = "Upgrade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 2)]
	public BetterList<string> GetListOfSprites()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[Calls(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIAtlas), Member = "Upgrade")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 30)]
	public BetterList<string> GetListOfSprites(string match)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIAtlas), Member = "CheckIfRelated")]
	[CalledBy(Type = typeof(UIAtlas), Member = "CheckIfRelated")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool References(UIAtlas atlas)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
	[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
	[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
	[Calls(Type = typeof(UIAtlas), Member = "References")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIAtlas), Member = "References")]
	[CallerCount(Count = 3)]
	public static bool CheckIfRelated(UIAtlas a, UIAtlas b)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIAtlas), Member = "set_replacement")]
	[CalledBy(Type = typeof(UIAtlas), Member = "set_replacement")]
	[CalledBy(Type = typeof(UIAtlas), Member = "set_pixelSize")]
	[CalledBy(Type = typeof(UIAtlas), Member = "set_spriteMaterial")]
	[CalledBy(Type = typeof(UIAtlas), Member = "set_spriteMaterial")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[Calls(Type = typeof(UIAtlas), Member = "CheckIfRelated")]
	[Calls(Type = typeof(UIFont), Member = "get_atlas")]
	[Calls(Type = typeof(UIFont), Member = "set_atlas")]
	[Calls(Type = typeof(UIFont), Member = "set_atlas")]
	[Calls(Type = typeof(UIFont), Member = "get_atlas")]
	[Calls(Type = typeof(UIAtlas), Member = "CheckIfRelated")]
	[Calls(Type = typeof(UIFont), Member = "get_atlas")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
	[Calls(Type = typeof(UIAtlas), Member = "CheckIfRelated")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void MarkAsChanged()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(UIAtlas), Member = "get_spriteList")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[CalledBy(Type = typeof(UIAtlas), Member = "Upgrade")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(UIAtlas), Member = "Upgrade")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UISpriteData), Member = ".ctor")]
	[Calls(Type = typeof(NGUIMath), Member = "ConvertToPixels")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(NGUIMath), Member = "ConvertToPixels")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	private bool Upgrade()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CalledBy(Type = typeof(UISDAtlas), Member = ".ctor")]
	[CallsUnknownMethods(Count = 22)]
	public UIAtlas()
	{
	}
}
