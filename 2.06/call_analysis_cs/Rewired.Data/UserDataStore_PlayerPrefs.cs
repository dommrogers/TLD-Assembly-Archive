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

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			public bool ContainsJoystick(int joystickId)
			{
				return default(bool);
			}

			[CallerCount(Count = 6)]
			[DeduplicatedMethod]
			public PlayerInfo()
			{
			}
		}

		public class JoystickInfo
		{
			public Guid instanceGuid;

			public string hardwareIdentifier;

			public int id;

			[CallerCount(Count = 6)]
			[DeduplicatedMethod]
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

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public ControllerAssignmentSaveInfo()
		{
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
		[CallsUnknownMethods(Count = 9)]
		public ControllerAssignmentSaveInfo(int playerCount)
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadKeyboardAndMouseAssignmentsNow")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
		public int IndexOfPlayer(int playerId)
		{
			return default(int);
		}

		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
		[CallerCount(Count = 1)]
		public bool ContainsPlayer(int playerId)
		{
			return default(bool);
		}
	}

	private class JoystickAssignmentHistoryInfo
	{
		public readonly Joystick joystick;

		public readonly int oldJoystickId;

		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
		[CallsUnknownMethods(Count = 6)]
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

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CLoadJoystickAssignmentsNow_003Eb__0(JoystickAssignmentHistoryInfo x)
		{
			return default(bool);
		}
	}

	private sealed class _003C_003Ec__DisplayClass78_1
	{
		public ControllerAssignmentSaveInfo.JoystickInfo joystickInfo;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
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

	private sealed class _003CLoadJoystickAssignmentsDeferred_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UserDataStore_PlayerPrefs _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			[DebuggerHidden]
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

		[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
		[CallsUnknownMethods(Count = 7)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
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
		[CallerCount(Count = 23)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 51)]
		set
		{
		}
	}

	private string playerPrefsKey_controllerAssignments
	{
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentData")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentData")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "ControllerAssignmentSaveDataExists")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "ControllerAssignmentSaveDataExists")]
		[CallerCount(Count = 5)]
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
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(ReInput), Member = "get_mapping")]
		[Calls(Type = typeof(ReInput.MappingHelper), Member = "get_Actions")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_allActionIdsString")]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "AddDefaultMappingsForNewActions")]
		[CallsUnknownMethods(Count = 11)]
		get
		{
			return null;
		}
	}

	private string allActionIdsString
	{
		[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[Calls(Type = typeof(StringBuilder), Member = "Append")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_allActionIds")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StringBuilder), Member = "Append")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAll")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public override void Save()
	{
	}

	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	public override void SavePlayerData(int playerId)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetInputBehavior")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	[Calls(Type = typeof(InputBehavior), Member = "ToXmlString")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public override void SaveInputBehavior(int playerId, int behaviorId)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAll")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviorNow")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetInputBehavior")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	public override void LoadInputBehavior(int playerId, int behaviorId)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnInitialize()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickData")]
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

	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[CallsUnknownMethods(Count = 1)]
	public override void SaveControllerMap(int playerId, ControllerMap controllerMap)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentsNow")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAllJoystickCalibrationData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "Load")]
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
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "RefreshLayoutManager")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAll")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerData")]
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

	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadAllJoystickCalibrationData")]
	[Calls(Type = typeof(CalibrationMap), Member = "ImportXmlString")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetJoystickCalibrationMapPlayerPrefsKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ControllerWithAxes), Member = "get_calibrationMap")]
	private int LoadJoystickCalibrationData(Joystick joystick)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerDataNow")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerData")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "GetJoystick")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerData")]
	private int LoadJoystickCalibrationData(int joystickId)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "GetJoystick")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "RefreshLayoutManager")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnControllerConnected")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "RefreshLayoutManager")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
	{
		return default(int);
	}

	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[CallerCount(Count = 0)]
	private int LoadControllerDataNow(ControllerType controllerType, int controllerId)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerData")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "AddMap")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "MapLayouts")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "GetController")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMaps")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "AddDefaultMappingsForNewActions")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapKnownActionIds")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKey")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ControllerMap), Member = "CreateFromXml")]
	private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetInputBehaviors")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviorNow")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
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
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviorNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviors")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehavior")]
	[Calls(Type = typeof(InputBehavior), Member = "ImportXmlString")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
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

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentsNow")]
	[CallsUnknownMethods(Count = 23)]
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

	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ControllerAssignmentSaveInfo), Member = "ContainsPlayer")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ControllerAssignmentSaveInfo), Member = "IndexOfPlayer")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "TryFindJoysticksImprecise")]
	[Calls(Type = typeof(JoystickAssignmentHistoryInfo), Member = ".ctor")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "AutoAssignJoysticks")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(_003CLoadJoystickAssignmentsDeferred_003Ed__80), Member = "MoveNext")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentsNow")]
	[CallsUnknownMethods(Count = 131)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(ReInput), Member = "get_configuration")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JoystickAssignmentHistoryInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentData")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "qVOccUfXdhgsLdOJByiWhuiJSkfd")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ControllerAssignmentSaveInfo), Member = "IndexOfPlayer")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "FindJoystickPrecise")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerAssignmentsNow")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadKeyboardAndMouseAssignmentsNow")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_playerPrefsKey_controllerAssignments")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_playerPrefsKey_controllerAssignments")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	private ControllerAssignmentSaveInfo LoadControllerAssignmentData()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadJoystickAssignmentsDeferred_003Ed__80))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	private IEnumerator LoadJoystickAssignmentsDeferred()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "Save")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerAssignments")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAllJoystickCalibrationData")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	private void SaveAll()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	private void SavePlayerDataNow(int playerId)
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Player), Member = "GetSaveData")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	[Calls(Type = typeof(InputBehavior), Member = "ToXmlString")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAll")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[CallsUnknownMethods(Count = 2)]
	private void SavePlayerDataNow(Player player)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(CalibrationMap), Member = "ToXmlString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetJoystickCalibrationMapPlayerPrefsKey")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAll")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Joystick), Member = "GetCalibrationMapSaveData")]
	private void SaveAllJoystickCalibrationData()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerDataNow")]
	private void SaveJoystickCalibrationData(int joystickId)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(CalibrationMap), Member = "ToXmlString")]
	[Calls(Type = typeof(Joystick), Member = "GetCalibrationMapSaveData")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetJoystickCalibrationMapPlayerPrefsKey")]
	private void SaveJoystickCalibrationData(Joystick joystick)
	{
	}

	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "GetJoystick")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnControllerPreDisconnect")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(CalibrationMap), Member = "ToXmlString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetJoystickCalibrationMapPlayerPrefsKey")]
	[Calls(Type = typeof(Joystick), Member = "GetCalibrationMapSaveData")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(Player.ControllerHelper.BnvLPSemkwrCfKYYABiuIneeJhx), Member = "eFsFDEPBoBwkCtkCNRQkVwhlOQ")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	private void SaveJoystickData(int joystickId)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[CallsUnknownMethods(Count = 1)]
	private void SaveControllerDataNow(ControllerType controllerType, int controllerId)
	{
	}

	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[Calls(Type = typeof(ControllerMapSaveData), Member = "get_map")]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerSaveData), Member = "get_AllControllerMapSaveData")]
	private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerData")]
	[Calls(Type = typeof(ControllerMapSaveData), Member = "get_map")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ContainsController")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "bwJwehFCYWrUsUIUBqkVaHmjbzp")]
	private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
	{
	}

	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapKnownActionIdsPlayerPrefsKey")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMaps")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveControllerMap")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_allActionIdsString")]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	[Calls(Type = typeof(InputBehavior), Member = "ToXmlString")]
	private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(InputBehavior), Member = "ToXmlString")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetInputBehavior")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorPlayerPrefsKey")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
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
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_playerPrefsKey_controllerAssignments")]
	[Calls(Type = typeof(JsonWriter), Member = "ToJson")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnControllerDisconnected")]
	[CallsUnknownMethods(Count = 42)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnControllerConnected")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAll")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[CalledBy(Type = typeof(_003CLoadJoystickAssignmentsDeferred_003Ed__80), Member = "MoveNext")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "OnInitialize")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_hasKeyboard")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_allPlayerCount")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ControllerAssignmentSaveInfo), Member = ".ctor")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_allPlayerCount")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_hasMouse")]
	private bool SaveControllerAssignments()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_playerPrefsKey_controllerAssignments")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_playerPrefsKey_controllerAssignments")]
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
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetDuplicateIndex")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKey")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapKnownActionIdsPlayerPrefsKey")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetDuplicateIndex")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetJoystickCalibrationMapXml")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveJoystickCalibrationData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveAllJoystickCalibrationData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickCalibrationData")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareIdentifier")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetInputBehaviorXml")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveInputBehaviorNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveInputBehaviorNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveInputBehaviors")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SavePlayerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadInputBehaviorNow")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Player), Member = "get_name")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "SaveInputBehavior")]
	private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId)
	{
		return null;
	}

	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKey")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[Calls(Type = typeof(string), Member = "Split")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapKnownActionIdsPlayerPrefsKey")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetJoystickCalibrationMapPlayerPrefsKey")]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(ControllerMap), Member = "get_controllerType")]
	[CallsUnknownMethods(Count = 32)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(AdaDTKzmCBgRGHQacnobDRfGngTN), Member = "ATmAaKeuFgLdsiWLDeruqclfAaRa")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_modifierKeyFlags")]
	[Calls(Type = typeof(ControllerMap), Member = "get_AllMaps")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetControllerMapInstance")]
	[Calls(Type = typeof(ControllerMap), Member = "get_layoutId")]
	[Calls(Type = typeof(ControllerMap), Member = "get_categoryId")]
	[Calls(Type = typeof(UserDataStore_PlayerPrefs), Member = "get_allActionIds")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	private Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
	{
		return null;
	}

	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickAssignmentsNow")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Controller), Member = "get_hardwareIdentifier")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	private bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches)
	{
		matches = null;
		return default(bool);
	}

	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKeyCommonSuffix")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "GetControllerMapPlayerPrefsKeyCommonSuffix")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareIdentifier")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareIdentifier")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Controllers")]
	[Calls(Type = typeof(bqgFhLJevgwGDBkMuBcbCeTHblPK), Member = "GdzbXbYxKujnkgbjkzWSvNZuKOq")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerDataNow")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadJoystickData")]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadPlayerDataNow")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ControllerMapLayoutManager), Member = "Apply")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(UserDataStore_PlayerPrefs), Member = "LoadControllerData")]
	private void RefreshLayoutManager(int playerId)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static Type GetControllerMapType(ControllerType controllerType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public UserDataStore_PlayerPrefs()
	{
	}
}
