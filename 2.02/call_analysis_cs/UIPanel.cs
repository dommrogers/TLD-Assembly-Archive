using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIPanel : UIRect
{
	public enum RenderQueue
	{
		Automatic,
		StartAt,
		Explicit
	}

	public delegate void OnGeometryUpdated();

	public delegate void OnClippingMoved(UIPanel panel);

	public static List<UIPanel> list;

	public OnGeometryUpdated onGeometryUpdated;

	public bool showInPanelTool;

	public bool generateNormals;

	public bool widgetsAreStatic;

	public bool cullWhileDragging;

	public bool alwaysOnScreen;

	public bool anchorOffset;

	public bool softBorderPadding;

	public RenderQueue renderQueue;

	public int startingRenderQueue;

	[NonSerialized]
	public List<UIWidget> widgets;

	[NonSerialized]
	public List<UIDrawCall> drawCalls;

	[NonSerialized]
	public Matrix4x4 worldToLocal;

	[NonSerialized]
	public Vector4 drawCallClipRange;

	public OnClippingMoved onClipMove;

	private Texture2D mClipTexture;

	private float mAlpha;

	private UIDrawCall.Clipping mClipping;

	private Vector4 mClipRange;

	private Vector2 mClipSoftness;

	private int mDepth;

	private int mSortingOrder;

	private bool mRebuild;

	private bool mResized;

	private Vector2 mClipOffset;

	private float mCullTime;

	private float mUpdateTime;

	private int mMatrixFrame;

	private int mAlphaFrameID;

	private int mLayer;

	private static float[] mTemp;

	private Vector2 mMin;

	private Vector2 mMax;

	private bool mHalfPixelOffset;

	private bool mSortWidgets;

	private bool mUpdateScroll;

	private UIPanel mParentPanel;

	private static Vector3[] mCorners;

	private static int mUpdateFrame;

	private UIDrawCall.OnRenderCallback mOnRender;

	private bool mForced;

	public static int nextUnusedDepth
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return default(int);
		}
	}

	public override bool canBeAnchored
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
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
		[Calls(Type = typeof(UIPanel), Member = "SetDirty")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int depth
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
		[CalledBy(Type = typeof(NGUITools), Member = "NormalizePanelDepths")]
		[CalledBy(Type = typeof(UIRoot), Member = "Awake")]
		[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
		[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
		[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
		[CallsUnknownMethods(Count = 9)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
		[CalledBy(Type = typeof(NGUITools), Member = "AdjustDepth")]
		set
		{
		}
	}

	public int sortingOrder
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float width
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
		get
		{
			return default(float);
		}
	}

	public float height
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
		get
		{
			return default(float);
		}
	}

	public bool halfPixelOffset
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public bool usedForUI
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(bool);
		}
	}

	public Vector3 drawCallOffset
	{
		[Calls(Type = typeof(UIRect), Member = "get_root")]
		[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIRect), Member = "get_root")]
		[Calls(Type = typeof(UIRoot), Member = "GetPixelSizeAdjustment")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
		[Calls(Type = typeof(UIRect), Member = "get_root")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 1)]
		get
		{
			return default(Vector3);
		}
	}

	public UIDrawCall.Clipping clipping
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(UIDrawCall.Clipping);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public UIPanel parentPanel
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public int clipCount
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(UIPanel), Member = "get_hasCumulativeClipping")]
		[CalledBy(Type = typeof(UIWidget), Member = "Invalidate")]
		[CalledBy(Type = typeof(UIPanel), Member = "get_clipsChildren")]
		[CalledBy(Type = typeof(UIPanel), Member = "Affects")]
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIDrawCall), Member = "UpdateMaterials")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(UIDrawCall), Member = "CreateMaterial")]
		[CallerCount(Count = 7)]
		get
		{
			return default(int);
		}
	}

	public bool hasClipping
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool hasCumulativeClipping
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Calls(Type = typeof(UIPanel), Member = "get_clipCount")]
		get
		{
			return default(bool);
		}
	}

	public bool clipsChildren
	{
		[Calls(Type = typeof(UIPanel), Member = "get_clipCount")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public Vector2 clipOffset
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector2);
		}
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[Calls(Type = typeof(UIPanel), Member = "InvalidateClipping")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(UIScrollView), Member = "MoveRelative")]
		[CalledBy(Type = typeof(SpringPanel), Member = "AdvanceTowardsPosition")]
		[CalledBy(Type = typeof(UIScrollView), Member = "Press")]
		[CalledBy(Type = typeof(UIScrollView), Member = "SetDragAmount")]
		set
		{
		}
	}

	public Texture2D clipTexture
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Vector4 clipRange
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Vector4);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIPanel), Member = "set_baseClipRegion")]
		set
		{
		}
	}

	public Vector4 baseClipRegion
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector4);
		}
		[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
		[CalledBy(Type = typeof(UIPanel), Member = "set_clipRange")]
		[Calls(Type = typeof(UIScrollView), Member = "UpdatePosition")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(UIPanel), Member = "SetRect")]
		[CalledBy(Type = typeof(UIStretch), Member = "Update")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public Vector4 finalClipRegion
	{
		[CalledBy(Type = typeof(UIScrollView), Member = "get_shouldMove")]
		[CalledBy(Type = typeof(UIScrollView), Member = "UpdateScrollbars")]
		[CalledBy(Type = typeof(UIScrollView), Member = "UpdateScrollbars")]
		[CalledBy(Type = typeof(UIScrollView), Member = "SetDragAmount")]
		[CalledBy(Type = typeof(UIAnchor), Member = "LateUpdate")]
		[CalledBy(Type = typeof(UIPanel), Member = "CalculateConstrainOffset")]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(UIStretch), Member = "Update")]
		[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
		get
		{
			return default(Vector4);
		}
	}

	public Vector2 clipSoftness
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector2);
		}
		[Calls(Type = typeof(Vector2), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public override Vector3[] localCorners
	{
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 19)]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		get
		{
			return null;
		}
	}

	public override Vector3[] worldCorners
	{
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[Calls(Type = typeof(Transform), Member = "get_position")]
		[Calls(Type = typeof(UIRect), Member = "get_cameraRayDistance")]
		[Calls(Type = typeof(NGUITools), Member = "GetWorldCorners")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
		[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 35)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static int CompareFunc(UIPanel a, UIPanel b)
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIPanel), Member = "InvalidateClipping")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(UIPanel), Member = "InvalidateClipping")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIPanel), Member = "set_clipOffset")]
	private void InvalidateClipping()
	{
	}

	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "get_cameraRayDistance")]
	[Calls(Type = typeof(NGUITools), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "GetSides")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsUnknownMethods(Count = 36)]
	[CallerCount(Count = 0)]
	public override Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "Invalidate")]
	public override void Invalidate(bool includeChildren)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_parent")]
	[Calls(Type = typeof(UIRect), Member = "get_parent")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public override float CalculateFinalAlpha(int frameID)
	{
		return default(float);
	}

	[Calls(Type = typeof(AnchorPoint), Member = "SetVertical")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "SetVertical")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "SetHorizontal")]
	[Calls(Type = typeof(AnchorPoint), Member = "SetHorizontal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UIPanel), Member = "set_baseClipRegion")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	public override void SetRect(float x, float y, float width, float height)
	{
	}

	[CallsUnknownMethods(Count = 36)]
	[CalledBy(Type = typeof(UIPanel), Member = "IsVisible")]
	[Calls(Type = typeof(UIPanel), Member = "UpdateTransformMatrix")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public bool IsVisible(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UICamera), Member = "IsVisible")]
	[CalledBy(Type = typeof(UICamera), Member = "IsVisible")]
	[Calls(Type = typeof(UIPanel), Member = "UpdateTransformMatrix")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	public bool IsVisible(Vector3 worldPos)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	[CalledBy(Type = typeof(UIWidget), Member = "Invalidate")]
	[Calls(Type = typeof(UIPanel), Member = "IsVisible")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public bool IsVisible(UIWidget w)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "get_clipCount")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public bool Affects(UIWidget w)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	public void RebuildAllDrawCalls()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(UIPanel), Member = "set_alpha")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void SetDirty()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIPanel), Member = "ParentHasChanged")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnInit")]
	private void FindParent()
	{
	}

	[Calls(Type = typeof(UIPanel), Member = "FindParent")]
	[Calls(Type = typeof(UIRect), Member = "ParentHasChanged")]
	[CallerCount(Count = 0)]
	public override void ParentHasChanged()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override void OnStart()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void OnEnable()
	{
	}

	[Calls(Type = typeof(UIRect), Member = "OnInit")]
	[Calls(Type = typeof(Rigidbody), Member = "set_useGravity")]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIPanel), Member = "FindParent")]
	[CallsUnknownMethods(Count = 15)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[CallsDeduplicatedMethods(Count = 8)]
	protected override void OnInit()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "OnDisable")]
	[Calls(Type = typeof(UIDrawCall), Member = "ReleaseInactive")]
	[Calls(Type = typeof(UIDrawCall), Member = "ClearAll")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UIDrawCall), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	protected override void OnDisable()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CalledBy(Type = typeof(UIPanel), Member = "IsVisible")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateSelf")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIPanel), Member = "IsVisible")]
	[CallerCount(Count = 3)]
	private void UpdateTransformMatrix()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 52)]
	[Calls(Type = typeof(UIPanel), Member = "set_baseClipRegion")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	protected override void OnAnchor()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(UIPanel), Member = "Refresh")]
	[Calls(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
	[Calls(Type = typeof(UIPanel), Member = "UpdateSelf")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(UIPanel), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	[Calls(Type = typeof(UIPanel), Member = "FillAllDrawCalls")]
	[Calls(Type = typeof(UIDrawCall), Member = "Destroy")]
	[Calls(Type = typeof(UIPanel), Member = "FillDrawCall")]
	[Calls(Type = typeof(UIPanel), Member = "UpdateTransformMatrix")]
	[Calls(Type = typeof(UIPanel), Member = "UpdateLayers")]
	private void UpdateSelf()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(UIPanel), Member = "AddWidget")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_depth")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void SortWidgets()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateSelf")]
	[CallAnalysisFailed]
	private void FillAllDrawCalls()
	{
	}

	[Calls(Type = typeof(UIDrawCall), Member = "UpdateGeometry")]
	[Calls(Type = typeof(UIWidget), Member = "get_isVisible")]
	[Calls(Type = typeof(UIGeometry), Member = "WriteToBuffers")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateSelf")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool FillDrawCall(UIDrawCall dc)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UIDrawCall), Member = "set_renderQueue")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(UIPanel), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIPanel), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIPanel), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIPanel), Member = "set_sortingOrder")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIDrawCall), Member = "set_sortingOrder")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIDrawCall), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Vector4), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	private void UpdateDrawCalls()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateSelf")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIRect), Member = "get_parent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateLayers()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIPanel), Member = "FindDrawCall")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIWidget), Member = "UpdateGeometry")]
	[Calls(Type = typeof(UIPanel), Member = "IsVisible")]
	[Calls(Type = typeof(UIWidget), Member = "CalculateCumulativeAlpha")]
	[Calls(Type = typeof(UIWidget), Member = "UpdateTransform")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Time), Member = "get_frameCount")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "get_clipCount")]
	private void UpdateWidgets()
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "AddWidget")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIWidget), Member = "get_isVisible")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 3)]
	public UIDrawCall FindDrawCall(UIWidget w)
	{
		return null;
	}

	[Calls(Type = typeof(UIWidget), Member = "PanelCompareFunc")]
	[Calls(Type = typeof(UIPanel), Member = "SortWidgets")]
	[Calls(Type = typeof(UIPanel), Member = "FindDrawCall")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_depth")]
	[CalledBy(Type = typeof(UIWidget), Member = "CreatePanel")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UIWidget), Member = "PanelCompareFunc")]
	[CallerCount(Count = 2)]
	public void AddWidget(UIWidget w)
	{
	}

	[CalledBy(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void RemoveWidget(UIWidget w)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "LateUpdate")]
	public void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "get_finalClipRegion")]
	[Calls(Type = typeof(NGUIMath), Member = "ConstrainRect")]
	public virtual Vector3 CalculateConstrainOffset(Vector2 min, Vector2 max)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[Calls(Type = typeof(SpringPosition), Member = "Begin")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIDragObject), Member = "OnPress")]
	[CalledBy(Type = typeof(UIDragObject), Member = "OnDrag")]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	public bool ConstrainTargetToBounds(Transform target, ref Bounds targetBounds, bool immediate)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UITable), Member = "Reposition")]
	[CalledBy(Type = typeof(UIGrid), Member = "ConstrainWithinPanel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	public bool ConstrainTargetToBounds(Transform target, bool immediate)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ButtonLegendConfigure), Member = "RefreshReferences")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(UIDragObject), Member = "FindPanel")]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "IsControllerSchemeEnabled")]
	public static UIPanel Find(Transform trans)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static UIPanel Find(Transform trans, bool createIfMissing)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIWidget), Member = "CreatePanel")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIPanel), Member = "Find")]
	[CalledBy(Type = typeof(UIWidget), Member = "ParentHasChanged")]
	[Calls(Type = typeof(NGUITools), Member = "CreateUI")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	public static UIPanel Find(Transform trans, bool createIfMissing, int layer)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIRoot), Member = "GetPixelSizeAdjustment")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	public Vector2 GetWindowSize()
	{
		return default(Vector2);
	}

	[CallerCount(Count = 53)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
	public Vector2 GetViewSize()
	{
		return default(Vector2);
	}

	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(UIRect), Member = ".ctor")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_identity")]
	[CallsDeduplicatedMethods(Count = 3)]
	public UIPanel()
	{
	}
}
