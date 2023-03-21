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
					return default(int);
				}
			}

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			public int IndexOfJoystick(int joystickId)
			{
				return default(int);
			}

			[CallsUnknownMethods(Count = 2)]
			[CallerCount(Count = 0)]
			public bool ContainsJoystick(int joystickId)
			{
				return default(bool);
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
				return default(int);
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public ControllerAssignmentSaveInfo()
		{
		}

		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
		[CallerCount(Count = 1)]
		public ControllerAssignmentSaveInfo(int playerCount)
		{
		}

		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadKeyboardAndMouseAssignmentsNow")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
		[CallsUnknownMethods(Count = 2)]
		public int IndexOfPlayer(int playerId)
		{
			return default(int);
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public bool ContainsPlayer(int playerId)
		{
			return default(bool);
		}
	}

	private class JoystickAssignmentHistoryInfo
	{
		public readonly Joystick joystick;

		public readonly int oldJoystickId;

		[CallsUnknownMethods(Count = 5)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
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
			return default(bool);
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
			return default(bool);
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
			return default(bool);
		}
	}

	private sealed class _003CLoadJoystickAssignmentsDeferred_003Ed__80 : IEnumerator, IDisposable, IEnumerator<object>
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UserDataStore_PlayerPrefs _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		public _003CLoadJoystickAssignmentsDeferred_003Ed__80(int _003C_003E1__state)
		{
		}

		[DeduplicatedMethod]
		[DebuggerHidden]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
		[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
		[CallerCount(Count = 0)]
		private bool MoveNext()
		{
			return default(bool);
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
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
			return default(bool);
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
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool LoadKeyboardAssignments
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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

	public bool LoadMouseAssignments
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
			return default(bool);
		}
	}

	private List<int> allActionIds
	{
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "get_Actions")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_allActionIdsString")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "AddDefaultMappingsForNewActions")]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return null;
		}
	}

	private string allActionIdsString
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(StringBuilder), Member = "Append")]
		[Calls(Type = typeof(StringBuilder), Member = "Append")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_allActionIds")]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
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

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallerCount(Count = 0)]
	public override void SavePlayerData(int playerId)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(InputBehavior), Member = "ToXmlString")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetInputBehavior")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	public override void SaveInputBehavior(int playerId, int behaviorId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAll")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public override void Load()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "RefreshLayoutManager")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public override void LoadControllerData(ControllerType controllerType, int controllerId)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	public override void LoadPlayerData(int playerId)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetInputBehavior")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviorNow")]
	[CallsUnknownMethods(Count = 1)]
	public override void LoadInputBehavior(int playerId, int behaviorId)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickData")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallerCount(Count = 0)]
	public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "Load")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAllJoystickCalibrationData")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentsNow")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	private int LoadAll()
	{
		return default(int);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private int LoadPlayerDataNow(int playerId)
	{
		return default(int);
	}

	[Calls(Type = typeof(Player), Member = "get_id")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAll")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerData")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "RefreshLayoutManager")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviors")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private int LoadPlayerDataNow(Player player)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAll")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	private int LoadAllJoystickCalibrationData()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAllJoystickCalibrationData")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[Calls(Type = typeof(CalibrationMap), Member = "ImportXmlString")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetJoystickCalibrationMapPlayerPrefsKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ControllerWithAxes), Member = "get_calibrationMap")]
	private int LoadJoystickCalibrationData(Joystick joystick)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerData")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "GetJoystick")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerDataNow")]
	[CallsUnknownMethods(Count = 1)]
	private int LoadJoystickCalibrationData(int joystickId)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "RefreshLayoutManager")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnControllerConnected")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "GetJoystick")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(Player.ControllerHelper.BnvLPSemkwrCfKYYABiuIneeJhx), Member = "eFsFDEPBoBwkCtkCNRQkVwhlOQ")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	private int LoadJoystickData(int joystickId)
	{
		return default(int);
	}

	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "RefreshLayoutManager")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	private int LoadControllerDataNow(ControllerType controllerType, int controllerId)
	{
		return default(int);
	}

	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "AddMap")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerData")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "MapLayouts")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "GetController")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
	{
		return default(int);
	}

	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKey")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "AddDefaultMappingsForNewActions")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapKnownActionIds")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ControllerMap), Member = "CreateFromXml")]
	private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviorNow")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetInputBehaviors")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	private int LoadInputBehaviors(int playerId)
	{
		return default(int);
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
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviors")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehavior")]
	[Calls(Type = typeof(InputBehavior), Member = "ImportXmlString")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviorNow")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior)
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentData")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadKeyboardAndMouseAssignmentsNow")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAll")]
	private bool LoadControllerAssignmentsNow()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentsNow")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "set_hasMouse")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "set_hasKeyboard")]
	[Calls(Type = typeof(ControllerAssignmentSaveInfo), Member = "IndexOfPlayer")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player), Member = "get_id")]
	private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data)
	{
		return default(bool);
	}

	[Calls(Type = typeof(ReInput), Member = "get_configuration")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "TryFindJoysticksImprecise")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ControllerAssignmentSaveInfo), Member = "IndexOfPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(_003CLoadJoystickAssignmentsDeferred_003Ed__80), Member = "MoveNext")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentsNow")]
	[CallsUnknownMethods(Count = 86)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "AutoAssignJoysticks")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "FindJoystickPrecise")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentData")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "qVOccUfXdhgsLdOJByiWhuiJSkfd")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ControllerAssignmentSaveInfo), Member = "IndexOfPlayer")]
	private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadKeyboardAndMouseAssignmentsNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentsNow")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format")]
	private ControllerAssignmentSaveInfo LoadControllerAssignmentData()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(_003CLoadJoystickAssignmentsDeferred_003Ed__80))]
	private IEnumerator LoadJoystickAssignmentsDeferred()
	{
		return null;
	}

	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "Save")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveInputBehaviors")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAllJoystickCalibrationData")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player), Member = "GetSaveData")]
	private void SaveAll()
	{
	}

	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[CallsUnknownMethods(Count = 2)]
	private void SavePlayerDataNow(int playerId)
	{
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerData")]
	[Calls(Type = typeof(Player), Member = "GetSaveData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveInputBehaviors")]
	private void SavePlayerDataNow(Player player)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAll")]
	[CallsUnknownMethods(Count = 3)]
	private void SaveAllJoystickCalibrationData()
	{
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerData")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerData")]
	[CallAnalysisFailed]
	private void SaveJoystickCalibrationData(int joystickId)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAllJoystickCalibrationData")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetJoystickCalibrationMapPlayerPrefsKey")]
	[Calls(Type = typeof(CalibrationMap), Member = "ToXmlString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetJoystickCalibrationMapPlayerPrefsKey")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "get_calibrationMap")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	private void SaveJoystickCalibrationData(Joystick joystick)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnControllerPreDisconnect")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "GetJoystick")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(Player.ControllerHelper.BnvLPSemkwrCfKYYABiuIneeJhx), Member = "eFsFDEPBoBwkCtkCNRQkVwhlOQ")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	private void SaveJoystickData(int joystickId)
	{
	}

	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[CallsUnknownMethods(Count = 1)]
	private void SaveControllerDataNow(ControllerType controllerType, int controllerId)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAll")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[Calls(Type = typeof(PlayerSaveData), Member = "get_AllControllerMapSaveData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ControllerMapSaveData), Member = "get_map")]
	private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
	{
	}

	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerData")]
	[Calls(Type = typeof(ControllerMapSaveData), Member = "get_map")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ContainsController")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "bwJwehFCYWrUsUIUBqkVaHmjbzp")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapKnownActionIdsPlayerPrefsKey")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_allActionIds")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(ControllerMap), Member = "get_layoutId")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controller")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(ControllerMap), Member = "ToXmlString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKey")]
	[Calls(Type = typeof(ControllerMap), Member = "get_layoutId")]
	[Calls(Type = typeof(ControllerMap), Member = "get_categoryId")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controller")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ControllerMap), Member = "get_categoryId")]
	private void SaveControllerMap(Player player, ControllerMap controllerMap)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAll")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(InputBehavior), Member = "ToXmlString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Player), Member = "get_name")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
	{
	}

	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(InputBehavior), Member = "ToXmlString")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetInputBehavior")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
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

	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareIdentifier")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(JsonWriter), Member = "ToJson")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAll")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnInitialize")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnControllerDisconnected")]
	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[CalledBy(Type = typeof(_003CLoadJoystickAssignmentsDeferred_003Ed__80), Member = "MoveNext")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnControllerConnected")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_hasKeyboard")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_allPlayerCount")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ControllerAssignmentSaveInfo), Member = ".ctor")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_allPlayerCount")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_hasMouse")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	private bool SaveControllerAssignments()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	private bool ControllerAssignmentSaveDataExists()
	{
		return default(bool);
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
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapXml")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKeyCommonSuffix")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Player), Member = "get_name")]
	[CallerCount(Count = 3)]
	private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		return null;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapKnownActionIds")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKeyCommonSuffix")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Player), Member = "get_name")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetDuplicateIndex")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKey")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapKnownActionIdsPlayerPrefsKey")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetDuplicateIndex")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetJoystickCalibrationMapXml")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareIdentifier")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
	{
		return null;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviorNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorXml")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveInputBehaviorNow")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveInputBehavior")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveInputBehaviorNow")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Player), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKey")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[CallsUnknownMethods(Count = 1)]
	private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[Calls(Type = typeof(string), Member = "Split")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapKnownActionIdsPlayerPrefsKey")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetJoystickCalibrationMapPlayerPrefsKey")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetJoystickCalibrationMapXml(Joystick joystick)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	private string GetInputBehaviorXml(Player player, int id)
	{
		return null;
	}

	[Calls(Type = typeof(ControllerMap), Member = "get_AllMaps")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(AdaDTKzmCBgRGHQacnobDRfGngTN), Member = "ATmAaKeuFgLdsiWLDeruqclfAaRa")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_modifierKeyFlags")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetControllerMapInstance")]
	[Calls(Type = typeof(ControllerMap), Member = "get_layoutId")]
	[Calls(Type = typeof(ControllerMap), Member = "get_categoryId")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_allActionIds")]
	private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds)
	{
	}

	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareIdentifier")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches)
	{
		matches = null;
		return default(bool);
	}

	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKeyCommonSuffix")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKeyCommonSuffix")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Controller), Member = "get_hardwareIdentifier")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareIdentifier")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Controllers")]
	[Calls(Type = typeof(bqgFhLJevgwGDBkMuBcbCeTHblPK), Member = "GdzbXbYxKujnkgbjkzWSvNZuKOq")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ControllerMapLayoutManager), Member = "Apply")]
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
