using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UISprite : UIBasicSprite
{
	private UIAtlas mAtlas;

	private string mSpriteName;

	private bool mFillCenter;

	[NonSerialized]
	protected UISpriteData mSprite;

	[NonSerialized]
	private bool mSpriteSet;

	public override Material material
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteMaterial")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public UIAtlas atlas
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UISprite), Member = "SetAtlasSprite")]
		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 24)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		set
		{
		}
	}

	public string spriteName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 127)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		set
		{
		}
	}

	public bool isValid
	{
		[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool fillCenter
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public override Vector4 border
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[Calls(Type = typeof(Vector4), Member = "get_zero")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(Vector4);
		}
	}

	public override float pixelSize
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIAtlas), Member = "get_pixelSize")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(float);
		}
	}

	public override int minWidth
	{
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[Calls(Type = typeof(UIBasicSprite), Member = "get_minWidth")]
		[Calls(Type = typeof(UIBasicSprite), Member = "get_minWidth")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		get
		{
			return default(int);
		}
	}

	public override int minHeight
	{
		[Calls(Type = typeof(UIBasicSprite), Member = "get_minHeight")]
		[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[Calls(Type = typeof(UIBasicSprite), Member = "get_minHeight")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		get
		{
			return default(int);
		}
	}

	public override Vector4 drawingDimensions
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Vector4), Member = "get_zero")]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector4);
		}
	}

	public override bool premultipliedAlpha
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIAtlas), Member = "get_premultipliedAlpha")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	[CalledBy(Type = typeof(UISprite), Member = "get_minHeight")]
	[CalledBy(Type = typeof(UISprite), Member = "get_minWidth")]
	[CalledBy(Type = typeof(UISprite), Member = "get_border")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(UISprite), Member = "MakePixelPerfect")]
	[CalledBy(Type = typeof(UISprite), Member = "MakePixelPerfect")]
	[CalledBy(Type = typeof(SpriteCreditElement), Member = "Populate")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(UISprite), Member = "get_isValid")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(UIPopupList), Member = "GetHighlightPosition")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Highlight")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(UISprite), Member = "get_drawingDimensions")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UISprite), Member = "SetAtlasSprite")]
	[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
	[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
	[Calls(Type = typeof(UISprite), Member = "SetAtlasSprite")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	public UISpriteData GetAtlasSprite()
	{
		return null;
	}

	[CalledBy(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[CalledBy(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UISprite), Member = "set_atlas")]
	[CallsUnknownMethods(Count = 1)]
	protected void SetAtlasSprite(UISpriteData sp)
	{
	}

	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[Calls(Type = typeof(UIWidget), Member = "MakePixelPerfect")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public override void MakePixelPerfect()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "OnInit")]
	protected override void OnInit()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "OnUpdate")]
	[CallerCount(Count = 0)]
	protected override void OnUpdate()
	{
	}

	[Calls(Type = typeof(OnPostFillCallback), Member = "Invoke")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIBasicSprite), Member = "Fill")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = ".ctor")]
	public UISprite()
	{
	}
}
