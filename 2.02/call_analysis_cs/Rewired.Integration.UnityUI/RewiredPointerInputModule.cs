using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using Rewired.UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI;

public abstract class RewiredPointerInputModule : BaseInputModule
{
	protected class MouseState
	{
		private List<ButtonState> m_TrackedButtons;

		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		public bool AnyPressesThisFrame()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsUnknownMethods(Count = 3)]
		public bool AnyReleasesThisFrame()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 18)]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 12)]
		[CalledBy(Type = typeof(MouseState), Member = "SetButtonState")]
		public ButtonState GetButtonState(int button)
		{
			return null;
		}

		[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data)
		{
		}

		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 1)]
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
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool ReleasedThisFrame()
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 71)]
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
				return default(int);
			}
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			set
			{
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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
				return default(int);
			}
		}

		private int Rewired_002EUI_002EITouchInputSource_002EplayerId
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			get
			{
				return default(int);
			}
		}

		private bool Rewired_002EUI_002EIMouseInputSource_002Eenabled
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			get
			{
				return default(bool);
			}
		}

		private bool Rewired_002EUI_002EIMouseInputSource_002Elocked
		{
			[CallsUnknownMethods(Count = 1)]
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallerCount(Count = 0)]
			get
			{
				return default(bool);
			}
		}

		private int Rewired_002EUI_002EIMouseInputSource_002EbuttonCount
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			get
			{
				return default(int);
			}
		}

		private Vector2 Rewired_002EUI_002EIMouseInputSource_002EscreenPosition
		{
			[CallsUnknownMethods(Count = 1)]
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			get
			{
				return default(Vector2);
			}
		}

		private Vector2 Rewired_002EUI_002EIMouseInputSource_002EscreenPositionDelta
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			get
			{
				return default(Vector2);
			}
		}

		private Vector2 Rewired_002EUI_002EIMouseInputSource_002EwheelDelta
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return default(Vector2);
			}
		}

		private bool Rewired_002EUI_002EITouchInputSource_002EtouchSupported
		{
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return default(bool);
			}
		}

		private int Rewired_002EUI_002EITouchInputSource_002EtouchCount
		{
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return default(int);
			}
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
		[CallsUnknownMethods(Count = 1)]
		private bool Rewired_002EUI_002EIMouseInputSource_002EGetButtonDown(int button)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
		[CallsUnknownMethods(Count = 1)]
		private bool Rewired_002EUI_002EIMouseInputSource_002EGetButtonUp(int button)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
		[CallsUnknownMethods(Count = 1)]
		private bool Rewired_002EUI_002EIMouseInputSource_002EGetButton(int button)
		{
			return default(bool);
		}

		[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "GetTouch")]
		private Touch Rewired_002EUI_002EITouchInputSource_002EGetTouch(int index)
		{
			return default(Touch);
		}

		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_wheelDelta")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_screenPositionDelta")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.ITouchInputSource.get_touchSupported")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_screenPosition")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.ITouchInputSource.GetTouch")]
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.ITouchInputSource.get_touchCount")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.GetButton")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.GetButtonDown")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_buttonCount")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_locked")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_enabled")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.ITouchInputSource.get_playerId")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_playerId")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.GetButtonUp")]
		[CallerCount(Count = 14)]
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
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ShouldActivateModule")]
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchEvents")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchEvents")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchEvents")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchEvents")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ShouldActivateModule")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ShouldActivateModule")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Awake")]
		[CallerCount(Count = 15)]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "get_isMouseSupported")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetTouchInputSource")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "IsDefaultMouse")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "get_defaultTouchInputSource")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "get_defaultMouseInputSource")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "get_isMouseSupported")]
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
		[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	protected virtual bool isMouseSupported
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	protected bool IsDefaultMouse(IMouseInputSource mouse)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "ProcessDrag")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "GetMouseButtonDownOnAnyMouse")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "DidAnyMouseMove")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMousePress")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "StateForMouseButton")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "ProcessMove")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "CreatePointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveMouseInputSource(IMouseInputSource source)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "SetUpRewiredPlayerMice")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "SetupRewiredVars")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	public void AddMouseInputSource(IMouseInputSource source)
	{
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "GetMouseButtonDownOnAnyMouse")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvents")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "DidAnyMouseMove")]
	[CallsUnknownMethods(Count = 5)]
	public int GetMouseInputSourceCount(int playerId)
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "CreatePointerEventData")]
	public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void RemoveTouchInputSource(ITouchInputSource source)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	public void AddTouchInputSource(ITouchInputSource source)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetTouchInputSourceCount(int playerId)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "OnRewiredShutDown")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ClearRewiredVars")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "SetUpRewiredPlayerMice")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "OnEditorRecompile")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "SetupRewiredVars")]
	protected void ClearMouseInputSources()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract bool IsDefaultPlayer(int playerId);

	[CallsUnknownMethods(Count = 46)]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetLastPointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetTouchInputSource")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetTouchPointerEventData")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "CreatePointerEventData")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType)
	{
		data = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetTouchInputSource")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PointerEventData), Member = ".ctor")]
	private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchEvents")]
	[CallsUnknownMethods(Count = 4)]
	protected void RemovePointerData(PlayerPointerEventData data)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchEvents")]
	[Calls(Type = typeof(BaseInputModule), Member = "FindFirstRaycast")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(EventSystem), Member = "RaycastAll")]
	protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref pressed) = null;
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref released) = null;
		return null;
	}

	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "StateForMouseButton")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "StateForMouseButton")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "StateForMouseButton")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "StateForMouseButton")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BaseInputModule), Member = "FindFirstRaycast")]
	[Calls(Type = typeof(EventSystem), Member = "RaycastAll")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	protected virtual MouseState GetMousePointerEventData(int playerId, int mouseIndex)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[CallsUnknownMethods(Count = 5)]
	protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void ProcessMove(PlayerPointerEventData pointerEvent)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress")]
	[CallsUnknownMethods(Count = 7)]
	protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 7)]
	public override bool IsPointerOverGameObject(int pointerTypeId)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "DeactivateModule")]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject")]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	protected void ClearSelection()
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public override string ToString()
	{
		return null;
	}

	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	protected void CopyFromTo(PointerEventData from, PointerEventData to)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CallsUnknownMethods(Count = 2)]
	protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId)
	{
		return default(PointerEventData.FramePressState);
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = ".ctor")]
	[Calls(Type = typeof(BaseInputModule), Member = ".ctor")]
	[Calls(Type = typeof(MouseState), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	protected RewiredPointerInputModule()
	{
	}
}
