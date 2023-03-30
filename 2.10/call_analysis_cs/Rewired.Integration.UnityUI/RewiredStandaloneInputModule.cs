using System;
using System.Collections.Generic;
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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public PlayerSetting()
		{
		}

		[CalledBy(Type = typeof(PlayerSetting), Member = "Clone")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 10)]
		private PlayerSetting(PlayerSetting other)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlayerSetting), Member = ".ctor")]
		[CallsUnknownMethods(Count = 1)]
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
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
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
			return false;
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
			return false;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "SetupRewiredVars")]
		set
		{
		}
	}

	public int[] RewiredPlayerIds
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
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
			return false;
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
		[Calls(Type = typeof(List<>), Member = ".ctor")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List<>), Member = ".ctor")]
		[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "SetupRewiredVars")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
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
			return false;
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
			return false;
		}
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
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool allowTouchInput
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
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
			return false;
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
			return false;
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
			return false;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "SetupRewiredVars")]
		set
		{
		}
	}

	public int HorizontalActionId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
		[CallsUnknownMethods(Count = 2)]
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
			return 0;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public int SubmitActionId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public int CancelActionId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	protected override bool isMouseSupported
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return false;
		}
	}

	private bool isTouchAllowed
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public bool allowActivationOnMobileDevice
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
			return false;
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
			return 0f;
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
			return 0f;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string horizontalAxis
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
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
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetActionId")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public string submitButton
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
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
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetActionId")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private RewiredStandaloneInputModule()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(ReInput), Member = "add_InitializedEvent")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "InitializeRewired")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected override void Awake()
	{
	}

	[CallerCount(Count = 0)]
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
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInputModule), Member = "ShouldActivateModule")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Player), Member = "GetNegativeButtonDown")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSourceCount")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public override bool ShouldActivateModule()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ShouldIgnoreEventsOnNoFocus")]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void ActivateModule()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "ClearSelection")]
	public override void DeactivateModule()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ShouldIgnoreEventsOnNoFocus")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "SendMoveEventToSelectedObject")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "SendSubmitEventToSelectedObject")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchEvents")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSourceCount")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public override void Process()
	{
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Process")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetTouchPointerEventData")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchPress")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "RemovePointerData")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private bool ProcessTouchEvents()
	{
		return false;
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchEvents")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "HandleMouseTouchDeselectionOnSelectionChanged")]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter")]
	[Calls(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler")]
	[Calls(Type = typeof(ReInput), Member = "get_time")]
	[Calls(Type = typeof(ReInput.TimeHelper), Member = "get_unscaledTime")]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
	{
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Process")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private bool SendSubmitEventToSelectedObject()
	{
		return false;
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "SendMoveEventToSelectedObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Player), Member = "GetButton")]
	[Calls(Type = typeof(Player), Member = "GetNegativeButton")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetNegativeButtonDown")]
	[CallsUnknownMethods(Count = 4)]
	private Vector2 GetRawMoveVector()
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Process")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_time")]
	[Calls(Type = typeof(ReInput.TimeHelper), Member = "get_unscaledTime")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "GetRawMoveVector")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "CheckButtonOrKeyMovement")]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private bool SendMoveEventToSelectedObject()
	{
		return false;
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "SendMoveEventToSelectedObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetNegativeButtonDown")]
	[CallsUnknownMethods(Count = 2)]
	private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical)
	{
		downHorizontal = default(bool);
		downVertical = default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSourceCount")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
	[CallsUnknownMethods(Count = 2)]
	private void ProcessMouseEvents()
	{
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Process")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvents")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMousePress")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler")]
	[Calls(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	private void ProcessMouseEvent(int playerId, int pointerIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool SendUpdateEventToSelectedObject()
	{
		return false;
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "HandleMouseTouchDeselectionOnSelectionChanged")]
	[Calls(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy")]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler")]
	[Calls(Type = typeof(ReInput), Member = "get_time")]
	[Calls(Type = typeof(ReInput.TimeHelper), Member = "get_unscaledTime")]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress")]
	[Calls(Type = typeof(ExecuteEvents), Member = "Execute")]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void ProcessMousePress(MouseButtonEventData data)
	{
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchPress")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMousePress")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "DeselectIfSelectionChanged")]
	[Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler")]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject")]
	[CallsUnknownMethods(Count = 1)]
	private void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
	{
	}

	[CallerCount(Count = 0)]
	private void OnApplicationFocus(bool hasFocus)
	{
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "UpdateModule")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ActivateModule")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Process")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ReInput), Member = "get_configuration")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ConfigVars), Member = "GetPlatformVars")]
	[CallsUnknownMethods(Count = 1)]
	private bool ShouldIgnoreEventsOnNoFocus()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "remove_InitializedEvent")]
	[Calls(Type = typeof(ReInput), Member = "remove_ShutDownEvent")]
	[Calls(Type = typeof(ReInput), Member = "remove_EditorRecompileEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_hasMouse")]
	[CallsUnknownMethods(Count = 3)]
	protected override bool IsDefaultPlayer(int playerId)
	{
		return false;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Awake")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "UpdateModule")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "CheckEditorRecompile")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "OnRewiredInitialized")]
	[CallerCount(Count = 4)]
	private void InitializeRewired()
	{
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "set_UseAllRewiredGamePlayers")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "set_UseRewiredSystemPlayer")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "set_RewiredPlayerIds")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "set_PlayerMice")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "set_SetActionsById")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "SetUpRewiredActions")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetSystemPlayer")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityTools), Member = "IsNullOrDestroyed")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "AddMouseInputSource")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_Players")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void SetupRewiredVars()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "ClearMouseInputSources")]
	[Calls(Type = typeof(UnityTools), Member = "IsNullOrDestroyed")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "AddMouseInputSource")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void SetUpRewiredPlayerMice()
	{
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "SetupRewiredVars")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetActionId")]
	[CallsUnknownMethods(Count = 1)]
	private void SetUpRewiredActions()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "GetButton")]
	[CallsUnknownMethods(Count = 1)]
	private bool GetButton(Player player, int actionId)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[CallsUnknownMethods(Count = 1)]
	private bool GetButtonDown(Player player, int actionId)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "GetNegativeButton")]
	[CallsUnknownMethods(Count = 1)]
	private bool GetNegativeButton(Player player, int actionId)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "GetNegativeButtonDown")]
	[CallsUnknownMethods(Count = 1)]
	private bool GetNegativeButtonDown(Player player, int actionId)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[CallsUnknownMethods(Count = 1)]
	private float GetAxis(Player player, int actionId)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "InitializeRewired")]
	[CallsUnknownMethods(Count = 1)]
	private void CheckEditorRecompile()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnEditorRecompile()
	{
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "OnRewiredShutDown")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	private void ClearRewiredVars()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSourceCount")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[CallsUnknownMethods(Count = 3)]
	private bool DidAnyMouseMove()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSourceCount")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[CallsUnknownMethods(Count = 3)]
	private bool GetMouseButtonDownOnAnyMouse(int buttonIndex)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "InitializeRewired")]
	private void OnRewiredInitialized()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ClearRewiredVars")]
	private void OnRewiredShutDown()
	{
	}
}
