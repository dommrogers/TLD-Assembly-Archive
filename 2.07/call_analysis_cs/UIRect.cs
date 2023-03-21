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

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
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

		[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[CalledBy(Type = typeof(UIWidget), Member = "SetRect")]
		[CalledBy(Type = typeof(UIPanel), Member = "SetRect")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		public void SetHorizontal(Transform parent, float localPos)
		{
		}

		[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[CalledBy(Type = typeof(UIWidget), Member = "SetRect")]
		[CalledBy(Type = typeof(UIPanel), Member = "SetRect")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		public void SetVertical(Transform parent, float localPos)
		{
		}

		[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
		[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[Calls(Type = typeof(NGUITools), Member = "GetSides")]
		[CallsDeduplicatedMethods(Count = 2)]
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
		[CalledBy(Type = typeof(UICenterOnChild), Member = "CenterOn")]
		[CalledBy(Type = typeof(UICenterOnClick), Member = "OnClick")]
		[CalledBy(Type = typeof(NGUITools), Member = "CalculateNextDepth")]
		[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
		[CalledBy(Type = typeof(UIDrawCall), Member = "Create")]
		[CalledBy(Type = typeof(UIRect), Member = "ResetAnchors")]
		[CalledBy(Type = typeof(UIWidget), Member = "CreatePanel")]
		[CalledBy(Type = typeof(UIWidget), Member = "ParentHasChanged")]
		[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateLayers")]
		[CallerCount(Count = 11)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public virtual bool isAnchoredHorizontally
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public virtual bool isAnchoredVertically
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public virtual bool canBeAnchored
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public UIRect parent
	{
		[CalledBy(Type = typeof(UIRect), Member = "get_root")]
		[CalledBy(Type = typeof(UIRect), Member = "OnInit")]
		[CalledBy(Type = typeof(UIWidget), Member = "UpdateFinalAlpha")]
		[CalledBy(Type = typeof(UIWidget), Member = "CalculateCumulativeAlpha")]
		[CalledBy(Type = typeof(UIPanel), Member = "CalculateFinalAlpha")]
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateLayers")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public UIRoot root
	{
		[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CalledBy(Type = typeof(UILabel), Member = "ClearDynamicSymbolSprites")]
		[CalledBy(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
		[CalledBy(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
		[CalledBy(Type = typeof(UIPanel), Member = "GetWindowSize")]
		[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "UpdateMenuNavigation")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(UIRect), Member = "get_parent")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public bool isAnchored
	{
		[CalledBy(Type = typeof(NGUIMath), Member = "MoveRect")]
		[CalledBy(Type = typeof(NGUIMath), Member = "AdjustWidget")]
		[CalledBy(Type = typeof(UIRect), Member = "UpdateAnchors")]
		[CalledBy(Type = typeof(UIRect), Member = "SetAnchor")]
		[CalledBy(Type = typeof(UIRect), Member = "SetAnchor")]
		[CalledBy(Type = typeof(UIRect), Member = "SetAnchor")]
		[CalledBy(Type = typeof(UIRect), Member = "ResetAndUpdateAnchors")]
		[CalledBy(Type = typeof(UIWidget), Member = "SetRect")]
		[CalledBy(Type = typeof(TweenPosition), Member = "set_value")]
		[CalledBy(Type = typeof(UIPanel), Member = "SetRect")]
		[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
		[CalledBy(Type = typeof(LogListItem), Member = "SetText")]
		[CalledBy(Type = typeof(LogListItem), Member = "SetHasNotes")]
		[CalledBy(Type = typeof(Panel_BreakDown), Member = "UpdateCurrentCaloriesLabel")]
		[CalledBy(Type = typeof(Panel_HUD), Member = "SetHoverText")]
		[CalledBy(Type = typeof(Panel_Log), Member = "UpdateExamineCollectible")]
		[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatActionButton")]
		[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowCurrentTutorialPopup")]
		[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
		[CallerCount(Count = 25)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public abstract float alpha { get; set; }

	public abstract Vector3[] localCorners { get; }

	public abstract Vector3[] worldCorners { get; }

	protected float cameraRayDistance
	{
		[CalledBy(Type = typeof(UIRect), Member = "GetSides")]
		[CalledBy(Type = typeof(UIPanel), Member = "get_worldCorners")]
		[CalledBy(Type = typeof(UIPanel), Member = "GetSides")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
		[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[Calls(Type = typeof(Plane), Member = ".ctor")]
		[Calls(Type = typeof(Plane), Member = "Raycast")]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 10)]
		get
		{
			return 0f;
		}
	}

	public abstract float CalculateFinalAlpha(int frameID);

	[CalledBy(Type = typeof(UIPanel), Member = "Invalidate")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Invalidate(bool includeChildren)
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "GetSides")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UIRect), Member = "get_cameraRayDistance")]
	[Calls(Type = typeof(NGUITools), Member = "GetSides")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public virtual Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIWidget), Member = "OnAnchor")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnAnchor")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	protected Vector3 GetLocalPos(AnchorPoint ac, Transform trans)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnEnable()
	{
	}

	[CalledBy(Type = typeof(UIWidget), Member = "OnInit")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnInit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_parent")]
	[Calls(Type = typeof(BetterList<>), Member = "Add")]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnInit()
	{
	}

	[CalledBy(Type = typeof(UIWidget), Member = "OnDisable")]
	[CalledBy(Type = typeof(UILabel), Member = "OnDisable")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnDisable")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BetterList<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected void Start()
	{
	}

	[CalledBy(Type = typeof(UIRect), Member = "Update")]
	[CalledBy(Type = typeof(UIWidget), Member = "OnInit")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "SetHoverText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UpdateAnchors()
	{
	}

	protected abstract void OnAnchor();

	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetAnchor(Transform t)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SetAnchor(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SetAnchor(GameObject go, int left, int bottom, int right, int top)
	{
	}

	[CalledBy(Type = typeof(UIRect), Member = "get_anchorCamera")]
	[CalledBy(Type = typeof(UIRect), Member = "get_cameraRayDistance")]
	[CalledBy(Type = typeof(UIRect), Member = "GetSides")]
	[CalledBy(Type = typeof(UIRect), Member = "GetLocalPos")]
	[CalledBy(Type = typeof(UIRect), Member = "Update")]
	[CalledBy(Type = typeof(UIRect), Member = "SetAnchor")]
	[CalledBy(Type = typeof(UIRect), Member = "SetAnchor")]
	[CalledBy(Type = typeof(UIRect), Member = "SetAnchor")]
	[CalledBy(Type = typeof(UIRect), Member = "ResetAndUpdateAnchors")]
	[CalledBy(Type = typeof(UIPanel), Member = "get_usedForUI")]
	[CalledBy(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
	[CalledBy(Type = typeof(UIPanel), Member = "get_worldCorners")]
	[CalledBy(Type = typeof(UIPanel), Member = "GetSides")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnInit")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateLayers")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(UIRect), Member = "FindCameraFor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ResetAnchors()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRect), Member = "ResetAnchors")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ResetAndUpdateAnchors()
	{
	}

	public abstract void SetRect(float x, float y, float width, float height);

	[CalledBy(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void FindCameraFor(AnchorPoint ap)
	{
	}

	[CalledBy(Type = typeof(UIWidget), Member = "ParentHasChanged")]
	[CalledBy(Type = typeof(UIPanel), Member = "ParentHasChanged")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BetterList<>), Member = "Remove")]
	[Calls(Type = typeof(BetterList<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void ParentHasChanged()
	{
	}

	protected abstract void OnStart();

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected virtual void OnUpdate()
	{
	}

	[CalledBy(Type = typeof(UIWidget), Member = ".ctor")]
	[CalledBy(Type = typeof(UIPanel), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected UIRect()
	{
	}
}
