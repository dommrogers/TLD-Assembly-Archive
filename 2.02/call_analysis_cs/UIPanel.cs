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
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return 0;
		}
	}

	public override bool canBeAnchored
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
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
		[Calls(Type = typeof(UIPanel), Member = "SetDirty")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public int depth
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CalledBy(Type = typeof(NGUITools), Member = "AdjustDepth")]
		[CalledBy(Type = typeof(NGUITools), Member = "NormalizePanelDepths")]
		[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
		[CalledBy(Type = typeof(UIRoot), Member = "Awake")]
		[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
		[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
		[CallerCount(Count = 8)]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentNullException")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 9)]
		set
		{
		}
	}

	public int sortingOrder
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0;
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
			return 0f;
		}
	}

	public float height
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
		get
		{
			return 0f;
		}
	}

	public bool halfPixelOffset
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public bool usedForUI
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return false;
		}
	}

	public Vector3 drawCallOffset
	{
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIRect), Member = "get_root")]
		[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(UIRoot), Member = "GetPixelSizeAdjustment")]
		[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return default(Vector3);
		}
	}

	public UIDrawCall.Clipping clipping
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[CalledBy(Type = typeof(UIDrawCall), Member = "CreateMaterial")]
		[CalledBy(Type = typeof(UIDrawCall), Member = "UpdateMaterials")]
		[CalledBy(Type = typeof(UIWidget), Member = "Invalidate")]
		[CalledBy(Type = typeof(UIPanel), Member = "get_hasCumulativeClipping")]
		[CalledBy(Type = typeof(UIPanel), Member = "get_clipsChildren")]
		[CalledBy(Type = typeof(UIPanel), Member = "Affects")]
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	public bool hasClipping
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public bool hasCumulativeClipping
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIPanel), Member = "get_clipCount")]
		get
		{
			return false;
		}
	}

	public bool clipsChildren
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIPanel), Member = "get_clipCount")]
		get
		{
			return false;
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
		[CalledBy(Type = typeof(UIScrollView), Member = "SetDragAmount")]
		[CalledBy(Type = typeof(UIScrollView), Member = "MoveRelative")]
		[CalledBy(Type = typeof(UIScrollView), Member = "Press")]
		[CalledBy(Type = typeof(SpringPanel), Member = "AdvanceTowardsPosition")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(UIPanel), Member = "InvalidateClipping")]
		[CallsDeduplicatedMethods(Count = 2)]
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public Vector4 clipRange
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[CalledBy(Type = typeof(UIPanel), Member = "set_clipRange")]
		[CalledBy(Type = typeof(UIPanel), Member = "SetRect")]
		[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
		[CalledBy(Type = typeof(UIStretch), Member = "Update")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIScrollView), Member = "UpdatePosition")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public Vector4 finalClipRegion
	{
		[CalledBy(Type = typeof(UIScrollView), Member = "get_shouldMove")]
		[CalledBy(Type = typeof(UIScrollView), Member = "UpdateScrollbars")]
		[CalledBy(Type = typeof(UIScrollView), Member = "SetDragAmount")]
		[CalledBy(Type = typeof(UIAnchor), Member = "LateUpdate")]
		[CalledBy(Type = typeof(UIPanel), Member = "CalculateConstrainOffset")]
		[CalledBy(Type = typeof(UIStretch), Member = "Update")]
		[CallerCount(Count = 7)]
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Vector2), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public override Vector3[] localCorners
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 19)]
		get
		{
			return null;
		}
	}

	public override Vector3[] worldCorners
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[Calls(Type = typeof(Transform), Member = "get_position")]
		[Calls(Type = typeof(UIRect), Member = "get_cameraRayDistance")]
		[Calls(Type = typeof(NGUITools), Member = "GetWorldCorners")]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 35)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int CompareFunc(UIPanel a, UIPanel b)
	{
		return 0;
	}

	[CalledBy(Type = typeof(UIPanel), Member = "set_clipOffset")]
	[CalledBy(Type = typeof(UIPanel), Member = "InvalidateClipping")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIPanel), Member = "InvalidateClipping")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void InvalidateClipping()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "get_cameraRayDistance")]
	[Calls(Type = typeof(NGUITools), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "GetSides")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 36)]
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
	[Calls(Type = typeof(UIRect), Member = "get_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override float CalculateFinalAlpha(int frameID)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIPanel), Member = "set_baseClipRegion")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnchorPoint), Member = "SetHorizontal")]
	[Calls(Type = typeof(AnchorPoint), Member = "SetVertical")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public override void SetRect(float x, float y, float width, float height)
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "IsVisible")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "UpdateTransformMatrix")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 36)]
	public bool IsVisible(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
	{
		return false;
	}

	[CalledBy(Type = typeof(UICamera), Member = "IsVisible")]
	[CalledBy(Type = typeof(UICamera), Member = "IsVisible")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIPanel), Member = "UpdateTransformMatrix")]
	public bool IsVisible(Vector3 worldPos)
	{
		return false;
	}

	[CalledBy(Type = typeof(UIWidget), Member = "Invalidate")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIPanel), Member = "IsVisible")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public bool IsVisible(UIWidget w)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIPanel), Member = "get_clipCount")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool Affects(UIWidget w)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void RebuildAllDrawCalls()
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "set_alpha")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void SetDirty()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "ParentHasChanged")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnInit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void FindParent()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "ParentHasChanged")]
	[Calls(Type = typeof(UIPanel), Member = "FindParent")]
	public override void ParentHasChanged()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnStart()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(UIRect), Member = "OnInit")]
	[Calls(Type = typeof(UIPanel), Member = "FindParent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic")]
	[Calls(Type = typeof(Rigidbody), Member = "set_useGravity")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentNullException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	protected override void OnInit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIDrawCall), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(UIDrawCall), Member = "ClearAll")]
	[Calls(Type = typeof(UIDrawCall), Member = "ReleaseInactive")]
	[Calls(Type = typeof(UIRect), Member = "OnDisable")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	protected override void OnDisable()
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "IsVisible")]
	[CalledBy(Type = typeof(UIPanel), Member = "IsVisible")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateSelf")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateTransformMatrix()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AnchorPoint), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "GetLocalPos")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIPanel), Member = "set_baseClipRegion")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 52)]
	protected override void OnAnchor()
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "Refresh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "UpdateSelf")]
	[Calls(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "UpdateTransformMatrix")]
	[Calls(Type = typeof(UIPanel), Member = "UpdateLayers")]
	[Calls(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIPanel), Member = "FillDrawCall")]
	[Calls(Type = typeof(UIDrawCall), Member = "Destroy")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(UIPanel), Member = "FillAllDrawCalls")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateSelf()
	{
	}

	[CalledBy(Type = typeof(UIWidget), Member = "set_depth")]
	[CalledBy(Type = typeof(UIPanel), Member = "FillAllDrawCalls")]
	[CalledBy(Type = typeof(UIPanel), Member = "AddWidget")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentNullException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public void SortWidgets()
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "UpdateSelf")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIDrawCall), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UIPanel), Member = "SortWidgets")]
	[Calls(Type = typeof(UIWidget), Member = "get_isVisible")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(UIDrawCall), Member = "UpdateGeometry")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIDrawCall), Member = "Create")]
	[Calls(Type = typeof(UIGeometry), Member = "WriteToBuffers")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 26)]
	private void FillAllDrawCalls()
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "UpdateSelf")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIWidget), Member = "get_isVisible")]
	[Calls(Type = typeof(UIGeometry), Member = "WriteToBuffers")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(UIDrawCall), Member = "UpdateGeometry")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private bool FillDrawCall(UIDrawCall dc)
	{
		return false;
	}

	[CalledBy(Type = typeof(UIPanel), Member = "set_sortingOrder")]
	[CalledBy(Type = typeof(UIPanel), Member = "LateUpdate")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector4), Member = "get_zero")]
	[Calls(Type = typeof(UIPanel), Member = "GetViewSize")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIDrawCall), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIDrawCall), Member = "set_renderQueue")]
	[Calls(Type = typeof(UIDrawCall), Member = "set_sortingOrder")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 25)]
	private void UpdateDrawCalls()
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "UpdateSelf")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "get_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateLayers()
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "UpdateSelf")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "get_clipCount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Time), Member = "get_frameCount")]
	[Calls(Type = typeof(UIWidget), Member = "UpdateTransform")]
	[Calls(Type = typeof(UIWidget), Member = "CalculateCumulativeAlpha")]
	[Calls(Type = typeof(UIPanel), Member = "IsVisible")]
	[Calls(Type = typeof(UIWidget), Member = "UpdateGeometry")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIPanel), Member = "FindDrawCall")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateWidgets()
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "UpdateWidgets")]
	[CalledBy(Type = typeof(UIPanel), Member = "AddWidget")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIWidget), Member = "get_isVisible")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public UIDrawCall FindDrawCall(UIWidget w)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIWidget), Member = "set_depth")]
	[CalledBy(Type = typeof(UIWidget), Member = "CreatePanel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "PanelCompareFunc")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(UIPanel), Member = "SortWidgets")]
	[Calls(Type = typeof(UIPanel), Member = "FindDrawCall")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public void AddWidget(UIWidget w)
	{
	}

	[CalledBy(Type = typeof(UIWidget), Member = "set_depth")]
	[CalledBy(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void RemoveWidget(UIWidget w)
	{
	}

	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Play")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "LateUpdate")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPanel), Member = "get_finalClipRegion")]
	[Calls(Type = typeof(NGUIMath), Member = "ConstrainRect")]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual Vector3 CalculateConstrainOffset(Vector2 min, Vector2 max)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(UIDragObject), Member = "OnPress")]
	[CalledBy(Type = typeof(UIDragObject), Member = "OnDrag")]
	[CalledBy(Type = typeof(UIDragObject), Member = "LateUpdate")]
	[CalledBy(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Bounds), Member = "get_min")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[Calls(Type = typeof(SpringPosition), Member = "Begin")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public bool ConstrainTargetToBounds(Transform target, ref Bounds targetBounds, bool immediate)
	{
		return false;
	}

	[CalledBy(Type = typeof(UIGrid), Member = "ConstrainWithinPanel")]
	[CalledBy(Type = typeof(UITable), Member = "Reposition")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
	public bool ConstrainTargetToBounds(Transform target, bool immediate)
	{
		return false;
	}

	[CalledBy(Type = typeof(UIDragObject), Member = "FindPanel")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(ButtonLegendConfigure), Member = "RefreshReferences")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "IsControllerSchemeEnabled")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UIPanel), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CalledBy(Type = typeof(UIWidget), Member = "ParentHasChanged")]
	[CalledBy(Type = typeof(UIPanel), Member = "Find")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "CreateUI")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static UIPanel Find(Transform trans, bool createIfMissing, int layer)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIRoot), Member = "GetPixelSizeAdjustment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Vector2 GetWindowSize()
	{
		return default(Vector2);
	}

	[CallerCount(Count = 53)]
	[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
	[CallsDeduplicatedMethods(Count = 1)]
	public Vector2 GetViewSize()
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_identity")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(UIRect), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public UIPanel()
	{
	}
}
