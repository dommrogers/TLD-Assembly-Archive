using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Rewired.Data;
using UnityEngine;

namespace Rewired.Demos;

public class ControlRemappingDemo1 : MonoBehaviour
{
	private class ControllerSelection
	{
		private int _id;

		private int _idPrev;

		private ControllerType _type;

		private ControllerType _typePrev;

		public int id
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return 0;
			}
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public ControllerType type
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 1)]
			get
			{
				return default(ControllerType);
			}
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public int idPrev
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			get
			{
				return 0;
			}
		}

		public ControllerType typePrev
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 1)]
			get
			{
				return default(ControllerType);
			}
		}

		public bool hasSelection
		{
			[CallerCount(Count = 0)]
			get
			{
				return false;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public ControllerSelection()
		{
		}

		[CallerCount(Count = 0)]
		public void Set(int id, ControllerType type)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public void Clear()
		{
		}
	}

	private class DialogHelper
	{
		public enum DialogType
		{
			None = 0,
			JoystickConflict = 1,
			ElementConflict = 2,
			KeyConflict = 3,
			DeleteAssignmentConfirmation = 10,
			AssignElement = 11
		}

		private const float openBusyDelay = 0.25f;

		private const float closeBusyDelay = 0.1f;

		private DialogType _type;

		private bool _enabled;

		private float _busyTime;

		private bool _busyTimerRunning;

		private Action<int> drawWindowDelegate;

		private GUI.WindowFunction drawWindowFunction;

		private WindowProperties windowProperties;

		private int currentActionId;

		private Action<int, UserResponse> resultCallback;

		private float busyTimer
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return 0f;
			}
		}

		public bool enabled
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return false;
			}
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 1)]
			set
			{
			}
		}

		public DialogType type
		{
			[CallerCount(Count = 0)]
			get
			{
				return default(DialogType);
			}
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 2)]
			set
			{
			}
		}

		public bool busy
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return false;
			}
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public DialogHelper()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DialogHelper), Member = "StartModal")]
		public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<int, UserResponse> resultCallback)
		{
		}

		[CalledBy(Type = typeof(DialogHelper), Member = "StartModal")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessJoystickAssignmentChange")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessRemoveOrReassignElementAssignment")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessRemoveElementAssignment")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessAddOrReplaceElementAssignment")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessElementAssignmentConflictCheck")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessFallbackJoystickIdentification")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessCalibration")]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<int, UserResponse> resultCallback, float openBusyDelay)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DialogHelper), Member = "Draw")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void Update()
		{
		}

		[CalledBy(Type = typeof(DialogHelper), Member = "Update")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ShowDialog")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(GUILayout), Member = "Window")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 5)]
		public void Draw()
		{
		}

		[CallAnalysisFailed]
		[CallerCount(Count = 0)]
		public void DrawConfirmButton()
		{
		}

		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawModalWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawModalWindow_OkayOnly")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawReassignOrRemoveElementAssignmentWindow")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(GUILayout), Member = "Button")]
		[Calls(Type = typeof(DialogHelper), Member = "Close")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 5)]
		public void DrawConfirmButton(string title)
		{
		}

		[CallAnalysisFailed]
		[CallerCount(Count = 0)]
		public void DrawConfirmButton(UserResponse response)
		{
		}

		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawElementAssignmentProtectedConflictWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawElementAssignmentNormalConflictWindow")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(GUILayout), Member = "Button")]
		[Calls(Type = typeof(DialogHelper), Member = "Close")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 5)]
		public void DrawConfirmButton(UserResponse response, string title)
		{
		}

		[CallAnalysisFailed]
		[CallerCount(Count = 0)]
		public void DrawCancelButton()
		{
		}

		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawModalWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawElementAssignmentProtectedConflictWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawElementAssignmentNormalConflictWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawReassignOrRemoveElementAssignmentWindow")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(GUILayout), Member = "Button")]
		[Calls(Type = typeof(DialogHelper), Member = "Close")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 5)]
		public void DrawCancelButton(string title)
		{
		}

		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawElementAssignmentWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawFallbackJoystickIdentificationWindow")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DialogHelper), Member = "Close")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void Confirm()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DialogHelper), Member = "Close")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void Confirm(UserResponse response)
		{
		}

		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawElementAssignmentWindow")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DialogHelper), Member = "Close")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void Cancel()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void DrawWindow(int windowId)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void UpdateTimers()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void StartBusyTimer(float time)
		{
		}

		[CalledBy(Type = typeof(DialogHelper), Member = "DrawConfirmButton")]
		[CalledBy(Type = typeof(DialogHelper), Member = "DrawConfirmButton")]
		[CalledBy(Type = typeof(DialogHelper), Member = "DrawCancelButton")]
		[CalledBy(Type = typeof(DialogHelper), Member = "Confirm")]
		[CalledBy(Type = typeof(DialogHelper), Member = "Confirm")]
		[CalledBy(Type = typeof(DialogHelper), Member = "Cancel")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawElementAssignmentWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawElementAssignmentProtectedConflictWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawElementAssignmentNormalConflictWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawFallbackJoystickIdentificationWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawCalibrationWindow")]
		[CallerCount(Count = 12)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void Close()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private void StateChanged(float delay)
		{
		}

		[CallerCount(Count = 0)]
		private void Reset()
		{
		}

		[CallerCount(Count = 0)]
		private void ResetTimers()
		{
		}

		[CallerCount(Count = 0)]
		public void FullReset()
		{
		}
	}

	private abstract class QueueEntry
	{
		public enum State
		{
			Waiting,
			Confirmed,
			Canceled
		}

		private int _003Cid_003Ek__BackingField;

		private QueueActionType _003CqueueActionType_003Ek__BackingField;

		private State _003Cstate_003Ek__BackingField;

		private UserResponse _003Cresponse_003Ek__BackingField;

		private static int uidCounter;

		public int id
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			protected set
			{
			}
		}

		public QueueActionType queueActionType
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			get
			{
				return default(QueueActionType);
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			protected set
			{
			}
		}

		public State state
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 1)]
			get
			{
				return default(State);
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			protected set
			{
			}
		}

		public UserResponse response
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 1)]
			get
			{
				return default(UserResponse);
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			protected set
			{
			}
		}

		protected static int nextId
		{
			[CallerCount(Count = 0)]
			get
			{
				return 0;
			}
		}

		[CallerCount(Count = 0)]
		public QueueEntry(QueueActionType queueActionType)
		{
		}

		[CallerCount(Count = 0)]
		public void Confirm(UserResponse response)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public void Cancel()
		{
		}
	}

	private class JoystickAssignmentChange : QueueEntry
	{
		private int _003CplayerId_003Ek__BackingField;

		private int _003CjoystickId_003Ek__BackingField;

		private bool _003Cassign_003Ek__BackingField;

		public int playerId
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			private set
			{
			}
		}

		public int joystickId
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 9)]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			private set
			{
			}
		}

		public bool assign
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return false;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			private set
			{
			}
		}

		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawJoystickSelector")]
		[CallerCount(Count = 1)]
		public JoystickAssignmentChange(int newPlayerId, int joystickId, bool assign)
			: base(default(QueueActionType))
		{
		}
	}

	private class ElementAssignmentChange : QueueEntry
	{
		private ElementAssignmentChangeType _003CchangeType_003Ek__BackingField;

		private InputMapper.Context _003Ccontext_003Ek__BackingField;

		public ElementAssignmentChangeType changeType
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return default(ElementAssignmentChangeType);
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public InputMapper.Context context
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 50)]
			private set
			{
			}
		}

		[CalledBy(Type = typeof(ElementAssignmentChange), Member = ".ctor")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawActionAssignmentButton")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawAddActionMapButton")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessRemoveOrReassignElementAssignment")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessAddOrReplaceElementAssignment")]
		[CallerCount(Count = 6)]
		public ElementAssignmentChange(ElementAssignmentChangeType changeType, InputMapper.Context context)
			: base(default(QueueActionType))
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputMapper.Context), Member = "Clone")]
		[Calls(Type = typeof(ElementAssignmentChange), Member = ".ctor")]
		[CallsUnknownMethods(Count = 1)]
		public ElementAssignmentChange(ElementAssignmentChange other)
			: base(default(QueueActionType))
		{
		}
	}

	private class FallbackJoystickIdentification : QueueEntry
	{
		private int _003CjoystickId_003Ek__BackingField;

		private string _003CjoystickName_003Ek__BackingField;

		public int joystickId
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			private set
			{
			}
		}

		public string joystickName
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 50)]
			private set
			{
			}
		}

		[CallerCount(Count = 0)]
		public FallbackJoystickIdentification(int joystickId, string joystickName)
			: base(default(QueueActionType))
		{
		}
	}

	private class Calibration : QueueEntry
	{
		private Player _003Cplayer_003Ek__BackingField;

		private ControllerType _003CcontrollerType_003Ek__BackingField;

		private Joystick _003Cjoystick_003Ek__BackingField;

		private CalibrationMap _003CcalibrationMap_003Ek__BackingField;

		public int selectedElementIdentifierId;

		public bool recording;

		public Player player
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 27)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 55)]
			private set
			{
			}
		}

		public ControllerType controllerType
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return default(ControllerType);
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			private set
			{
			}
		}

		public Joystick joystick
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 58)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 25)]
			private set
			{
			}
		}

		public CalibrationMap calibrationMap
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 18)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 43)]
			private set
			{
			}
		}

		[CallerCount(Count = 0)]
		public Calibration(Player player, Joystick joystick, CalibrationMap calibrationMap)
			: base(default(QueueActionType))
		{
		}
	}

	private struct WindowProperties
	{
		public int windowId;

		public Rect rect;

		public Action<string, string> windowDrawDelegate;

		public string title;

		public string message;
	}

	private enum QueueActionType
	{
		None,
		JoystickAssignment,
		ElementAssignment,
		FallbackJoystickIdentification,
		Calibrate
	}

	private enum ElementAssignmentChangeType
	{
		Add,
		Replace,
		Remove,
		ReassignOrRemove,
		ConflictCheck
	}

	public enum UserResponse
	{
		Confirm,
		Cancel,
		Custom1,
		Custom2
	}

	private const float defaultModalWidth = 250f;

	private const float defaultModalHeight = 200f;

	private const float assignmentTimeout = 5f;

	private DialogHelper dialog;

	private InputMapper inputMapper;

	private InputMapper.ConflictFoundEventData conflictFoundEventData;

	private bool guiState;

	private bool busy;

	private bool pageGUIState;

	private Player selectedPlayer;

	private int selectedMapCategoryId;

	private ControllerSelection selectedController;

	private ControllerMap selectedMap;

	private bool showMenu;

	private bool startListening;

	private Vector2 actionScrollPos;

	private Vector2 calibrateScrollPos;

	private Queue<QueueEntry> actionQueue;

	private bool setupFinished;

	[NonSerialized]
	private bool initialized;

	private bool isCompiling;

	private GUIStyle style_wordWrap;

	private GUIStyle style_centeredBox;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputMapper), Member = "get_options")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "Initialize")]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputMapper), Member = "RemoveAllEventListeners")]
	[Calls(Type = typeof(InputMapper), Member = "add_ConflictFoundEvent")]
	[Calls(Type = typeof(InputMapper), Member = "add_StoppedEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputMapper), Member = "RemoveAllEventListeners")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerConnectedEvent")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerPreDisconnectEvent")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerDisconnectedEvent")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ClearWorkingVars")]
	[Calls(Type = typeof(ReInput), Member = "get_userDataStore")]
	[Calls(Type = typeof(ReInput), Member = "get_unityJoystickIdentificationRequired")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "IdentifyAllJoysticks")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI")]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Setup()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputMapper), Member = "RemoveAllEventListeners")]
	[Calls(Type = typeof(InputMapper), Member = "add_ConflictFoundEvent")]
	[Calls(Type = typeof(InputMapper), Member = "add_StoppedEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void Subscribe()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputMapper), Member = "RemoveAllEventListeners")]
	[CallsUnknownMethods(Count = 1)]
	private void Unsubscribe()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnGUI()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetSystemPlayer")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(ReInput), Member = "get_userDataStore")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ClearWorkingVars")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void HandleMenuControl()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ClearWorkingVars")]
	private void Close()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Open()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetSystemPlayer")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstElementMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[Calls(Type = typeof(ActionElementMap), Member = "TOPwFiaqgxlpgnTfCgAfcRxFBSo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GUIContent), Member = ".ctor")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "GetScreenCenteredRect")]
	[Calls(Type = typeof(GUIStyle), Member = "get_none")]
	[Calls(Type = typeof(GUILayout), Member = "BeginArea")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandHeight")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "DoGetRect")]
	[Calls(Type = typeof(GUI), Member = "Box")]
	[Calls(Type = typeof(GUILayout), Member = "EndArea")]
	[CallsUnknownMethods(Count = 9)]
	private void DrawInitialScreen()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = "get_none")]
	[Calls(Type = typeof(GUILayout), Member = "BeginArea")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawPlayerSelector")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawJoystickSelector")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawMouseAssignment")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawControllerSelector")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawCalibrateButton")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawMapCategories")]
	[Calls(Type = typeof(GUILayout), Member = "BeginScrollView")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawCategoryActions")]
	[Calls(Type = typeof(GUILayout), Member = "EndScrollView")]
	[Calls(Type = typeof(GUILayout), Member = "EndArea")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 8)]
	private void DrawPage()
	{
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_allPlayerCount")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(TypeFullName = "Rewired.Utils.EmptyObjects`1", Member = "get_EmptyReadOnlyIListT")]
	[Calls(Type = typeof(Player), Member = "get_descriptiveName")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Player), Member = "get_name")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUILayout), Member = "Toggle")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	private void DrawPlayerSelector()
	{
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_hasMouse")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUILayout), Member = "Toggle")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "set_hasMouse")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_Players")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 19)]
	private void DrawMouseAssignment()
	{
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUILayout), Member = "Toggle")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "qVOccUfXdhgsLdOJByiWhuiJSkfd")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ContainsController")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(JoystickAssignmentChange), Member = ".ctor")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "EnqueueAction")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 27)]
	private void DrawJoystickSelector()
	{
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUILayout), Member = "Toggle")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_hasMouse")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 32)]
	private void DrawControllerSelector()
	{
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "GetController")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "get_calibrationMap")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "EnqueueAction")]
	[Calls(Type = typeof(GUI), Member = "set_enabled")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 14)]
	private void DrawCalibrateButton()
	{
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(TypeFullName = "Rewired.Utils.EmptyObjects`1", Member = "get_EmptyReadOnlyIListT")]
	[Calls(TypeFullName = "Rewired.Player.ControllerHelper.BnvLPSemkwrCfKYYABiuIneeJhx", Member = "eFsFDEPBoBwkCtkCNRQkVwhlOQ")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstMapInCategory")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(GUI), Member = "set_enabled")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUILayout), Member = "Toggle")]
	[Calls(Type = typeof(GUI), Member = "get_enabled")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 41)]
	private void DrawMapCategories()
	{
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetMapCategory")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(UserData), Member = "GetActionCategory")]
	[Calls(Type = typeof(UserData), Member = "GIRDqTjLRaEIriZdEiTFKTpCEtce")]
	[Calls(TypeFullName = "Rewired.Utils.EmptyObjects`1", Member = "get_EmptyReadOnlyIListT")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(GUILayout), Member = "Width")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawAddActionMapButton")]
	[Calls(Type = typeof(ControllerMap), Member = "get_AllMaps")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawActionAssignmentButton")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawInvertButton")]
	[Calls(Type = typeof(InputAction), Member = "get_positiveDescriptiveName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InputAction), Member = "get_negativeDescriptiveName")]
	[Calls(Type = typeof(GUI), Member = "get_enabled")]
	[Calls(Type = typeof(GUI), Member = "set_enabled")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 85)]
	private void DrawCategoryActions()
	{
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawCategoryActions")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[Calls(Type = typeof(ActionElementMap), Member = "TOPwFiaqgxlpgnTfCgAfcRxFBSo")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(TypeFullName = "Rewired.Logger", Member = "LogError")]
	[Calls(Type = typeof(InputMapper.Context), Member = "set_controllerMap")]
	[Calls(Type = typeof(InputMapper.Context), Member = "set_actionElementMapToReplace")]
	[Calls(Type = typeof(ElementAssignmentChange), Member = ".ctor")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "EnqueueAction")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[CallsUnknownMethods(Count = 9)]
	private void DrawActionAssignmentButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap)
	{
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawCategoryActions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUIContent), Member = "Temp")]
	[Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI")]
	[Calls(Type = typeof(GUILayout), Member = "DoToggle")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[CallsUnknownMethods(Count = 5)]
	private void DrawInvertButton(int playerId, InputAction action, Pole actionAxisContribution, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap)
	{
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawCategoryActions")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(TypeFullName = "Rewired.Logger", Member = "LogError")]
	[Calls(Type = typeof(InputMapper.Context), Member = "set_controllerMap")]
	[Calls(Type = typeof(ElementAssignmentChange), Member = ".ctor")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "EnqueueAction")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[CallsUnknownMethods(Count = 5)]
	private void DrawAddActionMapButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogHelper), Member = "Draw")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ShowDialog()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(DialogHelper), Member = "DrawConfirmButton")]
	[Calls(Type = typeof(DialogHelper), Member = "DrawCancelButton")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void DrawModalWindow(string title, string message)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(DialogHelper), Member = "DrawConfirmButton")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void DrawModalWindow_OkayOnly(string title, string message)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(InputMapper), Member = "get_options")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InputMapper), Member = "Start")]
	[Calls(TypeFullName = "Rewired.InputMapper.KFfTdKEYHyKIWgtQchMdsiMvqor", Member = "get_timeRemaining")]
	[Calls(Type = typeof(DialogHelper), Member = "Cancel")]
	[Calls(Type = typeof(DialogHelper), Member = "Confirm")]
	[Calls(Type = typeof(DialogHelper), Member = "Close")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void DrawElementAssignmentWindow(string title, string message)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(DialogHelper), Member = "DrawConfirmButton")]
	[Calls(Type = typeof(DialogHelper), Member = "DrawCancelButton")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[Calls(Type = typeof(DialogHelper), Member = "Close")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void DrawElementAssignmentProtectedConflictWindow(string title, string message)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(DialogHelper), Member = "DrawConfirmButton")]
	[Calls(Type = typeof(DialogHelper), Member = "DrawCancelButton")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[Calls(Type = typeof(DialogHelper), Member = "Close")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void DrawElementAssignmentNormalConflictWindow(string title, string message)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(DialogHelper), Member = "DrawConfirmButton")]
	[Calls(Type = typeof(DialogHelper), Member = "DrawCancelButton")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void DrawReassignOrRemoveElementAssignmentWindow(string title, string message)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "SetUnityJoystickIdFromAnyButtonOrAxisPress")]
	[Calls(Type = typeof(DialogHelper), Member = "Confirm")]
	[Calls(Type = typeof(DialogHelper), Member = "Close")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void DrawFallbackJoystickIdentificationWindow(string title, string message)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(GUILayout), Member = "Width")]
	[Calls(Type = typeof(GUILayout), Member = "BeginVertical")]
	[Calls(Type = typeof(GUILayout), Member = "BeginScrollView")]
	[Calls(Type = typeof(GUI), Member = "set_enabled")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "get_AxisElementIdentifiers")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUIContent), Member = "Temp")]
	[Calls(Type = typeof(GUILayout), Member = "DoToggle")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[Calls(Type = typeof(GUI), Member = "EndScrollView")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(Controller.Axis), Member = "get_valueRaw")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(CalibrationMap), Member = "GetAxis")]
	[Calls(Type = typeof(Controller.Axis), Member = "get_value")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(AxisCalibration), Member = "Reset")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(DialogHelper), Member = "Close")]
	[Calls(Type = typeof(OverflowException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 56)]
	private void DrawCalibrationWindow(string title, string message)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Queue<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 6)]
	private void DialogResultCallback(int queueActionId, UserResponse response)
	{
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawInitialScreen")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessJoystickAssignmentChange")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessRemoveOrReassignElementAssignment")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessRemoveElementAssignment")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessAddOrReplaceElementAssignment")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessElementAssignmentConflictCheck")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessFallbackJoystickIdentification")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessCalibration")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private Rect GetScreenCenteredRect(float width, float height)
	{
		return default(Rect);
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawJoystickSelector")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawCalibrateButton")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawActionAssignmentButton")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawAddActionMapButton")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Queue<>), Member = "Enqueue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void EnqueueAction(QueueEntry entry)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ProcessCalibration")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ProcessFallbackJoystickIdentification")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ProcessElementAssignmentChange")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ProcessJoystickAssignmentChange")]
	[Calls(Type = typeof(Queue<>), Member = "Dequeue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void ProcessQueue()
	{
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessQueue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(TypeFullName = "Rewired.Player.ControllerHelper.BnvLPSemkwrCfKYYABiuIneeJhx", Member = "eFsFDEPBoBwkCtkCNRQkVwhlOQ")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "IsJoystickAssigned")]
	[Calls(Type = typeof(Player), Member = "get_descriptiveName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "GetScreenCenteredRect")]
	[Calls(Type = typeof(DialogHelper), Member = "StartModal")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AEAGuWUxmCMnWwXPzMBFgjoWoCu")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool ProcessJoystickAssignmentChange(JoystickAssignmentChange entry)
	{
		return false;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessQueue")]
	[CallerCount(Count = 1)]
	private bool ProcessElementAssignmentChange(ElementAssignmentChange entry)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "GetScreenCenteredRect")]
	[Calls(Type = typeof(DialogHelper), Member = "StartModal")]
	[Calls(Type = typeof(InputMapper.Context), Member = "Clone")]
	[Calls(Type = typeof(ElementAssignmentChange), Member = ".ctor")]
	[Calls(Type = typeof(Queue<>), Member = "Enqueue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool ProcessRemoveOrReassignElementAssignment(ElementAssignmentChange entry)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "GetScreenCenteredRect")]
	[Calls(Type = typeof(DialogHelper), Member = "StartModal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool ProcessRemoveElementAssignment(ElementAssignmentChange entry)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[Calls(Type = typeof(Application), Member = "get_platform")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "GetScreenCenteredRect")]
	[Calls(Type = typeof(DialogHelper), Member = "StartModal")]
	[Calls(Type = typeof(InputMapper.Context), Member = "Clone")]
	[Calls(Type = typeof(ElementAssignmentChange), Member = ".ctor")]
	[Calls(Type = typeof(Queue<>), Member = "Enqueue")]
	[Calls(TypeFullName = "Rewired.InputMapper.KFfTdKEYHyKIWgtQchMdsiMvqor", Member = "cLsgLNiZfZLdTfDERXbrfQHXqTPc")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool ProcessAddOrReplaceElementAssignment(ElementAssignmentChange entry)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ElementAssignmentInfo), Member = "get_elementDisplayName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "GetScreenCenteredRect")]
	[Calls(Type = typeof(DialogHelper), Member = "StartModal")]
	[Calls(Type = typeof(InputMapper), Member = "Stop")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private bool ProcessElementAssignmentConflictCheck(ElementAssignmentChange entry)
	{
		return false;
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessQueue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "GetScreenCenteredRect")]
	[Calls(Type = typeof(DialogHelper), Member = "StartModal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool ProcessFallbackJoystickIdentification(FallbackJoystickIdentification entry)
	{
		return false;
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessQueue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "GetScreenCenteredRect")]
	[Calls(Type = typeof(DialogHelper), Member = "StartModal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool ProcessCalibration(Calibration entry)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ClearControllerSelection")]
	private void PlayerSelectionChanged()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	private void ControllerSelectionChanged()
	{
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "PlayerSelectionChanged")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "JoystickPreDisconnect")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void ClearControllerSelection()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	private void ClearMapSelection()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ClearWorkingVars")]
	private void ResetAll()
	{
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "Initialize")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "HandleMenuControl")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "Close")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ResetAll")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "JoystickDisconnected")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "IdentifyAllJoysticks")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Queue<>), Member = "Clear")]
	[Calls(TypeFullName = "Rewired.InputMapper.KFfTdKEYHyKIWgtQchMdsiMvqor", Member = "cLsgLNiZfZLdTfDERXbrfQHXqTPc")]
	[CallsUnknownMethods(Count = 1)]
	private void ClearWorkingVars()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void SetGUIStateStart()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SetGUIStateEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "IsControllerAssigned")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ContainsController")]
	[Calls(Type = typeof(ReInput), Member = "get_userDataStore")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ReInput), Member = "get_unityJoystickIdentificationRequired")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "IdentifyAllJoysticks")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	private void JoystickConnected(ControllerStatusChangedEventArgs args)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ClearControllerSelection")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "IsControllerAssigned")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ContainsController")]
	[Calls(Type = typeof(ReInput), Member = "get_userDataStore")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	private void JoystickPreDisconnect(ControllerStatusChangedEventArgs args)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ClearWorkingVars")]
	[Calls(Type = typeof(ReInput), Member = "get_unityJoystickIdentificationRequired")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "IdentifyAllJoysticks")]
	private void JoystickDisconnected(ControllerStatusChangedEventArgs args)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 50)]
	private void OnConflictFound(InputMapper.ConflictFoundEventData data)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnStopped(InputMapper.StoppedEventData data)
	{
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "Initialize")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "JoystickConnected")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "JoystickDisconnected")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ClearWorkingVars")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(Queue<>), Member = "Enqueue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public void IdentifyAllJoysticks()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected void CheckRecompile()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void RecompileWindow(int windowId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputMapper), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public ControlRemappingDemo1()
	{
	}
}
