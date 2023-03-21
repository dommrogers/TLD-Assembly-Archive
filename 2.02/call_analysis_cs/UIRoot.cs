using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIRoot : MonoBehaviour
{
	[Serializable]
	public class EmbeddedIcon
	{
		public string spriteName;

		public UIAtlas atlas;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public EmbeddedIcon()
		{
		}
	}

	public enum Scaling
	{
		Flexible,
		Constrained,
		ConstrainedOnMobiles
	}

	public enum Constraint
	{
		Fit,
		Fill,
		FitWidth,
		FitHeight
	}

	public bool DO_UI_RESCALING;

	public float m_AspectRatioForScaling;

	public List<EmbeddedIcon> m_EmbeddedIcons;

	public float m_AspectRatioOverride;

	public const int DEFAULTPANELDEPTH = 10000;

	public static List<UIRoot> list;

	public Scaling scalingStyle;

	public int manualWidth;

	public int manualHeight;

	public int minimumHeight;

	public int maximumHeight;

	public bool fitWidth;

	public bool fitHeight;

	public bool adjustByDPI;

	public bool shrinkPortraitUI;

	private int manualHeightOriginal;

	private Transform mTrans;

	private BetterList<UISprite> mDynamicSymbolSpritePool;

	public Constraint constraint
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Constraint);
		}
	}

	public Scaling activeScaling
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Scaling);
		}
	}

	public int activeHeight
	{
		[CalledBy(Type = typeof(UIAnchor), Member = "LateUpdate")]
		[CalledBy(Type = typeof(UIRoot), Member = "GetPixelSizeAdjustment")]
		[CalledBy(Type = typeof(UIRoot), Member = "UpdateScale")]
		[CalledBy(Type = typeof(UIStretch), Member = "Update")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0;
		}
	}

	public float pixelSizeAdjustment
	{
		[CalledBy(Type = typeof(UIDragDropItem), Member = "OnDrag")]
		[CalledBy(Type = typeof(UIDraggableCamera), Member = "Drag")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CalledBy(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
		[CalledBy(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
		[CalledBy(Type = typeof(UIRoot), Member = "GetPixelSizeAdjustment")]
		[CalledBy(Type = typeof(UIStretch), Member = "Update")]
		[CalledBy(Type = typeof(DragDropItem), Member = "OnDrag")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(UIRoot), Member = "GetPixelSizeAdjustment")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static float GetPixelSizeAdjustment(GameObject go)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
	[CalledBy(Type = typeof(UIPanel), Member = "GetWindowSize")]
	[CalledBy(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIRoot), Member = "get_activeHeight")]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetPixelSizeAdjustment(int height)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIPanel), Member = "set_depth")]
	[Calls(Type = typeof(UIRoot), Member = "CreateDynamicSymbolSprite")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	protected virtual void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRoot), Member = "UpdateScale")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Camera), Member = "set_orthographicSize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	protected virtual void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRoot), Member = "UpdateScale")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(UIRoot), Member = "Start")]
	[CalledBy(Type = typeof(UIRoot), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRoot), Member = "get_activeHeight")]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public void UpdateScale(bool updateAnchors = true)
	{
	}

	[CallerCount(Count = 0)]
	public float GetAspectRatioBonusSize()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Localization), Member = "SelectLanguage")]
	[CalledBy(Type = typeof(UICamera), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void Broadcast(string funcName)
	{
	}

	[CalledBy(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void Broadcast(string funcName, object param)
	{
	}

	[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRoot), Member = "CreateDynamicSymbolSprite")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	public UISprite GetDynamicSymbolSpriteFromPool()
	{
		return null;
	}

	[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
	[CalledBy(Type = typeof(UILabel), Member = "ClearDynamicSymbolSprites")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	public void ReturnDynamicSymbolSpriteToPool(UISprite uiSprite)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRoot), Member = "CreateDynamicSymbolSprite")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void InitDynamicSymbolSpritePool()
	{
	}

	[CalledBy(Type = typeof(UIRoot), Member = "Awake")]
	[CalledBy(Type = typeof(UIRoot), Member = "GetDynamicSymbolSpriteFromPool")]
	[CalledBy(Type = typeof(UIRoot), Member = "InitDynamicSymbolSpritePool")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(BetterList<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	private void CreateDynamicSymbolSprite()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public UIRoot()
	{
	}
}
