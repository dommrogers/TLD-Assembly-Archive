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
				return false;
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
			return 0;
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
		[CalledBy(Type = typeof(UIAtlas), Member = "get_premultipliedAlpha")]
		[CalledBy(Type = typeof(UIFont), Member = "set_atlas")]
		[CalledBy(Type = typeof(UIFont), Member = "get_material")]
		[CalledBy(Type = typeof(UISprite), Member = "get_material")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public bool premultipliedAlpha
	{
		[CalledBy(Type = typeof(UIFont), Member = "get_premultipliedAlphaShader")]
		[CalledBy(Type = typeof(UISprite), Member = "get_premultipliedAlpha")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteMaterial")]
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

	public List<UISpriteData> spriteList
	{
		[CalledBy(Type = typeof(UIAtlas), Member = "GetRandomSprite")]
		[CalledBy(Type = typeof(UISprite), Member = "set_atlas")]
		[CalledBy(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[CalledBy(Type = typeof(UISpriteAnimation), Member = "RebuildSpriteList")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIAtlas), Member = "Upgrade")]
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

	public Texture texture
	{
		[CalledBy(Type = typeof(BMSymbol), Member = "Validate")]
		[CalledBy(Type = typeof(UIFont), Member = "Trim")]
		[CalledBy(Type = typeof(UIFont), Member = "UpdateUVRect")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public float pixelSize
	{
		[CalledBy(Type = typeof(UIPopupList), Member = "GetHighlightPosition")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(UISprite), Member = "get_pixelSize")]
		[CalledBy(Type = typeof(UIStretch), Member = "Update")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public UIAtlas replacement
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 20)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(UIAtlas), Member = "set_replacement")]
		[CalledBy(Type = typeof(InterfaceManager), Member = "LoadReplacementAtlases")]
		[CalledBy(Type = typeof(InterfaceManager), Member = "ResetReplacementAtlases")]
		[CalledBy(Type = typeof(InterfaceManager), Member = "OnDestroy")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UIAtlas), Member = "set_replacement")]
		[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(UIImageButton), Member = "SetSprite")]
	[CalledBy(Type = typeof(BMSymbol), Member = "Validate")]
	[CalledBy(Type = typeof(NGUITools), Member = "AddSprite")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetRandomSprite")]
	[CalledBy(Type = typeof(UIFont), Member = "get_sprite")]
	[CalledBy(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[CalledBy(Type = typeof(UISprite), Member = "OnFill")]
	[CallerCount(Count = 9)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIAtlas), Member = "Upgrade")]
	[Calls(Type = typeof(UIAtlas), Member = "MarkSpriteListAsChanged")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public UISpriteData GetSprite(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 23)]
	public string GetRandomSprite(string startsWith)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void MarkSpriteListAsChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Sort")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void SortAlphabetically()
	{
	}

	[CalledBy(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIAtlas), Member = "Upgrade")]
	[Calls(Type = typeof(BetterList<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 7)]
	public BetterList<string> GetListOfSprites()
	{
		return null;
	}

	[CalledBy(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIAtlas), Member = "Upgrade")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(BetterList<>), Member = "Add")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[Calls(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 10)]
	public BetterList<string> GetListOfSprites(string match)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIAtlas), Member = "CheckIfRelated")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	private bool References(UIAtlas atlas)
	{
		return false;
	}

	[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIAtlas), Member = "References")]
	[CallsUnknownMethods(Count = 1)]
	public static bool CheckIfRelated(UIAtlas a, UIAtlas b)
	{
		return false;
	}

	[CalledBy(Type = typeof(UIAtlas), Member = "set_spriteMaterial")]
	[CalledBy(Type = typeof(UIAtlas), Member = "set_pixelSize")]
	[CalledBy(Type = typeof(UIAtlas), Member = "set_replacement")]
	[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
	[Calls(Type = typeof(NGUITools), Member = "FindActive")]
	[Calls(Type = typeof(UIAtlas), Member = "CheckIfRelated")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(ResourcesAPI), Member = "get_ActiveAPI")]
	[Calls(Type = typeof(UIFont), Member = "get_atlas")]
	[Calls(Type = typeof(UIFont), Member = "set_atlas")]
	[Calls(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void MarkAsChanged()
	{
	}

	[CalledBy(Type = typeof(UIAtlas), Member = "get_spriteList")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[CalledBy(Type = typeof(UIAtlas), Member = "GetListOfSprites")]
	[CalledBy(Type = typeof(UIAtlas), Member = "Upgrade")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUIMath), Member = "ConvertToPixels")]
	[Calls(Type = typeof(UISpriteData), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UIAtlas), Member = "Upgrade")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	private bool Upgrade()
	{
		return false;
	}

	[CalledBy(Type = typeof(UISDAtlas), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	public UIAtlas()
	{
	}
}
