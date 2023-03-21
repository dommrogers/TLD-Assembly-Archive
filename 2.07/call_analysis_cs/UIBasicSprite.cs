using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class UIBasicSprite : UIWidget
{
	public enum Type
	{
		Simple,
		Sliced,
		Tiled,
		Filled,
		Advanced
	}

	public enum FillDirection
	{
		Horizontal,
		Vertical,
		Radial90,
		Radial180,
		Radial360
	}

	public enum AdvancedType
	{
		Invisible,
		Sliced,
		Tiled
	}

	public enum Flip
	{
		Nothing,
		Horizontally,
		Vertically,
		Both
	}

	protected Type mType;

	protected FillDirection mFillDirection;

	protected float mFillAmount;

	protected bool mInvert;

	protected Flip mFlip;

	[NonSerialized]
	private Rect mInnerUV;

	[NonSerialized]
	private Rect mOuterUV;

	public AdvancedType centerType;

	public AdvancedType leftType;

	public AdvancedType rightType;

	public AdvancedType bottomType;

	public AdvancedType topType;

	protected static Vector2[] mTempPos;

	protected static Vector2[] mTempUVs;

	public virtual Type type
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Type);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public Flip flip
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Flip);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public FillDirection fillDirection
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(FillDirection);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float fillAmount
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CalledBy(Type = typeof(UIProgressBar), Member = "ForceUpdate")]
		[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
		[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
		[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisualsScrollList")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePackMorale")]
		[CalledBy(Type = typeof(TimedActionPopup), Member = "Update")]
		[CallerCount(Count = 6)]
		set
		{
		}
	}

	public override int minWidth
	{
		[CalledBy(Type = typeof(UISprite), Member = "get_minWidth")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	public override int minHeight
	{
		[CalledBy(Type = typeof(UISprite), Member = "get_minHeight")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	public bool invert
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool hasBorder
	{
		[CalledBy(Type = typeof(UI2DSprite), Member = "MakePixelPerfect")]
		[CalledBy(Type = typeof(UITexture), Member = "MakePixelPerfect")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public virtual bool premultipliedAlpha
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return false;
		}
	}

	public virtual float pixelSize
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	private Vector4 drawingUVs
	{
		[CalledBy(Type = typeof(UIBasicSprite), Member = "SimpleFill")]
		[CalledBy(Type = typeof(UIBasicSprite), Member = "FilledFill")]
		[CallerCount(Count = 2)]
		get
		{
			return default(Vector4);
		}
	}

	private Color32 drawingColor
	{
		[CalledBy(Type = typeof(UIBasicSprite), Member = "SimpleFill")]
		[CalledBy(Type = typeof(UIBasicSprite), Member = "SlicedFill")]
		[CalledBy(Type = typeof(UIBasicSprite), Member = "TiledFill")]
		[CalledBy(Type = typeof(UIBasicSprite), Member = "FilledFill")]
		[CalledBy(Type = typeof(UIBasicSprite), Member = "AdvancedFill")]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return default(Color32);
		}
	}

	[CalledBy(Type = typeof(UI2DSprite), Member = "OnFill")]
	[CalledBy(Type = typeof(UISprite), Member = "OnFill")]
	[CalledBy(Type = typeof(UITexture), Member = "OnFill")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIBasicSprite), Member = "AdvancedFill")]
	[Calls(Type = typeof(UIBasicSprite), Member = "FilledFill")]
	[Calls(Type = typeof(UIBasicSprite), Member = "TiledFill")]
	[Calls(Type = typeof(UIBasicSprite), Member = "SlicedFill")]
	[Calls(Type = typeof(UIBasicSprite), Member = "SimpleFill")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void Fill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, Rect outer, Rect inner)
	{
	}

	[CalledBy(Type = typeof(UIBasicSprite), Member = "Fill")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "SlicedFill")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "AdvancedFill")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingUVs")]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingColor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	private void SimpleFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CalledBy(Type = typeof(UIBasicSprite), Member = "Fill")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIBasicSprite), Member = "SimpleFill")]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingColor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	private void SlicedFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CalledBy(Type = typeof(UIBasicSprite), Member = "Fill")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingColor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	private void TiledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CalledBy(Type = typeof(UIBasicSprite), Member = "Fill")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingUVs")]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingColor")]
	[Calls(Type = typeof(UIBasicSprite), Member = "RadialCut")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	private void FilledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CalledBy(Type = typeof(UIBasicSprite), Member = "Fill")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIBasicSprite), Member = "SimpleFill")]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingColor")]
	[Calls(Type = typeof(UIBasicSprite), Member = "Fill")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	private void AdvancedFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CalledBy(Type = typeof(UIBasicSprite), Member = "FilledFill")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIBasicSprite), Member = "RadialCut")]
	[CallsUnknownMethods(Count = 2)]
	private static bool RadialCut(Vector2[] xy, Vector2[] uv, float fill, bool invert, int corner)
	{
		return false;
	}

	[CalledBy(Type = typeof(UIBasicSprite), Member = "RadialCut")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static void RadialCut(Vector2[] xy, float cos, float sin, bool invert, int corner)
	{
	}

	[CalledBy(Type = typeof(UIBasicSprite), Member = "AdvancedFill")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	private static void Fill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, float v0x, float v1x, float v0y, float v1y, float u0x, float u1x, float u0y, float u1y, Color col)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = ".ctor")]
	protected UIBasicSprite()
	{
	}
}
