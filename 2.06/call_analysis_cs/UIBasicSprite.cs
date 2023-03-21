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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Flip);
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public FillDirection fillDirection
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
			return default(float);
		}
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(UIProgressBar), Member = "ForceUpdate")]
		[CalledBy(Type = typeof(HUDNowhereToHide), Member = "Update")]
		[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisualsScrollList")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePackMorale")]
		[CalledBy(Type = typeof(TimedActionPopup), Member = "Update")]
		[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
		[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
		set
		{
		}
	}

	public override int minWidth
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CalledBy(Type = typeof(UISprite), Member = "get_minWidth")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UISprite), Member = "get_minWidth")]
		get
		{
			return default(int);
		}
	}

	public override int minHeight
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UISprite), Member = "get_minHeight")]
		[CalledBy(Type = typeof(UISprite), Member = "get_minHeight")]
		[CallsDeduplicatedMethods(Count = 4)]
		get
		{
			return default(int);
		}
	}

	public bool invert
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool hasBorder
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(UITexture), Member = "MakePixelPerfect")]
		[CalledBy(Type = typeof(UI2DSprite), Member = "MakePixelPerfect")]
		get
		{
			return default(bool);
		}
	}

	public virtual bool premultipliedAlpha
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public virtual float pixelSize
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
	}

	private Vector4 drawingUVs
	{
		[CalledBy(Type = typeof(UIBasicSprite), Member = "FilledFill")]
		[CalledBy(Type = typeof(UIBasicSprite), Member = "SimpleFill")]
		[CallerCount(Count = 2)]
		get
		{
			return default(Vector4);
		}
	}

	private Color32 drawingColor
	{
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(UIBasicSprite), Member = "TiledFill")]
		[CallsUnknownMethods(Count = 5)]
		[CalledBy(Type = typeof(UIBasicSprite), Member = "SlicedFill")]
		[CalledBy(Type = typeof(UIBasicSprite), Member = "AdvancedFill")]
		[CalledBy(Type = typeof(UIBasicSprite), Member = "FilledFill")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CalledBy(Type = typeof(UIBasicSprite), Member = "SimpleFill")]
		get
		{
			return default(Color32);
		}
	}

	[Calls(Type = typeof(UIBasicSprite), Member = "AdvancedFill")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIBasicSprite), Member = "TiledFill")]
	[Calls(Type = typeof(UIBasicSprite), Member = "FilledFill")]
	[Calls(Type = typeof(UIBasicSprite), Member = "SlicedFill")]
	[Calls(Type = typeof(UIBasicSprite), Member = "SimpleFill")]
	[CalledBy(Type = typeof(UI2DSprite), Member = "OnFill")]
	[CalledBy(Type = typeof(UISprite), Member = "OnFill")]
	[CalledBy(Type = typeof(UITexture), Member = "OnFill")]
	protected void Fill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, Rect outer, Rect inner)
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingUVs")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "AdvancedFill")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "SlicedFill")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingColor")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "Fill")]
	private void SimpleFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CalledBy(Type = typeof(UIBasicSprite), Member = "Fill")]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingColor")]
	[Calls(Type = typeof(UIBasicSprite), Member = "SimpleFill")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void SlicedFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CalledBy(Type = typeof(UIBasicSprite), Member = "Fill")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingColor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	private void TiledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingColor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIBasicSprite), Member = "RadialCut")]
	[Calls(Type = typeof(UIBasicSprite), Member = "RadialCut")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "Fill")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingUVs")]
	[Calls(Type = typeof(UIBasicSprite), Member = "RadialCut")]
	[CallsDeduplicatedMethods(Count = 11)]
	private void FilledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Calls(Type = typeof(Color32), Member = "op_Implicit")]
	[Calls(Type = typeof(UIBasicSprite), Member = "Fill")]
	[Calls(Type = typeof(UIBasicSprite), Member = "Fill")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit")]
	[Calls(Type = typeof(UIBasicSprite), Member = "Fill")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit")]
	[Calls(Type = typeof(UIBasicSprite), Member = "Fill")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "Fill")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Color32), Member = "op_Implicit")]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingColor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIBasicSprite), Member = "SimpleFill")]
	private void AdvancedFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "FilledFill")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "FilledFill")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "FilledFill")]
	[Calls(Type = typeof(UIBasicSprite), Member = "RadialCut")]
	[Calls(Type = typeof(UIBasicSprite), Member = "RadialCut")]
	[CallerCount(Count = 3)]
	private static bool RadialCut(Vector2[] xy, Vector2[] uv, float fill, bool invert, int corner)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "RadialCut")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "RadialCut")]
	private static void RadialCut(Vector2[] xy, float cos, float sin, bool invert, int corner)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "AdvancedFill")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "AdvancedFill")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "AdvancedFill")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "AdvancedFill")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 4)]
	private static void Fill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, float v0x, float v1x, float v0y, float v1y, float u0x, float u1x, float u0y, float u1y, Color col)
	{
	}

	[Calls(Type = typeof(UIWidget), Member = ".ctor")]
	[CallerCount(Count = 0)]
	protected UIBasicSprite()
	{
	}
}
