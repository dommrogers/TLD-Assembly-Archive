using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
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
		[CalledBy(Type = typeof(UISoundVolume), Member = "Awake")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(NGUITools), Member = "PlaySound")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 2)]
		get
		{
			return default(float);
		}
		[CallsDeduplicatedMethods(Count = 1)]
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
		[Calls(Type = typeof(TextEditor), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
		[Calls(Type = typeof(TextEditor), Member = "Paste")]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
		[CallsDeduplicatedMethods(Count = 8)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TextEditor), Member = ".ctor")]
		[Calls(Type = typeof(TextEditor), Member = "EnsureValidCodePointIndex")]
		[Calls(Type = typeof(TextEditor), Member = "EnsureValidCodePointIndex")]
		[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
		[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
		[CallsUnknownMethods(Count = 13)]
		[Calls(Type = typeof(TextEditor), Member = "EnsureValidCodePointIndex")]
		[Calls(Type = typeof(TextEditor), Member = "EnsureValidCodePointIndex")]
		set
		{
		}
	}

	public static Vector2 screenSize
	{
		[CalledBy(Type = typeof(UIPanel), Member = "GetWindowSize")]
		[CalledBy(Type = typeof(UIPanel), Member = "get_drawCallOffset")]
		[CalledBy(Type = typeof(NGUITools), Member = "GetWorldCorners")]
		[CalledBy(Type = typeof(NGUITools), Member = "GetSides")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(UIPanel), Member = "GetViewSize")]
		[CalledBy(Type = typeof(UIRoot), Member = "get_activeHeight")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
		[CalledBy(Type = typeof(UIRoot), Member = "get_activeHeight")]
		get
		{
			return default(Vector2);
		}
	}

	[CalledBy(Type = typeof(UIItemSlot), Member = "OnDrag")]
	[CalledBy(Type = typeof(UIItemSlot), Member = "OnClick")]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public static AudioSource PlaySound(AudioClip clip)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static AudioSource PlaySound(AudioClip clip, float volume)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIPlaySound), Member = "OnDisable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectOfType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(UIPlaySound), Member = "OnHover")]
	[CalledBy(Type = typeof(UIPlaySound), Member = "OnEnable")]
	[Calls(Type = typeof(AudioSource), Member = "PlayOneShot")]
	[CalledBy(Type = typeof(UIPlaySound), Member = "OnPress")]
	[CalledBy(Type = typeof(UIPlaySound), Member = "OnClick")]
	[CalledBy(Type = typeof(UIPlaySound), Member = "OnSelect")]
	[CalledBy(Type = typeof(UIPlaySound), Member = "Play")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Select")]
	[CalledBy(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Camera), Member = "get_main")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "get_soundVolume")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 9)]
	public static AudioSource PlaySound(AudioClip clip, float volume, float pitch)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(EquipItems), Member = "Start")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(EquipRandomItem), Member = "OnClick")]
	public static int RandomRange(int min, int max)
	{
		return default(int);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(PlayIdleAnimations), Member = "Start")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(UITweener), Member = "Begin")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Start")]
	[CalledBy(Type = typeof(NGUIDebug), Member = "OnGUI")]
	public static string GetHierarchy(GameObject obj)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 3)]
	public static T[] FindActive<T>() where T : Component
	{
		return null;
	}

	[Calls(Type = typeof(Camera), Member = "GetAllCameras")]
	[CalledBy(Type = typeof(UIProgressBar), Member = "get_cachedCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask")]
	[CalledBy(Type = typeof(UICursor), Member = "Start")]
	[CalledBy(Type = typeof(NGUIMath), Member = "OverlayPosition")]
	[CalledBy(Type = typeof(NGUIMath), Member = "ScreenToParentPixels")]
	[CalledBy(Type = typeof(NGUIMath), Member = "ScreenToPixels")]
	[CalledBy(Type = typeof(WindowAutoYaw), Member = "OnEnable")]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask")]
	[CalledBy(Type = typeof(UIAnchor), Member = "Start")]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(NGUIMath), Member = "OverlayPosition")]
	[CalledBy(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CalledBy(Type = typeof(UIRect), Member = "FindCameraFor")]
	[CalledBy(Type = typeof(UIStretch), Member = "Start")]
	[CalledBy(Type = typeof(UITooltip), Member = "Start")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(NGUIMath), Member = "OverlayPosition")]
	public static Camera FindCameraForLayer(int layer)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallerCount(Count = 1)]
	public static void AddWidgetCollider(GameObject go)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[Calls(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[Calls(Type = typeof(Collider), Member = "set_isTrigger")]
	[Calls(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Collider2D), Member = "set_isTrigger")]
	[Calls(Type = typeof(UICamera), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static void AddWidgetCollider(GameObject go, bool considerInactive)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void UpdateWidgetCollider(GameObject go)
	{
	}

	[CalledBy(Type = typeof(UILabel), Member = "UpgradeFrom265")]
	[CalledBy(Type = typeof(UIWidget), Member = "UpgradeFrom265")]
	[CalledBy(Type = typeof(UIWidget), Member = "ResizeCollider")]
	[CallerCount(Count = 3)]
	[CallAnalysisFailed]
	public static void UpdateWidgetCollider(GameObject go, bool considerInactive)
	{
	}

	[CalledBy(Type = typeof(NGUITools), Member = "AddWidgetCollider")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	[CallsDeduplicatedMethods(Count = 10)]
	public static void UpdateWidgetCollider(BoxCollider box, bool considerInactive)
	{
	}

	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(Collider2D), Member = "set_offset")]
	[Calls(Type = typeof(BoxCollider2D), Member = "set_size")]
	[CalledBy(Type = typeof(NGUITools), Member = "AddWidgetCollider")]
	[CalledBy(Type = typeof(NGUITools), Member = "AddWidgetCollider")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Collider2D), Member = "set_offset")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static void UpdateWidgetCollider(BoxCollider2D box, bool considerInactive)
	{
	}

	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetTypeName<T>()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	public static string GetTypeName(UnityEngine.Object obj)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void RegisterUndo(UnityEngine.Object obj, string name)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void SetDirty(UnityEngine.Object obj)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static GameObject AddChild(GameObject parent)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
	[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
	[CalledBy(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CalledBy(Type = typeof(NGUITools), Member = "AddChild")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 17)]
	public static GameObject AddChild(GameObject parent, bool undo)
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(ContainerUI), Member = "InstantiateInventoryTableItems")]
	[CalledBy(Type = typeof(ContainerUI), Member = "InstantiateContainerTableItems")]
	[CalledBy(Type = typeof(UIDragDropItem), Member = "StartDragging")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Log), Member = "InstantiateLogGridItems")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "InstantiateInventoryTableItems")]
	[CalledBy(Type = typeof(GridUI), Member = "Initialize")]
	[CalledBy(Type = typeof(UIItemStorage), Member = "Start")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(ExampleDragDropItem), Member = "OnDragDropRelease")]
	public static GameObject AddChild(GameObject parent, GameObject prefab)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "get_raycastDepth")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UIWidget), Member = "get_raycastDepth")]
	[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
	[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static int CalculateRaycastDepth(GameObject go)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(NGUITools), Member = "AddWidget")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(NGUITools), Member = "CalculateNextDepth")]
	public static int CalculateNextDepth(GameObject go)
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(NGUITools), Member = "CalculateNextDepth")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public static int CalculateNextDepth(GameObject go, bool ignoreChildrenWithColliders)
	{
		return default(int);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(NGUITools), Member = "BringForward")]
	[Calls(Type = typeof(UIPanel), Member = "set_depth")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	public static int AdjustDepth(GameObject go, int adjustment)
	{
		return default(int);
	}

	[Calls(Type = typeof(NGUITools), Member = "NormalizePanelDepths")]
	[Calls(Type = typeof(NGUITools), Member = "NormalizeWidgetDepths")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "AdjustDepth")]
	public static void BringForward(GameObject go)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void PushBack(GameObject go)
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "NormalizePanelDepths")]
	[Calls(Type = typeof(NGUITools), Member = "NormalizeWidgetDepths")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void NormalizeDepths()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "NormalizeWidgetDepths")]
	[CalledBy(Type = typeof(NGUITools), Member = "BringForward")]
	[CalledBy(Type = typeof(NGUITools), Member = "NormalizeDepths")]
	public static void NormalizeWidgetDepths()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void NormalizeWidgetDepths(GameObject go)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CalledBy(Type = typeof(NGUITools), Member = "NormalizeWidgetDepths")]
	[CallsUnknownMethods(Count = 15)]
	public static void NormalizeWidgetDepths(UIWidget[] list)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIPanel), Member = "set_depth")]
	[CalledBy(Type = typeof(NGUITools), Member = "BringForward")]
	[CalledBy(Type = typeof(NGUITools), Member = "NormalizeDepths")]
	[CallsUnknownMethods(Count = 15)]
	[CallerCount(Count = 2)]
	public static void NormalizePanelDepths()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "CreateUI")]
	public static UIPanel CreateUI(bool advanced3D)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static UIPanel CreateUI(bool advanced3D, int layer)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Camera), Member = "get_clearFlags")]
	[Calls(Type = typeof(Camera), Member = "get_clearFlags")]
	[Calls(Type = typeof(Camera), Member = "get_depth")]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask")]
	[Calls(Type = typeof(Camera), Member = "set_cullingMask")]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Camera), Member = "set_clearFlags")]
	[Calls(Type = typeof(Camera), Member = "set_cullingMask")]
	[Calls(Type = typeof(Camera), Member = "set_depth")]
	[Calls(Type = typeof(Camera), Member = "set_orthographic")]
	[Calls(Type = typeof(Camera), Member = "set_orthographicSize")]
	[Calls(Type = typeof(Camera), Member = "set_nearClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_nearClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(UIPanel), Member = "set_depth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(NGUITools), Member = "IsChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallsUnknownMethods(Count = 51)]
	[CalledBy(Type = typeof(UIPanel), Member = "Find")]
	[Calls(Type = typeof(NGUITools), Member = "SetChildLayer")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 38)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_hideFlags")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Camera), Member = "get_orthographic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(LayerMask), Member = "NameToLayer")]
	[Calls(Type = typeof(LayerMask), Member = "NameToLayer")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
	public static UIPanel CreateUI(Transform trans, bool advanced3D, int layer)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "SetChildLayer")]
	[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
	[CalledBy(Type = typeof(NGUITools), Member = "SetChildLayer")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 5)]
	public static void SetChildLayer(Transform t, int layer)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	public static T AddChild<T>(GameObject parent) where T : Component
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	public static T AddChild<T>(GameObject parent, bool undo) where T : Component
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NGUITools), Member = "CalculateNextDepth")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static T AddWidget<T>(GameObject go) where T : UIWidget
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallsUnknownMethods(Count = 1)]
	public static T AddWidget<T>(GameObject go, int depth) where T : UIWidget
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static UISprite AddSprite(GameObject go, UIAtlas atlas, string spriteName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static GameObject GetRoot(GameObject go)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 30)]
	public static T FindInParents<T>(GameObject go) where T : Component
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 1)]
	public static T FindInParents<T>(Transform trans) where T : Component
	{
		return null;
	}

	[CalledBy(Type = typeof(ExampleDragDropItem), Member = "OnDragDropRelease")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GridUI), Member = "ClearItems")]
	[CalledBy(Type = typeof(UIInput), Member = "Cleanup")]
	[CalledBy(Type = typeof(UIDragDropItem), Member = "OnDragDropRelease")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void Destroy(UnityEngine.Object obj)
	{
	}

	[CalledBy(Type = typeof(UIDrawCall), Member = "RebuildMaterial")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "ClearAll")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "ReleaseInactive")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "Destroy")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "OnDestroy")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "OnDisable")]
	public static void DestroyImmediate(UnityEngine.Object obj)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 7)]
	public static void Broadcast(string funcName)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void Broadcast(string funcName, object param)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CenterContents), Member = "LateUpdate")]
	[CalledBy(Type = typeof(EnvelopContent), Member = "Execute")]
	[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
	public static bool IsChild(Transform parent, Transform child)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(NGUITools), Member = "SetActiveChildren")]
	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	private static void Activate(Transform t)
	{
	}

	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "Activate")]
	[CalledBy(Type = typeof(NGUITools), Member = "Activate")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	private static void Activate(Transform t, bool compatibilityMode)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage")]
	[CalledBy(Type = typeof(NGUITools), Member = "SetActiveChildren")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static void Deactivate(Transform t)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 189)]
	public static void SetActive(GameObject go, bool state)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIWrapContent), Member = "WrapContent")]
	[CalledBy(Type = typeof(UIWrapContent), Member = "WrapContent")]
	[CallAnalysisFailed]
	public static void SetActive(GameObject go, bool state, bool compatibilityMode)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(NGUITools), Member = "CallCreatePanel")]
	[Calls(Type = typeof(NGUITools), Member = "CallCreatePanel")]
	private static void CallCreatePanel(Transform t)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(NGUITools), Member = "Deactivate")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(NGUITools), Member = "Activate")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static void SetActiveChildren(GameObject go, bool state)
	{
	}

	[Obsolete]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 5)]
	public static bool IsActive(Behaviour mb)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 23)]
	[CallsUnknownMethods(Count = 5)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static bool GetActive(Behaviour mb)
	{
		return default(bool);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 30)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool GetActive(GameObject go)
	{
		return default(bool);
	}

	[DebuggerStepThrough]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DebuggerHidden]
	public static void SetActiveSelf(GameObject go, bool state)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetLayer")]
	[CalledBy(Type = typeof(NGUITools), Member = "SetLayer")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 6)]
	public static void SetLayer(GameObject go, int layer)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(NGUITools), Member = "MakePixelPerfect")]
	[CalledBy(Type = typeof(NGUITools), Member = "MakePixelPerfect")]
	[CallsUnknownMethods(Count = 3)]
	public static Vector3 Round(Vector3 v)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(NGUITools), Member = "MakePixelPerfect")]
	[Calls(Type = typeof(NGUITools), Member = "MakePixelPerfect")]
	[Calls(Type = typeof(NGUITools), Member = "Round")]
	[Calls(Type = typeof(NGUITools), Member = "Round")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	public static void MakePixelPerfect(Transform t)
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(File), Member = "Delete")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(File), Member = "Create")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static bool Save(string fileName, byte[] bytes)
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(File), Member = "ReadAllBytes")]
	public static byte[] Load(string fileName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Color ApplyPMA(Color c)
	{
		return default(Color);
	}

	[CalledBy(Type = typeof(DragDropItem), Member = "OnDragDropStart")]
	[CalledBy(Type = typeof(UIDragDropItem), Member = "OnDragDropRelease")]
	[CalledBy(Type = typeof(UIDragDropItem), Member = "OnDragDropStart")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public static void MarkParentAsChanged(GameObject go)
	{
	}

	[Obsolete]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUIText), Member = "EncodeColor24")]
	[CallerCount(Count = 0)]
	public static string EncodeColor(Color c)
	{
		return null;
	}

	[Obsolete]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUIText), Member = "ParseColor24")]
	public static Color ParseColor(string text, int offset)
	{
		return default(Color);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUIText), Member = "StripSymbols")]
	[CallerCount(Count = 0)]
	[Obsolete]
	public static string StripSymbols(string text)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 3)]
	public static T AddMissingComponent<T>(this GameObject go) where T : Component
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(NGUITools), Member = "GetSides")]
	public static Vector3[] GetSides(this Camera cam)
	{
		return null;
	}

	[Calls(Type = typeof(NGUITools), Member = "GetSides")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Vector3[] GetSides(this Camera cam, float depth)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static Vector3[] GetSides(this Camera cam, Transform relativeTo)
	{
		return null;
	}

	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsUnknownMethods(Count = 44)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(NGUITools), Member = "GetSides")]
	[CalledBy(Type = typeof(UIRect), Member = "GetSides")]
	[CalledBy(Type = typeof(UIRect.AnchorPoint), Member = "GetSides")]
	[CalledBy(Type = typeof(UIPanel), Member = "GetSides")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CalledBy(Type = typeof(NGUITools), Member = "GetSides")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
	[CallerCount(Count = 5)]
	public static Vector3[] GetSides(this Camera cam, float depth, Transform relativeTo)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(NGUITools), Member = "GetWorldCorners")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 0)]
	public static Vector3[] GetWorldCorners(this Camera cam)
	{
		return null;
	}

	[Calls(Type = typeof(NGUITools), Member = "GetWorldCorners")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CalledBy(Type = typeof(NGUITools), Member = "GetWorldCorners")]
	[CalledBy(Type = typeof(NGUITools), Member = "GetWorldCorners")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CalledBy(Type = typeof(UIPanel), Member = "get_worldCorners")]
	[CallsUnknownMethods(Count = 44)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 12)]
	public static Vector3[] GetWorldCorners(this Camera cam, float depth, Transform relativeTo)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	public static string GetFuncName(object obj, string method)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(Type), Member = "GetMethod")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void Execute<T>(GameObject go, string funcName) where T : Component
	{
	}

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 7)]
	public static void ExecuteAll<T>(GameObject root, string funcName) where T : Component
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	public static void ImmediatelyCreateDrawCalls(GameObject root)
	{
	}
}
