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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 56)]
		set
		{
		}
	}

	public override int minWidth
	{
		[CalledBy(Type = typeof(UISprite), Member = "get_minWidth")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(UISprite), Member = "get_minWidth")]
		[CallsDeduplicatedMethods(Count = 5)]
		get
		{
			return default(int);
		}
	}

	public override int minHeight
	{
		[CalledBy(Type = typeof(UISprite), Member = "get_minHeight")]
		[CalledBy(Type = typeof(UISprite), Member = "get_minHeight")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallerCount(Count = 2)]
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
		[CalledBy(Type = typeof(UITexture), Member = "MakePixelPerfect")]
		[CalledBy(Type = typeof(UI2DSprite), Member = "MakePixelPerfect")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		get
		{
			return default(bool);
		}
	}

	public virtual bool premultipliedAlpha
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public virtual float pixelSize
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
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
		[CalledBy(Type = typeof(UIBasicSprite), Member = "FilledFill")]
		[CalledBy(Type = typeof(UIBasicSprite), Member = "TiledFill")]
		[CalledBy(Type = typeof(UIBasicSprite), Member = "SimpleFill")]
		[Calls(Type = typeof(Color32), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(UIBasicSprite), Member = "SlicedFill")]
		[CalledBy(Type = typeof(UIBasicSprite), Member = "AdvancedFill")]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return default(Color32);
		}
	}

	[Calls(Type = typeof(UIBasicSprite), Member = "AdvancedFill")]
	[Calls(Type = typeof(UIBasicSprite), Member = "FilledFill")]
	[Calls(Type = typeof(UIBasicSprite), Member = "TiledFill")]
	[Calls(Type = typeof(UIBasicSprite), Member = "SlicedFill")]
	[Calls(Type = typeof(UIBasicSprite), Member = "SimpleFill")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UI2DSprite), Member = "OnFill")]
	[CalledBy(Type = typeof(UITexture), Member = "OnFill")]
	[CalledBy(Type = typeof(UISprite), Member = "OnFill")]
	[CallerCount(Count = 3)]
	protected void Fill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, Rect outer, Rect inner)
	{
	}

	[CalledBy(Type = typeof(UIBasicSprite), Member = "AdvancedFill")]
	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "SlicedFill")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingUVs")]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingColor")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "Fill")]
	private void SimpleFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CallsUnknownMethods(Count = 171)]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "Fill")]
	[Calls(Type = typeof(UIBasicSprite), Member = "SimpleFill")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingColor")]
	private void SlicedFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CalledBy(Type = typeof(UIBasicSprite), Member = "Fill")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingColor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 32)]
	private void TiledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIBasicSprite), Member = "RadialCut")]
	[Calls(Type = typeof(UIBasicSprite), Member = "RadialCut")]
	[Calls(Type = typeof(Vector2), Member = "op_Implicit")]
	[Calls(Type = typeof(UIBasicSprite), Member = "RadialCut")]
	[Calls(Type = typeof(Vector2), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector2), Member = "op_Implicit")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "Fill")]
	[CallsUnknownMethods(Count = 142)]
	[Calls(Type = typeof(Vector2), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingUVs")]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingColor")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private void FilledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Calls(Type = typeof(Color32), Member = "op_Implicit")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIBasicSprite), Member = "Fill")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit")]
	[Calls(Type = typeof(UIBasicSprite), Member = "Fill")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIBasicSprite), Member = "Fill")]
	[Calls(Type = typeof(UIBasicSprite), Member = "Fill")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIBasicSprite), Member = "SimpleFill")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "Fill")]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_drawingColor")]
	[CallsUnknownMethods(Count = 178)]
	private void AdvancedFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "FilledFill")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "FilledFill")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "FilledFill")]
	[Calls(Type = typeof(UIBasicSprite), Member = "RadialCut")]
	[Calls(Type = typeof(UIBasicSprite), Member = "RadialCut")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	private static bool RadialCut(Vector2[] xy, Vector2[] uv, float fill, bool invert, int corner)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UIBasicSprite), Member = "RadialCut")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "RadialCut")]
	[CallsUnknownMethods(Count = 72)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void RadialCut(Vector2[] xy, float cos, float sin, bool invert, int corner)
	{
	}

	[CalledBy(Type = typeof(UIBasicSprite), Member = "AdvancedFill")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "AdvancedFill")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "AdvancedFill")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = "AdvancedFill")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit")]
	[Calls(Type = typeof(Color32), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 31)]
	[CallerCount(Count = 4)]
	private static void Fill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, float v0x, float v1x, float v0y, float v1y, float u0x, float u1x, float u0y, float u1y, Color col)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = ".ctor")]
	protected UIBasicSprite()
	{
	}
}
