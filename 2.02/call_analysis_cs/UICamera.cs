using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UICamera : MonoBehaviour
{
	public enum ControlScheme
	{
		Mouse,
		Touch,
		Controller
	}

	public enum ClickNotification
	{
		None,
		Always,
		BasedOnDelta
	}

	public class MouseOrTouch
	{
		public Vector2 pos;

		public Vector2 lastPos;

		public Vector2 delta;

		public Vector2 totalDelta;

		public Camera pressedCam;

		public GameObject last;

		private GameObject mCurrent;

		private GameObject mPressed;

		public GameObject dragged;

		public float pressTime;

		public float clickTime;

		public ClickNotification clickNotification;

		public bool touchBegan;

		public bool pressStarted;

		public bool dragStarted;

		public GameObject current
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return null;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 41)]
			set
			{
			}
		}

		public GameObject pressed
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 3)]
			get
			{
				return null;
			}
			[CallerCount(Count = 17)]
			[DeduplicatedMethod]
			set
			{
			}
		}

		public float deltaTime
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return default(float);
			}
		}

		public bool isOverUI
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
			[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
			[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
			get
			{
				return default(bool);
			}
		}

		[CallerCount(Count = 0)]
		public MouseOrTouch()
		{
		}
	}

	public enum EventType
	{
		World_3D,
		UI_3D,
		World_2D,
		UI_2D
	}

	public delegate bool GetKeyStateFunc(KeyCode key);

	public delegate float GetAxisFunc(string name);

	public delegate void OnScreenResize();

	public delegate void OnCustomInput();

	public delegate void MoveDelegate(Vector2 delta);

	public delegate void VoidDelegate(GameObject go);

	public delegate void BoolDelegate(GameObject go, bool state);

	public delegate void FloatDelegate(GameObject go, float delta);

	public delegate void VectorDelegate(GameObject go, Vector2 delta);

	public delegate void ObjectDelegate(GameObject go, GameObject obj);

	public delegate void KeyCodeDelegate(GameObject go, KeyCode key);

	private struct DepthEntry
	{
		public int depth;

		public RaycastHit hit;

		public Vector3 point;

		public GameObject go;
	}

	public class Touch
	{
		public int fingerId;

		public TouchPhase phase;

		public Vector2 position;

		public int tapCount;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public Touch()
		{
		}
	}

	public delegate int GetTouchCountCallback();

	public delegate Touch GetTouchCallback(int index);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static BetterList<DepthEntry>.CompareFunc _003C_003E9__132_0;

		public static BetterList<DepthEntry>.CompareFunc _003C_003E9__132_1;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal int _003CRaycast_003Eb__132_0(DepthEntry r1, DepthEntry r2)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal int _003CRaycast_003Eb__132_1(DepthEntry r1, DepthEntry r2)
		{
			return default(int);
		}
	}

	public static BetterList<UICamera> list;

	public static GetKeyStateFunc GetKeyDown;

	public static GetKeyStateFunc GetKeyUp;

	public static GetKeyStateFunc GetKey;

	public static GetAxisFunc GetAxis;

	public static OnScreenResize onScreenResize;

	public EventType eventType;

	public bool eventsGoToColliders;

	public LayerMask eventReceiverMask;

	public bool debug;

	public bool useMouse;

	public bool useTouch;

	public bool allowMultiTouch;

	public bool useKeyboard;

	public bool useController;

	public bool stickyTooltip;

	public float tooltipDelay;

	public bool longPressTooltip;

	public float mouseDragThreshold;

	public float mouseClickThreshold;

	public float touchDragThreshold;

	public float touchClickThreshold;

	public float rangeDistance;

	public string scrollAxisName;

	public string verticalAxisName;

	public string secondaryVerticalAxisName;

	public string horizontalAxisName;

	public string secondaryHorizontalAxisName;

	public bool commandClick;

	public KeyCode submitKey0;

	public KeyCode submitKey1;

	public KeyCode cancelKey0;

	public KeyCode cancelKey1;

	public string submitKey;

	public string cancelKey;

	public static OnCustomInput onCustomInput;

	public static bool showTooltips;

	public static Vector2 lastTouchPosition;

	public static Vector3 lastWorldPosition;

	public static RaycastHit lastHit;

	public static UICamera current;

	public static Camera currentCamera;

	private static ControlScheme mCurrentScheme;

	public static int currentTouchID;

	public static KeyCode currentKey;

	public static MouseOrTouch currentTouch;

	public static bool inputHasFocus;

	private static GameObject mGenericHandler;

	public static GameObject fallThrough;

	public static VoidDelegate onClick;

	public static VoidDelegate onDoubleClick;

	public static BoolDelegate onHover;

	public static BoolDelegate onPress;

	public static BoolDelegate onSelect;

	public static FloatDelegate onScroll;

	public static VectorDelegate onDrag;

	public static VoidDelegate onDragStart;

	public static ObjectDelegate onDragOver;

	public static ObjectDelegate onDragOut;

	public static VoidDelegate onDragEnd;

	public static ObjectDelegate onDrop;

	public static KeyCodeDelegate onKey;

	public static BoolDelegate onTooltip;

	public static MoveDelegate onMouseMove;

	private static GameObject mCurrentSelection;

	private static MouseOrTouch[] mMouse;

	private static GameObject mHover;

	public static MouseOrTouch controller;

	public static List<MouseOrTouch> activeTouches;

	private static List<int> mTouchIDs;

	private static int mWidth;

	private static int mHeight;

	private GameObject mTooltip;

	private Camera mCam;

	private float mTooltipTime;

	private float mNextRaycast;

	public static bool isDragging;

	public static GameObject lastHoveredObject;

	private static GameObject _hoveredObject;

	private static DepthEntry mHit;

	private static BetterList<DepthEntry> mHits;

	private static Plane m2DPlane;

	private static int mNotifying;

	private static bool mUsingTouchEvents;

	public static GetTouchCountCallback GetInputTouchCount;

	public static GetTouchCallback GetInputTouch;

	public bool stickyPress
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public static ControlScheme currentScheme
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(ControlScheme);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public static Ray currentRay
	{
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(UIInput), Member = "GetCharUnderMouse")]
		[CalledBy(Type = typeof(UIDragResize), Member = "OnDrag")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(UIDragResize), Member = "OnDragStart")]
		[Calls(Type = typeof(Camera), Member = "ScreenPointToRay")]
		get
		{
			return default(Ray);
		}
	}

	public static GameObject genericEventHandler
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	private bool handlesEvents
	{
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(UICamera), Member = "LateUpdate")]
		[CalledBy(Type = typeof(UICamera), Member = "Update")]
		[CalledBy(Type = typeof(UICamera), Member = "Start")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UICamera), Member = "get_eventHandler")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public Camera cachedCamera
	{
		[CalledBy(Type = typeof(UICamera), Member = "CompareFunc")]
		[CalledBy(Type = typeof(UICamera), Member = "CompareFunc")]
		[CalledBy(Type = typeof(UICamera), Member = "CompareFunc")]
		[CalledBy(Type = typeof(UICamera), Member = "CompareFunc")]
		[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
		[CalledBy(Type = typeof(UICamera), Member = "FindCameraForLayer")]
		[CalledBy(Type = typeof(UICamera), Member = "Start")]
		[CalledBy(Type = typeof(UICamera), Member = "Start")]
		[CalledBy(Type = typeof(UICamera), Member = "Start")]
		[CalledBy(Type = typeof(UIInput), Member = "Update")]
		[CalledBy(Type = typeof(UIInput), Member = "Update")]
		[CalledBy(Type = typeof(UICamera), Member = "get_mainCamera")]
		[CalledBy(Type = typeof(UICamera), Member = "set_selectedObject")]
		[CalledBy(Type = typeof(UIKeyNavigation), Member = "GetCenter")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 16)]
		get
		{
			return null;
		}
	}

	public static GameObject hoveredObject
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
		[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
		[CalledBy(Type = typeof(UICamera), Member = "ProcessMouse")]
		[CalledBy(Type = typeof(UICamera), Member = "ProcessTouches")]
		[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
		[CalledBy(Type = typeof(UICamera), Member = "ProcessTouches")]
		[CalledBy(Type = typeof(UICamera), Member = "ProcessFakeTouches")]
		[CalledBy(Type = typeof(UICamera), Member = "ProcessFakeTouches")]
		[CalledBy(Type = typeof(UICamera), Member = "ProcessMouse")]
		[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
		[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
		[CallerCount(Count = 11)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public static bool isOverUI
	{
		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(InspectGearController), Member = "Update")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		get
		{
			return default(bool);
		}
	}

	public static GameObject selectedObject
	{
		[CalledBy(Type = typeof(UtilsPanelChoose), Member = "ProcessMenu")]
		[CalledBy(Type = typeof(UtilsPanelChoose), Member = "ProcessMenu")]
		[CalledBy(Type = typeof(UtilsPanelChoose), Member = "ProcessMenu")]
		[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
		[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
		[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(UICamera), Member = "IsHighlighted")]
		[CalledBy(Type = typeof(NGUIEventHandler), Member = "OnKeyDelegate")]
		[CalledBy(Type = typeof(UIPopupList._003CCloseIfUnselected_003Ed__94), Member = "MoveNext")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(NGUIEventHandler), Member = "OnKeyDelegate")]
		[CalledBy(Type = typeof(UIPlayAnimation), Member = "Play")]
		[CalledBy(Type = typeof(UICamera), Member = "set_selectedObject")]
		[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnEnable")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIButton), Member = "OnEnable")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(UIKeyBinding), Member = "Update")]
		[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
		[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnClick")]
		[CalledBy(Type = typeof(UIPlayAnimation), Member = "Play")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(UICamera), Member = "Update")]
		[CalledBy(Type = typeof(UICamera), Member = "ProcessPress")]
		[CalledBy(Type = typeof(UIInput), Member = "set_isSelected")]
		[CalledBy(Type = typeof(UIKeyBinding), Member = "Update")]
		[CalledBy(Type = typeof(TextInputField), Member = "Select")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
		[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
		[CalledBy(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
		[CalledBy(Type = typeof(NGUIEventHandler), Member = "OnKeyDelegate")]
		[CallsUnknownMethods(Count = 17)]
		[CalledBy(Type = typeof(UIInput), Member = "set_isSelected")]
		[CalledBy(Type = typeof(TextInputField), Member = "Update")]
		[Calls(Type = typeof(UICamera), Member = "Notify")]
		[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 18)]
		[CallsDeduplicatedMethods(Count = 5)]
		[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
		[Calls(Type = typeof(UICamera), Member = "Notify")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(GameObject), Member = "get_layer")]
		[Calls(Type = typeof(UICamera), Member = "FindCameraForLayer")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		set
		{
		}
	}

	public static int touchCount
	{
		[CallerCount(Count = 0)]
		[CallAnalysisFailed]
		get
		{
			return default(int);
		}
	}

	public static int dragCount
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsUnknownMethods(Count = 9)]
		get
		{
			return default(int);
		}
	}

	public static Camera mainCamera
	{
		[CalledBy(Type = typeof(DragDropItem), Member = "OnDragDropMove")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
		[CalledBy(Type = typeof(UICamera), Member = "SetSchemeOverride")]
		[CalledBy(Type = typeof(UICamera), Member = "SetSchemeOverride")]
		[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UICamera), Member = "get_eventHandler")]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
	}

	public static UICamera eventHandler
	{
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(NGUITools), Member = "GetActive")]
		[CalledBy(Type = typeof(UICamera), Member = "get_handlesEvents")]
		[CalledBy(Type = typeof(UICamera), Member = "get_mainCamera")]
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 3)]
		get
		{
			return null;
		}
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(UIWrapContent), Member = "WrapContent")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(UIWrapContent), Member = "WrapContent")]
	public static bool IsPressed(GameObject go)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UIButtonColor), Member = "OnSelect")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public static int CountInputSources()
	{
		return default(int);
	}

	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	private static int CompareFunc(UICamera a, UICamera b)
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private static Rigidbody FindRootRigidbody(Transform trans)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private static Rigidbody2D FindRootRigidbody2D(Transform trans)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UICamera), Member = "IsVisible")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UIWidget), Member = "get_isVisible")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UICamera), Member = "set_hoveredObject")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UICamera), Member = "FindRootRigidbody2D")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Physics), Member = "RaycastAll")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIWidget), Member = "get_isVisible")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessFakeTouches")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UICamera), Member = "IsVisible")]
	[Calls(Type = typeof(Physics), Member = "Raycast")]
	[Calls(Type = typeof(UICamera), Member = "set_hoveredObject")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UICamera), Member = "set_hoveredObject")]
	[Calls(Type = typeof(Physics2D), Member = "OverlapPoint")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UICamera), Member = "set_hoveredObject")]
	[Calls(Type = typeof(UICamera), Member = "FindRootRigidbody")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessMouse")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessTouches")]
	[CallsUnknownMethods(Count = 47)]
	[Calls(Type = typeof(NGUITools), Member = "CalculateRaycastDepth")]
	[Calls(Type = typeof(Vector2), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Plane), Member = "Raycast")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 26)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[Calls(Type = typeof(Camera), Member = "ScreenToViewportPoint")]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay")]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask")]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane")]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane")]
	[Calls(Type = typeof(Plane), Member = "Raycast")]
	[Calls(Type = typeof(Ray), Member = "GetPoint")]
	[Calls(Type = typeof(Ray), Member = "GetPoint")]
	[Calls(Type = typeof(Physics2D), Member = "OverlapPointAll")]
	[Calls(Type = typeof(UICamera), Member = "IsVisible")]
	[Calls(Type = typeof(NGUITools), Member = "CalculateRaycastDepth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIWidget), Member = "get_isVisible")]
	[Calls(Type = typeof(UICamera), Member = "IsVisible")]
	[Calls(Type = typeof(UIWidget), Member = "get_isVisible")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "set_hoveredObject")]
	[Calls(Type = typeof(Vector2), Member = "op_Implicit")]
	public static bool Raycast(Vector3 inPos)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
	[Calls(Type = typeof(UIPanel), Member = "IsVisible")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
	private static bool IsVisible(Vector3 worldPoint, GameObject go)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIPanel), Member = "IsVisible")]
	[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
	private static bool IsVisible(ref DepthEntry de)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnPress")]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnPress")]
	[CalledBy(Type = typeof(UIImageButton), Member = "UpdateImage")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnPress")]
	[CalledBy(Type = typeof(UIButtonColor), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static bool IsHighlighted(GameObject go)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(UICamera), Member = "set_selectedObject")]
	[CalledBy(Type = typeof(NGUITools), Member = "AddWidgetCollider")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "GetCenter")]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[CallerCount(Count = 4)]
	public static UICamera FindCameraForLayer(int layer)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private static int GetDirection(KeyCode up, KeyCode down)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private static int GetDirection(KeyCode up0, KeyCode up1, KeyCode down0, KeyCode down1)
	{
		return default(int);
	}

	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallerCount(Count = 27)]
	public static void Notify(GameObject go, string funcName, object obj)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public static MouseOrTouch GetMouse(int button)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 20)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessTouches")]
	public static MouseOrTouch GetTouch(int id)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessFakeTouches")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessTouches")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	public static void RemoveTouch(int id)
	{
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 29)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(NGUIDebug), Member = "CreateInstance")]
	[Calls(Type = typeof(UICamera), Member = "get_handlesEvents")]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	private void Start()
	{
	}

	[Calls(Type = typeof(UICamera), Member = "ProcessTouches")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UICamera), Member = "get_handlesEvents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "ProcessMouse")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GetAxisFunc), Member = "Invoke")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(UICamera), Member = "ShowTooltip")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UIRoot), Member = "Broadcast")]
	[Calls(Type = typeof(UICamera), Member = "get_handlesEvents")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void LateUpdate()
	{
	}

	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown")]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonUp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[Calls(Type = typeof(UICamera), Member = "ProcessTouch")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[CalledBy(Type = typeof(UICamera), Member = "Update")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessTouches")]
	[CallsUnknownMethods(Count = 79)]
	[Calls(Type = typeof(UICamera), Member = "ShowTooltip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "ShowTooltip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UICamera), Member = "set_hoveredObject")]
	[Calls(Type = typeof(UICamera), Member = "Raycast")]
	[Calls(Type = typeof(Input), Member = "GetMouseButton")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UICamera), Member = "set_hoveredObject")]
	public void ProcessMouse()
	{
	}

	[Calls(Type = typeof(UICamera), Member = "set_hoveredObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UICamera), Member = "set_hoveredObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "ProcessTouch")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "Raycast")]
	[CalledBy(Type = typeof(UICamera), Member = "Update")]
	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(UICamera), Member = "RemoveTouch")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(UICamera), Member = "ProcessMouse")]
	[Calls(Type = typeof(Input), Member = "GetTouch")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UICamera), Member = "GetTouch")]
	public void ProcessTouches()
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(UICamera), Member = "RemoveTouch")]
	[Calls(Type = typeof(UICamera), Member = "ProcessTouch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "set_hoveredObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UICamera), Member = "Raycast")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UICamera), Member = "set_hoveredObject")]
	[CallerCount(Count = 0)]
	private void ProcessFakeTouches()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void ProcessOthers()
	{
	}

	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "ShowTooltip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsUnknownMethods(Count = 55)]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "ShowTooltip")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessTouch")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessTouch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[Calls(Type = typeof(UICamera), Member = "ShowTooltip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void ProcessPress(bool pressed, float click, float drag)
	{
	}

	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessTouch")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessTouch")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void ProcessRelease(bool isMouse, float drag)
	{
	}

	[CalledBy(Type = typeof(UICamera), Member = "ProcessFakeTouches")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessTouches")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessMouse")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[Calls(Type = typeof(UICamera), Member = "ShowTooltip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UICamera), Member = "ProcessPress")]
	[Calls(Type = typeof(UICamera), Member = "ProcessRelease")]
	[Calls(Type = typeof(UICamera), Member = "ProcessRelease")]
	[Calls(Type = typeof(UICamera), Member = "ProcessPress")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void ProcessTouch(bool pressed, bool released)
	{
	}

	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessMouse")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessMouse")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessPress")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessPress")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessPress")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessTouch")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(UICamera), Member = "Update")]
	[CallerCount(Count = 7)]
	public void ShowTooltip(bool val)
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeSetGamepadActive")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeSetMouseOrKeyboardActive")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeSetMouseOrKeyboardActive")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeSetMouseOrKeyboardActive")]
	[CalledBy(Type = typeof(InputManager), Member = "SetGamepadEnabled")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UICamera), Member = "get_mainCamera")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UICamera), Member = "get_mainCamera")]
	[Calls(Type = typeof(UIRoot), Member = "Broadcast")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static void SetSchemeOverride(ControlScheme newScheme)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public UICamera()
	{
	}
}
