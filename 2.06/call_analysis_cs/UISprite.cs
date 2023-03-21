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
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteMaterial")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public UIAtlas atlas
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
		[Calls(Type = typeof(UISprite), Member = "SetAtlasSprite")]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		set
		{
		}
	}

	public string spriteName
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 116)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
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
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public override Vector4 border
	{
		[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector4);
		}
	}

	public override float pixelSize
	{
		[Calls(Type = typeof(UIAtlas), Member = "get_pixelSize")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(float);
		}
	}

	public override int minWidth
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UIBasicSprite), Member = "get_minWidth")]
		[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[Calls(Type = typeof(UIBasicSprite), Member = "get_minWidth")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public override int minHeight
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(UIBasicSprite), Member = "get_minHeight")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[Calls(Type = typeof(UIBasicSprite), Member = "get_minHeight")]
		get
		{
			return default(int);
		}
	}

	public override Vector4 drawingDimensions
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		get
		{
			return default(Vector4);
		}
	}

	public override bool premultipliedAlpha
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIAtlas), Member = "get_premultipliedAlpha")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return default(bool);
		}
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(UIPopupList), Member = "GetHighlightPosition")]
	[CalledBy(Type = typeof(UISprite), Member = "get_minHeight")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Highlight")]
	[CalledBy(Type = typeof(UISprite), Member = "get_minWidth")]
	[CalledBy(Type = typeof(UISprite), Member = "get_border")]
	[CalledBy(Type = typeof(UISprite), Member = "get_isValid")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(UISprite), Member = "get_drawingDimensions")]
	[Calls(Type = typeof(UISprite), Member = "SetAtlasSprite")]
	[CalledBy(Type = typeof(UISprite), Member = "MakePixelPerfect")]
	[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
	[Calls(Type = typeof(UISprite), Member = "SetAtlasSprite")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SpriteCreditElement), Member = "Populate")]
	[CalledBy(Type = typeof(UISprite), Member = "MakePixelPerfect")]
	[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
	public UISpriteData GetAtlasSprite()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[CalledBy(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[CalledBy(Type = typeof(UISprite), Member = "set_atlas")]
	[CallerCount(Count = 3)]
	protected void SetAtlasSprite(UISpriteData sp)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIWidget), Member = "MakePixelPerfect")]
	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	public override void MakePixelPerfect()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "OnInit")]
	protected override void OnInit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "OnUpdate")]
	protected override void OnUpdate()
	{
	}

	[Calls(Type = typeof(UIBasicSprite), Member = "Fill")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = ".ctor")]
	public UISprite()
	{
	}
}
