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

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsUnknownMethods(Count = 2)]
		public bool AnyPressesThisFrame()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsUnknownMethods(Count = 2)]
		public bool AnyReleasesThisFrame()
		{
			return default(bool);
		}

		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
		[CallsUnknownMethods(Count = 13)]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
		[CalledBy(Type = typeof(MouseState), Member = "SetButtonState")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 12)]
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

		[CallsUnknownMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallerCount(Count = 6)]
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
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 85)]
			set
			{
			}
		}

		public int button
		{
			[CallerCount(Count = 14)]
			[DeduplicatedMethod]
			get
			{
				return default(int);
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			[CallerCount(Count = 0)]
			get
			{
				return default(bool);
			}
		}

		private bool Rewired_002EUI_002EIMouseInputSource_002Elocked
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			[CallsUnknownMethods(Count = 1)]
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
			[CallsDeduplicatedMethods(Count = 1)]
			get
			{
				return default(Vector2);
			}
		}

		private Vector2 Rewired_002EUI_002EIMouseInputSource_002EscreenPositionDelta
		{
			[CallerCount(Count = 0)]
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
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return default(bool);
			}
		}

		private int Rewired_002EUI_002EITouchInputSource_002EtouchCount
		{
			[CallsUnknownMethods(Count = 1)]
			[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
			[CallerCount(Count = 0)]
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

		[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		private bool Rewired_002EUI_002EIMouseInputSource_002EGetButtonUp(int button)
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
		private bool Rewired_002EUI_002EIMouseInputSource_002EGetButton(int button)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityInputSource), Member = "TryUpdate")]
		[Calls(Type = typeof(Input), Member = "GetTouch")]
		private Touch Rewired_002EUI_002EITouchInputSource_002EGetTouch(int index)
		{
			return default(Touch);
		}

		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.ITouchInputSource.GetTouch")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.ITouchInputSource.get_touchCount")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.ITouchInputSource.get_touchSupported")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_wheelDelta")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_screenPositionDelta")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_screenPosition")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.GetButton")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_locked")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.GetButtonDown")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_buttonCount")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.GetButtonUp")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_enabled")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.ITouchInputSource.get_playerId")]
		[CalledBy(Type = typeof(UnityInputSource), Member = "Rewired.UI.IMouseInputSource.get_playerId")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 14)]
		private void TryUpdate()
		{
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ShouldActivateModule")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ShouldActivateModule")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Awake")]
		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchEvents")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchEvents")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "get_isMouseSupported")]
		[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchEvents")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "get_isMouseSupported")]
		[CallerCount(Count = 15)]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "get_defaultMouseInputSource")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "get_defaultTouchInputSource")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetTouchInputSource")]
		[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "IsDefaultMouse")]
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
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
		get
		{
			return default(bool);
		}
	}

	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[CallerCount(Count = 0)]
	protected bool IsDefaultMouse(IMouseInputSource mouse)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "GetMouseButtonDownOnAnyMouse")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "DidAnyMouseMove")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMousePress")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ShouldActivateModule")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ShouldActivateModule")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "ProcessDrag")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "StateForMouseButton")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "CreatePointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "ProcessMove")]
	public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void RemoveMouseInputSource(IMouseInputSource source)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "SetupRewiredVars")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "SetUpRewiredPlayerMice")]
	[CallsUnknownMethods(Count = 8)]
	public void AddMouseInputSource(IMouseInputSource source)
	{
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvents")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "GetMouseButtonDownOnAnyMouse")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ShouldActivateModule")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "DidAnyMouseMove")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Process")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ShouldActivateModule")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	public int GetMouseInputSourceCount(int playerId)
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "CreatePointerEventData")]
	public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex)
	{
		return null;
	}

	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public void RemoveTouchInputSource(ITouchInputSource source)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public void AddTouchInputSource(ITouchInputSource source)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetTouchInputSourceCount(int playerId)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "SetUpRewiredPlayerMice")]
	protected void ClearMouseInputSources()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract bool IsDefaultPlayer(int playerId);

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetLastPointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "CreatePointerEventData")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetTouchPointerEventData")]
	protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType)
	{
		data = null;
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PointerEventData), Member = ".ctor")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetTouchInputSource")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[CallsUnknownMethods(Count = 6)]
	private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchEvents")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	protected void RemovePointerData(PlayerPointerEventData data)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[Calls(Type = typeof(EventSystem), Member = "RaycastAll")]
	[Calls(Type = typeof(BaseInputModule), Member = "FindFirstRaycast")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchEvents")]
	[CallsUnknownMethods(Count = 1)]
	protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref pressed) = null;
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref released) = null;
		return null;
	}

	[Calls(Type = typeof(RewiredPointerInputModule), Member = "StateForMouseButton")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "StateForMouseButton")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "StateForMouseButton")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "StateForMouseButton")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "CopyFromTo")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "CopyFromTo")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[Calls(Type = typeof(EventSystem), Member = "RaycastAll")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "CopyFromTo")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[Calls(Type = typeof(BaseInputModule), Member = "FindFirstRaycast")]
	protected virtual MouseState GetMousePointerEventData(int playerId, int mouseIndex)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetPointerData")]
	[CallsUnknownMethods(Count = 5)]
	protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[CallsUnknownMethods(Count = 8)]
	protected virtual void ProcessMove(PlayerPointerEventData pointerEvent)
	{
	}

	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 6)]
	public override bool IsPointerOverGameObject(int pointerTypeId)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "DeactivateModule")]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter")]
	protected void ClearSelection()
	{
	}

	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	public override string ToString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject")]
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
	{
	}

	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CallsUnknownMethods(Count = 1)]
	protected void CopyFromTo(PointerEventData from, PointerEventData to)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[CalledBy(Type = typeof(RewiredPointerInputModule), Member = "GetMousePointerEventData")]
	[CallerCount(Count = 4)]
	protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId)
	{
		return default(PointerEventData.FramePressState);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BaseInputModule), Member = ".ctor")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = ".ctor")]
	[CallsUnknownMethods(Count = 21)]
	protected RewiredPointerInputModule()
	{
	}
}
