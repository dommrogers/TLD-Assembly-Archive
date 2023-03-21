using System;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIWidget : UIRect
{
	public enum Pivot
	{
		TopLeft,
		Top,
		TopRight,
		Left,
		Center,
		Right,
		BottomLeft,
		Bottom,
		BottomRight
	}

	public delegate void OnDimensionsChanged();

	public delegate void OnPostFillCallback(UIWidget widget, int bufferOffset, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols);

	public enum AspectRatioSource
	{
		Free,
		BasedOnWidth,
		BasedOnHeight
	}

	public delegate bool HitCheck(Vector3 worldPos);

	protected Color mColor;

	protected Pivot mPivot;

	protected int mWidth;

	protected int mHeight;

	protected int mDepth;

	public OnDimensionsChanged onChange;

	public OnPostFillCallback onPostFill;

	public UIDrawCall.OnRenderCallback mOnRender;

	public bool autoResizeBoxCollider;

	public bool hideIfOffScreen;

	public AspectRatioSource keepAspectRatio;

	public float aspectRatio;

	public HitCheck hitCheck;

	[NonSerialized]
	public UIPanel panel;

	[NonSerialized]
	public UIGeometry geometry;

	[NonSerialized]
	public bool fillGeometry;

	[NonSerialized]
	protected bool mPlayMode;

	[NonSerialized]
	protected Vector4 mDrawRegion;

	[NonSerialized]
	private Matrix4x4 mLocalToPanel;

	[NonSerialized]
	private bool mIsVisibleByAlpha;

	[NonSerialized]
	private bool mIsVisibleByPanel;

	[NonSerialized]
	private bool mIsInFront;

	[NonSerialized]
	private float mLastAlpha;

	[NonSerialized]
	private bool mMoved;

	[NonSerialized]
	public UIDrawCall drawCall;

	[NonSerialized]
	protected Vector3[] mCorners;

	[NonSerialized]
	private int mAlphaFrameID;

	private int mMatrixFrame;

	private Vector3 mOldV0;

	private Vector3 mOldV1;

	public UIDrawCall.OnRenderCallback onRender
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 7)]
		[CallsDeduplicatedMethods(Count = 2)]
		set
		{
		}
	}

	public Vector4 drawRegion
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector4);
		}
		[Calls(Type = typeof(Vector4), Member = "op_Inequality")]
		[CalledBy(Type = typeof(UITexture), Member = "OnUpdate")]
		[CalledBy(Type = typeof(UI2DSprite), Member = "OnUpdate")]
		[CalledBy(Type = typeof(UIScrollBar), Member = "ForceUpdate")]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(UIProgressBar), Member = "ForceUpdate")]
		[Calls(Type = typeof(UIWidget), Member = "ResizeCollider")]
		[CalledBy(Type = typeof(UIProgressBar), Member = "ForceUpdate")]
		set
		{
		}
	}

	public Vector2 pivotOffset
	{
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector2);
		}
	}

	public int width
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIWidget), Member = "SetDimensions")]
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 41)]
		[Calls(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 3)]
		set
		{
		}
	}

	public int height
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 40)]
		[Calls(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIWidget), Member = "SetDimensions")]
		[CallsDeduplicatedMethods(Count = 3)]
		set
		{
		}
	}

	public Color color
	{
		[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
		[CallsDeduplicatedMethods(Count = 27)]
		[CallerCount(Count = 1)]
		get
		{
			return default(Color);
		}
		[CallerCount(Count = 38)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Color), Member = "op_Equality")]
		set
		{
		}
	}

	public override float alpha
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public bool isVisible
	{
		[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
		[CalledBy(Type = typeof(UIPanel), Member = "FindDrawCall")]
		[CalledBy(Type = typeof(UIPanel), Member = "FillDrawCall")]
		[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
		[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
		[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
		[CalledBy(Type = typeof(UIWidget), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UIWidget), Member = "SetDirty")]
		[Calls(Type = typeof(NGUITools), Member = "GetActive")]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public bool hasVertices
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public Pivot rawPivot
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Pivot);
		}
		[Calls(Type = typeof(UIWidget), Member = "ResizeCollider")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Pivot pivot
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Pivot);
		}
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
		[CalledBy(Type = typeof(UITextList), Member = "Start")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIInput), Member = "SetPivotToLeft")]
		[CalledBy(Type = typeof(UIInput), Member = "SetPivotToRight")]
		[CalledBy(Type = typeof(UIInput), Member = "RestoreLabelPivot")]
		[CalledBy(Type = typeof(UITextList), Member = "Start")]
		[CalledBy(Type = typeof(Panel_Container), Member = "HoverItem")]
		[CallsUnknownMethods(Count = 17)]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallerCount(Count = 15)]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		set
		{
		}
	}

	public int depth
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIPanel), Member = "RemoveWidget")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 34)]
		[Calls(Type = typeof(UIPanel), Member = "SortWidgets")]
		[Calls(Type = typeof(UIPanel), Member = "AddWidget")]
		[CallsUnknownMethods(Count = 5)]
		set
		{
		}
	}

	public int raycastDepth
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(NGUITools), Member = "CalculateRaycastDepth")]
		[CalledBy(Type = typeof(NGUITools), Member = "CalculateRaycastDepth")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
		get
		{
			return default(int);
		}
	}

	public override Vector3[] localCorners
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[CallsUnknownMethods(Count = 9)]
		get
		{
			return null;
		}
	}

	public virtual Vector2 localSize
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return default(Vector2);
		}
	}

	public Vector3 localCenter
	{
		[CallsUnknownMethods(Count = 5)]
		[CalledBy(Type = typeof(Panel_WorldMap), Member = "CheckForHoverState")]
		[CalledBy(Type = typeof(UIWidget), Member = "get_worldCenter")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Vector3), Member = "Lerp")]
		get
		{
			return default(Vector3);
		}
	}

	public override Vector3[] worldCorners
	{
		[CalledBy(Type = typeof(UILabel), Member = "get_worldCorners")]
		[CallsUnknownMethods(Count = 13)]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		get
		{
			return null;
		}
	}

	public Vector3 worldCenter
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[Calls(Type = typeof(UIWidget), Member = "get_localCenter")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(Vector3);
		}
	}

	public virtual Vector4 drawingDimensions
	{
		[CalledBy(Type = typeof(UILabel), Member = "get_drawingDimensions")]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(Vector4);
		}
	}

	public virtual Material material
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public virtual Texture mainTexture
	{
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public virtual Shader shader
	{
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public Vector2 relativeSize
	{
		[Calls(Type = typeof(Vector2), Member = "get_one")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector2);
		}
	}

	public bool hasBoxCollider
	{
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public virtual int minWidth
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public virtual int minHeight
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
	}

	public virtual Vector4 border
	{
		[Calls(Type = typeof(Vector4), Member = "get_zero")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector4);
		}
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[Calls(Type = typeof(UIWidget), Member = "ResizeCollider")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_height")]
	[CalledBy(Type = typeof(TextureCreditElement), Member = "Populate")]
	[CalledBy(Type = typeof(SpriteCreditElement), Member = "Populate")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_width")]
	public void SetDimensions(int w, int h)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(UILabel), Member = "GetSides")]
	public override Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	[Calls(Type = typeof(UIWidget), Member = "UpdateFinalAlpha")]
	[CallerCount(Count = 0)]
	public override float CalculateFinalAlpha(int frameID)
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIWidget), Member = "CalculateFinalAlpha")]
	[CalledBy(Type = typeof(UIWidget), Member = "Invalidate")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIRect), Member = "get_parent")]
	protected void UpdateFinalAlpha(int frameID)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIRect), Member = "Invalidate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIPanel), Member = "get_clipCount")]
	[Calls(Type = typeof(UIPanel), Member = "IsVisible")]
	[Calls(Type = typeof(UIWidget), Member = "CalculateCumulativeAlpha")]
	[Calls(Type = typeof(UIWidget), Member = "UpdateFinalAlpha")]
	public override void Invalidate(bool includeChildren)
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIWidget), Member = "Invalidate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "get_parent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public float CalculateCumulativeAlpha(int frameID)
	{
		return default(float);
	}

	[Calls(Type = typeof(AnchorPoint), Member = "SetHorizontal")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(AnchorPoint), Member = "SetHorizontal")]
	[Calls(Type = typeof(AnchorPoint), Member = "SetVertical")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "SetVertical")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public override void SetRect(float x, float y, float width, float height)
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CalledBy(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
	[CalledBy(Type = typeof(UIWidget), Member = "SetDimensions")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_rawPivot")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIWidget), Member = "set_drawRegion")]
	[Calls(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void ResizeCollider()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(UIWidget), Member = "PanelCompareFunc")]
	[CallerCount(Count = 0)]
	[DebuggerStepThrough]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[DebuggerHidden]
	public static int FullCompareFunc(UIWidget left, UIWidget right)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(UIWidget), Member = "FullCompareFunc")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIPanel), Member = "AddWidget")]
	[CalledBy(Type = typeof(UIPanel), Member = "AddWidget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static int PanelCompareFunc(UIWidget left, UIWidget right)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "CalculateBounds")]
	public Bounds CalculateBounds()
	{
		return default(Bounds);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(UIStretch), Member = "Update")]
	[CalledBy(Type = typeof(UIAnchor), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIWidget), Member = "CalculateBounds")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix")]
	public Bounds CalculateBounds(Transform relativeParent)
	{
		return default(Bounds);
	}

	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "get_isVisible")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SetDirty()
	{
	}

	[CalledBy(Type = typeof(UI2DSprite), Member = "set_material")]
	[CalledBy(Type = typeof(UI2DSprite), Member = "set_shader")]
	[CalledBy(Type = typeof(UILabel), Member = "set_material")]
	[CalledBy(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[CalledBy(Type = typeof(UILabel), Member = "set_trueTypeFont")]
	[CalledBy(Type = typeof(UILabel), Member = "OnDisable")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFontChanged")]
	[CalledBy(Type = typeof(UISprite), Member = "set_atlas")]
	[CalledBy(Type = typeof(UITexture), Member = "set_mainTexture")]
	[CalledBy(Type = typeof(UITexture), Member = "set_material")]
	[CalledBy(Type = typeof(UITexture), Member = "set_shader")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIWidget), Member = "OnDestroy")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnDisable")]
	[CalledBy(Type = typeof(UI2DSprite), Member = "set_sprite2D")]
	[CalledBy(Type = typeof(UIWidget), Member = "ParentHasChanged")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnInit")]
	[Calls(Type = typeof(UIPanel), Member = "RemoveWidget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 16)]
	public void RemoveFromPanel()
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "MarkAsChanged")]
	[CalledBy(Type = typeof(UILabel), Member = "set_trueTypeFont")]
	[Calls(Type = typeof(UIWidget), Member = "CheckLayer")]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[Calls(Type = typeof(UIWidget), Member = "get_isVisible")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	public virtual void MarkAsChanged()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UILabel), Member = "OnStart")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFontChanged")]
	[CalledBy(Type = typeof(UI2DSprite), Member = "set_sprite2D")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnUpdate")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnStart")]
	[CalledBy(Type = typeof(UIWidget), Member = "ParentHasChanged")]
	[CalledBy(Type = typeof(UIWidget), Member = "MarkAsChanged")]
	[CalledBy(Type = typeof(UIWidget), Member = "SetDirty")]
	[CalledBy(Type = typeof(UIWidget), Member = "get_raycastDepth")]
	[CalledBy(Type = typeof(NGUITools), Member = "CallCreatePanel")]
	[Calls(Type = typeof(UIWidget), Member = "CheckLayer")]
	[Calls(Type = typeof(UIPanel), Member = "AddWidget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	public UIPanel CreatePanel()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(UIWidget), Member = "CreatePanel")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIWidget), Member = "MarkAsChanged")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public void CheckLayer()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "ParentHasChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	public override void ParentHasChanged()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void Awake()
	{
	}

	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UISprite), Member = "OnInit")]
	[CalledBy(Type = typeof(UILabel), Member = "OnInit")]
	[Calls(Type = typeof(UIRect), Member = "Update")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[Calls(Type = typeof(UIRect), Member = "OnInit")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	protected override void OnInit()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[Calls(Type = typeof(Mathf), Member = "Abs")]
	[Calls(Type = typeof(Mathf), Member = "Abs")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	protected virtual void UpgradeFrom265()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	protected override void OnStart()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsUnknownMethods(Count = 56)]
	[CalledBy(Type = typeof(UILabel), Member = "OnAnchor")]
	[Calls(Type = typeof(UIWidget), Member = "ResizeCollider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	protected override void OnAnchor()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UISprite), Member = "OnUpdate")]
	[CalledBy(Type = typeof(UITexture), Member = "OnUpdate")]
	[CalledBy(Type = typeof(UI2DSprite), Member = "OnUpdate")]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	protected override void OnUpdate()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnApplicationPause(bool paused)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[Calls(Type = typeof(UIRect), Member = "OnDisable")]
	protected override void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public bool UpdateVisibility(bool visibleByAlpha, bool visibleByPanel)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "TransformPoint")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	[Calls(Type = typeof(Transform), Member = "TransformPoint")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Transform), Member = "set_hasChanged")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public bool UpdateTransform(int frame)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UIGeometry), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIGeometry), Member = "Clear")]
	[Calls(Type = typeof(UIGeometry), Member = "ApplyTransform")]
	public bool UpdateGeometry(int frame)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIGeometry), Member = "WriteToBuffers")]
	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
	}

	[CalledBy(Type = typeof(UISprite), Member = "MakePixelPerfect")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CalledBy(Type = typeof(UI2DSprite), Member = "MakePixelPerfect")]
	[CalledBy(Type = typeof(UILabel), Member = "MakePixelPerfect")]
	[CallsUnknownMethods(Count = 11)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(UITexture), Member = "MakePixelPerfect")]
	[CallerCount(Count = 4)]
	public virtual void MakePixelPerfect()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[Calls(Type = typeof(UIGeometry), Member = ".ctor")]
	[Calls(Type = typeof(UIRect), Member = ".ctor")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = ".ctor")]
	[CalledBy(Type = typeof(UILabel), Member = ".ctor")]
	[CalledBy(Type = typeof(UISprite), Member = ".ctor")]
	[CalledBy(Type = typeof(UITexture), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(UI2DSprite), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	public UIWidget()
	{
	}
}
