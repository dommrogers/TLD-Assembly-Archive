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
		[CallerCount(Count = 6)]
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
		[CalledBy(Type = typeof(UIPanel), Member = "GetWindowSize")]
		[CalledBy(Type = typeof(UIAnchor), Member = "LateUpdate")]
		[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
		[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(UIStretch), Member = "Update")]
		[CalledBy(Type = typeof(UIRoot), Member = "UpdateScale")]
		[CallsUnknownMethods(Count = 5)]
		[CalledBy(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
		[CalledBy(Type = typeof(UIStretch), Member = "Update")]
		[CalledBy(Type = typeof(UIRoot), Member = "GetPixelSizeAdjustment")]
		get
		{
			return default(int);
		}
	}

	public float pixelSizeAdjustment
	{
		[CalledBy(Type = typeof(UIDragDropItem), Member = "OnDrag")]
		[Calls(Type = typeof(UIRoot), Member = "get_activeHeight")]
		[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
		[CallerCount(Count = 9)]
		[CalledBy(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(DragDropItem), Member = "OnDrag")]
		[CalledBy(Type = typeof(UIStretch), Member = "Update")]
		[CalledBy(Type = typeof(UILabel), Member = "UpdateNGUIText")]
		[CalledBy(Type = typeof(UIRoot), Member = "GetPixelSizeAdjustment")]
		[CalledBy(Type = typeof(UIPanel), Member = "ConstrainTargetToBounds")]
		[CalledBy(Type = typeof(UIDraggableCamera), Member = "Drag")]
		[CalledBy(Type = typeof(UILabel), Member = "ProcessText")]
		get
		{
			return default(float);
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static float GetPixelSizeAdjustment(GameObject go)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRoot), Member = "get_activeHeight")]
	public float GetPixelSizeAdjustment(int height)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIPanel), Member = "set_depth")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UIRoot), Member = "CreateDynamicSymbolSprite")]
	protected virtual void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected virtual void OnDisable()
	{
	}

	[Calls(Type = typeof(Camera), Member = "set_orthographicSize")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRoot), Member = "UpdateScale")]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void Start()
	{
	}

	[Calls(Type = typeof(UIRoot), Member = "UpdateScale")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRoot), Member = "get_activeHeight")]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage")]
	[CalledBy(Type = typeof(UIRoot), Member = "Start")]
	[CalledBy(Type = typeof(UIRoot), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void UpdateScale(bool updateAnchors = true)
	{
	}

	[CallerCount(Count = 0)]
	public float GetAspectRatioBonusSize()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(UICamera), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Localization), Member = "SelectLanguage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public static void Broadcast(string funcName)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public static void Broadcast(string funcName, object param)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIRoot), Member = "CreateDynamicSymbolSprite")]
	[CallsUnknownMethods(Count = 3)]
	public UISprite GetDynamicSymbolSpriteFromPool()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(UILabel), Member = "ClearDynamicSymbolSprites")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public void ReturnDynamicSymbolSpriteToPool(UISprite uiSprite)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIRoot), Member = "CreateDynamicSymbolSprite")]
	[CallsUnknownMethods(Count = 1)]
	private void InitDynamicSymbolSpritePool()
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
	[CalledBy(Type = typeof(UIRoot), Member = "Awake")]
	[CalledBy(Type = typeof(UIRoot), Member = "GetDynamicSymbolSpriteFromPool")]
	[CalledBy(Type = typeof(UIRoot), Member = "InitDynamicSymbolSpritePool")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	private void CreateDynamicSymbolSprite()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public UIRoot()
	{
	}
}
