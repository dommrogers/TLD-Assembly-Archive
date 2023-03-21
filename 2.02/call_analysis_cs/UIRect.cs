using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class UIRect : MonoBehaviour
{
	[Serializable]
	public class AnchorPoint
	{
		public Transform target;

		public float relative;

		public int absolute;

		[NonSerialized]
		public UIRect rect;

		[NonSerialized]
		public Camera targetCam;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public AnchorPoint()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public AnchorPoint(float relative)
		{
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
		[CalledBy(Type = typeof(AnchorPoint), Member = "SetToNearest")]
		[CalledBy(Type = typeof(AnchorPoint), Member = "SetToNearest")]
		public void Set(float relative, float absolute)
		{
		}

		[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public void Set(Transform target, float relative, float absolute)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AnchorPoint), Member = "Set")]
		public void SetToNearest(float abs0, float abs1, float abs2)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AnchorPoint), Member = "Set")]
		public void SetToNearest(float rel0, float rel1, float rel2, float abs0, float abs1, float abs2)
		{
		}

		[CalledBy(Type = typeof(UIWidget), Member = "SetRect")]
		[CalledBy(Type = typeof(UIPanel), Member = "SetRect")]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[CallsUnknownMethods(Count = 10)]
		[CalledBy(Type = typeof(UIWidget), Member = "SetRect")]
		[CalledBy(Type = typeof(UIPanel), Member = "SetRect")]
		[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		public void SetHorizontal(Transform parent, float localPos)
		{
		}

		[CalledBy(Type = typeof(UIPanel), Member = "SetRect")]
		[CalledBy(Type = typeof(UIWidget), Member = "SetRect")]
		[CalledBy(Type = typeof(UIWidget), Member = "SetRect")]
		[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(UIPanel), Member = "SetRect")]
		[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
		[CallsUnknownMethods(Count = 8)]
		public void SetVertical(Transform parent, float localPos)
		{
		}

		[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
		[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
		[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
		[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
		[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
		[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
		[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
		[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 7)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[Calls(Type = typeof(NGUITools), Member = "GetSides")]
		public Vector3[] GetSides(Transform relativeTo)
		{
			return null;
		}
	}

	public enum AnchorUpdate
	{
		OnEnable,
		OnUpdate,
		OnStart
	}

	public AnchorPoint leftAnchor;

	public AnchorPoint rightAnchor;

	public AnchorPoint bottomAnchor;

	public AnchorPoint topAnchor;

	public AnchorUpdate updateAnchors;

	protected GameObject mGo;

	protected Transform mTrans;

	protected BetterList<UIRect> mChildren;

	protected bool mChanged;

	protected bool mStarted;

	protected bool mParentFound;

	[NonSerialized]
	private bool mUpdateAnchors;

	[NonSerialized]
	private int mUpdateFrame;

	[NonSerialized]
	private bool mAnchorsCached;

	[NonSerialized]
	private UIRoot mRoot;

	[NonSerialized]
	private UIRect mParent;

	[NonSerialized]
	private bool mRootSet;

	[NonSerialized]
	protected Camera mCam;

	[NonSerialized]
	public float finalAlpha;

	protected static Vector3[] mSides;

	public GameObject cachedGameObject
	{
		[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
		[CalledBy(Type = typeof(UIWidget), Member = "ParentHasChanged")]
		[CalledBy(Type = typeof(UIDrawCall), Member = "Create")]
		[CalledBy(Type = typeof(UIRect), Member = "ResetAnchors")]
		[CalledBy(Type = typeof(UIWidget), Member = "CreatePanel")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateLayers")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UICenterOnClick), Member = "OnClick")]
		[CalledBy(Type = typeof(UICenterOnChild), Member = "CenterOn")]
		[CalledBy(Type = typeof(NGUITools), Member = "CalculateNextDepth")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		get
		{
			return null;
		}
	}

	public Transform cachedTransform
	{
		[CallerCount(Count = 84)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public Camera anchorCamera
	{
		[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public bool isFullyAnchored
	{
		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(UILabel), Member = "OnAnchor")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		get
		{
			return default(bool);
		}
	}

	public virtual bool isAnchoredHorizontally
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public virtual bool isAnchoredVertically
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		get
		{
			return default(bool);
		}
	}

	public virtual bool canBeAnchored
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public UIRect parent
	{
		[CallerCount(Count = 7)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[CalledBy(Type = typeof(UIRect), Member = "get_root")]
		[CalledBy(Type = typeof(UIRect), Member = "OnInit")]
		[CalledBy(Type = typeof(UIWidget), Member = "CalculateCumulativeAlpha")]
		[CalledBy(Type = typeof(UIWidget), Member = "UpdateFinalAlpha")]
		[CalledBy(Type = typeof(UIPanel), Member = "CalculateFinalAlpha")]
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateLayers")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(UIPanel), Member = "CalculateFinalAlpha")]
		get
		{
			return null;
		}
	}

	public UIRoot root
	{
		[CalledBy(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
		[CalledBy(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "ClearDynamicSymbolSprites")]
		[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
		[CalledBy(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
		[CalledBy(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
		[CalledBy(Type = typeof(UIPanel), Member = "GetWindowSize")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UIRect), Member = "get_parent")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 16)]
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
		get
		{
			return null;
		}
	}

	public bool isAnchored
	{
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 24)]
		get
		{
			return default(bool);
		}
	}

	public abstract float alpha
	{
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		set;
	}

	public abstract Vector3[] localCorners
	{
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		get;
	}

	public abstract Vector3[] worldCorners
	{
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		get;
	}

	protected float cameraRayDistance
	{
		[Calls(Type = typeof(Vector3), Member = "get_back")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[Calls(Type = typeof(Plane), Member = ".ctor")]
		[Calls(Type = typeof(Vector3), Member = "get_forward")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[Calls(Type = typeof(Vector3), Member = "Normalize")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
		[CalledBy(Type = typeof(UIPanel), Member = "get_worldCorners")]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(UIRect), Member = "GetSides")]
		[Calls(Type = typeof(Plane), Member = "Raycast")]
		[CallsUnknownMethods(Count = 14)]
		[CalledBy(Type = typeof(UIPanel), Member = "GetSides")]
		[CallsDeduplicatedMethods(Count = 10)]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		get
		{
			return default(float);
		}
	}

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	public abstract float CalculateFinalAlpha(int frameID);

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIPanel), Member = "Invalidate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIWidget), Member = "Invalidate")]
	public virtual void Invalidate(bool includeChildren)
	{
	}

	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(UIPanel), Member = "GetSides")]
	[Calls(Type = typeof(NGUITools), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "get_cameraRayDistance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public virtual Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	protected Vector3 GetLocalPos(AnchorPoint ac, Transform trans)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIPanel), Member = "OnInit")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnInit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "get_parent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	protected virtual void OnInit()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIPanel), Member = "OnDisable")]
	[CalledBy(Type = typeof(UILabel), Member = "OnDisable")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnDisable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	protected virtual void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected void Start()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "Update")]
	[Calls(Type = typeof(UIRect), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UIRect), Member = "Update")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(UIRect), Member = "Update")]
	[CalledBy(Type = typeof(UIRect), Member = "Update")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(UIWidget), Member = "OnInit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(UIRect), Member = "Update")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "SetHoverText")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void UpdateAnchors()
	{
	}

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	protected abstract void OnAnchor();

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	public void SetAnchor(Transform t)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void SetAnchor(GameObject go)
	{
	}

	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 14)]
	public void SetAnchor(GameObject go, int left, int bottom, int right, int top)
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "get_usedForUI")]
	[CalledBy(Type = typeof(UIRect), Member = "get_anchorCamera")]
	[CalledBy(Type = typeof(UIRect), Member = "get_cameraRayDistance")]
	[CalledBy(Type = typeof(UIRect), Member = "GetSides")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(UIRect), Member = "GetLocalPos")]
	[CalledBy(Type = typeof(UIRect), Member = "Update")]
	[CalledBy(Type = typeof(UIRect), Member = "SetAnchor")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(UIRect), Member = "SetAnchor")]
	[CalledBy(Type = typeof(UIRect), Member = "ResetAndUpdateAnchors")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateLayers")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnInit")]
	[CalledBy(Type = typeof(UIPanel), Member = "GetSides")]
	[CalledBy(Type = typeof(UIPanel), Member = "get_worldCorners")]
	[CalledBy(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
	[CalledBy(Type = typeof(UIRect), Member = "SetAnchor")]
	[Calls(Type = typeof(UIRect), Member = "FindCameraFor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "FindCameraFor")]
	[Calls(Type = typeof(UIRect), Member = "FindCameraFor")]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(UIRect), Member = "FindCameraFor")]
	public void ResetAnchors()
	{
	}

	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	public void ResetAndUpdateAnchors()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract void SetRect(float x, float y, float width, float height);

	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[CalledBy(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CalledBy(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CalledBy(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CalledBy(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void FindCameraFor(AnchorPoint ap)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(UIWidget), Member = "ParentHasChanged")]
	[CalledBy(Type = typeof(UIPanel), Member = "ParentHasChanged")]
	[CallerCount(Count = 2)]
	public virtual void ParentHasChanged()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract void OnStart();

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 36)]
	[CalledBy(Type = typeof(UIPanel), Member = ".ctor")]
	[CalledBy(Type = typeof(UIWidget), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected UIRect()
	{
	}
}
