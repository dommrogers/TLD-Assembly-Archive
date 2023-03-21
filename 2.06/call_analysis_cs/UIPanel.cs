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
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIPanel), Member = "SetDirty")]
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
		[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "StopAcceleratingTime")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "StartAcceleratingTime")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(UIRoot), Member = "Awake")]
		[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
		[CalledBy(Type = typeof(NGUITools), Member = "NormalizePanelDepths")]
		[CalledBy(Type = typeof(NGUITools), Member = "AdjustDepth")]
		[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 6)]
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
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
		[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
		[CallerCount(Count = 0)]
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
		[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(bool);
		}
	}

	public Vector3 drawCallOffset
	{
		[Calls(Type = typeof(UIPanel), Member = "GetWindowSize")]
		[Calls(Type = typeof(UIRect), Member = "get_root")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIRect), Member = "get_root")]
		[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public int clipCount
	{
		[CalledBy(Type = typeof(UIPanel), Member = "get_hasCumulativeClipping")]
		[CalledBy(Type = typeof(UIWidget), Member = "Invalidate")]
		[CalledBy(Type = typeof(UIDrawCall), Member = "UpdateMaterials")]
		[CalledBy(Type = typeof(UIDrawCall), Member = "CreateMaterial")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
		[CalledBy(Type = typeof(UIPanel), Member = "get_clipsChildren")]
		[CalledBy(Type = typeof(UIPanel), Member = "Affects")]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIPanel), Member = "get_clipCount")]
		get
		{
			return default(bool);
		}
	}

	public bool clipsChildren
	{
		[DeduplicatedMethod]
		[Calls(Type = typeof(UIPanel), Member = "get_clipCount")]
		[CallerCount(Count = 0)]
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
		[CalledBy(Type = typeof(SpringPanel), Member = "AdvanceTowardsPosition")]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UIPanel), Member = "InvalidateClipping")]
		[CalledBy(Type = typeof(UIScrollView), Member = "Press")]
		[CalledBy(Type = typeof(UIScrollView), Member = "SetDragAmount")]
		[CalledBy(Type = typeof(UIScrollView), Member = "MoveRelative")]
		set
		{
		}
	}

	public Texture2D clipTexture
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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
		[Calls(Type = typeof(UIPanel), Member = "set_baseClipRegion")]
		[CallerCount(Count = 0)]
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
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIScrollView), Member = "UpdatePosition")]
		[CalledBy(Type = typeof(UIPanel), Member = "set_clipRange")]
		[CalledBy(Type = typeof(UIPanel), Member = "SetRect")]
		[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
		[CalledBy(Type = typeof(UIStretch), Member = "Update")]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
		set
		{
		}
	}

	public Vector4 finalClipRegion
	{
		[CalledBy(Type = typeof(UIScrollView), Member = "SetDragAmount")]
		[CalledBy(Type = typeof(UIStretch), Member = "Update")]
		[CalledBy(Type = typeof(UIPanel), Member = "CalculateConstrainOffset")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
		[CalledBy(Type = typeof(UIScrollView), Member = "get_shouldMove")]
		[CalledBy(Type = typeof(UIScrollView), Member = "UpdateScrollbars")]
		[CalledBy(Type = typeof(UIScrollView), Member = "UpdateScrollbars")]
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
		[CalledBy(Type = typeof(UIAnchor), Member = "LateUpdate")]
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
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public override Vector3[] localCorners
	{
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public override Vector3[] worldCorners
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[Calls(Type = typeof(Transform), Member = "get_position")]
		[Calls(Type = typeof(UIRect), Member = "get_cameraRayDistance")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[Calls(Type = typeof(NGUITools), Member = "GetWorldCorners")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	public static int CompareFunc(UIPanel a, UIPanel b)
	{
		return default(int);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UIPanel), Member = "InvalidateClipping")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIPanel), Member = "set_clipOffset")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIPanel), Member = "InvalidateClipping")]
	private void InvalidateClipping()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UIRect), Member = "get_cameraRayDistance")]
	[Calls(Type = typeof(NGUITools), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIRect), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public override Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	[Calls(Type = typeof(UIRect), Member = "Invalidate")]
	[CallerCount(Count = 0)]
	public override void Invalidate(bool includeChildren)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIRect), Member = "get_parent")]
	[Calls(Type = typeof(UIRect), Member = "get_parent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override float CalculateFinalAlpha(int frameID)
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "SetHorizontal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "SetHorizontal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "SetVertical")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "SetVertical")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UIPanel), Member = "set_baseClipRegion")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override void SetRect(float x, float y, float width, float height)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIPanel), Member = "IsVisible")]
	[Calls(Type = typeof(Mathf), Member = "Max")]
	[Calls(Type = typeof(Mathf), Member = "Min")]
	[Calls(Type = typeof(Mathf), Member = "Max")]
	[Calls(Type = typeof(Mathf), Member = "Min")]
	[Calls(Type = typeof(UIPanel), Member = "UpdateTransformMatrix")]
	[CallerCount(Count = 1)]
	public bool IsVisible(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UICamera), Member = "IsVisible")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIPanel), Member = "UpdateTransformMatrix")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(UICamera), Member = "IsVisible")]
	public bool IsVisible(Vector3 worldPos)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIPanel), Member = "IsVisible")]
	[CalledBy(Type = typeof(UIWidget), Member = "Invalidate")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsVisible(UIWidget w)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "get_clipCount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public bool Affects(UIWidget w)
	{
		return default(bool);
	}

	[ContextMenu("Force Refresh")]
	[CallerCount(Count = 0)]
	public void RebuildAllDrawCalls()
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "set_alpha")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void SetDirty()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIPanel), Member = "OnInit")]
	[CalledBy(Type = typeof(UIPanel), Member = "ParentHasChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private void FindParent()
	{
	}

	[Calls(Type = typeof(UIPanel), Member = "FindParent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "ParentHasChanged")]
	public override void ParentHasChanged()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnStart()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected override void OnEnable()
	{
	}

	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIPanel), Member = "FindParent")]
	[Calls(Type = typeof(UIRect), Member = "OnInit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Rigidbody), Member = "set_useGravity")]
	[CallerCount(Count = 0)]
	protected override void OnInit()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIDrawCall), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UIDrawCall), Member = "ReleaseAll")]
	[Calls(Type = typeof(UIRect), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	protected override void OnDisable()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateSelf")]
	[CalledBy(Type = typeof(UIPanel), Member = "IsVisible")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CalledBy(Type = typeof(UIPanel), Member = "IsVisible")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	private void UpdateTransformMatrix()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPanel), Member = "set_baseClipRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	protected override void OnAnchor()
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "Refresh")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "UpdateSelf")]
	[Calls(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
	[Calls(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void LateUpdate()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIPanel), Member = "FillDrawCall")]
	[Calls(Type = typeof(UIDrawCall), Member = "Destroy")]
	[Calls(Type = typeof(UIPanel), Member = "FillAllDrawCalls")]
	[CalledBy(Type = typeof(UIPanel), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	[Calls(Type = typeof(UIPanel), Member = "UpdateTransformMatrix")]
	[Calls(Type = typeof(UIPanel), Member = "UpdateLayers")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void UpdateSelf()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(UIPanel), Member = "AddWidget")]
	[CalledBy(Type = typeof(UIPanel), Member = "AddWidget")]
	[CalledBy(Type = typeof(UIPanel), Member = "FillAllDrawCalls")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_depth")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SortWidgets()
	{
	}

	[Calls(Type = typeof(UIDrawCall), Member = "Create")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIDrawCall), Member = "UpdateGeometry")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateSelf")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIGeometry), Member = "WriteToBuffers")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIDrawCall), Member = "UpdateGeometry")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UIPanel), Member = "SortWidgets")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UIDrawCall), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void FillAllDrawCalls()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateSelf")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UIDrawCall), Member = "UpdateGeometry")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UIGeometry), Member = "WriteToBuffers")]
	[Calls(Type = typeof(UIWidget), Member = "get_isVisible")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private bool FillDrawCall(UIDrawCall dc)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(UIPanel), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIPanel), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIPanel), Member = "set_sortingOrder")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UIDrawCall), Member = "set_sortingOrder")]
	[Calls(Type = typeof(UIDrawCall), Member = "set_renderQueue")]
	[Calls(Type = typeof(UIDrawCall), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIPanel), Member = "get_finalClipRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void UpdateDrawCalls()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateSelf")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIRect), Member = "get_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	private void UpdateLayers()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIWidget), Member = "UpdateTransform")]
	[Calls(Type = typeof(UIPanel), Member = "IsVisible")]
	[Calls(Type = typeof(UIWidget), Member = "UpdateGeometry")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIPanel), Member = "FindDrawCall")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateSelf")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "get_clipCount")]
	[Calls(Type = typeof(UIWidget), Member = "CalculateCumulativeAlpha")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void UpdateWidgets()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIPanel), Member = "AddWidget")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	[Calls(Type = typeof(UIWidget), Member = "get_isVisible")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 2)]
	public UIDrawCall FindDrawCall(UIWidget w)
	{
		return null;
	}

	[Calls(Type = typeof(UIWidget), Member = "PanelCompareFunc")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(UIWidget), Member = "CreatePanel")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UIPanel), Member = "FindDrawCall")]
	[Calls(Type = typeof(UIPanel), Member = "SortWidgets")]
	[Calls(Type = typeof(UIPanel), Member = "SortWidgets")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "PanelCompareFunc")]
	public void AddWidget(UIWidget w)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[CalledBy(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void RemoveWidget(UIWidget w)
	{
	}

	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UIPanel), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	public void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPanel), Member = "get_finalClipRegion")]
	[Calls(Type = typeof(NGUIMath), Member = "ConstrainRect")]
	public virtual Vector3 CalculateConstrainOffset(Vector2 min, Vector2 max)
	{
		return default(Vector3);
	}

	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIDragObject), Member = "OnDrag")]
	[CalledBy(Type = typeof(UIDragObject), Member = "OnPress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SpringPosition), Member = "Begin")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	public bool ConstrainTargetToBounds(Transform target, ref Bounds targetBounds, bool immediate)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[CalledBy(Type = typeof(UIGrid), Member = "Reposition")]
	[CalledBy(Type = typeof(UIGrid), Member = "ConstrainWithinPanel")]
	[CalledBy(Type = typeof(UITable), Member = "Reposition")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	public bool ConstrainTargetToBounds(Transform target, bool immediate)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	public static UIPanel Find(Transform trans)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static UIPanel Find(Transform trans, bool createIfMissing)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIDragObject), Member = "FindPanel")]
	[CalledBy(Type = typeof(UIWidget), Member = "CreatePanel")]
	[CalledBy(Type = typeof(ButtonLegendConfigure), Member = "RefreshReferences")]
	[Calls(Type = typeof(NGUITools), Member = "CreateUI")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(UIWidget), Member = "ParentHasChanged")]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "IsControllerSchemeEnabled")]
	[CalledBy(Type = typeof(UIPanel), Member = "Find")]
	public static UIPanel Find(Transform trans, bool createIfMissing, int layer)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIRoot), Member = "get_activeHeight")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
	public Vector2 GetWindowSize()
	{
		return default(Vector2);
	}

	[CallerCount(Count = 45)]
	[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
	public Vector2 GetViewSize()
	{
		return default(Vector2);
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UIRect), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public UIPanel()
	{
	}
}
