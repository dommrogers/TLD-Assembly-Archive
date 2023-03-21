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

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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

		[CallsUnknownMethods(Count = 5)]
		[CalledBy(Type = typeof(UIPanel), Member = "SetRect")]
		[CalledBy(Type = typeof(UIPanel), Member = "SetRect")]
		[CalledBy(Type = typeof(UIWidget), Member = "SetRect")]
		[CalledBy(Type = typeof(UIWidget), Member = "SetRect")]
		[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		public void SetHorizontal(Transform parent, float localPos)
		{
		}

		[CalledBy(Type = typeof(UIWidget), Member = "SetRect")]
		[CallsUnknownMethods(Count = 5)]
		[CalledBy(Type = typeof(UIPanel), Member = "SetRect")]
		[CalledBy(Type = typeof(UIPanel), Member = "SetRect")]
		[CalledBy(Type = typeof(UIWidget), Member = "SetRect")]
		[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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
		[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
		[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
		[Calls(Type = typeof(NGUITools), Member = "GetSides")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 10)]
		[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
		[CallsUnknownMethods(Count = 3)]
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
		[CalledBy(Type = typeof(UIRect), Member = "ResetAnchors")]
		[CalledBy(Type = typeof(UIWidget), Member = "CreatePanel")]
		[CalledBy(Type = typeof(UIWidget), Member = "ParentHasChanged")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateLayers")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIDrawCall), Member = "Create")]
		[CalledBy(Type = typeof(NGUITools), Member = "CalculateNextDepth")]
		[CalledBy(Type = typeof(UICenterOnClick), Member = "OnClick")]
		[CalledBy(Type = typeof(UICenterOnChild), Member = "CenterOn")]
		[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return null;
		}
	}

	public Transform cachedTransform
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 83)]
		get
		{
			return null;
		}
	}

	public Camera anchorCamera
	{
		[CallerCount(Count = 0)]
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
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public virtual bool isAnchoredVertically
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallerCount(Count = 0)]
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
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(UIWidget), Member = "UpdateFinalAlpha")]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(UIWidget), Member = "CalculateCumulativeAlpha")]
		[CalledBy(Type = typeof(UIPanel), Member = "CalculateFinalAlpha")]
		[CalledBy(Type = typeof(UIPanel), Member = "CalculateFinalAlpha")]
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateLayers")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(UIRect), Member = "get_root")]
		[CalledBy(Type = typeof(UIRect), Member = "OnInit")]
		get
		{
			return null;
		}
	}

	public UIRoot root
	{
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
		[CalledBy(Type = typeof(UIPanel), Member = "GetWindowSize")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CalledBy(Type = typeof(UILabel), Member = "ClearDynamicSymbolSprites")]
		[CalledBy(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
		[CalledBy(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
		[CalledBy(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
		[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UIRect), Member = "get_parent")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 14)]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
		get
		{
			return null;
		}
	}

	public bool isAnchored
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallerCount(Count = 25)]
		get
		{
			return default(bool);
		}
	}

	public abstract float alpha
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		set;
	}

	public abstract Vector3[] localCorners
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
	}

	public abstract Vector3[] worldCorners
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
	}

	protected float cameraRayDistance
	{
		[CalledBy(Type = typeof(UIPanel), Member = "get_worldCorners")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[Calls(Type = typeof(Plane), Member = ".ctor")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CalledBy(Type = typeof(UIRect), Member = "GetSides")]
		[CalledBy(Type = typeof(UIPanel), Member = "GetSides")]
		[CallsUnknownMethods(Count = 11)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 8)]
		get
		{
			return default(float);
		}
	}

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	public abstract float CalculateFinalAlpha(int frameID);

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UIWidget), Member = "Invalidate")]
	[CalledBy(Type = typeof(UIPanel), Member = "Invalidate")]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Invalidate(bool includeChildren)
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "GetSides")]
	[Calls(Type = typeof(NGUITools), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "get_cameraRayDistance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public virtual Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
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

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIWidget), Member = "OnInit")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnInit")]
	protected virtual void OnInit()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIPanel), Member = "OnDisable")]
	[CalledBy(Type = typeof(UILabel), Member = "OnDisable")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnDisable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	protected virtual void OnDisable()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected void Start()
	{
	}

	[CalledBy(Type = typeof(UIRect), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(UIRect), Member = "Update")]
	[CalledBy(Type = typeof(UIRect), Member = "Update")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnInit")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "Update")]
	[CalledBy(Type = typeof(UIRect), Member = "Update")]
	public void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "SetHoverText")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	public void UpdateAnchors()
	{
	}

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	protected abstract void OnAnchor();

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	public void SetAnchor(Transform t)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SetAnchor(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	public void SetAnchor(GameObject go, int left, int bottom, int right, int top)
	{
	}

	[CalledBy(Type = typeof(UIRect), Member = "get_anchorCamera")]
	[CalledBy(Type = typeof(UIRect), Member = "ResetAndUpdateAnchors")]
	[CalledBy(Type = typeof(UIRect), Member = "get_cameraRayDistance")]
	[CalledBy(Type = typeof(UIRect), Member = "GetSides")]
	[CalledBy(Type = typeof(UIRect), Member = "GetLocalPos")]
	[CalledBy(Type = typeof(UIRect), Member = "Update")]
	[CalledBy(Type = typeof(UIRect), Member = "SetAnchor")]
	[CalledBy(Type = typeof(UIRect), Member = "SetAnchor")]
	[CalledBy(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateLayers")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnInit")]
	[CalledBy(Type = typeof(UIPanel), Member = "GetSides")]
	[CalledBy(Type = typeof(UIPanel), Member = "get_worldCorners")]
	[CalledBy(Type = typeof(UIPanel), Member = "get_usedForUI")]
	[Calls(Type = typeof(UIRect), Member = "FindCameraFor")]
	[CalledBy(Type = typeof(UIRect), Member = "SetAnchor")]
	[Calls(Type = typeof(UIRect), Member = "FindCameraFor")]
	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "FindCameraFor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(UIRect), Member = "FindCameraFor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	public abstract void SetRect(float x, float y, float width, float height);

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CalledBy(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CalledBy(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[CallerCount(Count = 4)]
	private void FindCameraFor(AnchorPoint ap)
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "ParentHasChanged")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIWidget), Member = "ParentHasChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	public virtual void ParentHasChanged()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract void OnStart();

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIPanel), Member = ".ctor")]
	[CalledBy(Type = typeof(UIWidget), Member = ".ctor")]
	protected UIRect()
	{
	}
}
