using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Rewired.Components;
using Rewired.Data;
using Rewired.Utils;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI;

public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule
{
	[Serializable]
	public class PlayerSetting
	{
		public int playerId;

		public List<Rewired.Components.PlayerMouse> playerMice;

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		public PlayerSetting()
		{
		}

		[CallsUnknownMethods(Count = 18)]
		[CalledBy(Type = typeof(PlayerSetting), Member = "Clone")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 5)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		private PlayerSetting(PlayerSetting other)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(PlayerSetting), Member = ".ctor")]
		[CallsUnknownMethods(Count = 7)]
		public PlayerSetting Clone()
		{
			return null;
		}
	}

	private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal";

	private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical";

	private const string DEFAULT_ACTION_SUBMIT = "UISubmit";

	private const string DEFAULT_ACTION_CANCEL = "UICancel";

	private InputManager_Base rewiredInputManager;

	private bool useAllRewiredGamePlayers;

	private bool useRewiredSystemPlayer;

	private int[] rewiredPlayerIds;

	private bool usePlayingPlayersOnly;

	private List<Rewired.Components.PlayerMouse> playerMice;

	private bool moveOneElementPerAxisPress;

	private bool setActionsById;

	private int horizontalActionId;

	private int verticalActionId;

	private int submitActionId;

	private int cancelActionId;

	private string m_HorizontalAxis;

	private string m_VerticalAxis;

	private string m_SubmitButton;

	private string m_CancelButton;

	private float m_InputActionsPerSecond;

	private float m_RepeatDelay;

	private bool m_allowMouseInput;

	private bool m_allowMouseInputIfTouchSupported;

	private bool m_allowTouchInput;

	private bool m_deselectIfBackgroundClicked;

	private bool m_deselectBeforeSelecting;

	private bool m_ForceModuleActive;

	[NonSerialized]
	private int[] playerIds;

	private bool recompiling;

	[NonSerialized]
	private bool isTouchSupported;

	[NonSerialized]
	private double m_PrevActionTime;

	[NonSerialized]
	private Vector2 m_LastMoveVector;

	[NonSerialized]
	private int m_ConsecutiveMoveCount;

	[NonSerialized]
	private bool m_HasFocus;

	public InputManager_Base RewiredInputManager
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		set
		{
		}
	}

	public bool UseAllRewiredGamePlayers
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "SetupRewiredVars")]
		set
		{
		}
	}

	public bool UseRewiredSystemPlayer
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "SetupRewiredVars")]
		set
		{
		}
	}

	public int[] RewiredPlayerIds
	{
		[CallsUnknownMethods(Count = 4)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "SetupRewiredVars")]
		[CallsUnknownMethods(Count = 4)]
		set
		{
		}
	}

	public bool UsePlayingPlayersOnly
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public List<Rewired.Components.PlayerMouse> PlayerMice
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 14)]
		[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "SetupRewiredVars")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		set
		{
		}
	}

	public bool MoveOneElementPerAxisPress
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool allowMouseInput
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool allowMouseInputIfTouchSupported
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public bool allowTouchInput
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool deselectIfBackgroundClicked
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	private bool deselectBeforeSelecting
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool SetActionsById
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "SetupRewiredVars")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int HorizontalActionId
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
		[CallsUnknownMethods(Count = 5)]
		set
		{
		}
	}

	public int VerticalActionId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		set
		{
		}
	}

	public int SubmitActionId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(int);
		}
		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		set
		{
		}
	}

	public int CancelActionId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
		set
		{
		}
	}

	protected override bool isMouseSupported
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

	private bool isTouchAllowed
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool allowActivationOnMobileDevice
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public bool forceModuleActive
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float inputActionsPerSecond
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float repeatDelay
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string horizontalAxis
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetActionId")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public string verticalAxis
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetActionId")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		set
		{
		}
	}

	public string submitButton
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetActionId")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public string cancelButton
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetActionId")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	private RewiredStandaloneInputModule()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(ReInput), Member = "add_InitializedEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "InitializeRewired")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	protected override void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "InitializeRewired")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ShouldIgnoreEventsOnNoFocus")]
	[CallsUnknownMethods(Count = 2)]
	public override void UpdateModule()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool IsModuleSupported()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Player), Member = "GetNegativeButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetNegativeButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "DidAnyMouseMove")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "GetMouseButtonDownOnAnyMouse")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(BaseInputModule), Member = "ShouldActivateModule")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	public override bool ShouldActivateModule()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ShouldIgnoreEventsOnNoFocus")]
	public override void ActivateModule()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "ClearSelection")]
	public override void DeactivateModule()
	{
	}

	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchEvents")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvents")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "SendSubmitEventToSelectedObject")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "SendMoveEventToSelectedObject")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ShouldIgnoreEventsOnNoFocus")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public override void Process()
	{
	}

	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Process")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "RemovePointerData")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetTouchPointerEventData")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchPress")]
	private bool ProcessTouchEvents()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchEvents")]
	[Calls(Type = typeof(ReInput), Member = "get_time")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "HandleMouseTouchDeselectionOnSelectionChanged")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(ReInput.TimeHelper), Member = "get_unscaledTime")]
	[CallerCount(Count = 1)]
	private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Process")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	private bool SendSubmitEventToSelectedObject()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Player), Member = "GetNegativeButton")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetNegativeButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetButton")]
	[Calls(Type = typeof(Player), Member = "GetNegativeButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetButton")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "GetNegativeButton")]
	private Vector2 GetRawMoveVector()
	{
		return default(Vector2);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Process")]
	private bool SendMoveEventToSelectedObject()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Player), Member = "GetNegativeButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetNegativeButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref downHorizontal) = null;
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref downVertical) = null;
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Process")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSourceCount")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	private void ProcessMouseEvents()
	{
	}

	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvents")]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMousePress")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMousePress")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMousePress")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMousePress")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	private void ProcessMouseEvent(int playerId, int pointerIndex)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	private bool SendUpdateEventToSelectedObject()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter")]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ReInput.TimeHelper), Member = "get_unscaledTime")]
	[Calls(Type = typeof(ReInput), Member = "get_time")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "HandleMouseTouchDeselectionOnSelectionChanged")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void ProcessMousePress(MouseButtonEventData data)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMousePress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchPress")]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
	{
	}

	[CallerCount(Count = 0)]
	private void OnApplicationFocus(bool hasFocus)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Process")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ActivateModule")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "UpdateModule")]
	[Calls(Type = typeof(ConfigVars), Member = "GetPlatformVars")]
	[Calls(Type = typeof(ReInput), Member = "get_configuration")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	private bool ShouldIgnoreEventsOnNoFocus()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "remove_InitializedEvent")]
	[CallsUnknownMethods(Count = 7)]
	protected override void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_hasMouse")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[CallerCount(Count = 0)]
	protected override bool IsDefaultPlayer(int playerId)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "CheckEditorRecompile")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "UpdateModule")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Awake")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "SetupRewiredVars")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "OnRewiredInitialized")]
	[Calls(Type = typeof(Rewired.Utils.SafeAction), Member = "op_Subtraction")]
	[Calls(Type = typeof(ReInput), Member = "add_ShutDownEvent")]
	[Calls(Type = typeof(ReInput), Member = "remove_ShutDownEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Rewired.Utils.SafeAction), Member = "op_Addition")]
	private void InitializeRewired()
	{
	}

	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_Players")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "set_RewiredPlayerIds")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "set_UseRewiredSystemPlayer")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "set_PlayerMice")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "set_SetActionsById")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "InitializeRewired")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "set_UseAllRewiredGamePlayers")]
	[CallsUnknownMethods(Count = 48)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "AddMouseInputSource")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetSystemPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "SetUpRewiredActions")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "ClearMouseInputSources")]
	private void SetupRewiredVars()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "AddMouseInputSource")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "ClearMouseInputSources")]
	private void SetUpRewiredPlayerMice()
	{
	}

	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "SetupRewiredVars")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetActionId")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetActionId")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetActionId")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetActionId")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void SetUpRewiredActions()
	{
	}

	[Calls(Type = typeof(Player), Member = "GetButton")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool GetButton(Player player, int actionId)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[CallsUnknownMethods(Count = 1)]
	private bool GetButtonDown(Player player, int actionId)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "GetNegativeButton")]
	[CallsUnknownMethods(Count = 1)]
	private bool GetNegativeButton(Player player, int actionId)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "GetNegativeButtonDown")]
	[CallsUnknownMethods(Count = 1)]
	private bool GetNegativeButtonDown(Player player, int actionId)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	private float GetAxis(Player player, int actionId)
	{
		return default(float);
	}

	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "InitializeRewired")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void CheckEditorRecompile()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "ClearMouseInputSources")]
	[CallsUnknownMethods(Count = 1)]
	private void OnEditorRecompile()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "ClearMouseInputSources")]
	[CallsUnknownMethods(Count = 1)]
	private void ClearRewiredVars()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ShouldActivateModule")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSourceCount")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	private bool DidAnyMouseMove()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSourceCount")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ShouldActivateModule")]
	private bool GetMouseButtonDownOnAnyMouse(int buttonIndex)
	{
		return default(bool);
	}

	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "InitializeRewired")]
	[CallerCount(Count = 0)]
	private void OnRewiredInitialized()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "ClearMouseInputSources")]
	[CallsUnknownMethods(Count = 1)]
	private void OnRewiredShutDown()
	{
	}
}
