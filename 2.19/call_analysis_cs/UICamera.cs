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
			[CallerCount(Count = 4)]
			get
			{
				return null;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 70)]
			set
			{
			}
		}

		public GameObject pressed
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 11)]
			get
			{
				return null;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 26)]
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
				return 0f;
			}
		}

		public bool isOverUI
		{
			[CalledBy(Type = typeof(UICamera), Member = "get_isOverUI")]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return false;
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
		[CallerCount(Count = 6)]
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
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal int _003CRaycast_003Eb__132_0(DepthEntry r1, DepthEntry r2)
		{
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal int _003CRaycast_003Eb__132_1(DepthEntry r1, DepthEntry r2)
		{
			return 0;
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public static ControlScheme currentScheme
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(ControlScheme);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		set
		{
		}
	}

	public static Ray currentRay
	{
		[CalledBy(Type = typeof(UIDragResize), Member = "OnDragStart")]
		[CalledBy(Type = typeof(UIDragResize), Member = "OnDrag")]
		[CalledBy(Type = typeof(UIInput), Member = "GetCharUnderMouse")]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(Ray);
		}
	}

	public static GameObject genericEventHandler
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	private bool handlesEvents
	{
		[CalledBy(Type = typeof(UICamera), Member = "Start")]
		[CalledBy(Type = typeof(UICamera), Member = "Update")]
		[CalledBy(Type = typeof(UICamera), Member = "LateUpdate")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UICamera), Member = "get_eventHandler")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public Camera cachedCamera
	{
		[CalledBy(Type = typeof(UIKeyNavigation), Member = "GetCenter")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
		[CalledBy(Type = typeof(UICamera), Member = "set_selectedObject")]
		[CalledBy(Type = typeof(UICamera), Member = "get_mainCamera")]
		[CalledBy(Type = typeof(UICamera), Member = "CompareFunc")]
		[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
		[CalledBy(Type = typeof(UICamera), Member = "FindCameraForLayer")]
		[CalledBy(Type = typeof(UICamera), Member = "Start")]
		[CalledBy(Type = typeof(UIInput), Member = "Update")]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		get
		{
			return null;
		}
	}

	public static GameObject hoveredObject
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
		[CalledBy(Type = typeof(UICamera), Member = "ProcessMouse")]
		[CalledBy(Type = typeof(UICamera), Member = "ProcessTouches")]
		[CalledBy(Type = typeof(UICamera), Member = "ProcessFakeTouches")]
		[CallerCount(Count = 11)]
		set
		{
		}
	}

	public static bool isOverUI
	{
		[CalledBy(Type = typeof(InspectGearController), Member = "Update")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
		[Calls(Type = typeof(MouseOrTouch), Member = "get_isOverUI")]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return false;
		}
	}

	public static GameObject selectedObject
	{
		[CalledBy(Type = typeof(UIButton), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIPlayAnimation), Member = "Play")]
		[CalledBy(TypeFullName = "UIPopupList.<CloseIfUnselected>d__94", Member = "MoveNext")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(UICamera), Member = "set_selectedObject")]
		[CalledBy(Type = typeof(UICamera), Member = "IsHighlighted")]
		[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
		[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
		[CalledBy(Type = typeof(UtilsPanelChoose), Member = "ProcessMenu")]
		[CalledBy(Type = typeof(NGUIEventHandler), Member = "OnKeyDelegate")]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(ChatInput), Member = "OnSubmit")]
		[CalledBy(Type = typeof(UIKeyBinding), Member = "Update")]
		[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnEnable")]
		[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
		[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnClick")]
		[CalledBy(Type = typeof(UIPlayAnimation), Member = "Play")]
		[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
		[CalledBy(Type = typeof(UICamera), Member = "Update")]
		[CalledBy(Type = typeof(UICamera), Member = "ProcessPress")]
		[CalledBy(Type = typeof(UIInput), Member = "set_isSelected")]
		[CalledBy(Type = typeof(UIInput), Member = "RemoveFocus")]
		[CalledBy(Type = typeof(TextInputField), Member = "Update")]
		[CalledBy(Type = typeof(TextInputField), Member = "Select")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
		[CalledBy(Type = typeof(Panel_FeedFire), Member = "ShowTab")]
		[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
		[CalledBy(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
		[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetCommunicationButtonsFocus")]
		[CalledBy(Type = typeof(NGUIEventHandler), Member = "OnKeyDelegate")]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
		[Calls(Type = typeof(UICamera), Member = "Notify")]
		[Calls(Type = typeof(GameObject), Member = "get_layer")]
		[Calls(Type = typeof(UICamera), Member = "FindCameraForLayer")]
		[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
		[Calls(Type = typeof(GameObject), Member = "GetComponent")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		set
		{
		}
	}

	public static int touchCount
	{
		[CallAnalysisFailed]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
	}

	public static int dragCount
	{
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0;
		}
	}

	public static Camera mainCamera
	{
		[CalledBy(Type = typeof(UICamera), Member = "SetSchemeOverride")]
		[CalledBy(Type = typeof(DragDropItem), Member = "OnDragDropMove")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(UICamera), Member = "get_eventHandler")]
		[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
		get
		{
			return null;
		}
	}

	public static UICamera eventHandler
	{
		[CalledBy(Type = typeof(UICamera), Member = "get_handlesEvents")]
		[CalledBy(Type = typeof(UICamera), Member = "get_mainCamera")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(NGUITools), Member = "GetActive")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(UIWrapContent), Member = "WrapContent")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsPressed(GameObject go)
	{
		return false;
	}

	[CalledBy(Type = typeof(UIButtonColor), Member = "OnSelect")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static int CountInputSources()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private static int CompareFunc(UICamera a, UICamera b)
	{
		return 0;
	}

	[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static Rigidbody FindRootRigidbody(Transform trans)
	{
		return null;
	}

	[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static Rigidbody2D FindRootRigidbody2D(Transform trans)
	{
		return null;
	}

	[CalledBy(Type = typeof(UICamera), Member = "ProcessMouse")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessTouches")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessFakeTouches")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay")]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask")]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane")]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane")]
	[Calls(Type = typeof(Plane), Member = "Raycast")]
	[Calls(Type = typeof(Physics2D), Member = "OverlapPointAll")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[Calls(Type = typeof(UIWidget), Member = "get_isVisible")]
	[Calls(Type = typeof(UICamera), Member = "IsVisible")]
	[Calls(Type = typeof(UICamera), Member = "set_hoveredObject")]
	[Calls(Type = typeof(NGUITools), Member = "CalculateRaycastDepth")]
	[Calls(Type = typeof(UICamera), Member = "IsVisible")]
	[Calls(Type = typeof(Physics2D), Member = "OverlapPoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UICamera), Member = "FindRootRigidbody2D")]
	[Calls(Type = typeof(Physics), Member = "RaycastAll")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Physics), Member = "Raycast")]
	[Calls(Type = typeof(UICamera), Member = "FindRootRigidbody")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 21)]
	public static bool Raycast(Vector3 inPos)
	{
		return false;
	}

	[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[Calls(Type = typeof(UIPanel), Member = "IsVisible")]
	private static bool IsVisible(Vector3 worldPoint, GameObject go)
	{
		return false;
	}

	[CalledBy(Type = typeof(UICamera), Member = "Raycast")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[Calls(Type = typeof(UIPanel), Member = "IsVisible")]
	private static bool IsVisible(ref DepthEntry de)
	{
		return false;
	}

	[CalledBy(Type = typeof(UIButtonColor), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnPress")]
	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnPress")]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnPress")]
	[CalledBy(Type = typeof(UIImageButton), Member = "UpdateImage")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnEnable")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsHighlighted(GameObject go)
	{
		return false;
	}

	[CalledBy(Type = typeof(UIKeyNavigation), Member = "GetCenter")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(NGUITools), Member = "AddWidgetCollider")]
	[CalledBy(Type = typeof(UICamera), Member = "set_selectedObject")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask")]
	[CallsUnknownMethods(Count = 2)]
	public static UICamera FindCameraForLayer(int layer)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static int GetDirection(KeyCode up, KeyCode down)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private static int GetDirection(KeyCode up0, KeyCode up1, KeyCode down0, KeyCode down1)
	{
		return 0;
	}

	[CalledBy(Type = typeof(UIDragDropItem), Member = "StartDragging")]
	[CalledBy(Type = typeof(UIKeyBinding), Member = "OnBindingPress")]
	[CalledBy(Type = typeof(UIKeyBinding), Member = "OnBindingClick")]
	[CalledBy(Type = typeof(UICamera), Member = "set_selectedObject")]
	[CalledBy(Type = typeof(UICamera), Member = "Update")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessMouse")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessTouches")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessPress")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessRelease")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessTouch")]
	[CalledBy(Type = typeof(UICamera), Member = "ShowTooltip")]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsUnknownMethods(Count = 1)]
	public static void Notify(GameObject go, string funcName, object obj)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static MouseOrTouch GetMouse(int button)
	{
		return null;
	}

	[CalledBy(Type = typeof(UICamera), Member = "ProcessTouches")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static MouseOrTouch GetTouch(int id)
	{
		return null;
	}

	[CalledBy(Type = typeof(UICamera), Member = "ProcessTouches")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessFakeTouches")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public static void RemoveTouch(int id)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BetterList<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BetterList<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
	[Calls(Type = typeof(UICamera), Member = "get_handlesEvents")]
	[Calls(Type = typeof(NGUIDebug), Member = "CreateInstance")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 8)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UICamera), Member = "get_handlesEvents")]
	[Calls(Type = typeof(UICamera), Member = "ProcessMouse")]
	[Calls(Type = typeof(UICamera), Member = "ProcessTouches")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[Calls(Type = typeof(UICamera), Member = "ShowTooltip")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UICamera), Member = "get_handlesEvents")]
	[Calls(Type = typeof(UIRoot), Member = "Broadcast")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(UICamera), Member = "Update")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessTouches")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Input), Member = "GetMouseButton")]
	[Calls(Type = typeof(UICamera), Member = "Raycast")]
	[Calls(Type = typeof(UICamera), Member = "set_hoveredObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "ShowTooltip")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[Calls(Type = typeof(UICamera), Member = "ProcessTouch")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 15)]
	public void ProcessMouse()
	{
	}

	[CalledBy(Type = typeof(UICamera), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Input), Member = "GetTouch")]
	[Calls(Type = typeof(UICamera), Member = "GetTouch")]
	[Calls(Type = typeof(UICamera), Member = "Raycast")]
	[Calls(Type = typeof(UICamera), Member = "set_hoveredObject")]
	[Calls(Type = typeof(UICamera), Member = "ProcessTouch")]
	[Calls(Type = typeof(UICamera), Member = "RemoveTouch")]
	[Calls(Type = typeof(UICamera), Member = "ProcessMouse")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	public void ProcessTouches()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UICamera), Member = "Raycast")]
	[Calls(Type = typeof(UICamera), Member = "set_hoveredObject")]
	[Calls(Type = typeof(UICamera), Member = "ProcessTouch")]
	[Calls(Type = typeof(UICamera), Member = "RemoveTouch")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private void ProcessFakeTouches()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void ProcessOthers()
	{
	}

	[CalledBy(Type = typeof(UICamera), Member = "ProcessTouch")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[Calls(Type = typeof(UICamera), Member = "ShowTooltip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 4)]
	private void ProcessPress(bool pressed, float click, float drag)
	{
	}

	[CalledBy(Type = typeof(UICamera), Member = "ProcessTouch")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 4)]
	private void ProcessRelease(bool isMouse, float drag)
	{
	}

	[CalledBy(Type = typeof(UICamera), Member = "ProcessMouse")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessTouches")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessFakeTouches")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UICamera), Member = "ProcessRelease")]
	[Calls(Type = typeof(UICamera), Member = "ProcessPress")]
	[Calls(Type = typeof(UICamera), Member = "ShowTooltip")]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void ProcessTouch(bool pressed, bool released)
	{
	}

	[CalledBy(Type = typeof(UICamera), Member = "Update")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessMouse")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessPress")]
	[CalledBy(Type = typeof(UICamera), Member = "ProcessTouch")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ShowTooltip(bool val)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CalledBy(Type = typeof(InputManager), Member = "SetGamepadEnabled")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeSetGamepadActive")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeSetMouseOrKeyboardActive")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UIRoot), Member = "Broadcast")]
	[Calls(Type = typeof(UICamera), Member = "get_mainCamera")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetSchemeOverride(ControlScheme newScheme)
	{
	}

	[CallerCount(Count = 0)]
	public UICamera()
	{
	}
}
