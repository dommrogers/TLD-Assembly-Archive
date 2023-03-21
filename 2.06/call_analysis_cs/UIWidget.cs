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
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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
		[CalledBy(Type = typeof(UI2DSprite), Member = "OnUpdate")]
		[CalledBy(Type = typeof(UITexture), Member = "OnUpdate")]
		[CalledBy(Type = typeof(UITexture), Member = "OnUpdate")]
		[CalledBy(Type = typeof(UIScrollBar), Member = "ForceUpdate")]
		[CalledBy(Type = typeof(UIProgressBar), Member = "ForceUpdate")]
		[Calls(Type = typeof(UIWidget), Member = "ResizeCollider")]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public Vector2 pivotOffset
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		get
		{
			return default(Vector2);
		}
	}

	public int width
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return default(int);
		}
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UIWidget), Member = "SetDimensions")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 42)]
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
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UIWidget), Member = "SetDimensions")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 41)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
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
		[CallerCount(Count = 141)]
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
		[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
		[CalledBy(Type = typeof(UIPanel), Member = "FillDrawCall")]
		[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
		[CalledBy(Type = typeof(UIPanel), Member = "FindDrawCall")]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		get
		{
			return default(Pivot);
		}
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CallsUnknownMethods(Count = 9)]
		[CalledBy(Type = typeof(UITextList), Member = "Start")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIInput), Member = "SetPivotToLeft")]
		[CalledBy(Type = typeof(UIInput), Member = "SetPivotToRight")]
		[CalledBy(Type = typeof(UIInput), Member = "RestoreLabelPivot")]
		[CalledBy(Type = typeof(UITextList), Member = "Start")]
		[CalledBy(Type = typeof(Panel_Container), Member = "HoverItem")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(UIPanel), Member = "RemoveWidget")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 35)]
		[Calls(Type = typeof(UIPanel), Member = "SortWidgets")]
		[Calls(Type = typeof(UIPanel), Member = "AddWidget")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public int raycastDepth
	{
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(NGUITools), Member = "CalculateRaycastDepth")]
		[CalledBy(Type = typeof(NGUITools), Member = "CalculateRaycastDepth")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
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
		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector2);
		}
	}

	public Vector3 localCenter
	{
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(Vector3);
		}
	}

	public override Vector3[] worldCorners
	{
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[CallsUnknownMethods(Count = 6)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[CalledBy(Type = typeof(UILabel), Member = "get_worldCorners")]
		get
		{
			return null;
		}
	}

	public Vector3 worldCenter
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector3);
		}
	}

	public virtual Vector4 drawingDimensions
	{
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[CalledBy(Type = typeof(UILabel), Member = "get_drawingDimensions")]
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
		[CallsUnknownMethods(Count = 8)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		set
		{
		}
	}

	public virtual Texture mainTexture
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 8)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		set
		{
		}
	}

	public virtual Shader shader
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 8)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Vector2 relativeSize
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 15)]
		get
		{
			return default(Vector2);
		}
	}

	public bool hasBoxCollider
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 2)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
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

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "ResizeCollider")]
	[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
	[CalledBy(Type = typeof(TextureCreditElement), Member = "Populate")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_width")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIWidget), Member = "set_height")]
	[CalledBy(Type = typeof(SpriteCreditElement), Member = "Populate")]
	public void SetDimensions(int w, int h)
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(UILabel), Member = "GetSides")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	public override Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "UpdateFinalAlpha")]
	public override float CalculateFinalAlpha(int frameID)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(UIWidget), Member = "Invalidate")]
	[CalledBy(Type = typeof(UIWidget), Member = "CalculateFinalAlpha")]
	[Calls(Type = typeof(UIRect), Member = "get_parent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	protected void UpdateFinalAlpha(int frameID)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIPanel), Member = "get_clipCount")]
	[Calls(Type = typeof(UIPanel), Member = "IsVisible")]
	[Calls(Type = typeof(UIWidget), Member = "CalculateCumulativeAlpha")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UIWidget), Member = "UpdateFinalAlpha")]
	[Calls(Type = typeof(UIRect), Member = "Invalidate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override void Invalidate(bool includeChildren)
	{
	}

	[Calls(Type = typeof(UIRect), Member = "get_parent")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	[CalledBy(Type = typeof(UIWidget), Member = "Invalidate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public float CalculateCumulativeAlpha(int frameID)
	{
		return default(float);
	}

	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(AnchorPoint), Member = "SetHorizontal")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(AnchorPoint), Member = "SetVertical")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "SetVertical")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "SetHorizontal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	public override void SetRect(float x, float y, float width, float height)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
	[CalledBy(Type = typeof(UIWidget), Member = "SetDimensions")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_drawRegion")]
	[Calls(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UIWidget), Member = "set_rawPivot")]
	[CallerCount(Count = 5)]
	public void ResizeCollider()
	{
	}

	[DebuggerStepThrough]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "PanelCompareFunc")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[DebuggerHidden]
	public static int FullCompareFunc(UIWidget left, UIWidget right)
	{
		return default(int);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIPanel), Member = "AddWidget")]
	[CalledBy(Type = typeof(UIPanel), Member = "AddWidget")]
	[CalledBy(Type = typeof(UIWidget), Member = "FullCompareFunc")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 3)]
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

	[CalledBy(Type = typeof(UIStretch), Member = "Update")]
	[CalledBy(Type = typeof(UIAnchor), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIWidget), Member = "CalculateBounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix")]
	[CallsUnknownMethods(Count = 2)]
	public Bounds CalculateBounds(Transform relativeParent)
	{
		return default(Bounds);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIWidget), Member = "get_isVisible")]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SetDirty()
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "set_material")]
	[CalledBy(Type = typeof(UI2DSprite), Member = "set_shader")]
	[CalledBy(Type = typeof(UI2DSprite), Member = "set_material")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UI2DSprite), Member = "set_sprite2D")]
	[CalledBy(Type = typeof(UITexture), Member = "set_material")]
	[CalledBy(Type = typeof(UITexture), Member = "set_mainTexture")]
	[CalledBy(Type = typeof(UISprite), Member = "set_atlas")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFontChanged")]
	[CalledBy(Type = typeof(UILabel), Member = "OnDisable")]
	[CalledBy(Type = typeof(UILabel), Member = "set_trueTypeFont")]
	[CalledBy(Type = typeof(UILabel), Member = "set_bitmapFont")]
	[CalledBy(Type = typeof(UITexture), Member = "set_shader")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnDestroy")]
	[CalledBy(Type = typeof(UIWidget), Member = "ParentHasChanged")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnInit")]
	[Calls(Type = typeof(UIPanel), Member = "RemoveWidget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(UIWidget), Member = "OnDisable")]
	public void RemoveFromPanel()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UILabel), Member = "MarkAsChanged")]
	[CalledBy(Type = typeof(UILabel), Member = "set_trueTypeFont")]
	[Calls(Type = typeof(UIWidget), Member = "CheckLayer")]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[Calls(Type = typeof(UIWidget), Member = "get_isVisible")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual void MarkAsChanged()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "AddWidget")]
	[Calls(Type = typeof(UIWidget), Member = "CheckLayer")]
	[CalledBy(Type = typeof(NGUITools), Member = "CallCreatePanel")]
	[CalledBy(Type = typeof(UIWidget), Member = "get_raycastDepth")]
	[CalledBy(Type = typeof(UILabel), Member = "OnStart")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFontChanged")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnUpdate")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnStart")]
	[CalledBy(Type = typeof(UIWidget), Member = "ParentHasChanged")]
	[CalledBy(Type = typeof(UIWidget), Member = "MarkAsChanged")]
	[CalledBy(Type = typeof(UIWidget), Member = "SetDirty")]
	[CalledBy(Type = typeof(UI2DSprite), Member = "set_sprite2D")]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	public UIPanel CreatePanel()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(UIWidget), Member = "CreatePanel")]
	[CalledBy(Type = typeof(UIWidget), Member = "MarkAsChanged")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	public void CheckLayer()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[Calls(Type = typeof(UIRect), Member = "ParentHasChanged")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public override void ParentHasChanged()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected virtual void Awake()
	{
	}

	[Calls(Type = typeof(UIRect), Member = "OnInit")]
	[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "Update")]
	[CalledBy(Type = typeof(UILabel), Member = "OnInit")]
	[CalledBy(Type = typeof(UISprite), Member = "OnInit")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallerCount(Count = 2)]
	protected override void OnInit()
	{
	}

	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[CallsUnknownMethods(Count = 5)]
	protected virtual void UpgradeFrom265()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[CallerCount(Count = 0)]
	protected override void OnStart()
	{
	}

	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIWidget), Member = "ResizeCollider")]
	[CalledBy(Type = typeof(UILabel), Member = "OnAnchor")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	protected override void OnAnchor()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UITexture), Member = "OnUpdate")]
	[CalledBy(Type = typeof(UISprite), Member = "OnUpdate")]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[CalledBy(Type = typeof(UI2DSprite), Member = "OnUpdate")]
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

	[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public bool UpdateVisibility(bool visibleByAlpha, bool visibleByPanel)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Transform), Member = "TransformPoint")]
	[Calls(Type = typeof(Transform), Member = "TransformPoint")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Transform), Member = "set_hasChanged")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public bool UpdateTransform(int frame)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIGeometry), Member = "Clear")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(UIGeometry), Member = "Clear")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIGeometry), Member = "ApplyTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
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
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(UITexture), Member = "MakePixelPerfect")]
	[CalledBy(Type = typeof(UISprite), Member = "MakePixelPerfect")]
	[CalledBy(Type = typeof(UILabel), Member = "MakePixelPerfect")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallerCount(Count = 4)]
	public virtual void MakePixelPerfect()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CalledBy(Type = typeof(UISprite), Member = ".ctor")]
	[Calls(Type = typeof(UIGeometry), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UIRect), Member = ".ctor")]
	[CalledBy(Type = typeof(UIBasicSprite), Member = ".ctor")]
	[CalledBy(Type = typeof(UI2DSprite), Member = ".ctor")]
	[CalledBy(Type = typeof(UILabel), Member = ".ctor")]
	[CalledBy(Type = typeof(UITexture), Member = ".ctor")]
	[CallerCount(Count = 5)]
	public UIWidget()
	{
	}
}
