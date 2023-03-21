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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteMaterial")]
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
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 25)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
		[Calls(Type = typeof(UISprite), Member = "SetAtlasSprite")]
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
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallerCount(Count = 120)]
		set
		{
		}
	}

	public bool isValid
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
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
		get
		{
			return default(Vector4);
		}
	}

	public override float pixelSize
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIAtlas), Member = "get_pixelSize")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(float);
		}
	}

	public override int minWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[Calls(Type = typeof(UIBasicSprite), Member = "get_minWidth")]
		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 5)]
		[Calls(Type = typeof(UIBasicSprite), Member = "get_minWidth")]
		get
		{
			return default(int);
		}
	}

	public override int minHeight
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[Calls(Type = typeof(UIBasicSprite), Member = "get_minHeight")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIBasicSprite), Member = "get_minHeight")]
		get
		{
			return default(int);
		}
	}

	public override Vector4 drawingDimensions
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[CallsDeduplicatedMethods(Count = 3)]
		get
		{
			return default(Vector4);
		}
	}

	public override bool premultipliedAlpha
	{
		[Calls(Type = typeof(UIAtlas), Member = "get_premultipliedAlpha")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	[CalledBy(Type = typeof(UISprite), Member = "get_minHeight")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Highlight")]
	[CalledBy(Type = typeof(UIPopupList), Member = "GetHighlightPosition")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(UISprite), Member = "get_isValid")]
	[Calls(Type = typeof(UISprite), Member = "SetAtlasSprite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
	[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(UISprite), Member = "get_border")]
	[CalledBy(Type = typeof(UISprite), Member = "get_drawingDimensions")]
	[CalledBy(Type = typeof(UISprite), Member = "MakePixelPerfect")]
	[CalledBy(Type = typeof(UISprite), Member = "MakePixelPerfect")]
	[CalledBy(Type = typeof(SpriteCreditElement), Member = "Populate")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UISprite), Member = "SetAtlasSprite")]
	[CalledBy(Type = typeof(UISprite), Member = "get_minWidth")]
	public UISpriteData GetAtlasSprite()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UISprite), Member = "set_atlas")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[CalledBy(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	protected void SetAtlasSprite(UISpriteData sp)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[Calls(Type = typeof(UIWidget), Member = "MakePixelPerfect")]
	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override void MakePixelPerfect()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "OnInit")]
	[CallerCount(Count = 0)]
	protected override void OnInit()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "OnUpdate")]
	[CallerCount(Count = 0)]
	protected override void OnUpdate()
	{
	}

	[Calls(Type = typeof(UIBasicSprite), Member = "Fill")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
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
