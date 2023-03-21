using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using Rewired.UI;
using Rewired.Utils;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI;

public abstract class RewiredPointerInputModule : BaseInputModule
{
	protected class MouseState
	{
		private List<ButtonState> m_TrackedButtons;

		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public bool AnyPressesThisFrame()
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public bool AnyReleasesThisFrame()
		{
			return false;
		}

		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
		[CalledBy(Type = typeof(MouseState), Member = "SetButtonState")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(List<>), Member = "Add")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 18)]
		public ButtonState GetButtonState(int button)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
		[CallsUnknownMethods(Count = 1)]
		public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data)
		{
		}

		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = ".ctor")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(List<>), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public MouseState()
		{
		}
	}

	public class MouseButtonEventData
	{
		public PointerEventData.FramePressState buttonState;

		public PlayerPointerEventData buttonData;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool PressedThisFrame()
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool ReleasedThisFrame()
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public MouseButtonEventData()
		{
		}
	}

	protected class ButtonState
	{
		private int m_Button;

		private MouseButtonEventData m_EventData;

		public MouseButtonEventData eventData
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 77)]
			set
			{
			}
		}

		public int button
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			get
			{
				return 0;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public ButtonState()
		{
		}
	}

	private sealed class UnityInputSource : IMouseInputSource, ITouchInputSource
	{
		private Vector2 m_MousePosition;

		private Vector2 m_MousePositionPrev;

		private int m_LastUpdatedFrame;

		private int Rewired_002EUI_002EIMouseInputSource_002EplayerId
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			get
			{
				return 0;
			}
		}

		private int Rewired_002EUI_002EITouchInputSource_002EplayerId
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			get
			{
				return 0;
			}
		}

		private bool Rewired_002EUI_002EIMouseInputSource_002Eenabled
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			get
			{
				return false;
			}
		}

		private bool Rewired_002EUI_002EIMouseInputSource_002Elocked
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return false;
			}
		}

		private int Rewired_002EUI_002EIMouseInputSource_002EbuttonCount
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			get
			{
				return 0;
			}
		}

		private Vector2 Rewired_002EUI_002EIMouseInputSource_002EscreenPosition
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return default(Vector2);
			}
		}

		private Vector2 Rewired_002EUI_002EIMouseInputSource_002EscreenPositionDelta
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			[CallsDeduplicatedMethods(Count = 1)]
			get
			{
				return default(Vector2);
			}
		}

		private Vector2 Rewired_002EUI_002EIMouseInputSource_002EwheelDelta
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return default(Vector2);
			}
		}

		private bool Rewired_002EUI_002EITouchInputSource_002EtouchSupported
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return false;
			}
		}

		private int Rewired_002EUI_002EITouchInputSource_002EtouchCount
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return 0;
			}
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
		[CallsUnknownMethods(Count = 1)]
		private bool Rewired_002EUI_002EIMouseInputSource_002EGetButtonDown(int button)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
		[CallsUnknownMethods(Count = 1)]
		private bool Rewired_002EUI_002EIMouseInputSource_002EGetButtonUp(int button)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
		[CallsUnknownMethods(Count = 1)]
		private bool Rewired_002EUI_002EIMouseInputSource_002EGetButton(int button)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
		[Calls(Type = typeof(Input), Member = "GetTouch")]
		private Touch Rewired_002EUI_002EITouchInputSource_002EGetTouch(int index)
		{
			return default(Touch);
		}

		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_playerId")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.ITouchInputSource.get_playerId")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_enabled")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_locked")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_buttonCount")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.GetButtonDown")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.GetButtonUp")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.GetButton")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_screenPosition")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_screenPositionDelta")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_wheelDelta")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.ITouchInputSource.get_touchSupported")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.ITouchInputSource.get_touchCount")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.ITouchInputSource.GetTouch")]
		[CallerCount(Count = 14)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		private void TryUpdate()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public UnityInputSource()
		{
		}
	}

	public const int kMouseLeftId = -1;

	public const int kMouseRightId = -2;

	public const int kMouseMiddleId = -3;

	public const int kFakeTouchesId = -4;

	private const int customButtonsStartingId = -2147483520;

	private const int customButtonsMaxCount = 128;

	private const int customButtonsLastId = -2147483392;

	private readonly List<IMouseInputSource> m_MouseInputSourcesList;

	private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData;

	private ITouchInputSource m_UserDefaultTouchInputSource;

	private UnityInputSource __m_DefaultInputSource;

	private readonly MouseState m_MouseState;

	private UnityInputSource defaultInputSource
	{
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "get_defaultMouseInputSource")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "get_defaultTouchInputSource")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "IsDefaultMouse")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetTouchInputSource")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "get_isMouseSupported")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "get_isMouseSupported")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Awake")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ShouldActivateModule")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchEvents")]
		[CallerCount(Count = 15)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	private IMouseInputSource defaultMouseInputSource
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
		get
		{
			return null;
		}
	}

	protected ITouchInputSource defaultTouchInputSource
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
		get
		{
			return null;
		}
	}

	protected virtual bool isMouseSupported
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return false;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	protected bool IsDefaultMouse(IMouseInputSource mouse)
	{
		return false;
	}

	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "CreatePointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "ProcessMove")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "ProcessDrag")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "StateForMouseButton")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMousePress")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "DidAnyMouseMove")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "GetMouseButtonDownOnAnyMouse")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[Calls(Type = typeof(UnityTools), Member = "IsNullOrDestroyed")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveMouseInputSource(IMouseInputSource source)
	{
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "SetupRewiredVars")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "SetUpRewiredPlayerMice")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityTools), Member = "IsNullOrDestroyed")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void AddMouseInputSource(IMouseInputSource source)
	{
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvents")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "DidAnyMouseMove")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "GetMouseButtonDownOnAnyMouse")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityTools), Member = "IsNullOrDestroyed")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public int GetMouseInputSourceCount(int playerId)
	{
		return 0;
	}

	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "CreatePointerEventData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityTools), Member = "IsNullOrDestroyed")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[CallsDeduplicatedMethods(Count = 1)]
	public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveTouchInputSource(ITouchInputSource source)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityTools), Member = "IsNullOrDestroyed")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AddTouchInputSource(ITouchInputSource source)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetTouchInputSourceCount(int playerId)
	{
		return 0;
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "SetupRewiredVars")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "SetUpRewiredPlayerMice")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "OnEditorRecompile")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ClearRewiredVars")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "OnRewiredShutDown")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void ClearMouseInputSources()
	{
	}

	protected abstract bool IsDefaultPlayer(int playerId);

	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetTouchPointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetLastPointerEventData")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetTouchInputSource")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "CreatePointerEventData")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 46)]
	protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType)
	{
		data = null;
		return false;
	}

	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PointerEventData), Member = ".ctor")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetTouchInputSource")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType)
	{
		return null;
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchEvents")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	protected void RemovePointerData(PlayerPointerEventData data)
	{
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchEvents")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(EventSystem), Member = "RaycastAll")]
	[Calls(Type = typeof(BaseInputModule), Member = "FindFirstRaycast")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released)
	{
		pressed = default(bool);
		released = default(bool);
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(EventSystem), Member = "RaycastAll")]
	[Calls(Type = typeof(BaseInputModule), Member = "FindFirstRaycast")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "StateForMouseButton")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 37)]
	protected virtual MouseState GetMousePointerEventData(int playerId, int mouseIndex)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	protected virtual void ProcessMove(PlayerPointerEventData pointerEvent)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public override bool IsPointerOverGameObject(int pointerTypeId)
	{
		return false;
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "DeactivateModule")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	protected void ClearSelection()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	public override string ToString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	protected void CopyFromTo(PointerEventData from, PointerEventData to)
	{
	}

	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId)
	{
		return default(PointerEventData.FramePressState);
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(MouseState), Member = ".ctor")]
	[Calls(Type = typeof(BaseInputModule), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	protected RewiredPointerInputModule()
	{
	}
}
