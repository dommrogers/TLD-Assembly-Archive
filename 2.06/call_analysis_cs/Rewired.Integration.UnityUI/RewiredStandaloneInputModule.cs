using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Rewired.Components;
using Rewired.Data;
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
		[CallsUnknownMethods(Count = 6)]
		public PlayerSetting()
		{
		}

		[CallsUnknownMethods(Count = 22)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		[CalledBy(Type = typeof(PlayerSetting), Member = "Clone")]
		private PlayerSetting(PlayerSetting other)
		{
		}

		[CallsUnknownMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlayerSetting), Member = ".ctor")]
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
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool UseAllRewiredGamePlayers
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "SetupRewiredVars")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		set
		{
		}
	}

	public bool UsePlayingPlayersOnly
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

	public List<Rewired.Components.PlayerMouse> PlayerMice
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "SetupRewiredVars")]
		[CallsUnknownMethods(Count = 11)]
		set
		{
		}
	}

	public bool MoveOneElementPerAxisPress
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

	public bool allowMouseInput
	{
		[DeduplicatedMethod]
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

	public bool allowMouseInputIfTouchSupported
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

	public bool allowTouchInput
	{
		[DeduplicatedMethod]
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

	public bool SetActionsById
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

	public int HorizontalActionId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return default(int);
		}
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int VerticalActionId
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public int SubmitActionId
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
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
			return default(int);
		}
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	protected override bool isMouseSupported
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsUnknownMethods(Count = 4)]
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
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string horizontalAxis
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetActionId")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
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
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetActionId")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public string submitButton
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
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
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetActionId")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	private RewiredStandaloneInputModule()
	{
	}

	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "InitializeRewired")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ReInput), Member = "add_InitializedEvent")]
	[CallsUnknownMethods(Count = 8)]
	protected override void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ShouldIgnoreEventsOnNoFocus")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "InitializeRewired")]
	public override void UpdateModule()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool IsModuleSupported()
	{
		return default(bool);
	}

	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSourceCount")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSourceCount")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Player), Member = "GetNegativeButtonDown")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(BaseInputModule), Member = "ShouldActivateModule")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetNegativeButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	public override bool ShouldActivateModule()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ShouldIgnoreEventsOnNoFocus")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject")]
	[CallsUnknownMethods(Count = 1)]
	public override void ActivateModule()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "ClearSelection")]
	public override void DeactivateModule()
	{
	}

	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSourceCount")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchEvents")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ShouldIgnoreEventsOnNoFocus")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "SendMoveEventToSelectedObject")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "SendSubmitEventToSelectedObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public override void Process()
	{
	}

	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "get_defaultInputSource")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetTouchPointerEventData")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchPress")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "RemovePointerData")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Process")]
	[CallsUnknownMethods(Count = 4)]
	private bool ProcessTouchEvents()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchEvents")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress")]
	[Calls(Type = typeof(ReInput.TimeHelper), Member = "get_unscaledTime")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_time")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "HandleMouseTouchDeselectionOnSelectionChanged")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Process")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[CallsUnknownMethods(Count = 4)]
	private bool SendSubmitEventToSelectedObject()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Player), Member = "GetNegativeButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetButton")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Player), Member = "GetNegativeButton")]
	[Calls(Type = typeof(Player), Member = "GetNegativeButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetButton")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
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

	[Calls(Type = typeof(Player), Member = "GetNegativeButtonDown")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetNegativeButtonDown")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallerCount(Count = 0)]
	private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref downHorizontal) = null;
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref downVertical) = null;
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

	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMousePress")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Process")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMousePress")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvents")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMousePress")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMousePress")]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MouseState), Member = "GetButtonState")]
	private void ProcessMouseEvent(int playerId, int pointerIndex)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool SendUpdateEventToSelectedObject()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMouseEvent")]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter")]
	[Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ReInput.TimeHelper), Member = "get_unscaledTime")]
	[Calls(Type = typeof(ReInput), Member = "get_time")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "HandleMouseTouchDeselectionOnSelectionChanged")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void ProcessMousePress(MouseButtonEventData data)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessMousePress")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ProcessTouchPress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
	{
	}

	[CallerCount(Count = 0)]
	private void OnApplicationFocus(bool hasFocus)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Process")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "ActivateModule")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "UpdateModule")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ReInput), Member = "get_configuration")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ConfigVars), Member = "GetPlatformVars")]
	private bool ShouldIgnoreEventsOnNoFocus()
	{
		return default(bool);
	}

	[Calls(Type = typeof(ReInput), Member = "remove_EditorRecompileEvent")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(ReInput), Member = "remove_InitializedEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "remove_ShutDownEvent")]
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
		return default(bool);
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "OnRewiredInitialized")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "CheckEditorRecompile")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "UpdateModule")]
	[CallerCount(Count = 4)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "Awake")]
	private void InitializeRewired()
	{
	}

	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_Players")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "set_SetActionsById")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "set_UseAllRewiredGamePlayers")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "set_UseRewiredSystemPlayer")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "set_RewiredPlayerIds")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "set_PlayerMice")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "AddMouseInputSource")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetSystemPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "SetUpRewiredActions")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 17)]
	private void SetupRewiredVars()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "AddMouseInputSource")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "ClearMouseInputSources")]
	private void SetUpRewiredPlayerMice()
	{
	}

	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "SetupRewiredVars")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetActionId")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetActionId")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetActionId")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
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
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[CallerCount(Count = 0)]
	private float GetAxis(Player player, int actionId)
	{
		return default(float);
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

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(RewiredStandaloneInputModule), Member = "OnRewiredShutDown")]
	[CallsUnknownMethods(Count = 1)]
	private void ClearRewiredVars()
	{
	}

	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSource")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(RewiredPointerInputModule), Member = "GetMouseInputSourceCount")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player), Member = "get_isPlaying")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallerCount(Count = 0)]
	private bool DidAnyMouseMove()
	{
		return default(bool);
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
		return default(bool);
	}

	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "InitializeRewired")]
	[CallerCount(Count = 0)]
	private void OnRewiredInitialized()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RewiredStandaloneInputModule), Member = "ClearRewiredVars")]
	private void OnRewiredShutDown()
	{
	}
}
