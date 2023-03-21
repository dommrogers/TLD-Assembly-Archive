using System;
using System.Collections.Generic;
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
		[CalledBy(Type = typeof(UISoundVolume), Member = "Awake")]
		[CalledBy(Type = typeof(NGUITools), Member = "PlaySound")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
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
			return false;
		}
	}

	public static string clipboard
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextEditor), Member = ".ctor")]
		[Calls(Type = typeof(TextEditor), Member = "Paste")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(UIInput), Member = "ProcessEvent")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TextEditor), Member = ".ctor")]
		[Calls(Type = typeof(TextEditor), Member = "OnFocus")]
		[Calls(Type = typeof(TextEditor), Member = "Copy")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public static Vector2 screenSize
	{
		[CalledBy(Type = typeof(NGUITools), Member = "GetSides")]
		[CalledBy(Type = typeof(NGUITools), Member = "GetWorldCorners")]
		[CalledBy(Type = typeof(UIPanel), Member = "GetWindowSize")]
		[CalledBy(Type = typeof(UIPanel), Member = "GetViewSize")]
		[CalledBy(Type = typeof(UIRoot), Member = "get_activeHeight")]
		[CalledBy(Type = typeof(UIRoot), Member = "get_pixelSizeAdjustment")]
		[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
		[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
		[CallerCount(Count = 9)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(Vector2);
		}
	}

	[CalledBy(Type = typeof(UIItemSlot), Member = "OnClick")]
	[CalledBy(Type = typeof(UIItemSlot), Member = "OnDrag")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
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

	[CalledBy(Type = typeof(UIItemSlot), Member = "OnClick")]
	[CalledBy(Type = typeof(UIPlaySound), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIPlaySound), Member = "OnDisable")]
	[CalledBy(Type = typeof(UIPlaySound), Member = "OnHover")]
	[CalledBy(Type = typeof(UIPlaySound), Member = "OnPress")]
	[CalledBy(Type = typeof(UIPlaySound), Member = "OnClick")]
	[CalledBy(Type = typeof(UIPlaySound), Member = "OnSelect")]
	[CalledBy(Type = typeof(UIPlaySound), Member = "Play")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Select")]
	[CalledBy(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(NGUITools), Member = "get_soundVolume")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(Camera), Member = "get_main")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectOfType")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(AudioSource), Member = "PlayOneShot")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	public static AudioSource PlaySound(AudioClip clip, float volume, float pitch)
	{
		return null;
	}

	[CalledBy(Type = typeof(EquipItems), Member = "Start")]
	[CalledBy(Type = typeof(EquipRandomItem), Member = "OnClick")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static int RandomRange(int min, int max)
	{
		return 0;
	}

	[CalledBy(Type = typeof(PlayIdleAnimations), Member = "Start")]
	[CalledBy(Type = typeof(UIDraggableCamera), Member = "Start")]
	[CalledBy(Type = typeof(NGUIDebug), Member = "OnGUI")]
	[CalledBy(Type = typeof(UITweener), Member = "Begin")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	public static string GetHierarchy(GameObject obj)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(InvDatabase), Member = "get_list")]
	[CalledBy(Type = typeof(NGUITools), Member = "NormalizeDepths")]
	[CalledBy(Type = typeof(NGUITools), Member = "NormalizeWidgetDepths")]
	[CalledBy(Type = typeof(NGUITools), Member = "NormalizePanelDepths")]
	[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
	[CalledBy(Type = typeof(UIAtlas), Member = "MarkAsChanged")]
	[CalledBy(Type = typeof(UIFont), Member = "MarkAsChanged")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[CallsUnknownMethods(Count = 2)]
	public static T[] FindActive<T>() where T : Component
	{
		return null;
	}

	[CalledBy(Type = typeof(UICursor), Member = "Start")]
	[CalledBy(Type = typeof(WindowAutoYaw), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIProgressBar), Member = "get_cachedCamera")]
	[CalledBy(Type = typeof(NGUIMath), Member = "ScreenToPixels")]
	[CalledBy(Type = typeof(NGUIMath), Member = "ScreenToParentPixels")]
	[CalledBy(Type = typeof(NGUIMath), Member = "OverlayPosition")]
	[CalledBy(Type = typeof(NGUIMath), Member = "OverlayPosition")]
	[CalledBy(Type = typeof(UIRect), Member = "ResetAnchors")]
	[CalledBy(Type = typeof(UIRect), Member = "FindCameraFor")]
	[CalledBy(Type = typeof(UIAnchor), Member = "Start")]
	[CalledBy(Type = typeof(UIStretch), Member = "Start")]
	[CalledBy(Type = typeof(UITooltip), Member = "Start")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask")]
	[Calls(Type = typeof(Camera), Member = "GetAllCameras")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public static Camera FindCameraForLayer(int layer)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void AddWidgetCollider(GameObject go)
	{
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[Calls(Type = typeof(NGUITools), Member = "UpdateWidgetCollider")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UICamera), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(Collider2D), Member = "set_isTrigger")]
	[Calls(Type = typeof(Collider), Member = "set_isTrigger")]
	[CallsUnknownMethods(Count = 1)]
	public static void AddWidgetCollider(GameObject go, bool considerInactive)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void UpdateWidgetCollider(GameObject go)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(UIWidget), Member = "ResizeCollider")]
	[CalledBy(Type = typeof(UIWidget), Member = "UpgradeFrom265")]
	[CalledBy(Type = typeof(UILabel), Member = "UpgradeFrom265")]
	[CallerCount(Count = 3)]
	public static void UpdateWidgetCollider(GameObject go, bool considerInactive)
	{
	}

	[CalledBy(Type = typeof(NGUITools), Member = "AddWidgetCollider")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 10)]
	public static void UpdateWidgetCollider(BoxCollider box, bool considerInactive)
	{
	}

	[CalledBy(Type = typeof(NGUITools), Member = "AddWidgetCollider")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Collider2D), Member = "set_offset")]
	[Calls(Type = typeof(BoxCollider2D), Member = "set_size")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static void UpdateWidgetCollider(BoxCollider2D box, bool considerInactive)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetTypeName<T>()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static GameObject AddChild(GameObject parent)
	{
		return null;
	}

	[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
	[CalledBy(Type = typeof(NGUITools), Member = "AddChild")]
	[CalledBy(Type = typeof(NGUITools), Member = "AddChild")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	public static GameObject AddChild(GameObject parent, bool undo)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIItemStorage), Member = "Start")]
	[CalledBy(Type = typeof(ExampleDragDropItem), Member = "OnDragDropRelease")]
	[CalledBy(Type = typeof(UIDragDropItem), Member = "StartDragging")]
	[CalledBy(Type = typeof(ContainerUI), Member = "InstantiateContainerTableItems")]
	[CalledBy(Type = typeof(ContainerUI), Member = "InstantiateInventoryTableItems")]
	[CalledBy(Type = typeof(GridUI), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "InstantiateInventoryTableItems")]
	[CalledBy(Type = typeof(Panel_Log), Member = "InstantiateLogGridItems")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	public static GameObject AddChild(GameObject parent, GameObject prefab)
	{
		return null;
	}

	[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UIWidget), Member = "get_raycastDepth")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static int CalculateRaycastDepth(GameObject go)
	{
		return 0;
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(NGUITools), Member = "CalculateNextDepth")]
	[CalledBy(Type = typeof(NGUITools), Member = "AddWidget")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int CalculateNextDepth(GameObject go)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "CalculateNextDepth")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int CalculateNextDepth(GameObject go, bool ignoreChildrenWithColliders)
	{
		return 0;
	}

	[CalledBy(Type = typeof(NGUITools), Member = "BringForward")]
	[CalledBy(Type = typeof(NGUITools), Member = "PushBack")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UIPanel), Member = "set_depth")]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallsUnknownMethods(Count = 2)]
	public static int AdjustDepth(GameObject go, int adjustment)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "AdjustDepth")]
	[Calls(Type = typeof(NGUITools), Member = "NormalizeWidgetDepths")]
	[Calls(Type = typeof(NGUITools), Member = "NormalizePanelDepths")]
	public static void BringForward(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "AdjustDepth")]
	[Calls(Type = typeof(NGUITools), Member = "NormalizeWidgetDepths")]
	[Calls(Type = typeof(NGUITools), Member = "NormalizePanelDepths")]
	public static void PushBack(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "FindActive")]
	[Calls(Type = typeof(NGUITools), Member = "NormalizeWidgetDepths")]
	[Calls(Type = typeof(NGUITools), Member = "NormalizePanelDepths")]
	public static void NormalizeDepths()
	{
	}

	[CalledBy(Type = typeof(NGUITools), Member = "BringForward")]
	[CalledBy(Type = typeof(NGUITools), Member = "PushBack")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "FindActive")]
	[Calls(Type = typeof(NGUITools), Member = "NormalizeWidgetDepths")]
	public static void NormalizeWidgetDepths()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void NormalizeWidgetDepths(GameObject go)
	{
	}

	[CalledBy(Type = typeof(NGUITools), Member = "NormalizeDepths")]
	[CalledBy(Type = typeof(NGUITools), Member = "NormalizeWidgetDepths")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void NormalizeWidgetDepths(UIWidget[] list)
	{
	}

	[CalledBy(Type = typeof(NGUITools), Member = "BringForward")]
	[CalledBy(Type = typeof(NGUITools), Member = "PushBack")]
	[CalledBy(Type = typeof(NGUITools), Member = "NormalizeDepths")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NGUITools), Member = "FindActive")]
	[Calls(Type = typeof(UIPanel), Member = "set_depth")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void NormalizePanelDepths()
	{
	}

	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
	[CalledBy(Type = typeof(UIPanel), Member = "Find")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Camera), Member = "get_orthographic")]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(LayerMask), Member = "NameToLayer")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(NGUITools), Member = "FindActive")]
	[Calls(Type = typeof(Camera), Member = "get_clearFlags")]
	[Calls(Type = typeof(Camera), Member = "get_depth")]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask")]
	[Calls(Type = typeof(Camera), Member = "set_cullingMask")]
	[Calls(Type = typeof(UIPanel), Member = "set_depth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "IsChild")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(NGUITools), Member = "SetChildLayer")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 36)]
	[CallsUnknownMethods(Count = 37)]
	public static UIPanel CreateUI(Transform trans, bool advanced3D, int layer)
	{
		return null;
	}

	[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
	[CalledBy(Type = typeof(NGUITools), Member = "SetChildLayer")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "SetChildLayer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public static void SetChildLayer(Transform t, int layer)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static T AddChild<T>(GameObject parent) where T : Component
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static T AddChild<T>(GameObject parent, bool undo) where T : Component
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(NGUITools), Member = "AddSprite")]
	[CalledBy(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NGUITools), Member = "CalculateNextDepth")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static T AddWidget<T>(GameObject go) where T : UIWidget
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static T AddWidget<T>(GameObject go, int depth) where T : UIWidget
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIAtlas), Member = "GetSprite")]
	[Calls(Type = typeof(NGUITools), Member = "AddWidget")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static UISprite AddSprite(GameObject go, UIAtlas atlas, string spriteName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static GameObject GetRoot(GameObject go)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 30)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public static T FindInParents<T>(GameObject go) where T : Component
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(UIDragDropItem), Member = "OnDragDropStart")]
	[CalledBy(Type = typeof(UIDragDropItem), Member = "OnDragDropRelease")]
	[CalledBy(Type = typeof(UIDragScrollView), Member = "FindScrollView")]
	[CalledBy(Type = typeof(UIDragScrollView), Member = "OnPress")]
	[CalledBy(Type = typeof(UIRect), Member = "get_parent")]
	[CalledBy(Type = typeof(UIRect), Member = "get_root")]
	[CalledBy(Type = typeof(UIRect), Member = "ParentHasChanged")]
	[CalledBy(Type = typeof(UIPanel), Member = "Find")]
	[CalledBy(Type = typeof(DragDropItem), Member = "OnDragDropStart")]
	[CallerCount(Count = 14)]
	public static T FindInParents<T>(Transform trans) where T : Component
	{
		return null;
	}

	[CalledBy(Type = typeof(ExampleDragDropItem), Member = "OnDragDropRelease")]
	[CalledBy(Type = typeof(UIDragDropItem), Member = "OnDragDropRelease")]
	[CalledBy(Type = typeof(UIInput), Member = "Cleanup")]
	[CalledBy(Type = typeof(GridUI), Member = "ClearItems")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void Destroy(UnityEngine.Object obj)
	{
	}

	[CalledBy(Type = typeof(UIDrawCall), Member = "RebuildMaterial")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "OnDisable")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "OnDestroy")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "ClearAll")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "ReleaseInactive")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "Destroy")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	public static void DestroyImmediate(UnityEngine.Object obj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void Broadcast(string funcName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void Broadcast(string funcName, object param)
	{
	}

	[CalledBy(Type = typeof(EnvelopContent), Member = "Execute")]
	[CalledBy(Type = typeof(NGUITools), Member = "CreateUI")]
	[CalledBy(Type = typeof(CenterContents), Member = "LateUpdate")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsChild(Transform parent, Transform child)
	{
		return false;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private static void Activate(Transform t)
	{
	}

	[CalledBy(Type = typeof(NGUITools), Member = "Activate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "Activate")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	private static void Activate(Transform t, bool compatibilityMode)
	{
	}

	[CalledBy(Type = typeof(NGUITools), Member = "SetActiveChildren")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "BroadcastMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void Deactivate(Transform t)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 86)]
	public static void SetActive(GameObject go, bool state)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 102)]
	public static void SetActive(GameObject go, bool state, bool compatibilityMode)
	{
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CalledBy(Type = typeof(NGUITools), Member = "CallCreatePanel")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UIWidget), Member = "CreatePanel")]
	[Calls(Type = typeof(NGUITools), Member = "CallCreatePanel")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void CallCreatePanel(Transform t)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "Deactivate")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	public static void SetActiveChildren(GameObject go, bool state)
	{
	}

	[Obsolete("Use NGUITools.GetActive instead")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static bool IsActive(Behaviour mb)
	{
		return false;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static bool GetActive(Behaviour mb)
	{
		return false;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public static bool GetActive(GameObject go)
	{
		return false;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetActiveSelf(GameObject go, bool state)
	{
	}

	[CalledBy(Type = typeof(NGUITools), Member = "SetLayer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetLayer")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public static void SetLayer(GameObject go, int layer)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static Vector3 Round(Vector3 v)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(NGUITools), Member = "MakePixelPerfect")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(NGUITools), Member = "MakePixelPerfect")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 13)]
	public static void MakePixelPerfect(Transform t)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(File), Member = "Create")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(File), Member = "Delete")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static bool Save(string fileName, byte[] bytes)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(File), Member = "ReadAllBytes")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static byte[] Load(string fileName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Color ApplyPMA(Color c)
	{
		return default(Color);
	}

	[CalledBy(Type = typeof(UIDragDropItem), Member = "OnDragDropStart")]
	[CalledBy(Type = typeof(UIDragDropItem), Member = "OnDragDropRelease")]
	[CalledBy(Type = typeof(DragDropItem), Member = "OnDragDropStart")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void MarkParentAsChanged(GameObject go)
	{
	}

	[Obsolete("Use NGUIText.EncodeColor instead")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIText), Member = "EncodeColor24")]
	public static string EncodeColor(Color c)
	{
		return null;
	}

	[Obsolete("Use NGUIText.ParseColor instead")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUIText), Member = "ParseColor24")]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static T AddMissingComponent<T>(this GameObject go) where T : Component
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetSides")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static Vector3[] GetSides(this Camera cam, Transform relativeTo)
	{
		return null;
	}

	[CalledBy(Type = typeof(NGUITools), Member = "GetSides")]
	[CalledBy(Type = typeof(NGUITools), Member = "GetSides")]
	[CalledBy(Type = typeof(UIRect.AnchorPoint), Member = "GetSides")]
	[CalledBy(Type = typeof(UIRect), Member = "GetSides")]
	[CalledBy(Type = typeof(UIPanel), Member = "GetSides")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 15)]
	public static Vector3[] GetSides(this Camera cam, float depth, Transform relativeTo)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetWorldCorners")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static Vector3[] GetWorldCorners(this Camera cam)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetWorldCorners")]
	public static Vector3[] GetWorldCorners(this Camera cam, float depth)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static Vector3[] GetWorldCorners(this Camera cam, Transform relativeTo)
	{
		return null;
	}

	[CalledBy(Type = typeof(NGUITools), Member = "GetWorldCorners")]
	[CalledBy(Type = typeof(NGUITools), Member = "GetWorldCorners")]
	[CalledBy(Type = typeof(UIPanel), Member = "get_worldCorners")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NGUITools), Member = "get_screenSize")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 13)]
	public static Vector3[] GetWorldCorners(this Camera cam, float depth, Transform relativeTo)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetFuncName(object obj, string method)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public static void Execute<T>(GameObject go, string funcName) where T : Component
	{
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(NGUITools), Member = "ImmediatelyCreateDrawCalls")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	public static void ExecuteAll<T>(GameObject root, string funcName) where T : Component
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "ExecuteAll")]
	public static void ImmediatelyCreateDrawCalls(GameObject root)
	{
	}
}
