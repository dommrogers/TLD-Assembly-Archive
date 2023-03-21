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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
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
		[Calls(Type = typeof(UIWidget), Member = "ResizeCollider")]
		[CalledBy(Type = typeof(UITexture), Member = "OnUpdate")]
		[CalledBy(Type = typeof(UITexture), Member = "OnUpdate")]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(UI2DSprite), Member = "OnUpdate")]
		[CalledBy(Type = typeof(UIProgressBar), Member = "ForceUpdate")]
		[CalledBy(Type = typeof(UIScrollBar), Member = "ForceUpdate")]
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
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 42)]
		[Calls(Type = typeof(UIWidget), Member = "SetDimensions")]
		[Calls(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		set
		{
		}
	}

	public int height
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 41)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UIWidget), Member = "SetDimensions")]
		[Calls(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public Color color
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Color);
		}
		[CallerCount(Count = 205)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public override float alpha
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CalledBy(Type = typeof(UIPanel), Member = "FillDrawCall")]
		[CalledBy(Type = typeof(UIPanel), Member = "FindDrawCall")]
		[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
		[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(NGUITools), Member = "GetActive")]
		[CalledBy(Type = typeof(UIWidget), Member = "SetDirty")]
		[CalledBy(Type = typeof(UIWidget), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
		[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
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
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		get
		{
			return default(Pivot);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UIWidget), Member = "ResizeCollider")]
		set
		{
		}
	}

	public Pivot pivot
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		get
		{
			return default(Pivot);
		}
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIInput), Member = "SetPivotToRight")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIInput), Member = "SetPivotToLeft")]
		[CalledBy(Type = typeof(UIInput), Member = "RestoreLabelPivot")]
		[CalledBy(Type = typeof(UITextList), Member = "Start")]
		[CalledBy(Type = typeof(UITextList), Member = "Start")]
		[CalledBy(Type = typeof(Panel_Container), Member = "HoverItem")]
		[CallsUnknownMethods(Count = 9)]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallerCount(Count = 15)]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		set
		{
		}
	}

	public int depth
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(UIPanel), Member = "SortWidgets")]
		[CallerCount(Count = 35)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UIPanel), Member = "RemoveWidget")]
		[Calls(Type = typeof(UIPanel), Member = "AddWidget")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public int raycastDepth
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(NGUITools), Member = "CalculateRaycastDepth")]
		[CalledBy(Type = typeof(NGUITools), Member = "CalculateRaycastDepth")]
		[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
		[CallerCount(Count = 2)]
		get
		{
			return default(int);
		}
	}

	public override Vector3[] localCorners
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public virtual Vector2 localSize
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(Vector2);
		}
	}

	public Vector3 localCenter
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(Vector3);
		}
	}

	public override Vector3[] worldCorners
	{
		[CallsUnknownMethods(Count = 6)]
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(UILabel), Member = "get_worldCorners")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[CallsDeduplicatedMethods(Count = 4)]
		get
		{
			return null;
		}
	}

	public Vector3 worldCenter
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return default(Vector3);
		}
	}

	public virtual Vector4 drawingDimensions
	{
		[CalledBy(Type = typeof(UILabel), Member = "get_drawingDimensions")]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[CallerCount(Count = 1)]
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
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 7)]
		set
		{
		}
	}

	public virtual Texture mainTexture
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public virtual Shader shader
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Vector2 relativeSize
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		get
		{
			return default(Vector2);
		}
	}

	public bool hasBoxCollider
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public virtual Vector4 border
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector4);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(TextureCreditElement), Member = "Populate")]
	[Calls(Type = typeof(UIWidget), Member = "ResizeCollider")]
	[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UIWidget), Member = "set_width")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_height")]
	[CalledBy(Type = typeof(SpriteCreditElement), Member = "Populate")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 5)]
	public void SetDimensions(int w, int h)
	{
	}

	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(UILabel), Member = "GetSides")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[CallerCount(Count = 1)]
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

	[CalledBy(Type = typeof(UIWidget), Member = "CalculateFinalAlpha")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIWidget), Member = "Invalidate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIRect), Member = "get_parent")]
	protected void UpdateFinalAlpha(int frameID)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIPanel), Member = "get_clipCount")]
	[Calls(Type = typeof(UIPanel), Member = "IsVisible")]
	[Calls(Type = typeof(UIWidget), Member = "CalculateCumulativeAlpha")]
	[Calls(Type = typeof(UIWidget), Member = "UpdateFinalAlpha")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public override void Invalidate(bool includeChildren)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIRect), Member = "get_parent")]
	[CalledBy(Type = typeof(UIWidget), Member = "Invalidate")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	public float CalculateCumulativeAlpha(int frameID)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "SetVertical")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "SetHorizontal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "SetHorizontal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(AnchorPoint), Member = "SetVertical")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	public override void SetRect(float x, float y, float width, float height)
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_drawRegion")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_rawPivot")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
	[CalledBy(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIWidget), Member = "SetDimensions")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	public void ResizeCollider()
	{
	}

	[DebuggerHidden]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "PanelCompareFunc")]
	[Calls(Type = typeof(UIPanel), Member = "CompareFunc")]
	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	public static int FullCompareFunc(UIWidget left, UIWidget right)
	{
		return default(int);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	[CalledBy(Type = typeof(UIPanel), Member = "AddWidget")]
	[CalledBy(Type = typeof(UIPanel), Member = "AddWidget")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[CalledBy(Type = typeof(UIWidget), Member = "FullCompareFunc")]
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

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(UIWidget), Member = "CalculateBounds")]
	[CalledBy(Type = typeof(UIAnchor), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIStretch), Member = "Update")]
	public Bounds CalculateBounds(Transform relativeParent)
	{
		return default(Bounds);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[Calls(Type = typeof(UIWidget), Member = "get_isVisible")]
	[CallerCount(Count = 0)]
	public void SetDirty()
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "set_material")]
	[CalledBy(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[CalledBy(Type = typeof(UI2DSprite), Member = "set_shader")]
	[CalledBy(Type = typeof(UILabel), Member = "OnDisable")]
	[CalledBy(Type = typeof(UILabel), Member = "set_trueTypeFont")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFontChanged")]
	[CalledBy(Type = typeof(UISprite), Member = "set_atlas")]
	[CalledBy(Type = typeof(UITexture), Member = "set_mainTexture")]
	[CalledBy(Type = typeof(UITexture), Member = "set_material")]
	[CalledBy(Type = typeof(UITexture), Member = "set_shader")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UI2DSprite), Member = "set_material")]
	[CalledBy(Type = typeof(UI2DSprite), Member = "set_sprite2D")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnInit")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnDisable")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnDestroy")]
	[CalledBy(Type = typeof(UIWidget), Member = "ParentHasChanged")]
	[Calls(Type = typeof(UIPanel), Member = "RemoveWidget")]
	[CallerCount(Count = 16)]
	public void RemoveFromPanel()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UILabel), Member = "MarkAsChanged")]
	[CalledBy(Type = typeof(UILabel), Member = "set_trueTypeFont")]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[Calls(Type = typeof(UIWidget), Member = "get_isVisible")]
	[Calls(Type = typeof(UIWidget), Member = "CheckLayer")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public virtual void MarkAsChanged()
	{
	}

	[CalledBy(Type = typeof(UIWidget), Member = "SetDirty")]
	[CalledBy(Type = typeof(UIWidget), Member = "MarkAsChanged")]
	[CalledBy(Type = typeof(UIWidget), Member = "ParentHasChanged")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnStart")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnUpdate")]
	[CalledBy(Type = typeof(UI2DSprite), Member = "set_sprite2D")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFontChanged")]
	[CalledBy(Type = typeof(UILabel), Member = "OnStart")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(NGUITools), Member = "CallCreatePanel")]
	[Calls(Type = typeof(UIWidget), Member = "CheckLayer")]
	[Calls(Type = typeof(UIPanel), Member = "AddWidget")]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[CalledBy(Type = typeof(UIWidget), Member = "get_raycastDepth")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	public UIPanel CreatePanel()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(UIWidget), Member = "MarkAsChanged")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIWidget), Member = "CreatePanel")]
	public void CheckLayer()
	{
	}

	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIRect), Member = "ParentHasChanged")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	public override void ParentHasChanged()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected virtual void Awake()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[Calls(Type = typeof(UIRect), Member = "OnInit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UISprite), Member = "OnInit")]
	[Calls(Type = typeof(UIRect), Member = "Update")]
	[CalledBy(Type = typeof(UILabel), Member = "OnInit")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	protected override void OnInit()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	protected virtual void UpgradeFrom265()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	protected override void OnStart()
	{
	}

	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(UILabel), Member = "OnAnchor")]
	[Calls(Type = typeof(UIWidget), Member = "ResizeCollider")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	protected override void OnAnchor()
	{
	}

	[CalledBy(Type = typeof(UI2DSprite), Member = "OnUpdate")]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UITexture), Member = "OnUpdate")]
	[CalledBy(Type = typeof(UISprite), Member = "OnUpdate")]
	protected override void OnUpdate()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnApplicationPause(bool paused)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "OnDisable")]
	[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
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

	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Transform), Member = "TransformPoint")]
	[Calls(Type = typeof(Transform), Member = "TransformPoint")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Transform), Member = "set_hasChanged")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public bool UpdateTransform(int frame)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	[Calls(Type = typeof(UIGeometry), Member = "Clear")]
	[Calls(Type = typeof(UIGeometry), Member = "ApplyTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIGeometry), Member = "Clear")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply")]
	[CallerCount(Count = 1)]
	public bool UpdateGeometry(int frame)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UIGeometry), Member = "WriteToBuffers")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
	}

	[CalledBy(Type = typeof(UI2DSprite), Member = "MakePixelPerfect")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UITexture), Member = "MakePixelPerfect")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(UISprite), Member = "MakePixelPerfect")]
	public virtual void MakePixelPerfect()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CalledBy(Type = typeof(UI2DSprite), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UITexture), Member = ".ctor")]
	[CalledBy(Type = typeof(UISprite), Member = ".ctor")]
	[CalledBy(Type = typeof(UILabel), Member = ".ctor")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = ".ctor")]
	[Calls(Type = typeof(UIRect), Member = ".ctor")]
	[Calls(Type = typeof(UIGeometry), Member = ".ctor")]
	[CallerCount(Count = 5)]
	public UIWidget()
	{
	}
}
