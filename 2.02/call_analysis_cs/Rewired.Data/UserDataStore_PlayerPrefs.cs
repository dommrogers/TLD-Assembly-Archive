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
			[CallsUnknownMethods(Count = 3)]
			public int IndexOfJoystick(int joystickId)
			{
				return default(int);
			}

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 3)]
			public bool ContainsJoystick(int joystickId)
			{
				return default(bool);
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
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
			[CallerCount(Count = 2)]
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
		[CallerCount(Count = 2)]
		public ControllerAssignmentSaveInfo()
		{
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
		[CallsUnknownMethods(Count = 13)]
		public ControllerAssignmentSaveInfo(int playerCount)
		{
		}

		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadKeyboardAndMouseAssignmentsNow")]
		[CalledBy(Type = typeof(ControllerAssignmentSaveInfo), Member = "ContainsPlayer")]
		[CallsUnknownMethods(Count = 3)]
		public int IndexOfPlayer(int playerId)
		{
			return default(int);
		}

		[Calls(Type = typeof(ControllerAssignmentSaveInfo), Member = "IndexOfPlayer")]
		[CallerCount(Count = 0)]
		public bool ContainsPlayer(int playerId)
		{
			return default(bool);
		}
	}

	private class JoystickAssignmentHistoryInfo
	{
		public readonly Joystick joystick;

		public readonly int oldJoystickId;

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 2)]
		public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass78_0
	{
		public Joystick joystick;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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
		[CallerCount(Count = 2)]
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

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
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

	private sealed class _003CLoadJoystickAssignmentsDeferred_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UserDataStore_PlayerPrefs _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
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
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 10)]
		[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
		[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool LoadMouseAssignments
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		set
		{
		}
	}

	private string playerPrefsKey_controllerAssignments
	{
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "ControllerAssignmentSaveDataExists")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "ControllerAssignmentSaveDataExists")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentData")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentData")]
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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "get_Actions")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_allActionIdsString")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "AddDefaultMappingsForNewActions")]
		[CallsUnknownMethods(Count = 21)]
		get
		{
			return null;
		}
	}

	private string allActionIdsString
	{
		[CallsUnknownMethods(Count = 11)]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(StringBuilder), Member = "Append")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_allActionIds")]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(StringBuilder), Member = "Append")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAll")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public override void Save()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 1)]
	public override void SaveControllerData(ControllerType controllerType, int controllerId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 2)]
	public override void SavePlayerData(int playerId)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveInputBehaviorNow")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void SaveInputBehavior(int playerId, int behaviorId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAll")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public override void Load()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "RefreshLayoutManager")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void LoadControllerData(ControllerType controllerType, int controllerId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 1)]
	public override void LoadPlayerData(int playerId)
	{
	}

	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviorNow")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetInputBehavior")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override void LoadInputBehavior(int playerId, int behaviorId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnInitialize()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickData")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsDeferred")]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	public override void SaveControllerMap(int playerId, ControllerMap controllerMap)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[CallsUnknownMethods(Count = 1)]
	public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAllJoystickCalibrationData")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "Load")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentsNow")]
	[CallsDeduplicatedMethods(Count = 3)]
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

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAll")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerData")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "RefreshLayoutManager")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviors")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	private int LoadPlayerDataNow(Player player)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAll")]
	private int LoadAllJoystickCalibrationData()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAllJoystickCalibrationData")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(CalibrationMap), Member = "ImportXmlString")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "get_calibrationMap")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetJoystickCalibrationMapPlayerPrefsKey")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private int LoadJoystickCalibrationData(Joystick joystick)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerDataNow")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "GetJoystick")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	private int LoadJoystickCalibrationData(int joystickId)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnControllerConnected")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "RefreshLayoutManager")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ContainsController")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player), Member = "get_id")]
	private int LoadJoystickData(int joystickId)
	{
		return default(int);
	}

	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "RefreshLayoutManager")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerData")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "AddMap")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "MapLayouts")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "GetController")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
	{
		return default(int);
	}

	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "AddDefaultMappingsForNewActions")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapKnownActionIds")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateFromXml")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKey")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviorNow")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetInputBehaviors")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	private int LoadInputBehaviors(int playerId)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviorNow")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetInputBehavior")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	private int LoadInputBehaviorNow(int playerId, int behaviorId)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviors")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviorNow")]
	[Calls(Type = typeof(InputBehavior), Member = "ImportXmlString")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehavior")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAll")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadKeyboardAndMouseAssignmentsNow")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentData")]
	private bool LoadControllerAssignmentsNow()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentsNow")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "set_hasMouse")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "set_hasKeyboard")]
	[Calls(Type = typeof(ControllerAssignmentSaveInfo), Member = "IndexOfPlayer")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentData")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player), Member = "get_id")]
	private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data)
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentsNow")]
	[CalledBy(Type = typeof(_003CLoadJoystickAssignmentsDeferred_003Ed__80), Member = "MoveNext")]
	private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentsNow")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadKeyboardAndMouseAssignmentsNow")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_playerPrefsKey_controllerAssignments")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_playerPrefsKey_controllerAssignments")]
	[CallerCount(Count = 2)]
	private ControllerAssignmentSaveInfo LoadControllerAssignmentData()
	{
		return null;
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnControllerConnected")]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator LoadJoystickAssignmentsDeferred()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "Save")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAllJoystickCalibrationData")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	private void SaveAll()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[CallsUnknownMethods(Count = 2)]
	private void SavePlayerDataNow(int playerId)
	{
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerData")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAll")]
	[Calls(Type = typeof(InputBehavior), Member = "ToXmlString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	[Calls(Type = typeof(Player), Member = "GetSaveData")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	private void SavePlayerDataNow(Player player)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAll")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(CalibrationMap), Member = "ToXmlString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetJoystickCalibrationMapPlayerPrefsKey")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Joystick), Member = "GetCalibrationMapSaveData")]
	private void SaveAllJoystickCalibrationData()
	{
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickData")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerData")]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerData")]
	private void SaveJoystickCalibrationData(int joystickId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Joystick), Member = "GetCalibrationMapSaveData")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetJoystickCalibrationMapPlayerPrefsKey")]
	[Calls(Type = typeof(CalibrationMap), Member = "ToXmlString")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CallsUnknownMethods(Count = 1)]
	private void SaveJoystickCalibrationData(Joystick joystick)
	{
	}

	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnControllerPreDisconnect")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ContainsController")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	private void SaveJoystickData(int joystickId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
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

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerSaveData), Member = "get_AllControllerMapSaveData")]
	[Calls(Type = typeof(ControllerMapSaveData), Member = "get_map")]
	private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
	{
	}

	[Calls(Type = typeof(ControllerMapSaveData), Member = "get_map")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerData")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ContainsController")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "gOUeiDXiTUyjKFsueBjILINTgmB")]
	private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_allActionIdsString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapKnownActionIdsPlayerPrefsKey")]
	[Calls(Type = typeof(ControllerMap), Member = "get_layoutId")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controller")]
	[Calls(Type = typeof(ControllerMap), Member = "ToXmlString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKey")]
	[Calls(Type = typeof(ControllerMap), Member = "get_layoutId")]
	[Calls(Type = typeof(ControllerMap), Member = "get_categoryId")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controller")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ControllerMap), Member = "get_categoryId")]
	private void SaveControllerMap(Player player, ControllerMap controllerMap)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(InputBehavior), Member = "ToXmlString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	[CallerCount(Count = 0)]
	private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetInputBehavior")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	[Calls(Type = typeof(InputBehavior), Member = "ToXmlString")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveInputBehavior")]
	[CallsUnknownMethods(Count = 3)]
	private void SaveInputBehaviorNow(int playerId, int behaviorId)
	{
	}

	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(InputBehavior), Member = "ToXmlString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	[CallerCount(Count = 0)]
	private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
	{
	}

	[CallsUnknownMethods(Count = 46)]
	[CalledBy(Type = typeof(_003CLoadJoystickAssignmentsDeferred_003Ed__80), Member = "MoveNext")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAll")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnControllerDisconnected")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnControllerConnected")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnInitialize")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(JsonWriter), Member = "ToJson")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_playerPrefsKey_controllerAssignments")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareIdentifier")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_hasMouse")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_allPlayerCount")]
	[Calls(Type = typeof(ControllerAssignmentSaveInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_allPlayerCount")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_hasKeyboard")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	private bool SaveControllerAssignments()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_playerPrefsKey_controllerAssignments")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_playerPrefsKey_controllerAssignments")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[CallsUnknownMethods(Count = 1)]
	private bool ControllerAssignmentSaveDataExists()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapKnownActionIdsPlayerPrefsKey")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKey")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Player), Member = "get_name")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetBasePlayerPrefsKey(Player player)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetBasePlayerPrefsKey")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKeyCommonSuffix")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapXml")]
	private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapKnownActionIds")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetBasePlayerPrefsKey")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKeyCommonSuffix")]
	private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		return null;
	}

	[Calls(Type = typeof(Guid), Member = "op_Equality")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapKnownActionIdsPlayerPrefsKey")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKey")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetDuplicateIndex")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapType")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetJoystickCalibrationMapXml")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAllJoystickCalibrationData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareIdentifier")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
	{
		return null;
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorXml")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveInputBehaviorNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveInputBehaviors")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviorNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveInputBehaviorNow")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetBasePlayerPrefsKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 6)]
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

	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapKnownActionIdsPlayerPrefsKey")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetJoystickCalibrationMapPlayerPrefsKey")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[CallsUnknownMethods(Count = 1)]
	private string GetJoystickCalibrationMapXml(Joystick joystick)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	private string GetInputBehaviorXml(Player player, int id)
	{
		return null;
	}

	[Calls(Type = typeof(ActionElementMap), Member = "get_modifierKeyFlags")]
	[CallsUnknownMethods(Count = 47)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(BzxjZyfxZBLfcJfGHbNqDmEeyvxJ), Member = "FKraikiUGmVcCRnoLQHrNOualZh")]
	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[Calls(Type = typeof(ControllerMap), Member = "get_layoutId")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_allActionIds")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetControllerMapInstance")]
	[Calls(Type = typeof(ControllerMap), Member = "get_AllMaps")]
	[Calls(Type = typeof(ControllerMap), Member = "get_categoryId")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Guid), Member = "op_Equality")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Guid), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	private Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "CompareOrdinalIgnoreCaseHelper")]
	[Calls(Type = typeof(TextInfo), Member = "CompareOrdinalIgnoreCase")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Controller), Member = "get_hardwareIdentifier")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches)
	{
		matches = null;
		return default(bool);
	}

	[Calls(Type = typeof(Guid), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKeyCommonSuffix")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareIdentifier")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareIdentifier")]
	[Calls(Type = typeof(Guid), Member = "op_Inequality")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Controllers")]
	[Calls(Type = typeof(ysphnPsmWicbVrouVReNRqcFaEt), Member = "HzikLTEyTcdBAfqVNXjZOWaKJPU")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ControllerMapLayoutManager), Member = "Apply")]
	private void RefreshLayoutManager(int playerId)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKeyCommonSuffix")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static Type GetControllerMapType(ControllerType controllerType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UserDataStore_PlayerPrefs()
	{
	}
}
