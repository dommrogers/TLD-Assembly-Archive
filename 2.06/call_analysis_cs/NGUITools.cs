using System;
using System.Diagnostics;
using System.IO;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public static class NGUITools
{
	private static AudioListener mListener;

	private static bool mLoaded;

	private static float mGlobalVolume;

	private static float mLastTimestamp;

	private static AudioClip mLastClip;

	private static Vector3[] mSides;

	public static float soundVolume
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(NGUITools), Member = "PlaySound")]
		[CalledBy(Type = typeof(UISoundVolume), Member = "Awake")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat")]
		set
		{
		}
	}

	public static bool fileAccess
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public static string clipboard
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextEditor), Member = ".ctor")]
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(TextEditor), Member = "Paste")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(TextEditor), Member = "OnFocus")]
		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TextEditor), Member = ".ctor")]
		[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
		[Calls(Type = typeof(TextEditor), Member = "Copy")]
		set
		{
		}
	}

	public static Vector2 screenSize
	{
		[CalledBy(Type = typeof(UIRoot), Member = "get_activeHeight")]
		[CalledBy(Type = typeof(UIPanel), Member = "GetViewSize")]
		[CalledBy(Type = typeof(UIRoot), Member = "get_activeHeight")]
		[CalledBy(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
		[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
		[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(UIPanel), Member = "GetWindowSize")]
		[CalledBy(Type = typeof(NGUITools), Member = "GetWorldCorners")]
		[CalledBy(Type = typeof(NGUITools), Member = "GetSides")]
		[CallerCount(Count = 9)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return default(Vector2);
		}
	}

	[CalledBy(Type = typeof(UIItemSlot), Member = "OnDrag")]
	[CalledBy(Type = typeof(UIItemSlot), Member = "OnClick")]
	[CalledBy(Type = typeof(UIItemSlot), Member = "OnClick")]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallerCount(Count = 3)]
	public static AudioSource PlaySound(AudioClip clip)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static AudioSource PlaySound(AudioClip clip, float volume)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIPlaySound), Member = "OnEnable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AudioSource), Member = "PlayOneShot")]
	[CalledBy(Type = typeof(UIItemSlot), Member = "OnClick")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectOfType")]
	[CalledBy(Type = typeof(UIPlaySound), Member = "OnDisable")]
	[Calls(Type = typeof(Camera), Member = "get_main")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(UIPlaySound), Member = "OnPress")]
	[CalledBy(Type = typeof(UIPlaySound), Member = "OnClick")]
	[CalledBy(Type = typeof(UIPlaySound), Member = "OnSelect")]
	[CalledBy(Type = typeof(UIPlaySound), Member = "Play")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Select")]
	[CalledBy(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(UIPlaySound), Member = "OnHover")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NGUITools), Member = "get_soundVolume")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 10)]
	public static AudioSource PlaySound(AudioClip clip, float volume, float pitch)
	{
		return null;
	}

	[CalledBy(Type = typeof(EquipRandomItem), Member = "OnClick")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(EquipItems), Member = "Start")]
	[CallerCount(Count = 2)]
	public static int RandomRange(int min, int max)
	{
		return default(int);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(UITweener), Member = "Begin")]
	[CalledBy(Type = typeof(PlayIdleAnimations), Member = "Start")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Start")]
	[CalledBy(Type = typeof(NGUIDebug), Member = "OnGUI")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 6)]
	public static string GetHierarchy(GameObject obj)
	{
		return null;
	}

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[DeduplicatedMethod]
	public static T[] FindActive<T>() where T : Component
	{
		return null;
	}

	[CalledBy(Type = typeof(UICursor), Member = "Start")]
	[CalledBy(Type = typeof(WindowAutoYaw), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIProgressBar), Member = "get_cachedCamera")]
	[CalledBy(Type = typeof(NGUIMath), Member = "ScreenToPixels")]
	[CalledBy(Type = typeof(NGUIMath), Member = "ScreenToParentPixels")]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask")]
	[CalledBy(Type = typeof(UITooltip), Member = "Start")]
	[CalledBy(Type = typeof(UIAnchor), Member = "Start")]
	[CalledBy(Type = typeof(UIRect), Member = "FindCameraFor")]
	[CalledBy(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CalledBy(Type = typeof(NGUIMath), Member = "OverlayPosition")]
	[CalledBy(Type = typeof(NGUIMath), Member = "OverlayPosition")]
	[CalledBy(Type = typeof(NGUIMath), Member = "OverlayPosition")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(UIStretch), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Camera), Member = "GetAllCameras")]
	public static Camera FindCameraForLayer(int layer)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	public static void AddWidgetCollider(GameObject go)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[Calls(Type = typeof(Collider), Member = "set_isTrigger")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Collider2D), Member = "set_isTrigger")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static void AddWidgetCollider(GameObject go, bool considerInactive)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void UpdateWidgetCollider(GameObject go)
	{
	}

	[CalledBy(Type = typeof(UIWidget), Member = "ResizeCollider")]
	[CalledBy(Type = typeof(UILabel), Member = "UpgradeFrom265")]
	[CalledBy(Type = typeof(UIWidget), Member = "UpgradeFrom265")]
	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	public static void UpdateWidgetCollider(GameObject go, bool considerInactive)
	{
	}

	[CalledBy(Type = typeof(NGUITools), Member = "AddWidgetCollider")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 10)]
	public static void UpdateWidgetCollider(BoxCollider box, bool considerInactive)
	{
	}

	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(Collider2D), Member = "set_offset")]
	[Calls(Type = typeof(BoxCollider2D), Member = "set_size")]
	[Calls(Type = typeof(Collider2D), Member = "set_offset")]
	[Calls(Type = typeof(BoxCollider2D), Member = "set_size")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(NGUITools), Member = "AddWidgetCollider")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public static void UpdateWidgetCollider(BoxCollider2D box, bool considerInactive)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetTypeName<T>()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	public static string GetTypeName(UnityEngine.Object obj)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void RegisterUndo(UnityEngine.Object obj, string name)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void SetDirty(UnityEngine.Object obj)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static GameObject AddChild(GameObject parent)
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(NGUITools), Member = "AddChild")]
	[CalledBy(Type = typeof(NGUITools), Member = "AddChild")]
	[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
	[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static GameObject AddChild(GameObject parent, bool undo)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIItemStorage), Member = "Start")]
	[CalledBy(Type = typeof(ContainerUI), Member = "InstantiateContainerTableItems")]
	[CalledBy(Type = typeof(ExampleDragDropItem), Member = "OnDragDropRelease")]
	[CalledBy(Type = typeof(UIDragDropItem), Member = "StartDragging")]
	[CalledBy(Type = typeof(ContainerUI), Member = "InstantiateInventoryTableItems")]
	[CalledBy(Type = typeof(GridUI), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "InstantiateInventoryTableItems")]
	[CalledBy(Type = typeof(Panel_Log), Member = "InstantiateLogGridItems")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static GameObject AddChild(GameObject parent, GameObject prefab)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
	[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
	[Calls(Type = typeof(UIWidget), Member = "get_raycastDepth")]
	[Calls(Type = typeof(UIWidget), Member = "get_raycastDepth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static int CalculateRaycastDepth(GameObject go)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(NGUITools), Member = "AddWidget")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(NGUITools), Member = "CalculateNextDepth")]
	[CallsUnknownMethods(Count = 2)]
	public static int CalculateNextDepth(GameObject go)
	{
		return default(int);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(NGUITools), Member = "CalculateNextDepth")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static int CalculateNextDepth(GameObject go, bool ignoreChildrenWithColliders)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIPanel), Member = "set_depth")]
	[CalledBy(Type = typeof(NGUITools), Member = "BringForward")]
	[CalledBy(Type = typeof(NGUITools), Member = "PushBack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static int AdjustDepth(GameObject go, int adjustment)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "NormalizePanelDepths")]
	[Calls(Type = typeof(NGUITools), Member = "NormalizeWidgetDepths")]
	[Calls(Type = typeof(NGUITools), Member = "AdjustDepth")]
	public static void BringForward(GameObject go)
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "NormalizePanelDepths")]
	[Calls(Type = typeof(NGUITools), Member = "NormalizeWidgetDepths")]
	[Calls(Type = typeof(NGUITools), Member = "AdjustDepth")]
	[CallerCount(Count = 0)]
	public static void PushBack(GameObject go)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "NormalizeWidgetDepths")]
	[Calls(Type = typeof(NGUITools), Member = "NormalizePanelDepths")]
	[CallerCount(Count = 0)]
	public static void NormalizeDepths()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "NormalizeWidgetDepths")]
	[CalledBy(Type = typeof(NGUITools), Member = "BringForward")]
	[CalledBy(Type = typeof(NGUITools), Member = "PushBack")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void NormalizeWidgetDepths()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void NormalizeWidgetDepths(GameObject go)
	{
	}

	[CalledBy(Type = typeof(NGUITools), Member = "NormalizeWidgetDepths")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CalledBy(Type = typeof(NGUITools), Member = "NormalizeDepths")]
	[CallsUnknownMethods(Count = 7)]
	public static void NormalizeWidgetDepths(UIWidget[] list)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(NGUITools), Member = "NormalizeDepths")]
	[CalledBy(Type = typeof(NGUITools), Member = "PushBack")]
	[CalledBy(Type = typeof(NGUITools), Member = "BringForward")]
	[Calls(Type = typeof(UIPanel), Member = "set_depth")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	public static void NormalizePanelDepths()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "CreateUI")]
	[CallerCount(Count = 0)]
	public static UIPanel CreateUI(bool advanced3D)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static UIPanel CreateUI(bool advanced3D, int layer)
	{
		return null;
	}

	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(LayerMask), Member = "NameToLayer")]
	[Calls(Type = typeof(LayerMask), Member = "NameToLayer")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Camera), Member = "get_clearFlags")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIPanel), Member = "set_depth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(Camera), Member = "set_cullingMask")]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask")]
	[Calls(Type = typeof(Camera), Member = "get_depth")]
	[Calls(Type = typeof(Camera), Member = "get_orthographic")]
	[CallsUnknownMethods(Count = 71)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(UIPanel), Member = "Find")]
	[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(NGUITools), Member = "SetChildLayer")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(NGUITools), Member = "IsChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 47)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 2)]
	public static UIPanel CreateUI(Transform trans, bool advanced3D, int layer)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "SetChildLayer")]
	[CalledBy(Type = typeof(NGUITools), Member = "SetChildLayer")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
	public static void SetChildLayer(Transform t, int layer)
	{
	}

	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static T AddChild<T>(GameObject parent) where T : Component
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public static T AddChild<T>(GameObject parent, bool undo) where T : Component
	{
		return null;
	}

	[Calls(Type = typeof(NGUITools), Member = "CalculateNextDepth")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	public static T AddWidget<T>(GameObject go) where T : UIWidget
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[DeduplicatedMethod]
	public static T AddWidget<T>(GameObject go, int depth) where T : UIWidget
	{
		return null;
	}

	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	public static UISprite AddSprite(GameObject go, UIAtlas atlas, string spriteName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static GameObject GetRoot(GameObject go)
	{
		return null;
	}

	[CallerCount(Count = 30)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static T FindInParents<T>(GameObject go) where T : Component
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static T FindInParents<T>(Transform trans) where T : Component
	{
		return null;
	}

	[CalledBy(Type = typeof(UIDragDropItem), Member = "OnDragDropRelease")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(ExampleDragDropItem), Member = "OnDragDropRelease")]
	[CalledBy(Type = typeof(UIInput), Member = "Cleanup")]
	[CalledBy(Type = typeof(GridUI), Member = "ClearItems")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void Destroy(UnityEngine.Object obj)
	{
	}

	[CalledBy(Type = typeof(UIDrawCall), Member = "ReleaseInactive")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "ReleaseAll")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "ClearAll")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "OnDestroy")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "OnDisable")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "RebuildMaterial")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(UIDrawCall), Member = "Destroy")]
	public static void DestroyImmediate(UnityEngine.Object obj)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public static void Broadcast(string funcName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[CallsUnknownMethods(Count = 4)]
	public static void Broadcast(string funcName, object param)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CenterContents), Member = "LateUpdate")]
	[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
	[CalledBy(Type = typeof(EnvelopContent), Member = "Execute")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static bool IsChild(Transform parent, Transform child)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private static void Activate(Transform t)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(NGUITools), Member = "Activate")]
	[CalledBy(Type = typeof(NGUITools), Member = "Activate")]
	[CalledBy(Type = typeof(NGUITools), Member = "SetActiveChildren")]
	private static void Activate(Transform t, bool compatibilityMode)
	{
	}

	[Calls(Type = typeof(Component), Member = "BroadcastMessage")]
	[CalledBy(Type = typeof(NGUITools), Member = "SetActiveChildren")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private static void Deactivate(Transform t)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 85)]
	public static void SetActive(GameObject go, bool state)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 103)]
	public static void SetActive(GameObject go, bool state, bool compatibilityMode)
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "CallCreatePanel")]
	[DebuggerStepThrough]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[CalledBy(Type = typeof(NGUITools), Member = "CallCreatePanel")]
	[DebuggerHidden]
	private static void CallCreatePanel(Transform t)
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(NGUITools), Member = "Activate")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(NGUITools), Member = "Deactivate")]
	[CallerCount(Count = 0)]
	public static void SetActiveChildren(GameObject go, bool state)
	{
	}

	[Obsolete("Use NGUITools.GetActive instead")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public static bool IsActive(Behaviour mb)
	{
		return default(bool);
	}

	[DebuggerHidden]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 24)]
	[DebuggerStepThrough]
	public static bool GetActive(Behaviour mb)
	{
		return default(bool);
	}

	[CallerCount(Count = 31)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool GetActive(GameObject go)
	{
		return default(bool);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetActiveSelf(GameObject go, bool state)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(NGUITools), Member = "SetLayer")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(NGUITools), Member = "SetLayer")]
	public static void SetLayer(GameObject go, int layer)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static Vector3 Round(Vector3 v)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(NGUITools), Member = "MakePixelPerfect")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(NGUITools), Member = "MakePixelPerfect")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static void MakePixelPerfect(Transform t)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(File), Member = "Create")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(File), Member = "Delete")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[CallsUnknownMethods(Count = 3)]
	public static bool Save(string fileName, byte[] bytes)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(File), Member = "ReadAllBytes")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static byte[] Load(string fileName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Color ApplyPMA(Color c)
	{
		return default(Color);
	}

	[CalledBy(Type = typeof(UIDragDropItem), Member = "OnDragDropRelease")]
	[CalledBy(Type = typeof(UIDragDropItem), Member = "OnDragDropStart")]
	[CalledBy(Type = typeof(DragDropItem), Member = "OnDragDropStart")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	public static void MarkParentAsChanged(GameObject go)
	{
	}

	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(NGUIMath), Member = "ColorToInt")]
	[CallerCount(Count = 0)]
	[Obsolete("Use NGUIText.EncodeColor instead")]
	public static string EncodeColor(Color c)
	{
		return null;
	}

	[Obsolete("Use NGUIText.ParseColor instead")]
	[Calls(Type = typeof(NGUIText), Member = "ParseColor24")]
	[CallerCount(Count = 0)]
	public static Color ParseColor(string text, int offset)
	{
		return default(Color);
	}

	[Obsolete("Use NGUIText.StripSymbols instead")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIText), Member = "StripSymbols")]
	public static string StripSymbols(string text)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static T AddMissingComponent<T>(this GameObject go) where T : Component
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "GetSides")]
	public static Vector3[] GetSides(this Camera cam)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetSides")]
	public static Vector3[] GetSides(this Camera cam, float depth)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static Vector3[] GetSides(this Camera cam, Transform relativeTo)
	{
		return null;
	}

	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(NGUITools), Member = "GetSides")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(UIPanel), Member = "GetSides")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CalledBy(Type = typeof(UIRect), Member = "GetSides")]
	[CalledBy(Type = typeof(UIRect.AnchorPoint), Member = "GetSides")]
	[CalledBy(Type = typeof(NGUITools), Member = "GetSides")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	public static Vector3[] GetSides(this Camera cam, float depth, Transform relativeTo)
	{
		return null;
	}

	[Calls(Type = typeof(NGUITools), Member = "GetWorldCorners")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static Vector3[] GetWorldCorners(this Camera cam)
	{
		return null;
	}

	[Calls(Type = typeof(NGUITools), Member = "GetWorldCorners")]
	[CallerCount(Count = 0)]
	public static Vector3[] GetWorldCorners(this Camera cam, float depth)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static Vector3[] GetWorldCorners(this Camera cam, Transform relativeTo)
	{
		return null;
	}

	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(UIPanel), Member = "get_worldCorners")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(NGUITools), Member = "GetWorldCorners")]
	[CalledBy(Type = typeof(NGUITools), Member = "GetWorldCorners")]
	public static Vector3[] GetWorldCorners(this Camera cam, float depth, Transform relativeTo)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static string GetFuncName(object obj, string method)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void Execute<T>(GameObject go, string funcName) where T : Component
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public static void ExecuteAll<T>(GameObject root, string funcName) where T : Component
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public static void ImmediatelyCreateDrawCalls(GameObject root)
	{
	}
}
