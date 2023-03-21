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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteMaterial")]
		[CallsUnknownMethods(Count = 1)]
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
		[CalledBy(Type = typeof(UICursor), Member = "Set")]
		[CalledBy(Type = typeof(UIItemSlot), Member = "Update")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
		[CalledBy(Type = typeof(NGUITools), Member = "AddSprite")]
		[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
		[CalledBy(Type = typeof(ButtonLegendItem), Member = "Setup")]
		[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
		[CalledBy(Type = typeof(SpriteCreditElement), Member = "Populate")]
		[CalledBy(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
		[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateButtonLegend")]
		[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
		[CalledBy(Type = typeof(PlayerManager), Member = "RefreshGamepadPrompts")]
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
		[Calls(Type = typeof(UISprite), Member = "SetAtlasSprite")]
		[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
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
		[CallerCount(Count = 116)]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
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
			return false;
		}
	}

	public bool fillCenter
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIAtlas), Member = "get_pixelSize")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	public override int minWidth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIBasicSprite), Member = "get_minWidth")]
		[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0;
		}
	}

	public override int minHeight
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIBasicSprite), Member = "get_minHeight")]
		[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	public override Vector4 drawingDimensions
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return default(Vector4);
		}
	}

	public override bool premultipliedAlpha
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIAtlas), Member = "get_premultipliedAlpha")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "Highlight")]
	[CalledBy(Type = typeof(UIPopupList), Member = "GetHighlightPosition")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(UISprite), Member = "get_isValid")]
	[CalledBy(Type = typeof(UISprite), Member = "get_border")]
	[CalledBy(Type = typeof(UISprite), Member = "get_minWidth")]
	[CalledBy(Type = typeof(UISprite), Member = "get_minHeight")]
	[CalledBy(Type = typeof(UISprite), Member = "get_drawingDimensions")]
	[CalledBy(Type = typeof(UISprite), Member = "MakePixelPerfect")]
	[CalledBy(Type = typeof(SpriteCreditElement), Member = "Populate")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(Type = typeof(UISprite), Member = "SetAtlasSprite")]
	[Calls(Type = typeof(UIAtlas), Member = "get_spriteList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public UISpriteData GetAtlasSprite()
	{
		return null;
	}

	[CalledBy(Type = typeof(UISprite), Member = "set_atlas")]
	[CalledBy(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected void SetAtlasSprite(UISpriteData sp)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISprite), Member = "GetAtlasSprite")]
	[Calls(Type = typeof(UIWidget), Member = "MakePixelPerfect")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(Type = typeof(UIBasicSprite), Member = "Fill")]
	[CallsDeduplicatedMethods(Count = 6)]
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
