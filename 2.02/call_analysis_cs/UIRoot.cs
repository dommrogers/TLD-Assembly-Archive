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
		[CallerCount(Count = 2)]
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
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[CalledBy(Type = typeof(UIAnchor), Member = "LateUpdate")]
		[CalledBy(Type = typeof(UIRoot), Member = "GetPixelSizeAdjustment")]
		[CalledBy(Type = typeof(UIRoot), Member = "UpdateScale")]
		[CalledBy(Type = typeof(UIStretch), Member = "Update")]
		[CalledBy(Type = typeof(UIStretch), Member = "Update")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		get
		{
			return default(int);
		}
	}

	public float pixelSizeAdjustment
	{
		[CalledBy(Type = typeof(UIDraggableCamera), Member = "Drag")]
		[Calls(Type = typeof(UIRoot), Member = "GetPixelSizeAdjustment")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CalledBy(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
		[CalledBy(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
		[CalledBy(Type = typeof(UIRoot), Member = "GetPixelSizeAdjustment")]
		[CalledBy(Type = typeof(UIStretch), Member = "Update")]
		[CalledBy(Type = typeof(DragDropItem), Member = "OnDrag")]
		[CalledBy(Type = typeof(UIDragDropItem), Member = "OnDrag")]
		[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
		[CallerCount(Count = 9)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
		get
		{
			return default(float);
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static float GetPixelSizeAdjustment(GameObject go)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[CalledBy(Type = typeof(UIPanel), Member = "GetWindowSize")]
	[CalledBy(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
	[Calls(Type = typeof(UIRoot), Member = "get_activeHeight")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public float GetPixelSizeAdjustment(int height)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UIRoot), Member = "CreateDynamicSymbolSprite")]
	[Calls(Type = typeof(UIPanel), Member = "set_depth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	protected virtual void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected virtual void OnDisable()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UIRoot), Member = "UpdateScale")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Camera), Member = "set_orthographicSize")]
	protected virtual void Start()
	{
	}

	[Calls(Type = typeof(UIRoot), Member = "UpdateScale")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(UIRoot), Member = "Start")]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage")]
	[Calls(Type = typeof(UIRoot), Member = "get_activeHeight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIRoot), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	public void UpdateScale(bool updateAnchors = true)
	{
	}

	[CallerCount(Count = 0)]
	public float GetAspectRatioBonusSize()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(UICamera), Member = "LateUpdate")]
	[CalledBy(Type = typeof(Localization), Member = "SelectLanguage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public static void Broadcast(string funcName)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static void Broadcast(string funcName, object param)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRoot), Member = "CreateDynamicSymbolSprite")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
	public UISprite GetDynamicSymbolSpriteFromPool()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
	[CalledBy(Type = typeof(UILabel), Member = "ClearDynamicSymbolSprites")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void ReturnDynamicSymbolSpriteToPool(UISprite uiSprite)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIRoot), Member = "CreateDynamicSymbolSprite")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void InitDynamicSymbolSpritePool()
	{
	}

	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(UIRoot), Member = "Awake")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(UIRoot), Member = "InitDynamicSymbolSpritePool")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(UIRoot), Member = "GetDynamicSymbolSpriteFromPool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	private void CreateDynamicSymbolSprite()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	public UIRoot()
	{
	}
}
