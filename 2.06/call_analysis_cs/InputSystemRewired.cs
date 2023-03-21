using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Conditions;
using Rewired;
using Steamworks;
using TLD.UI.Generics;
using UnityEngine;

public class InputSystemRewired
{
	private enum ActiveControllerType
	{
		None,
		Steam,
		Ps4,
		XboxOne,
		Switch
	}

	public class InputController_ButtonState
	{
		public InputDigitalActionHandle_t m_Handle;

		public bool m_Value;

		public bool m_PreviousValue;

		public bool m_RequiresUpForReset;

		[CallerCount(Count = 0)]
		public bool GetButtonPressed()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		public bool GetButtonUp()
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool GetButtonValue()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		public bool GetButtonValueChanged()
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public InputController_ButtonState()
		{
		}
	}

	public class InputController_AxisState
	{
		public InputAnalogActionHandle_t m_Handle;

		public bool m_Active;

		public Vector2 m_Value;

		public Vector2 m_PreviousValue;

		public EInputSourceMode m_EMode;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public Vector2 GetAxis()
		{
			return default(Vector2);
		}

		[CallerCount(Count = 0)]
		public bool ValueChanged()
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public InputController_AxisState()
		{
		}
	}

	public float m_MouseSensitivityMin;

	public float m_MouseSensitivityMid;

	public float m_MouseSensitivityMax;

	public float m_ZoomSensitivityMin;

	public float m_ZoomSensitivityMid;

	public float m_ZoomSensitivityMax;

	public float m_GamepadCameraSensitivityMin;

	public float m_GamepadCameraSensitivityMid;

	public float m_GamepadCameraSensitivityMax;

	private int playerId;

	public Player m_Player;

	private ControllerMap m_CachedControllerMap;

	private bool m_HasReconnectedJoystick;

	private bool m_HasReconnectedJoystickPS4;

	private PanelReference<Panel_Confirmation> m_Confirmation;

	private PanelReference<Panel_OptionsMenu> m_OptionsMenu;

	private const int AUTOREPEAT_PERSISTENCE = 1;

	private const int AUTOREPEAT_PERSISTENCE_MASK = 1;

	private int keyLeftMask;

	private int keyRightMask;

	private int keyUpMask;

	private int keyDownMask;

	private int keySprintMask;

	private ActiveControllerType m_LastActiveController;

	private Dictionary<InputManager.InputAction, int> m_ActionToActionId;

	private static float m_MenuNavigationDeadzone;

	private Vector2 m_MousePosLastFrame;

	private int m_ActiveSteamControllerIndex;

	private InputActionSetHandle_t m_ActionSetHandleGameplay;

	private InputActionSetHandle_t m_ActionSetHandleInterface;

	private InputActionSetHandle_t m_ActionSetHandleInteractiveDisplay;

	private InputActionSetHandle_t INVALID_ACTION_SETHANDLE;

	private InputHandle_t[] m_TempControllerHandles;

	private const float STEAM_INPUT_SENSITIVITY = 0.118f;

	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	private Dictionary<InputManager.InputAction, InputController_ButtonState> m_SteamControllerButtonState;

	private Dictionary<InputManager.InputAxis, InputController_AxisState> m_SteamControllerAxisState;

	private bool m_SteamControllerInitialized;

	private bool m_InInteractiveDisplay;

	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Controller), Member = "get_buttonCount")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "get_axisCount")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PrintDebugInfo")]
	[CallsUnknownMethods(Count = 96)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareName")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareIdentifier")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ContainsController")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Controller), Member = "get_buttonCount")]
	[Calls(Type = typeof(Controller), Member = "get_Buttons")]
	[Calls(Type = typeof(Controller.Button), Member = "get_value")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(int), Member = "ToString")]
	private string PrintJoystickDebugInfo(int joystickIndex)
	{
		return null;
	}

	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetJoystickLayout")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ControllerMap), Member = "get_categoryId")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetMapCategory")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ControllerMap), Member = "get_layoutId")]
	[Calls(Type = typeof(ControllerMap), Member = "get_enabled")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMaps")]
	[Calls(Type = typeof(ControllerMap), Member = "GetElementMaps")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_elementIdentifierName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PrintDebugInfo")]
	[CallsUnknownMethods(Count = 63)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_Players")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Player), Member = "get_name")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	private string PrintPlayerDebugInfo(int playerIndex)
	{
		return null;
	}

	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Initialize")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InputSystemRewired), Member = "PrintPlayerDebugInfo")]
	[Calls(Type = typeof(Rewired.Logger), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "PrintJoystickDebugInfo")]
	private void PrintDebugInfo()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(InputManager), Member = "Awake")]
	[Calls(Type = typeof(InputSystemRewired), Member = "PrintDebugInfo")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "SetAllMapsEnabled")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerDisconnectedEvent")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerConnectedEvent")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerPreDisconnectEvent")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ReInput), Member = "get_configuration")]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[Calls(Type = typeof(ReInput.ConfigHelper), Member = "set_windowsStandalonePrimaryInputSource")]
	[Calls(Type = typeof(ReInput), Member = "get_configuration")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput.ConfigHelper), Member = "set_windowsStandalonePrimaryInputSource")]
	public void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeSetGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeSetMouseOrKeyboardActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "FindActiveGamepad")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "UpdateSteamController")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	public void Update()
	{
	}

	[Calls(Type = typeof(Controller), Member = "get_Buttons")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(InputManager), Member = "ResetControllerState")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Controller.Element), Member = "Reset")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(InputSystemRewired), Member = "ResetSteamControllerState")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Controller), Member = "get_Buttons")]
	public void ResetControllerState()
	{
	}

	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "SetAllMapsEnabled")]
	[CalledBy(Type = typeof(InputManager), Member = "SaveRemapping")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnBeforeSerialization")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ControllerMap), Member = "ToXmlString")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ControllerMap), Member = "ToXmlString")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Player), Member = "GetSaveData")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void SaveRemapping()
	{
	}

	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "LoadRemapping")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	private void PatchControllerMapping()
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	private bool CheckForExistingKeyboardMapping(KeyCode keycode)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "LoadRemapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "SetGamepadEnabled")]
	[Calls(Type = typeof(InputSystemRewired), Member = "ResetKeybindingsToDefault")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "ClearMaps")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "ClearMaps")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "AddMapsFromXml")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "AddMapsFromXml")]
	public void LoadRemapping()
	{
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "AnySteamButtonPressed")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "AnyButtonsOrKeysPressed")]
	[CalledBy(Type = typeof(InputManager), Member = "AnyInput")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Keyboard")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Mouse")]
	public bool AnyButtonsOrKeysPressed()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InputManager), Member = "AnyMouseOrStickMovement")]
	[Calls(Type = typeof(InputSystemRewired), Member = "AnySteamAxisPressed")]
	[CalledBy(Type = typeof(InputManager), Member = "AnyInput")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	public bool GetAnyMouseOrStickMovement()
	{
		return default(bool);
	}

	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Mouse")]
	[CalledBy(Type = typeof(InputManager), Member = "CheckForActiveController")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Keyboard")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Mouse")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Keyboard")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ClearAllControllers")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "FindActiveGamepad")]
	public bool CheckForActiveController()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	public float GetScroll()
	{
		return default(float);
	}

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public int GetActiveUserID()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ulong GetActiveJoystickID()
	{
		return default(ulong);
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetAnyMouseOrStickMovement")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetMenuNavigationPrimary")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetCameraMovementGamepad")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetScroll")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetAnyMouseOrStickMovement")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetAnyMouseOrStickMovement")]
	[CalledBy(Type = typeof(InputManager), Member = "GetScroll")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(InteractiveScrollText), Member = "Update")]
	private Vector2 GetAxis(InputManager.InputAxis axis, int axisXActionId, int axisYactionId)
	{
		return default(Vector2);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool GetRewiredButtonPressed(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 175)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private bool GetButtonPressed(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Player), Member = "GetButtonUp")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool GetRewiredButtonUnpressed(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetFireReleased")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetInventoryDropReleased")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetAltFireReleased")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetInteractReleased")]
	[CalledBy(Type = typeof(Condition_ActionInputButton), Member = "OnCheck")]
	[CalledBy(Type = typeof(Condition_ActionInputButton), Member = "Test")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetInputActionReleased")]
	[CalledBy(Type = typeof(InputManager), Member = "GetAltFireReleased")]
	[CalledBy(Type = typeof(InputManager), Member = "GetInteractReleased")]
	[CalledBy(Type = typeof(InputManager), Member = "GetInventoryDropReleased")]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Player), Member = "GetButtonUp")]
	[CalledBy(Type = typeof(InputManager), Member = "GetFireReleased")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "Update")]
	private bool GetButtonUnpressed(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Player), Member = "GetButton")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 2)]
	private bool GetRewiredButton(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Player), Member = "GetButton")]
	[CallerCount(Count = 65)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	private bool GetButton(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetFlyModeMoveSlowMultiplier")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetFlyModeMoveFastMultiplier")]
	[CalledBy(Type = typeof(InputManager), Member = "GetFlyModeMoveSlowMultiplier")]
	[CalledBy(Type = typeof(InputManager), Member = "GetFlyModeMoveFastMultiplier")]
	[CalledBy(Type = typeof(FlyMode), Member = "LateUpdate")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(FlyMode), Member = "LateUpdate")]
	private float GetRewiredActionAsAxis(InputManager.InputAction action)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetMenuNavigationPrimary")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public Vector2 GetPlayerMovementKeyboard()
	{
		return default(Vector2);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool WasLastControllerActiveSteam()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool WasLastControllerActivePS4()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool WasLastControllerActiveSwitch()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InputManager), Member = "GetSafeCrackingMovementDirection")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "GetAxisValue")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "OnCheck")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetSafeCrackingMovementDirection")]
	[CalledBy(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "Test")]
	[CalledBy(Type = typeof(SafeCracking), Member = "GetDialDelta")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovementKeyboard")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "UpdateLimpAnimation")]
	public Vector2 GetPlayerMovement()
	{
		return default(Vector2);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "Test")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "GetAxisValue")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "OnCheck")]
	[CalledBy(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	public Vector2 GetCameraMovementMouse()
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "Test")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "GetAxisValue")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "OnCheck")]
	[CalledBy(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	public Vector2 GetCameraMovementGamepad()
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetInteractPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	public bool GetInteractReleased()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetSprintDown()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetAutoWalkDown()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetCompassPressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetCrouchPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetReloadPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetEquipPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown")]
	[CallsUnknownMethods(Count = 4)]
	public bool GetPickupPressed()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Application), Member = "get_platform")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetPutBackPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetHolsterPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetOpenActionsPanelPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetOpenActionsPanelHeldDown()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetOpenInventoryPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetOpenClothingPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetOpenJournalPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetOpenFirstAidPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetOpenMapPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetPauseMenuTogglePressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetEscapePressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetCarryPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetQuarterPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetHarvestCharcoalPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetContinuePressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetStartFirePressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetEquipLightSourcePressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetDeployDecoyPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetEquipWeaponPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetMenuToolSelectPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetMenuBuyNowPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetQuickSavePressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetQuickLoadPressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetHinterlandMailingListPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetSkyboundInsidersPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetScrollDownPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetScrollUpPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetScrollDownHeld()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetScrollUpHeld()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InputManager), Member = "GetMenuNavigationPrimary")]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonUp")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovementKeyboard")]
	public Vector2 GetMenuNavigationPrimary()
	{
		return default(Vector2);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public Vector2 GetMenuNavigationSecondary()
	{
		return default(Vector2);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 0)]
	public bool GetRadialButtonHeldDown()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetRadialButton()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetInventoryDropPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetInventoryDropHeldDown()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	public bool GetInventoryDropReleased()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetInventoryFilterLeftPressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetInventoryFilterRightPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetInventoryEquipPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetInventoryExaminePressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetInventorySortPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetInventoryAddToSatchelPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetContainerSelectLeftTablePressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetContainerSelectRightTablePressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetOptionsConfirmPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetStruggleTapPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetStruggleTapHeldDown()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetFeedFireTakeTorchePressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetQuickSelect1Pressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetQuickSelect2Pressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetQuickSelect3Pressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetQuickSelect4Pressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetTabLeftPressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	public bool GetTabRightPressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 0)]
	public bool GetFirePressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	public bool GetFireReleased()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetAltFirePressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetAltFire()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	public bool GetAltFireReleased()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetRewiredActionAsAxis")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallerCount(Count = 0)]
	public float GetFlyModeMoveSlowMultiplier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetRewiredActionAsAxis")]
	[CallsUnknownMethods(Count = 2)]
	public float GetFlyModeMoveFastMultiplier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetFlyModeMoveUpDown()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetFlyModeMoveDownDown()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 0)]
	public bool GetFlyModeLockOrientationDown()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetFlyModeAcceptPlacement()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetFlyModeCancelPlacement()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetFlyModeToggleEnabled()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetThreeDaysOfNightToggle()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetFlyModeToggleCoords()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetSafeCrackingLeft()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetSafeCrackingRight()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	public float GetSafeCrackingMovementDirection()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetDebugMenuTogglePressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetLeftPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetRightPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetShowAccountPickerPressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetShowStatsScreenPressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetResetAllTimeStatsPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetRenamePressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetDeletePressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetOverwritePressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetSaveJournalPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetRotateClockwiseHeld()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 0)]
	public bool GetRotateCounterClockwiseHeld()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetCraftingPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetShowSteamControllerBindingsPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromKeyboardPolling")]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromMousePolling")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	public bool PoleForKeyRemap(string actionName, out string keyName)
	{
		keyName = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(InputManager), Member = "UpdateKeyBindingTable")]
	[Calls(Type = typeof(KeyRebindingButton), Member = "SetValueLabel")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_elementIdentifierName")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(KeyRebindingButton), Member = "SetValueLabel")]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateKeyBindingTable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void ApplyRemapping()
	{
	}

	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "LoadRemapping")]
	[CalledBy(Type = typeof(InputManager), Member = "ResetKeybindingsToDefault")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "LoadDefaultMaps")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "AZOxHXNYoYmDNxdKLSbyHBepCxG")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "vCwWmZNlNchsKYePzGBBmGGyFOB")]
	public void ResetKeybindingsToDefault()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void InitializeDefaultKeyBindings()
	{
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetSteamButtonOrAxisNameForAction")]
	[CalledBy(Type = typeof(InputManager), Member = "GetButtonNameForAction")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnGUI")]
	[CalledBy(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolWithKeycode")]
	[CalledBy(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolWithKeycode")]
	[Calls(Type = typeof(InputManager), Member = "ConvertKeycodeToLabel")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PoleForKeyRemap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMouseMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ActionElementMap), Member = "get_elementIdentifierName")]
	public string GetButtonNameForAction(InputManager.ControllerType controllerType, string action, bool convertKeycodes = true)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "LoadRemapping")]
	[CalledBy(Type = typeof(InputManager), Member = "SetGamepadEnabled")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AEAGuWUxmCMnWwXPzMBFgjoWoCu")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	public void SetGamepadEnabled(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	public void OnPlayerControllerDisconnected()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "CreateReassignment")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "RemoveKeybinding")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	private KeyboardMap GetKeyboardMap()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "CreateReassignment")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "RemoveKeybinding")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	private MouseMap GetMouseMap()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Update")]
	[CalledBy(Type = typeof(InputManager), Member = "Update")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(InputSystemRewired), Member = "AnySteamAxisPressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "AnySteamButtonPressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "PollForFirstAxis")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "IsInBootScene")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	private void MaybeSetGamepadActive()
	{
	}

	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[CalledBy(Type = typeof(InputManager), Member = "Update")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Keyboard")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Update")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(Keyboard), Member = "PollForFirstKeyDown")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Mouse")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Mouse")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "PollForFirstAxis")]
	private void MaybeSetMouseOrKeyboardActive()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMap")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ClearAllControllers")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	private void JoystickConnect(ControllerStatusChangedEventArgs args)
	{
	}

	[Calls(Type = typeof(InputManager), Member = "OnPlayerControllerDisconnected")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ContainsController")]
	private void JoystickPreDisconnect(ControllerStatusChangedEventArgs args)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void JoystickDisconnect(ControllerStatusChangedEventArgs args)
	{
	}

	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GouCKvssMFMACiWJfaRQHCDLBuzb")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(InputSystemRewired), Member = "SetGamepadEnabled")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "JoystickConnect")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "JoystickPreDisconnect")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "FindActiveGamepad")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "UpdateSteamController")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ClearAllControllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Keyboard")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(InputSystemRewired), Member = "DebugLogControllerConnected")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Mouse")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	private void SetActiveController(Controller controller)
	{
	}

	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "CheckForActiveController")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Update")]
	[CalledBy(Type = typeof(InputManager), Member = "Update")]
	[Calls(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "PollForFirstAxis")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(InputSystemRewired), Member = "FindActiveSteamController")]
	private bool FindActiveGamepad(bool includeAxis)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ControllerMap), Member = "DeleteButtonMapsWithAction")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMouseMap")]
	[Calls(Type = typeof(ControllerMap), Member = "DeleteButtonMapsWithAction")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromMousePolling")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	private void RemoveKeybinding(InputAction action)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ActionElementMap), Member = "get_modifierKeyFlags")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "RebindKeybindingConflicts")]
	[Calls(Type = typeof(Keyboard), Member = "untSoBSHcWcUVKSpUbQMajhzKPH")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMouseMap")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ControllerMap), Member = "ReplaceOrCreateElementMap")]
	private void CreateReassignment(ActionElementMap existingBinding, InputAction action)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CreateReassignment")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromMousePolling")]
	[CallsUnknownMethods(Count = 10)]
	private void RebindKeybindingConflicts(ControllerMap controllerMap, ElementAssignment elementAssignment, ActionElementMap existingBinding)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromMousePolling")]
	private ActionElementMap GetExistingBinding(InputAction action)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnGUI")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PoleForKeyRemap")]
	[CallerCount(Count = 2)]
	[CallAnalysisFailed]
	private bool MaybeCreateElementAssignmentFromKeyboardPolling(string actionName)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(Player.ControllerHelper.PollingHelper), Member = "PollControllerForFirstButtonDown")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetExistingBinding")]
	[Calls(Type = typeof(InputSystemRewired), Member = "RemoveKeybinding")]
	[Calls(Type = typeof(InputSystemRewired), Member = "RebindKeybindingConflicts")]
	[Calls(Type = typeof(ControllerMap), Member = "ReplaceOrCreateElementMap")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnGUI")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PoleForKeyRemap")]
	[CallsUnknownMethods(Count = 1)]
	private bool MaybeCreateElementAssignmentFromMousePolling(string actionName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetInputActionPressed(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	public bool GetInputActionReleased(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetInputActionHeld(InputManager.InputAction action)
	{
		return default(bool);
	}

	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetMapCategory")]
	[Calls(Type = typeof(ControllerMap), Member = "get_categoryId")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMaps")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(ControllerMap), Member = "get_layoutId")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ControllerMap), Member = "get_enabled")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ControllerMap), Member = "GetElementMaps")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_elementIdentifierName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[CallsUnknownMethods(Count = 127)]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetJoystickLayout")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareName")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_Players")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "IsControllerAssigned")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void DebugLogControllerConnected()
	{
	}

	[CallerCount(Count = 0)]
	public string GetPS4ControllerHardwareGuid()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateControlsMenuItems")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "IsXboxController")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[CalledBy(Type = typeof(InputManager), Member = "GetButtonMap")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateControlsMenuItems")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "GetActiveDictionary")]
	public bool IsPS4Controller()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsSwitchController()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasReconnectedPS4Controller()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool HasReconnectedJoystick()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	public bool IsXboxController()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Joystick), Member = "StopVibration")]
	[CalledBy(Type = typeof(InputManager), Member = "StopVibration")]
	[CallsUnknownMethods(Count = 16)]
	public void StopVibration()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Joystick), Member = "SetVibration")]
	[Calls(Type = typeof(Joystick), Member = "get_vibrationMotorCount")]
	[Calls(Type = typeof(Joystick), Member = "SetVibration")]
	[Calls(Type = typeof(Joystick), Member = "get_supportsVibration")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Joystick), Member = "get_vibrationMotorCount")]
	public void SetVibration(float motor0, float motor1)
	{
	}

	[Calls(Type = typeof(SteamInput), Member = "GetDigitalActionHandle")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "UpdateSteamController")]
	[Calls(Type = typeof(SteamInput), Member = "GetAnalogActionHandle")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(SteamInput), Member = "GetActionSetHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(SteamInput), Member = "GetActionSetHandle")]
	[Calls(Type = typeof(SteamInput), Member = "GetActionSetHandle")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	private void InitializeSteamController()
	{
	}

	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "IsInBootScene")]
	private bool InMenus()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void SetInInteractiveDisplay(bool inInteractiveDisplay)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsInInteractiveDisplay()
	{
		return default(bool);
	}

	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "TryUpdateSteamControllerActionSet")]
	[CallerCount(Count = 0)]
	public void RefreshSteamControllerActionSet()
	{
	}

	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Update")]
	[CalledBy(Type = typeof(InputManager), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "OnPlayerControllerDisconnected")]
	[Calls(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(SteamInput), Member = "GetAnalogActionData")]
	[Calls(Type = typeof(SteamInput), Member = "GetDigitalActionData")]
	[Calls(Type = typeof(SteamInput), Member = "RunFrame")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InputSystemRewired), Member = "TryUpdateSteamControllerActionSet")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(InputSystemRewired), Member = "InitializeSteamController")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void UpdateSteamController()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	private bool IsSteamControllerPresent()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "FindActiveGamepad")]
	[Calls(Type = typeof(SteamInput), Member = "GetAnalogActionData")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(SteamInput), Member = "GetDigitalActionData")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(SteamInput), Member = "RunFrame")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	private bool FindActiveSteamController()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeSetGamepadActive")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Update")]
	[CalledBy(Type = typeof(InputManager), Member = "Update")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	public bool IsSteamControllerActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[CallsUnknownMethods(Count = 3)]
	public ESteamInputType GetCurrentControllerSteamInputType()
	{
		return default(ESteamInputType);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsSteamControllerDisconnected()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "AnyButtonsOrKeysPressed")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeSetGamepadActive")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private bool AnySteamButtonPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetAnyMouseOrStickMovement")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeSetGamepadActive")]
	[CallsUnknownMethods(Count = 4)]
	private bool AnySteamAxisPressed()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool GetSteamButtonPressed(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool GetSteamButtonUnpressed(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool GetSteamButton(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "IndexOf")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(SteamInput), Member = "GetCurrentActionSet")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	private string GetSteamButtonOrAxisNameForAction(string action)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "ResetControllerState")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private void ResetSteamControllerState()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[CallsUnknownMethods(Count = 3)]
	public void ShowSteamControllerBindingPanel()
	{
	}

	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "UpdateSteamController")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "RefreshSteamControllerActionSet")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(InputManager), Member = "IsInBootScene")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SteamInput), Member = "GetCurrentActionSet")]
	private bool TryUpdateSteamControllerActionSet(int connectedSteamControllers)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static float GetSteamInputSensitivityFactor()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 89)]
	[CalledBy(Type = typeof(InputManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 18)]
	public InputSystemRewired()
	{
	}
}
