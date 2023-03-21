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
			[CallerCount(Count = 14)]
			get
			{
				return default(int);
			}
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public ControllerType type
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 11)]
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
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			get
			{
				return default(int);
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
				return default(bool);
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
			[CallsUnknownMethods(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallerCount(Count = 0)]
			get
			{
				return default(float);
			}
		}

		public bool enabled
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return default(bool);
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
			[CallerCount(Count = 2)]
			get
			{
				return default(bool);
			}
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "Initialize")]
		[CallsUnknownMethods(Count = 12)]
		public DialogHelper()
		{
		}

		[Calls(Type = typeof(DialogHelper), Member = "StartModal")]
		[CallerCount(Count = 0)]
		public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<int, UserResponse> resultCallback)
		{
		}

		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessElementAssignmentConflictCheck")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessAddOrReplaceElementAssignment")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessCalibration")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessFallbackJoystickIdentification")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessRemoveElementAssignment")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessJoystickAssignmentChange")]
		[CalledBy(Type = typeof(DialogHelper), Member = "StartModal")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessRemoveOrReassignElementAssignment")]
		public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<int, UserResponse> resultCallback, float openBusyDelay)
		{
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(DialogHelper), Member = "Draw")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public void Update()
		{
		}

		[CallsUnknownMethods(Count = 5)]
		[CalledBy(Type = typeof(DialogHelper), Member = "Update")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ShowDialog")]
		[CallsDeduplicatedMethods(Count = 6)]
		[Calls(Type = typeof(GUILayout), Member = "Window")]
		[CallerCount(Count = 2)]
		public void Draw()
		{
		}

		[CallAnalysisFailed]
		[CallerCount(Count = 0)]
		public void DrawConfirmButton()
		{
		}

		[CallsUnknownMethods(Count = 5)]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawReassignOrRemoveElementAssignmentWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawModalWindow_OkayOnly")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawModalWindow")]
		[Calls(Type = typeof(DialogHelper), Member = "Close")]
		[Calls(Type = typeof(GUILayout), Member = "Button")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 3)]
		public void DrawConfirmButton(string title)
		{
		}

		[CallAnalysisFailed]
		[CallerCount(Count = 0)]
		public void DrawConfirmButton(UserResponse response)
		{
		}

		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawElementAssignmentNormalConflictWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawElementAssignmentNormalConflictWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawElementAssignmentProtectedConflictWindow")]
		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(GUILayout), Member = "Button")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(DialogHelper), Member = "Close")]
		public void DrawConfirmButton(UserResponse response, string title)
		{
		}

		[CallAnalysisFailed]
		[CallerCount(Count = 0)]
		public void DrawCancelButton()
		{
		}

		[CallsUnknownMethods(Count = 5)]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawElementAssignmentNormalConflictWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawElementAssignmentProtectedConflictWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawModalWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawReassignOrRemoveElementAssignmentWindow")]
		[Calls(Type = typeof(GUILayout), Member = "Button")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(DialogHelper), Member = "Close")]
		public void DrawCancelButton(string title)
		{
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(DialogHelper), Member = "Close")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawElementAssignmentWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawFallbackJoystickIdentificationWindow")]
		[CallsUnknownMethods(Count = 1)]
		public void Confirm()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(DialogHelper), Member = "Close")]
		[CallsUnknownMethods(Count = 1)]
		public void Confirm(UserResponse response)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawElementAssignmentWindow")]
		[Calls(Type = typeof(DialogHelper), Member = "Close")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 1)]
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

		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		private void StartBusyTimer(float time)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawCalibrationWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawCalibrationWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawElementAssignmentNormalConflictWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawElementAssignmentProtectedConflictWindow")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawElementAssignmentWindow")]
		[CalledBy(Type = typeof(DialogHelper), Member = "Cancel")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawFallbackJoystickIdentificationWindow")]
		[CalledBy(Type = typeof(DialogHelper), Member = "Confirm")]
		[CalledBy(Type = typeof(DialogHelper), Member = "DrawCancelButton")]
		[CalledBy(Type = typeof(DialogHelper), Member = "DrawConfirmButton")]
		[CalledBy(Type = typeof(DialogHelper), Member = "Confirm")]
		[CalledBy(Type = typeof(DialogHelper), Member = "DrawConfirmButton")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 12)]
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
			[CallerCount(Count = 14)]
			get
			{
				return default(int);
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
			[DeduplicatedMethod]
			[CallerCount(Count = 11)]
			[CompilerGenerated]
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
				return default(int);
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
			[CallerCount(Count = 1)]
			get
			{
				return default(int);
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
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			get
			{
				return default(int);
			}
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
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
				return default(bool);
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			private set
			{
			}
		}

		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawJoystickSelector")]
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
			[CallerCount(Count = 1)]
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
			[DeduplicatedMethod]
			[CallerCount(Count = 58)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 36)]
			[CompilerGenerated]
			private set
			{
			}
		}

		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessRemoveOrReassignElementAssignment")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawAddActionMapButton")]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(ElementAssignmentChange), Member = ".ctor")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawActionAssignmentButton")]
		public ElementAssignmentChange(ElementAssignmentChangeType changeType, InputMapper.Context context)
			: base(default(QueueActionType))
		{
		}

		[CallerCount(Count = 2)]
		[Calls(Type = typeof(InputMapper.Context), Member = "Clone")]
		[Calls(Type = typeof(ElementAssignmentChange), Member = ".ctor")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessRemoveOrReassignElementAssignment")]
		[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessAddOrReplaceElementAssignment")]
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
			[DeduplicatedMethod]
			[CallerCount(Count = 1)]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			private set
			{
			}
		}

		public string joystickName
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
			[CallerCount(Count = 36)]
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
			[CallerCount(Count = 23)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 51)]
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
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[CompilerGenerated]
			private set
			{
			}
		}

		public Joystick joystick
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 56)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 21)]
			private set
			{
			}
		}

		public CalibrationMap calibrationMap
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 33)]
			[CompilerGenerated]
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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "Subscribe")]
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

	[Calls(Type = typeof(ControlRemappingDemo1), Member = "IdentifyAllJoysticks")]
	[Calls(Type = typeof(ReInput), Member = "get_unityJoystickIdentificationRequired")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ReInput), Member = "get_userDataStore")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ClearWorkingVars")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerPreDisconnectEvent")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerConnectedEvent")]
	[Calls(Type = typeof(DialogHelper), Member = ".ctor")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerDisconnectedEvent")]
	private void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI")]
	private void Setup()
	{
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(InputMapper), Member = "RemoveAllEventListeners")]
	[Calls(Type = typeof(InputMapper), Member = "add_StoppedEvent")]
	[CallsUnknownMethods(Count = 12)]
	private void Subscribe()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputMapper), Member = "RemoveAllEventListeners")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Unsubscribe()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnGUI()
	{
	}

	[Calls(Type = typeof(ReInput), Member = "get_userDataStore")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetSystemPlayer")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ClearWorkingVars")]
	[CallsUnknownMethods(Count = 3)]
	private void HandleMenuControl()
	{
	}

	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ClearWorkingVars")]
	[CallerCount(Count = 0)]
	private void Close()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Open()
	{
	}

	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandHeight")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "DoGetRect")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[Calls(Type = typeof(GUILayout), Member = "EndArea")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(GUILayout), Member = "BeginArea")]
	[Calls(Type = typeof(GUI), Member = "Box")]
	[Calls(Type = typeof(GUIStyle), Member = "get_none")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(GUIContent), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ActionElementMap), Member = "TOPwFiaqgxlpgnTfCgAfcRxFBSo")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstElementMapWithAction")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetSystemPlayer")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "GetScreenCenteredRect")]
	private void DrawInitialScreen()
	{
	}

	[Calls(Type = typeof(GUILayout), Member = "BeginScrollView")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawCategoryActions")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(GUILayout), Member = "EndArea")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawMapCategories")]
	[Calls(Type = typeof(GUI), Member = "EndScrollView")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawCalibrateButton")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawMouseAssignment")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawJoystickSelector")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawPlayerSelector")]
	[Calls(Type = typeof(GUILayout), Member = "BeginArea")]
	[Calls(Type = typeof(GUIStyle), Member = "get_none")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawControllerSelector")]
	private void DrawPage()
	{
	}

	[Calls(Type = typeof(Player), Member = "get_name")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawPage")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[Calls(Type = typeof(Player), Member = "get_descriptiveName")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(GUILayout), Member = "Toggle")]
	[Calls(Type = typeof(Player), Member = "get_descriptiveName")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_allPlayerCount")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	private void DrawPlayerSelector()
	{
	}

	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_Players")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "set_hasMouse")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawPage")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "set_hasMouse")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "set_hasMouse")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_hasMouse")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUILayout), Member = "Toggle")]
	private void DrawMouseAssignment()
	{
	}

	[Calls(Type = typeof(GUILayout), Member = "Toggle")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ContainsController")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "EnqueueAction")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawPage")]
	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(JoystickAssignmentChange), Member = ".ctor")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "qVOccUfXdhgsLdOJByiWhuiJSkfd")]
	[Calls(Type = typeof(GUILayout), Member = "Toggle")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	private void DrawJoystickSelector()
	{
	}

	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUILayout), Member = "Toggle")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawPage")]
	[CallsUnknownMethods(Count = 44)]
	[Calls(Type = typeof(GUILayout), Member = "Toggle")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUILayout), Member = "Toggle")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_hasMouse")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit")]
	private void DrawControllerSelector()
	{
	}

	[Calls(Type = typeof(ControlRemappingDemo1), Member = "EnqueueAction")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawPage")]
	[Calls(Type = typeof(GUI), Member = "set_enabled")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "get_calibrationMap")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "GetController")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	private void DrawCalibrateButton()
	{
	}

	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUILayout), Member = "Toggle")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstMapInCategory")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawPage")]
	[Calls(Type = typeof(GUI), Member = "set_enabled")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit")]
	[Calls(Type = typeof(GUI), Member = "get_enabled")]
	[Calls(Type = typeof(GUI), Member = "set_enabled")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstMapInCategory")]
	[Calls(Type = typeof(Player.ControllerHelper.BnvLPSemkwrCfKYYABiuIneeJhx), Member = "eFsFDEPBoBwkCtkCNRQkVwhlOQ")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "get_UserAssignableMapCategories")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	private void DrawMapCategories()
	{
	}

	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawAddActionMapButton")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "Width")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(InputAction), Member = "get_negativeDescriptiveName")]
	[Calls(Type = typeof(InputAction), Member = "get_negativeDescriptiveName")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawActionAssignmentButton")]
	[Calls(Type = typeof(ControllerMap), Member = "get_AllMaps")]
	[Calls(Type = typeof(ControllerMap), Member = "get_AllMaps")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawAddActionMapButton")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(GUILayout), Member = "Width")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawAddActionMapButton")]
	[Calls(Type = typeof(ControllerMap), Member = "get_AllMaps")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawActionAssignmentButton")]
	[Calls(Type = typeof(GUI), Member = "get_enabled")]
	[Calls(Type = typeof(GUI), Member = "set_enabled")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawPage")]
	[CallsUnknownMethods(Count = 89)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawActionAssignmentButton")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "Width")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetMapCategory")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(UserData), Member = "GetActionCategory")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(UserData), Member = "GIRDqTjLRaEIriZdEiTFKTpCEtce")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "Width")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InputAction), Member = "get_positiveDescriptiveName")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawInvertButton")]
	[Calls(Type = typeof(InputAction), Member = "get_positiveDescriptiveName")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawActionAssignmentButton")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ControllerMap), Member = "get_AllMaps")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "DrawAddActionMapButton")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	private void DrawCategoryActions()
	{
	}

	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "EnqueueAction")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawCategoryActions")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawCategoryActions")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawCategoryActions")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawCategoryActions")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(ElementAssignmentChange), Member = ".ctor")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(InputMapper.Context), Member = "set_controllerMap")]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(ActionElementMap), Member = "TOPwFiaqgxlpgnTfCgAfcRxFBSo")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputMapper.Context), Member = "set_actionElementMapToReplace")]
	private void DrawActionAssignmentButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap)
	{
	}

	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawCategoryActions")]
	[Calls(Type = typeof(GUILayout), Member = "DoToggle")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUIContent), Member = "Temp")]
	[Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI")]
	[CallerCount(Count = 1)]
	private void DrawInvertButton(int playerId, InputAction action, Pole actionAxisContribution, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawCategoryActions")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawCategoryActions")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawCategoryActions")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "EnqueueAction")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawCategoryActions")]
	[Calls(Type = typeof(InputMapper.Context), Member = "set_controllerMap")]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ElementAssignmentChange), Member = ".ctor")]
	private void DrawAddActionMapButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DialogHelper), Member = "Draw")]
	[CallsUnknownMethods(Count = 2)]
	private void ShowDialog()
	{
	}

	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[Calls(Type = typeof(DialogHelper), Member = "DrawCancelButton")]
	[Calls(Type = typeof(DialogHelper), Member = "DrawConfirmButton")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	private void DrawModalWindow(string title, string message)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(DialogHelper), Member = "DrawConfirmButton")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[CallsUnknownMethods(Count = 1)]
	private void DrawModalWindow_OkayOnly(string title, string message)
	{
	}

	[Calls(Type = typeof(InputMapper.KFfTdKEYHyKIWgtQchMdsiMvqor), Member = "get_timeRemaining")]
	[Calls(Type = typeof(DialogHelper), Member = "Cancel")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(DialogHelper), Member = "Close")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(DialogHelper), Member = "Confirm")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InputMapper), Member = "Start")]
	[Calls(Type = typeof(InputMapper), Member = "get_options")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	private void DrawElementAssignmentWindow(string title, string message)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(DialogHelper), Member = "Close")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[Calls(Type = typeof(DialogHelper), Member = "DrawCancelButton")]
	[Calls(Type = typeof(DialogHelper), Member = "DrawConfirmButton")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	private void DrawElementAssignmentProtectedConflictWindow(string title, string message)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(DialogHelper), Member = "Close")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[Calls(Type = typeof(DialogHelper), Member = "DrawCancelButton")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(DialogHelper), Member = "DrawConfirmButton")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogHelper), Member = "DrawConfirmButton")]
	private void DrawElementAssignmentNormalConflictWindow(string title, string message)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[Calls(Type = typeof(DialogHelper), Member = "DrawCancelButton")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(DialogHelper), Member = "DrawConfirmButton")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	private void DrawReassignOrRemoveElementAssignmentWindow(string title, string message)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(DialogHelper), Member = "Close")]
	[Calls(Type = typeof(DialogHelper), Member = "Confirm")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "SetUnityJoystickIdFromAnyButtonOrAxisPress")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	private void DrawFallbackJoystickIdentificationWindow(string title, string message)
	{
	}

	[Calls(Type = typeof(GUILayout), Member = "DoToggle")]
	[Calls(Type = typeof(GUIContent), Member = "Temp")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(GUILayout), Member = "DoToggle")]
	[Calls(Type = typeof(GUIContent), Member = "Temp")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Min")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[CallsUnknownMethods(Count = 54)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor")]
	[Calls(Type = typeof(DialogHelper), Member = "Close")]
	[Calls(Type = typeof(DialogHelper), Member = "Close")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(GUILayout), Member = "FlexibleSpace")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[Calls(Type = typeof(Mathf), Member = "Max")]
	[Calls(Type = typeof(AxisCalibration), Member = "Reset")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(GUILayout), Member = "DoToggle")]
	[Calls(Type = typeof(GUIContent), Member = "Temp")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "EndLayoutGroup")]
	[Calls(Type = typeof(GUILayout), Member = "DoToggle")]
	[Calls(Type = typeof(GUIContent), Member = "Temp")]
	[Calls(Type = typeof(GUILayout), Member = "ExpandWidth")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "get_AxisElementIdentifiers")]
	[Calls(Type = typeof(GUI), Member = "set_enabled")]
	[Calls(Type = typeof(GUILayout), Member = "BeginScrollView")]
	[Calls(Type = typeof(GUILayout), Member = "BeginVertical")]
	[Calls(Type = typeof(GUILayout), Member = "Width")]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "Space")]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "Width")]
	[Calls(Type = typeof(GUILayout), Member = "BeginVertical")]
	[Calls(Type = typeof(GUI), Member = "EndScrollView")]
	[Calls(Type = typeof(Controller.Axis), Member = "get_valueRaw")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(CalibrationMap), Member = "GetAxis")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(Controller.Axis), Member = "get_value")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	private void DrawCalibrationWindow(string title, string message)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	private void DialogResultCallback(int queueActionId, UserResponse response)
	{
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessElementAssignmentConflictCheck")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessCalibration")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessFallbackJoystickIdentification")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessElementAssignmentConflictCheck")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessAddOrReplaceElementAssignment")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessRemoveOrReassignElementAssignment")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessJoystickAssignmentChange")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawInitialScreen")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessRemoveElementAssignment")]
	private Rect GetScreenCenteredRect(float width, float height)
	{
		return default(Rect);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawJoystickSelector")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawCalibrateButton")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawActionAssignmentButton")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "DrawAddActionMapButton")]
	[CallsUnknownMethods(Count = 3)]
	private void EnqueueAction(QueueEntry entry)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ProcessJoystickAssignmentChange")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ProcessElementAssignmentChange")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ProcessCalibration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ProcessFallbackJoystickIdentification")]
	private void ProcessQueue()
	{
	}

	[Calls(Type = typeof(ControlRemappingDemo1), Member = "GetScreenCenteredRect")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessQueue")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AEAGuWUxmCMnWwXPzMBFgjoWoCu")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(DialogHelper), Member = "StartModal")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Player.ControllerHelper.BnvLPSemkwrCfKYYABiuIneeJhx), Member = "eFsFDEPBoBwkCtkCNRQkVwhlOQ")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "IsJoystickAssigned")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player), Member = "get_descriptiveName")]
	private bool ProcessJoystickAssignmentChange(JoystickAssignmentChange entry)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessQueue")]
	[CallAnalysisFailed]
	private bool ProcessElementAssignmentChange(ElementAssignmentChange entry)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "GetScreenCenteredRect")]
	[Calls(Type = typeof(DialogHelper), Member = "StartModal")]
	[Calls(Type = typeof(ElementAssignmentChange), Member = ".ctor")]
	[Calls(Type = typeof(InputMapper.Context), Member = "Clone")]
	[Calls(Type = typeof(ElementAssignmentChange), Member = ".ctor")]
	[CallsUnknownMethods(Count = 23)]
	private bool ProcessRemoveOrReassignElementAssignment(ElementAssignmentChange entry)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(DialogHelper), Member = "StartModal")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "GetScreenCenteredRect")]
	private bool ProcessRemoveElementAssignment(ElementAssignmentChange entry)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(InputMapper), Member = "Stop")]
	[Calls(Type = typeof(ElementAssignmentChange), Member = ".ctor")]
	[Calls(Type = typeof(DialogHelper), Member = "StartModal")]
	[Calls(Type = typeof(Application), Member = "get_platform")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "GetScreenCenteredRect")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Application), Member = "get_platform")]
	private bool ProcessAddOrReplaceElementAssignment(ElementAssignmentChange entry)
	{
		return default(bool);
	}

	[Calls(Type = typeof(ControlRemappingDemo1), Member = "GetScreenCenteredRect")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
	[Calls(Type = typeof(InputMapper), Member = "Stop")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DialogHelper), Member = "StartModal")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "GetScreenCenteredRect")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ElementAssignmentInfo), Member = "get_elementDisplayName")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ElementAssignmentInfo), Member = "get_elementDisplayName")]
	private bool ProcessElementAssignmentConflictCheck(ElementAssignmentChange entry)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "GetScreenCenteredRect")]
	[Calls(Type = typeof(DialogHelper), Member = "StartModal")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessQueue")]
	[CallsUnknownMethods(Count = 12)]
	private bool ProcessFallbackJoystickIdentification(FallbackJoystickIdentification entry)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ProcessQueue")]
	[Calls(Type = typeof(DialogHelper), Member = "StartModal")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "GetScreenCenteredRect")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private bool ProcessCalibration(Calibration entry)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ClearControllerSelection")]
	private void PlayerSelectionChanged()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void ControllerSelectionChanged()
	{
	}

	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "JoystickPreDisconnect")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "PlayerSelectionChanged")]
	private void ClearControllerSelection()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void ClearMapSelection()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ClearWorkingVars")]
	private void ResetAll()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "IdentifyAllJoysticks")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "ResetAll")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "Close")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "HandleMenuControl")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "JoystickDisconnected")]
	[Calls(Type = typeof(InputMapper.KFfTdKEYHyKIWgtQchMdsiMvqor), Member = "phyIjntGRGdruzJQpjVunAYjwjK")]
	[Calls(Type = typeof(InputMapper.KFfTdKEYHyKIWgtQchMdsiMvqor), Member = "EqPgiPmfSOBssCubKMDkHibjeil")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "Initialize")]
	private void ClearWorkingVars()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void SetGUIStateStart()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SetGUIStateEnd()
	{
	}

	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "IdentifyAllJoysticks")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(ReInput), Member = "get_unityJoystickIdentificationRequired")]
	[Calls(Type = typeof(ReInput), Member = "get_userDataStore")]
	[Calls(Type = typeof(ReInput), Member = "get_userDataStore")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "IsControllerAssigned")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ContainsController")]
	private void JoystickConnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Calls(Type = typeof(ReInput), Member = "get_userDataStore")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ReInput), Member = "get_userDataStore")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ContainsController")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "IsControllerAssigned")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ClearControllerSelection")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	private void JoystickPreDisconnect(ControllerStatusChangedEventArgs args)
	{
	}

	[Calls(Type = typeof(ReInput), Member = "get_unityJoystickIdentificationRequired")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "IdentifyAllJoysticks")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ClearWorkingVars")]
	private void JoystickDisconnected(ControllerStatusChangedEventArgs args)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 36)]
	private void OnConflictFound(InputMapper.ConflictFoundEventData data)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnStopped(InputMapper.StoppedEventData data)
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "JoystickDisconnected")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "JoystickConnected")]
	[CalledBy(Type = typeof(ControlRemappingDemo1), Member = "Initialize")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(ControlRemappingDemo1), Member = "ClearWorkingVars")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	public void IdentifyAllJoysticks()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected void CheckRecompile()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void RecompileWindow(int windowId)
	{
	}

	[Calls(Type = typeof(InputMapper), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public ControlRemappingDemo1()
	{
	}
}
