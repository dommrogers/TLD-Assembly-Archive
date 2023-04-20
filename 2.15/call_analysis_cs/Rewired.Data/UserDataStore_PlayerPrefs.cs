using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Data;

public class UserDataStore_PlayerPrefs : UserDataStore
{
	private class ControllerAssignmentSaveInfo
	{
		public class PlayerInfo
		{
			public int id;

			public bool hasKeyboard;

			public bool hasMouse;

			public JoystickInfo[] joysticks;

			public int joystickCount
			{
				[DeduplicatedMethod]
				[CallerCount(Count = 0)]
				get
				{
					return 0;
				}
			}

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			public int IndexOfJoystick(int joystickId)
			{
				return 0;
			}

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			public bool ContainsJoystick(int joystickId)
			{
				return false;
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 6)]
			public PlayerInfo()
			{
			}
		}

		public class JoystickInfo
		{
			public Guid instanceGuid;

			public string hardwareIdentifier;

			public int id;

			[DeduplicatedMethod]
			[CallerCount(Count = 6)]
			public JoystickInfo()
			{
			}
		}

		public PlayerInfo[] players;

		public int playerCount
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return 0;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public ControllerAssignmentSaveInfo()
		{
		}

		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		public ControllerAssignmentSaveInfo(int playerCount)
		{
		}

		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadKeyboardAndMouseAssignmentsNow")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		public int IndexOfPlayer(int playerId)
		{
			return 0;
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public bool ContainsPlayer(int playerId)
		{
			return false;
		}
	}

	private class JoystickAssignmentHistoryInfo
	{
		public readonly Joystick joystick;

		public readonly int oldJoystickId;

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
		public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass78_0
	{
		public Joystick joystick;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass78_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CLoadJoystickAssignmentsNow_003Eb__0(JoystickAssignmentHistoryInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass78_1
	{
		public ControllerAssignmentSaveInfo.JoystickInfo joystickInfo;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass78_1()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CLoadJoystickAssignmentsNow_003Eb__1(JoystickAssignmentHistoryInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass78_2
	{
		public Joystick match;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass78_2()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CLoadJoystickAssignmentsNow_003Eb__2(JoystickAssignmentHistoryInfo x)
		{
			return false;
		}
	}

	private sealed class _003CLoadJoystickAssignmentsDeferred_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UserDataStore_PlayerPrefs _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CLoadJoystickAssignmentsDeferred_003Ed__80(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
		[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private const string thisScriptName = "UserDataStore_PlayerPrefs";

	private const string logPrefix = "Rewired: ";

	private const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component.";

	private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments";

	private const int controllerMapPPKeyVersion_original = 0;

	private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1;

	private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2;

	private const int controllerMapPPKeyVersion_includeFormatVersion = 2;

	private const int controllerMapPPKeyVersion = 2;

	private bool isEnabled;

	private bool loadDataOnStart;

	private bool loadJoystickAssignments;

	private bool loadKeyboardAssignments;

	private bool loadMouseAssignments;

	private string playerPrefsKeyPrefix;

	[NonSerialized]
	private bool allowImpreciseJoystickAssignmentMatching;

	[NonSerialized]
	private bool deferredJoystickAssignmentLoadPending;

	[NonSerialized]
	private bool wasJoystickEverDetected;

	[NonSerialized]
	private List<int> __allActionIds;

	[NonSerialized]
	private string __allActionIdsString;

	public bool IsEnabled
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

	public bool LoadDataOnStart
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

	public bool LoadJoystickAssignments
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

	public bool LoadKeyboardAssignments
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

	public bool LoadMouseAssignments
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

	public string PlayerPrefsKeyPrefix
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 55)]
		set
		{
		}
	}

	private string playerPrefsKey_controllerAssignments
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format")]
		get
		{
			return null;
		}
	}

	private bool loadControllerAssignments
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	private List<int> allActionIds
	{
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_allActionIdsString")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "AddDefaultMappingsForNewActions")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "get_Actions")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return null;
		}
	}

	private string allActionIdsString
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
		[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_allActionIds")]
		[Calls(Type = typeof(StringBuilder), Member = "Append")]
		[Calls(Type = typeof(StringBuilder), Member = "Append")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAll")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public override void Save()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 1)]
	public override void SaveControllerData(ControllerType controllerType, int controllerId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 2)]
	public override void SavePlayerData(int playerId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetInputBehavior")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	[Calls(Type = typeof(InputBehavior), Member = "ToXmlString")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void SaveInputBehavior(int playerId, int behaviorId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAll")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public override void Load()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "RefreshLayoutManager")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public override void LoadControllerData(ControllerType controllerType, int controllerId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 1)]
	public override void LoadPlayerData(int playerId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetInputBehavior")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviorNow")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 1)]
	public override void LoadInputBehavior(int playerId, int behaviorId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnInitialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickData")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnControllerConnected(ControllerStatusChangedEventArgs args)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickData")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
	protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[CallsUnknownMethods(Count = 1)]
	public override void SaveControllerMap(int playerId, ControllerMap controllerMap)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[CallsUnknownMethods(Count = 1)]
	public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "Load")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentsNow")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAllJoystickCalibrationData")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private int LoadAll()
	{
		return 0;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private int LoadPlayerDataNow(int playerId)
	{
		return 0;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviors")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "RefreshLayoutManager")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private int LoadPlayerDataNow(Player player)
	{
		return 0;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private int LoadAllJoystickCalibrationData()
	{
		return 0;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAllJoystickCalibrationData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickData")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetJoystickCalibrationMapPlayerPrefsKey")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "get_calibrationMap")]
	[Calls(Type = typeof(CalibrationMap), Member = "ImportXmlString")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private int LoadJoystickCalibrationData(Joystick joystick)
	{
		return 0;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerDataNow")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "GetJoystick")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[CallsUnknownMethods(Count = 1)]
	private int LoadJoystickCalibrationData(int joystickId)
	{
		return 0;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnControllerConnected")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(TypeFullName = "Rewired.Player.ControllerHelper.BnvLPSemkwrCfKYYABiuIneeJhx", Member = "eFsFDEPBoBwkCtkCNRQkVwhlOQ")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "RefreshLayoutManager")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "GetJoystick")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private int LoadJoystickData(int joystickId)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "RefreshLayoutManager")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	private int LoadControllerDataNow(ControllerType controllerType, int controllerId)
	{
		return 0;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerDataNow")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "GetController")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(TypeFullName = "Rewired.Utils.EmptyObjects`1", Member = "get_EmptyReadOnlyIListT")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "MapLayouts")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "AddMap")]
	[CallsUnknownMethods(Count = 5)]
	private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
	{
		return 0;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKey")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateFromXml")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapKnownActionIds")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "AddDefaultMappingsForNewActions")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetInputBehaviors")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviorNow")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private int LoadInputBehaviors(int playerId)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetInputBehavior")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviorNow")]
	[CallsUnknownMethods(Count = 1)]
	private int LoadInputBehaviorNow(int playerId, int behaviorId)
	{
		return 0;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehavior")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviors")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviorNow")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(InputBehavior), Member = "ImportXmlString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior)
	{
		return 0;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentData")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadKeyboardAndMouseAssignmentsNow")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
	private bool LoadControllerAssignmentsNow()
	{
		return false;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentsNow")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentData")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ControllerAssignmentSaveInfo), Member = "IndexOfPlayer")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "set_hasKeyboard")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "set_hasMouse")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data)
	{
		return false;
	}

	[CalledBy(Type = typeof(_003CLoadJoystickAssignmentsDeferred_003Ed__80), Member = "MoveNext")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentsNow")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentData")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "qVOccUfXdhgsLdOJByiWhuiJSkfd")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ControllerAssignmentSaveInfo), Member = "IndexOfPlayer")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "FindJoystickPrecise")]
	[Calls(Type = typeof(List<>), Member = "Find")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "TryFindJoysticksImprecise")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(ReInput), Member = "get_configuration")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "AutoAssignJoysticks")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 85)]
	private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data)
	{
		return false;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentsNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadKeyboardAndMouseAssignmentsNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private ControllerAssignmentSaveInfo LoadControllerAssignmentData()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadJoystickAssignmentsDeferred_003Ed__80))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator LoadJoystickAssignmentsDeferred()
	{
		return null;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "Save")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(Player), Member = "GetSaveData")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveInputBehaviors")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAllJoystickCalibrationData")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void SaveAll()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[CallsUnknownMethods(Count = 2)]
	private void SavePlayerDataNow(int playerId)
	{
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Player), Member = "GetSaveData")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveInputBehaviors")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	private void SavePlayerDataNow(Player player)
	{
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SaveAllJoystickCalibrationData()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerDataNow")]
	[CallerCount(Count = 4)]
	private void SaveJoystickCalibrationData(int joystickId)
	{
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAllJoystickCalibrationData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ControllerWithAxes), Member = "get_calibrationMap")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetJoystickCalibrationMapPlayerPrefsKey")]
	[Calls(Type = typeof(CalibrationMap), Member = "ToXmlString")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[CallsUnknownMethods(Count = 1)]
	private void SaveJoystickCalibrationData(Joystick joystick)
	{
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnControllerPreDisconnect")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(TypeFullName = "Rewired.Player.ControllerHelper.BnvLPSemkwrCfKYYABiuIneeJhx", Member = "eFsFDEPBoBwkCtkCNRQkVwhlOQ")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "GetJoystick")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void SaveJoystickData(int joystickId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[CallsUnknownMethods(Count = 1)]
	private void SaveControllerDataNow(ControllerType controllerType, int controllerId)
	{
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAll")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerSaveData), Member = "get_AllControllerMapSaveData")]
	[Calls(Type = typeof(ControllerMapSaveData), Member = "get_map")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
	{
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerDataNow")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ContainsController")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "bwJwehFCYWrUsUIUBqkVaHmjbzp")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(TypeFullName = "Rewired.Utils.EmptyObjects`1", Member = "get_array")]
	[Calls(Type = typeof(ControllerMapSaveData), Member = "get_map")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[CallsUnknownMethods(Count = 2)]
	private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ControllerMap), Member = "get_controller")]
	[Calls(Type = typeof(ControllerMap), Member = "get_categoryId")]
	[Calls(Type = typeof(ControllerMap), Member = "get_layoutId")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKey")]
	[Calls(Type = typeof(ControllerMap), Member = "ToXmlString")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapKnownActionIdsPlayerPrefsKey")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_allActionIds")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SaveControllerMap(Player player, ControllerMap controllerMap)
	{
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAll")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Player), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(InputBehavior), Member = "ToXmlString")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CallsUnknownMethods(Count = 3)]
	private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetInputBehavior")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	[Calls(Type = typeof(InputBehavior), Member = "ToXmlString")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SaveInputBehaviorNow(int playerId, int behaviorId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	[Calls(Type = typeof(InputBehavior), Member = "ToXmlString")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
	{
	}

	[CalledBy(Type = typeof(_003CLoadJoystickAssignmentsDeferred_003Ed__80), Member = "MoveNext")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnInitialize")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnControllerConnected")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnControllerDisconnected")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAll")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_allPlayerCount")]
	[Calls(Type = typeof(ControllerAssignmentSaveInfo), Member = ".ctor")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_hasKeyboard")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_hasMouse")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareIdentifier")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(JsonWriter), Member = "ToJson")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 29)]
	private bool SaveControllerAssignments()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool ControllerAssignmentSaveDataExists()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	private string GetBasePlayerPrefsKey(Player player)
	{
		return null;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapXml")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Player), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKeyCommonSuffix")]
	[CallsUnknownMethods(Count = 1)]
	private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		return null;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapKnownActionIds")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Player), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKeyCommonSuffix")]
	[CallsUnknownMethods(Count = 1)]
	private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		return null;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKey")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapKnownActionIdsPlayerPrefsKey")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetDuplicateIndex")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		return null;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetJoystickCalibrationMapXml")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareIdentifier")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[CallsUnknownMethods(Count = 1)]
	private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
	{
		return null;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveInputBehavior")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviorNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveInputBehaviorNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveInputBehaviorNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorXml")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Player), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsUnknownMethods(Count = 1)]
	private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKey")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapKnownActionIdsPlayerPrefsKey")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetJoystickCalibrationMapPlayerPrefsKey")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private string GetJoystickCalibrationMapXml(Joystick joystick)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private string GetInputBehaviorXml(Player player, int id)
	{
		return null;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ControllerMap), Member = "get_categoryId")]
	[Calls(Type = typeof(ControllerMap), Member = "get_layoutId")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetControllerMapInstance")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_allActionIds")]
	[Calls(Type = typeof(ControllerMap), Member = "get_AllMaps")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_modifierKeyFlags")]
	[Calls(TypeFullName = "AdaDTKzmCBgRGHQacnobDRfGngTN", Member = "ATmAaKeuFgLdsiWLDeruqclfAaRa")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds)
	{
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
	{
		return null;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareIdentifier")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches)
	{
		matches = null;
		return false;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKeyCommonSuffix")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(TypeFullName = "bqgFhLJevgwGDBkMuBcbCeTHblPK", Member = "GdzbXbYxKujnkgbjkzWSvNZuKOq")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Controllers")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareIdentifier")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 12)]
	private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier)
	{
		return 0;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerDataNow")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ControllerMapLayoutManager), Member = "Apply")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshLayoutManager(int playerId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private static Type GetControllerMapType(ControllerType controllerType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public UserDataStore_PlayerPrefs()
	{
	}
}
