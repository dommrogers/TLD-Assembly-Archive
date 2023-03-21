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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
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
		[CalledBy(Type = typeof(UIProgressBar), Member = "ForceUpdate")]
		[CalledBy(Type = typeof(UIScrollBar), Member = "ForceUpdate")]
		[CalledBy(Type = typeof(UI2DSprite), Member = "OnUpdate")]
		[CalledBy(Type = typeof(UITexture), Member = "OnUpdate")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Vector4), Member = "op_Inequality")]
		[Calls(Type = typeof(UIWidget), Member = "ResizeCollider")]
		[CallsDeduplicatedMethods(Count = 2)]
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
		[CallerCount(Count = 1)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 41)]
		[Calls(Type = typeof(UIWidget), Member = "SetDimensions")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public int height
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 40)]
		[Calls(Type = typeof(UIWidget), Member = "SetDimensions")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public Color color
	{
		[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 27)]
		get
		{
			return default(Color);
		}
		[CallerCount(Count = 38)]
		[Calls(Type = typeof(Color), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
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
			return 0f;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public bool isVisible
	{
		[CalledBy(Type = typeof(UIWidget), Member = "SetDirty")]
		[CalledBy(Type = typeof(UIWidget), Member = "MarkAsChanged")]
		[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
		[CalledBy(Type = typeof(UIPanel), Member = "FillAllDrawCalls")]
		[CalledBy(Type = typeof(UIPanel), Member = "FillDrawCall")]
		[CalledBy(Type = typeof(UIPanel), Member = "FindDrawCall")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(NGUITools), Member = "GetActive")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public bool hasVertices
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public Pivot rawPivot
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Pivot);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIWidget), Member = "ResizeCollider")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIInput), Member = "SetPivotToLeft")]
		[CalledBy(Type = typeof(UIInput), Member = "SetPivotToRight")]
		[CalledBy(Type = typeof(UIInput), Member = "RestoreLabelPivot")]
		[CalledBy(Type = typeof(UITextList), Member = "Start")]
		[CalledBy(Type = typeof(Panel_Container), Member = "HoverItem")]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 17)]
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
			return 0;
		}
		[CalledBy(Type = typeof(UICursor), Member = "Start")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
		[CalledBy(Type = typeof(NGUITools), Member = "AdjustDepth")]
		[CalledBy(Type = typeof(NGUITools), Member = "NormalizeWidgetDepths")]
		[CalledBy(Type = typeof(NGUITools), Member = "AddWidget")]
		[CalledBy(Type = typeof(NGUITools), Member = "AddWidget")]
		[CalledBy(Type = typeof(ButtonLegendItem), Member = "SetDepth")]
		[CalledBy(Type = typeof(ClothingSlot), Member = "UpdatePaperDollTextureLayer")]
		[CalledBy(Type = typeof(DragDropItem), Member = "MoveWidgetDepth")]
		[CalledBy(Type = typeof(MapIcon), Member = "ShowHoverWidget")]
		[CalledBy(Type = typeof(MapIcon), Member = "HideHoverWidget")]
		[CalledBy(Type = typeof(MapIcon), Member = "SetDepths")]
		[CalledBy(Type = typeof(ScrollList), Member = "SetObjectDepth")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "SetConditionLabelDepth")]
		[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
		[CalledBy(Type = typeof(GenericSimpleScrollbarSpawner), Member = "AssignValuesToSpawnedObject")]
		[CallerCount(Count = 34)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIPanel), Member = "RemoveWidget")]
		[Calls(Type = typeof(UIPanel), Member = "AddWidget")]
		[Calls(Type = typeof(UIPanel), Member = "SortWidgets")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		set
		{
		}
	}

	public int raycastDepth
	{
		[CalledBy(Type = typeof(NGUITools), Member = "CalculateRaycastDepth")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
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
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return default(Vector2);
		}
	}

	public Vector3 localCenter
	{
		[CalledBy(Type = typeof(UIWidget), Member = "get_worldCenter")]
		[CalledBy(Type = typeof(Panel_WorldMap), Member = "CheckForHoverState")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Vector3), Member = "Lerp")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return default(Vector3);
		}
	}

	public override Vector3[] worldCorners
	{
		[CalledBy(Type = typeof(UILabel), Member = "get_worldCorners")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 13)]
		get
		{
			return null;
		}
	}

	public Vector3 worldCenter
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[Calls(Type = typeof(UIWidget), Member = "get_localCenter")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(Vector3);
		}
	}

	public virtual Vector4 drawingDimensions
	{
		[CalledBy(Type = typeof(UILabel), Member = "get_drawingDimensions")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(Vector4);
		}
	}

	public virtual Material material
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public virtual Texture mainTexture
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public virtual Shader shader
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public Vector2 relativeSize
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Vector2), Member = "get_one")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(Vector2);
		}
	}

	public bool hasBoxCollider
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public virtual int minWidth
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
	}

	public virtual int minHeight
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
	}

	public virtual Vector4 border
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Vector4), Member = "get_zero")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(Vector4);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_width")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_height")]
	[CalledBy(Type = typeof(SpriteCreditElement), Member = "Populate")]
	[CalledBy(Type = typeof(TextureCreditElement), Member = "Populate")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIWidget), Member = "ResizeCollider")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SetDimensions(int w, int h)
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "GetSides")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 25)]
	public override Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "UpdateFinalAlpha")]
	public override float CalculateFinalAlpha(int frameID)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(UIWidget), Member = "CalculateFinalAlpha")]
	[CalledBy(Type = typeof(UIWidget), Member = "Invalidate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected void UpdateFinalAlpha(int frameID)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIPanel), Member = "get_clipCount")]
	[Calls(Type = typeof(UIPanel), Member = "IsVisible")]
	[Calls(Type = typeof(UIWidget), Member = "CalculateCumulativeAlpha")]
	[Calls(Type = typeof(UIWidget), Member = "UpdateFinalAlpha")]
	[Calls(Type = typeof(UIRect), Member = "Invalidate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public override void Invalidate(bool includeChildren)
	{
	}

	[CalledBy(Type = typeof(UIWidget), Member = "Invalidate")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public float CalculateCumulativeAlpha(int frameID)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "SetHorizontal")]
	[Calls(Type = typeof(AnchorPoint), Member = "SetVertical")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 14)]
	public override void SetRect(float x, float y, float width, float height)
	{
	}

	[CalledBy(Type = typeof(UIWidget), Member = "set_drawRegion")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_rawPivot")]
	[CalledBy(Type = typeof(UIWidget), Member = "SetDimensions")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
	[CalledBy(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void ResizeCollider()
	{
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(UIWidget), Member = "PanelCompareFunc")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static int FullCompareFunc(UIWidget left, UIWidget right)
	{
		return 0;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CalledBy(Type = typeof(UIWidget), Member = "FullCompareFunc")]
	[CalledBy(Type = typeof(UIPanel), Member = "AddWidget")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static int PanelCompareFunc(UIWidget left, UIWidget right)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "CalculateBounds")]
	public Bounds CalculateBounds()
	{
		return default(Bounds);
	}

	[CalledBy(Type = typeof(UIWidget), Member = "CalculateBounds")]
	[CalledBy(Type = typeof(UIAnchor), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIStretch), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	public Bounds CalculateBounds(Transform relativeParent)
	{
		return default(Bounds);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIWidget), Member = "get_isVisible")]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetDirty()
	{
	}

	[CalledBy(Type = typeof(UIWidget), Member = "ParentHasChanged")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnInit")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnDisable")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnDestroy")]
	[CalledBy(Type = typeof(UI2DSprite), Member = "set_sprite2D")]
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
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIPanel), Member = "RemoveWidget")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveFromPanel()
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "set_trueTypeFont")]
	[CalledBy(Type = typeof(UILabel), Member = "MarkAsChanged")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIWidget), Member = "get_isVisible")]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[Calls(Type = typeof(UIWidget), Member = "CheckLayer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public virtual void MarkAsChanged()
	{
	}

	[CalledBy(Type = typeof(NGUITools), Member = "CallCreatePanel")]
	[CalledBy(Type = typeof(UIWidget), Member = "get_raycastDepth")]
	[CalledBy(Type = typeof(UIWidget), Member = "SetDirty")]
	[CalledBy(Type = typeof(UIWidget), Member = "MarkAsChanged")]
	[CalledBy(Type = typeof(UIWidget), Member = "ParentHasChanged")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnStart")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnUpdate")]
	[CalledBy(Type = typeof(UI2DSprite), Member = "set_sprite2D")]
	[CalledBy(Type = typeof(UILabel), Member = "OnFontChanged")]
	[CalledBy(Type = typeof(UILabel), Member = "OnStart")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIPanel), Member = "AddWidget")]
	[Calls(Type = typeof(UIWidget), Member = "CheckLayer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public UIPanel CreatePanel()
	{
		return null;
	}

	[CalledBy(Type = typeof(UIWidget), Member = "MarkAsChanged")]
	[CalledBy(Type = typeof(UIWidget), Member = "CreatePanel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 13)]
	public void CheckLayer()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "ParentHasChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override void ParentHasChanged()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void Awake()
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "OnInit")]
	[CalledBy(Type = typeof(UISprite), Member = "OnInit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "OnInit")]
	[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(UIRect), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnInit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "Abs")]
	[Calls(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void UpgradeFrom265()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	protected override void OnStart()
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "OnAnchor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIWidget), Member = "ResizeCollider")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 56)]
	protected override void OnAnchor()
	{
	}

	[CalledBy(Type = typeof(UI2DSprite), Member = "OnUpdate")]
	[CalledBy(Type = typeof(UISprite), Member = "OnUpdate")]
	[CalledBy(Type = typeof(UITexture), Member = "OnUpdate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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
		return false;
	}

	[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Transform), Member = "set_hasChanged")]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply")]
	[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
	[Calls(Type = typeof(Transform), Member = "TransformPoint")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public bool UpdateTransform(int frame)
	{
		return false;
	}

	[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIGeometry), Member = "Clear")]
	[Calls(Type = typeof(UIGeometry), Member = "ApplyTransform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 17)]
	public bool UpdateGeometry(int frame)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIGeometry), Member = "WriteToBuffers")]
	[CallsUnknownMethods(Count = 1)]
	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
	}

	[CalledBy(Type = typeof(UI2DSprite), Member = "MakePixelPerfect")]
	[CalledBy(Type = typeof(UILabel), Member = "MakePixelPerfect")]
	[CalledBy(Type = typeof(UISprite), Member = "MakePixelPerfect")]
	[CalledBy(Type = typeof(UITexture), Member = "MakePixelPerfect")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	public virtual void MakePixelPerfect()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CalledBy(Type = typeof(UIBasicSprite), Member = ".ctor")]
	[CalledBy(Type = typeof(UI2DSprite), Member = ".ctor")]
	[CalledBy(Type = typeof(UILabel), Member = ".ctor")]
	[CalledBy(Type = typeof(UISprite), Member = ".ctor")]
	[CalledBy(Type = typeof(UITexture), Member = ".ctor")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UIGeometry), Member = ".ctor")]
	[Calls(Type = typeof(UIRect), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public UIWidget()
	{
	}
}
