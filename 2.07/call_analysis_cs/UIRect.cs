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
		[CallerCount(Count = 6)]
		public AnchorPoint()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public AnchorPoint(float relative)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		public void Set(float relative, float absolute)
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public void Set(Transform target, float relative, float absolute)
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		public void SetToNearest(float abs0, float abs1, float abs2)
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public void SetToNearest(float rel0, float rel1, float rel2, float abs0, float abs1, float abs2)
		{
		}

		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(UIPanel), Member = "SetRect")]
		[CalledBy(Type = typeof(UIPanel), Member = "SetRect")]
		[CalledBy(Type = typeof(UIWidget), Member = "SetRect")]
		[CalledBy(Type = typeof(UIWidget), Member = "SetRect")]
		[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 6)]
		public void SetHorizontal(Transform parent, float localPos)
		{
		}

		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(UIPanel), Member = "SetRect")]
		[CalledBy(Type = typeof(UIPanel), Member = "SetRect")]
		[CalledBy(Type = typeof(UIWidget), Member = "SetRect")]
		[CalledBy(Type = typeof(UIWidget), Member = "SetRect")]
		[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 6)]
		public void SetVertical(Transform parent, float localPos)
		{
		}

		[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
		[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
		[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
		[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
		[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
		[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
		[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
		[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
		[Calls(Type = typeof(NGUITools), Member = "GetSides")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 10)]
		[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
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
		[CalledBy(Type = typeof(NGUITools), Member = "CalculateNextDepth")]
		[CalledBy(Type = typeof(UIWidget), Member = "ParentHasChanged")]
		[CalledBy(Type = typeof(UIWidget), Member = "CreatePanel")]
		[CalledBy(Type = typeof(UIRect), Member = "ResetAnchors")]
		[CalledBy(Type = typeof(UIDrawCall), Member = "Create")]
		[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
		[CalledBy(Type = typeof(UICenterOnClick), Member = "OnClick")]
		[CalledBy(Type = typeof(UICenterOnChild), Member = "CenterOn")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 11)]
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateLayers")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		get
		{
			return null;
		}
	}

	public Transform cachedTransform
	{
		[CallerCount(Count = 81)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public Camera anchorCamera
	{
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
		get
		{
			return null;
		}
	}

	public bool isFullyAnchored
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public virtual bool isAnchoredHorizontally
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public virtual bool isAnchoredVertically
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public virtual bool canBeAnchored
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public UIRect parent
	{
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateLayers")]
		[CalledBy(Type = typeof(UIPanel), Member = "CalculateFinalAlpha")]
		[CalledBy(Type = typeof(UIPanel), Member = "CalculateFinalAlpha")]
		[CalledBy(Type = typeof(UIWidget), Member = "CalculateCumulativeAlpha")]
		[CalledBy(Type = typeof(UIWidget), Member = "UpdateFinalAlpha")]
		[CalledBy(Type = typeof(UIRect), Member = "get_root")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(UIRect), Member = "OnInit")]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
	}

	public UIRoot root
	{
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CalledBy(Type = typeof(UILabel), Member = "ClearDynamicSymbolSprites")]
		[CalledBy(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
		[Calls(Type = typeof(UIRect), Member = "get_parent")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
		[CallerCount(Count = 14)]
		[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
		[CalledBy(Type = typeof(UIPanel), Member = "GetWindowSize")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
		[CalledBy(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
		get
		{
			return null;
		}
	}

	public bool isAnchored
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallerCount(Count = 25)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		get
		{
			return default(bool);
		}
	}

	public abstract float alpha
	{
		[CallerCount(Count = 101261)]
		[DeduplicatedMethod]
		get;
		[CallerCount(Count = 101261)]
		[DeduplicatedMethod]
		set;
	}

	public abstract Vector3[] localCorners
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	public abstract Vector3[] worldCorners
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
	}

	protected float cameraRayDistance
	{
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 8)]
		[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[CalledBy(Type = typeof(UIRect), Member = "GetSides")]
		[CallsUnknownMethods(Count = 10)]
		[CalledBy(Type = typeof(UIPanel), Member = "GetSides")]
		[Calls(Type = typeof(Plane), Member = ".ctor")]
		[CalledBy(Type = typeof(UIPanel), Member = "get_worldCorners")]
		[Calls(Type = typeof(Plane), Member = "Raycast")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		get
		{
			return default(float);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	public abstract float CalculateFinalAlpha(int frameID);

	[CalledBy(Type = typeof(UIPanel), Member = "Invalidate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Invalidate(bool includeChildren)
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(NGUITools), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "get_cameraRayDistance")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
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
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
	protected Vector3 GetLocalPos(AnchorPoint ac, Transform trans)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnEnable()
	{
	}

	[Calls(Type = typeof(UIRect), Member = "get_parent")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnInit")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnInit")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	protected virtual void OnInit()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnDisable")]
	[CalledBy(Type = typeof(UILabel), Member = "OnDisable")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnDisable")]
	protected virtual void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected void Start()
	{
	}

	[Calls(Type = typeof(UIRect), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(UIRect), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIWidget), Member = "OnInit")]
	[CalledBy(Type = typeof(UIRect), Member = "Update")]
	[CalledBy(Type = typeof(UIRect), Member = "Update")]
	[CalledBy(Type = typeof(UIRect), Member = "Update")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UIRect), Member = "Update")]
	public void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "SetHoverText")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	public void UpdateAnchors()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	protected abstract void OnAnchor();

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallerCount(Count = 2)]
	public void SetAnchor(Transform t)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SetAnchor(GameObject go)
	{
	}

	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void SetAnchor(GameObject go, int left, int bottom, int right, int top)
	{
	}

	[CalledBy(Type = typeof(UIRect), Member = "SetAnchor")]
	[CalledBy(Type = typeof(UIRect), Member = "SetAnchor")]
	[CalledBy(Type = typeof(UIRect), Member = "Update")]
	[CalledBy(Type = typeof(UIRect), Member = "GetLocalPos")]
	[CalledBy(Type = typeof(UIPanel), Member = "get_usedForUI")]
	[CalledBy(Type = typeof(UIRect), Member = "GetSides")]
	[CalledBy(Type = typeof(UIRect), Member = "get_anchorCamera")]
	[CalledBy(Type = typeof(UIRect), Member = "ResetAndUpdateAnchors")]
	[CalledBy(Type = typeof(UIRect), Member = "SetAnchor")]
	[CalledBy(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
	[CalledBy(Type = typeof(UIPanel), Member = "get_worldCorners")]
	[CalledBy(Type = typeof(UIPanel), Member = "GetSides")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnInit")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateLayers")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "FindCameraFor")]
	[Calls(Type = typeof(UIRect), Member = "FindCameraFor")]
	[CalledBy(Type = typeof(UIRect), Member = "get_cameraRayDistance")]
	[Calls(Type = typeof(UIRect), Member = "FindCameraFor")]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(UIRect), Member = "FindCameraFor")]
	public void ResetAnchors()
	{
	}

	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ResetAndUpdateAnchors()
	{
	}

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	public abstract void SetRect(float x, float y, float width, float height);

	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CalledBy(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[CalledBy(Type = typeof(UIRect), Member = "ResetAnchors")]
	private void FindCameraFor(AnchorPoint ap)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIPanel), Member = "ParentHasChanged")]
	[CalledBy(Type = typeof(UIWidget), Member = "ParentHasChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallerCount(Count = 2)]
	public virtual void ParentHasChanged()
	{
	}

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	protected abstract void OnStart();

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIPanel), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIWidget), Member = ".ctor")]
	protected UIRect()
	{
	}
}
