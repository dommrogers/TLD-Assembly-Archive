using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Conditions;
using Rewired;
using Steamworks;
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
		[CallerCount(Count = 2)]
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

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public Vector2 GetAxis()
		{
			return default(Vector2);
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Vector2), Member = "op_Inequality")]
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(InputSystemRewired), Member = "AnySteamAxisPressed")]
		public bool ValueChanged()
		{
			return default(bool);
		}

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
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

	private Dictionary<InputManager.InputAction, InputController_ButtonState> m_SteamControllerButtonState;

	private Dictionary<InputManager.InputAxis, InputController_AxisState> m_SteamControllerAxisState;

	private bool m_SteamControllerInitialized;

	private bool m_InInteractiveDisplay;

	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(Guid), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMaps")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ControllerMap), Member = "get_categoryId")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetMapCategory")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetJoystickLayout")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(ControllerMap), Member = "get_enabled")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ControllerMap), Member = "GetElementMaps")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_elementIdentifierName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ControllerMap), Member = "get_layoutId")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(Guid), Member = "op_Inequality")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "IsControllerAssigned")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_Players")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareName")]
	[CallsUnknownMethods(Count = 102)]
	private void PrintDebugInfo()
	{
	}

	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerDisconnectedEvent")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerConnectedEvent")]
	[Calls(Type = typeof(InputSystemRewired), Member = "PrintDebugInfo")]
	[CalledBy(Type = typeof(InputManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "SetAllMapsEnabled")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerPreDisconnectEvent")]
	[Calls(Type = typeof(ReInput), Member = "get_configuration")]
	[Calls(Type = typeof(ReInput.ConfigHelper), Member = "set_windowsStandalonePrimaryInputSource")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[Calls(Type = typeof(ReInput.ConfigHelper), Member = "set_windowsStandalonePrimaryInputSource")]
	[Calls(Type = typeof(ReInput), Member = "get_configuration")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void Initialize()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "Update")]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeSetGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeSetMouseOrKeyboardActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "FindActiveGamepad")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InputSystemRewired), Member = "UpdateSteamController")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(InputSystemRewired), Member = "ResetSteamControllerState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Controller.Element), Member = "Reset")]
	[Calls(Type = typeof(Controller), Member = "get_Buttons")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Controller), Member = "get_Buttons")]
	public void ResetControllerState()
	{
	}

	[Calls(Type = typeof(ControllerMap), Member = "ToXmlString")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetMappingFromCInput")]
	[CalledBy(Type = typeof(InputManager), Member = "SaveRemapping")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Serialize")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "SetAllMapsEnabled")]
	[Calls(Type = typeof(ControllerMapSaveData), Member = "get_map")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(ControllerMap), Member = "ToXmlString")]
	[Calls(Type = typeof(ControllerMapSaveData), Member = "get_map")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Player), Member = "GetSaveData")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void SaveRemapping()
	{
	}

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
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[CallsUnknownMethods(Count = 81)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "LoadRemapping")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
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
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	private void PatchControllerMapping()
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	private bool CheckForExistingKeyboardMapping(KeyCode keycode)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[CallsUnknownMethods(Count = 34)]
	[CalledBy(Type = typeof(InputManager), Member = "LoadRemapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "ResetKeybindingsToDefault")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "RemoveController")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "ClearMaps")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "AddMapsFromXml")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "ClearMaps")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "AddMapsFromXml")]
	public void LoadRemapping()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(InputManager), Member = "AnyButtonsOrKeysPressed")]
	[CalledBy(Type = typeof(InputManager), Member = "AnyInput")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(InputSystemRewired), Member = "AnySteamButtonPressed")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Keyboard")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Mouse")]
	public bool AnyButtonsOrKeysPressed()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "AnyMouseOrStickMovement")]
	[CalledBy(Type = typeof(InputManager), Member = "AnyInput")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(InputSystemRewired), Member = "AnySteamAxisPressed")]
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	public bool GetAnyMouseOrStickMovement()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(InputManager), Member = "CheckForActiveController")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Mouse")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Keyboard")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Keyboard")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Mouse")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "FindActiveGamepad")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ClearAllControllers")]
	public bool CheckForActiveController()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetScroll()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetMenuNavigationPrimary")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetCameraMovementGamepad")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetScroll")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetAnyMouseOrStickMovement")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetAnyMouseOrStickMovement")]
	[CalledBy(Type = typeof(InputManager), Member = "GetScroll")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	private Vector2 GetAxis(InputManager.InputAxis axis, int axisXActionId, int axisYactionId)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 5)]
	private bool GetRewiredButtonPressed(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 157)]
	private bool GetButtonPressed(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Player), Member = "GetButtonUp")]
	[CallsUnknownMethods(Count = 5)]
	private bool GetRewiredButtonUnpressed(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Condition_ActionInputButton), Member = "Test")]
	[CalledBy(Type = typeof(Condition_ActionInputButton), Member = "OnCheck")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetInputActionReleased")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetAltFireReleased")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetFireReleased")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetInventoryDropReleased")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetInteractReleased")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[CalledBy(Type = typeof(InputManager), Member = "GetFireReleased")]
	[CalledBy(Type = typeof(InputManager), Member = "GetInventoryDropReleased")]
	[CalledBy(Type = typeof(InputManager), Member = "GetInteractReleased")]
	[Calls(Type = typeof(Player), Member = "GetButtonUp")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(InputManager), Member = "GetAltFireReleased")]
	private bool GetButtonUnpressed(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Player), Member = "GetButton")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool GetRewiredButton(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallerCount(Count = 64)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Player), Member = "GetButton")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 8)]
	private bool GetButton(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetFlyModeMoveSlowMultiplier")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetFlyModeMoveFastMultiplier")]
	[CalledBy(Type = typeof(InputManager), Member = "GetFlyModeMoveSlowMultiplier")]
	[CalledBy(Type = typeof(InputManager), Member = "GetFlyModeMoveFastMultiplier")]
	[CalledBy(Type = typeof(FlyMode), Member = "LateUpdate")]
	[CalledBy(Type = typeof(FlyMode), Member = "LateUpdate")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	private float GetRewiredActionAsAxis(InputManager.InputAction action)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetMenuNavigationPrimary")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public Vector2 GetPlayerMovementKeyboard()
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	public bool WasLastControllerActiveSteam()
	{
		return default(bool);
	}

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
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "Test")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "GetAxisValue")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetSafeCrackingMovementDirection")]
	[CalledBy(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SafeCracking), Member = "GetDialDelta")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovementKeyboard")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "UpdateLimpAnimation")]
	public Vector2 GetPlayerMovement()
	{
		return default(Vector2);
	}

	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "Test")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "GetAxisValue")]
	[CalledBy(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public Vector2 GetCameraMovementMouse()
	{
		return default(Vector2);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "Test")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "GetAxisValue")]
	[CalledBy(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
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

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetCompassPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
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

	[CalledBy(Type = typeof(InputManager), Member = "GetPickupPressed")]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	public bool GetPickupPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(Application), Member = "get_platform")]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown")]
	[CalledBy(Type = typeof(InputManager), Member = "GetPutBackPressed")]
	[CallsUnknownMethods(Count = 3)]
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

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 0)]
	public bool GetOpenActionsPanelHeldDown()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetEquipLightSourcePressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetDeployDecoyPressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetHinterlandMailingListPressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CalledBy(Type = typeof(InputManager), Member = "GetMenuNavigationPrimary")]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonUp")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovementKeyboard")]
	public Vector2 GetMenuNavigationPrimary()
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public Vector2 GetMenuNavigationSecondary()
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
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

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetStruggleTapPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetTabLeftPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetTabRightPressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool GetFirePressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetRewiredActionAsAxis")]
	[CallerCount(Count = 0)]
	public float GetFlyModeMoveSlowMultiplier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetRewiredActionAsAxis")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
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

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
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

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallsUnknownMethods(Count = 2)]
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

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetRightPressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetShowAccountPickerPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetShowStatsScreenPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
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

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 0)]
	public bool GetRotateClockwiseHeld()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
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
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(KeyRebindingButton), Member = "SetValueLabel")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_elementIdentifierName")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	public void UpdateKeyBindingTable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void ApplyRemapping()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ResetKeybindingsToDefault")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "LoadDefaultMaps")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "LoadDefaultMaps")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "LoadDefaultMaps")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "LoadRemapping")]
	[CallsUnknownMethods(Count = 1)]
	public void ResetKeybindingsToDefault()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
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
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMouseMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ActionElementMap), Member = "get_elementIdentifierName")]
	public string GetButtonNameForAction(InputManager.ControllerType controllerType, string action, bool convertKeycodes = true)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "RemoveController")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	public void SetGamepadEnabled(bool enabled)
	{
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DeserializeSettings")]
	[Calls(Type = typeof(InputSystemRewired), Member = "SaveRemapping")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(InputSystemRewired), Member = "RemoveKeybinding")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMouseMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "LoadDefaultMaps")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "LoadDefaultMaps")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "LoadDefaultMaps")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	public void GetMappingFromCInput()
	{
	}

	[CallerCount(Count = 0)]
	public void OnPlayerControllerDisconnected()
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetMappingFromCInput")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "RemoveKeybinding")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetExistingBinding")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromKeyboardPolling")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "CreateReassignment")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	private KeyboardMap GetKeyboardMap()
	{
		return null;
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetExistingBinding")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromMousePolling")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "CreateReassignment")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetMappingFromCInput")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "RemoveKeybinding")]
	private MouseMap GetMouseMap()
	{
		return null;
	}

	[Calls(Type = typeof(ControllerWithAxes), Member = "PollForFirstAxis")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Update")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(InputSystemRewired), Member = "AnySteamAxisPressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "AnySteamButtonPressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "IsInBootScene")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	private void MaybeSetGamepadActive()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Update")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(Keyboard), Member = "PollForFirstKeyDown")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Keyboard")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "PollForFirstAxis")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Mouse")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Mouse")]
	private void MaybeSetMouseOrKeyboardActive()
	{
	}

	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ClearAllControllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPS4ControllerHardwareGuid")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void JoystickConnect(ControllerStatusChangedEventArgs args)
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "UpdateSteamController")]
	[Calls(Type = typeof(InputManager), Member = "OnPlayerControllerDisconnected")]
	[Calls(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ContainsController")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void JoystickPreDisconnect(ControllerStatusChangedEventArgs args)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void JoystickDisconnect(ControllerStatusChangedEventArgs args)
	{
	}

	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMap")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "RemoveController")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "DebugLogControllerConnected")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "JoystickConnect")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "JoystickPreDisconnect")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "FindActiveGamepad")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ClearAllControllers")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Mouse")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Keyboard")]
	private void SetActiveController(Controller controller)
	{
	}

	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "CheckForActiveController")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "PollForFirstAxis")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Update")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "FindActiveSteamController")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private bool FindActiveGamepad(bool includeAxis)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromMousePolling")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetMappingFromCInput")]
	[Calls(Type = typeof(ControllerMap), Member = "DeleteButtonMapsWithAction")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromKeyboardPolling")]
	[Calls(Type = typeof(ControllerMap), Member = "DeleteButtonMapsWithAction")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMouseMap")]
	private void RemoveKeybinding(InputAction action)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMouseMap")]
	[Calls(Type = typeof(ControllerMap), Member = "ReplaceOrCreateElementMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_modifierKeyFlags")]
	[Calls(Type = typeof(Keyboard), Member = "GetElementIdentifierIdByKeyCode")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "RebindKeybindingConflicts")]
	[CallsUnknownMethods(Count = 1)]
	private void CreateReassignment(ActionElementMap existingBinding, InputAction action)
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromKeyboardPolling")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromMousePolling")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(InputSystemRewired), Member = "CreateReassignment")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ElementAssignment), Member = "ToElementAssignmentConflictCheck")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	private void RebindKeybindingConflicts(ControllerMap controllerMap, ElementAssignment elementAssignment, ActionElementMap existingBinding)
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromKeyboardPolling")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMouseMap")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromMousePolling")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	private ActionElementMap GetExistingBinding(InputAction action)
	{
		return null;
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PoleForKeyRemap")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnGUI")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(ControllerMap), Member = "ReplaceOrCreateElementMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "RebindKeybindingConflicts")]
	[Calls(Type = typeof(ElementAssignment), Member = "KeyboardKeyAssignment")]
	[Calls(Type = typeof(InputSystemRewired), Member = "RemoveKeybinding")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetExistingBinding")]
	[Calls(Type = typeof(InputManager), Member = "GetKeycodeCanBeBound")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Keyboard")]
	[Calls(Type = typeof(Keyboard), Member = "PollForAllKeys")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Keyboard")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	private bool MaybeCreateElementAssignmentFromKeyboardPolling(string actionName)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PoleForKeyRemap")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnGUI")]
	[Calls(Type = typeof(InputSystemRewired), Member = "RemoveKeybinding")]
	[Calls(Type = typeof(ControllerMap), Member = "ReplaceOrCreateElementMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "RebindKeybindingConflicts")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetExistingBinding")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMouseMap")]
	[Calls(Type = typeof(Player.ControllerHelper.PollingHelper), Member = "PollControllerForFirstButtonDown")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	private bool MaybeCreateElementAssignmentFromMousePolling(string actionName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
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

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 0)]
	public bool GetInputActionHeld(InputManager.InputAction action)
	{
		return default(bool);
	}

	[Calls(Type = typeof(ControllerMap), Member = "get_layoutId")]
	[Calls(Type = typeof(Guid), Member = "op_Inequality")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMaps")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ControllerMap), Member = "get_categoryId")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetMapCategory")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ControllerMap), Member = "GetElementMaps")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_elementIdentifierName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[CallsUnknownMethods(Count = 102)]
	[Calls(Type = typeof(ControllerMap), Member = "get_enabled")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetJoystickLayout")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareName")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_Players")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "IsControllerAssigned")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(Guid), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void DebugLogControllerConnected()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "JoystickConnect")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	public string GetPS4ControllerHardwareGuid()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateControlsMenuItems")]
	[CalledBy(Type = typeof(InputManager), Member = "GetButtonMap")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "IsXboxController")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateControlsMenuItems")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "GetActiveDictionary")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPS4ControllerHardwareGuid")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasReconnectedJoystick()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	public bool IsXboxController()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Joystick), Member = "StopVibration")]
	[CalledBy(Type = typeof(InputManager), Member = "StopVibration")]
	[CallsUnknownMethods(Count = 14)]
	public void StopVibration()
	{
	}

	[Calls(Type = typeof(Joystick), Member = "SetVibration")]
	[CalledBy(Type = typeof(InputManager), Member = "SetVibration")]
	[Calls(Type = typeof(Joystick), Member = "SetVibration")]
	[Calls(Type = typeof(Joystick), Member = "get_vibrationMotorCount")]
	[Calls(Type = typeof(Joystick), Member = "get_vibrationMotorCount")]
	[CalledBy(Type = typeof(RumbleEffectManager), Member = "Update")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Joystick), Member = "get_supportsVibration")]
	[CallsUnknownMethods(Count = 8)]
	public void SetVibration(float motor0, float motor1)
	{
	}

	[Calls(Type = typeof(SteamInput), Member = "GetDigitalActionHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(SteamInput), Member = "GetAnalogActionHandle")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "UpdateSteamController")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(SteamInput), Member = "GetActionSetHandle")]
	[Calls(Type = typeof(SteamInput), Member = "GetActionSetHandle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(SteamInput), Member = "GetActionSetHandle")]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[CallsDeduplicatedMethods(Count = 12)]
	private void InitializeSteamController()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "TryUpdateSteamControllerActionSet")]
	[Calls(Type = typeof(InputManager), Member = "IsInBootScene")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private bool InMenus()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void SetInInteractiveDisplay(bool inInteractiveDisplay)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsInInteractiveDisplay()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "TryUpdateSteamControllerActionSet")]
	public void RefreshSteamControllerActionSet()
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Update")]
	[Calls(Type = typeof(InputSystemRewired), Member = "JoystickPreDisconnect")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(SteamInput), Member = "GetDigitalActionData")]
	[Calls(Type = typeof(InputSystemRewired), Member = "TryUpdateSteamControllerActionSet")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(SteamInput), Member = "RunFrame")]
	[Calls(Type = typeof(InputSystemRewired), Member = "InitializeSteamController")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public void UpdateSteamController()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	private bool IsSteamControllerPresent()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "FindActiveGamepad")]
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	[Calls(Type = typeof(SteamInput), Member = "GetAnalogActionData")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(SteamInput), Member = "RunFrame")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SteamInput), Member = "GetDigitalActionData")]
	private bool FindActiveSteamController()
	{
		return default(bool);
	}

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsSteamControllerActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	public ESteamInputType GetCurrentControllerSteamInputType()
	{
		return default(ESteamInputType);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	public bool IsSteamControllerDisconnected()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "AnyButtonsOrKeysPressed")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeSetGamepadActive")]
	[CallsUnknownMethods(Count = 7)]
	private bool AnySteamButtonPressed()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeSetGamepadActive")]
	[Calls(Type = typeof(InputController_AxisState), Member = "ValueChanged")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetAnyMouseOrStickMovement")]
	private bool AnySteamAxisPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool GetSteamButtonPressed(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool GetSteamButtonUnpressed(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool GetSteamButton(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetSteamButtonOrAxisNameForAction")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetSteamButtonOrAxisNameForAction")]
	[Calls(Type = typeof(SteamInput), Member = "GetCurrentActionSet")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private string GetSteamButtonOrAxisNameForAction(string action)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetSteamButtonOrAxisNameForAction")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetSteamButtonOrAxisNameForAction")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	private string GetSteamButtonOrAxisNameForAction(InputHandle_t[] controllers, InputActionSetHandle_t actionSetHandle, string action)
	{
		return null;
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "ResetControllerState")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsUnknownMethods(Count = 14)]
	private void ResetSteamControllerState()
	{
	}

	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[CallerCount(Count = 0)]
	public void ShowSteamControllerBindingPanel()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "InMenus")]
	[Calls(Type = typeof(SteamInput), Member = "GetCurrentActionSet")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "RefreshSteamControllerActionSet")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "UpdateSteamController")]
	[CallsUnknownMethods(Count = 8)]
	private bool TryUpdateSteamControllerActionSet(int connectedSteamControllers)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static float GetSteamInputSensitivityFactor()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(InputManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 24)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 90)]
	public InputSystemRewired()
	{
	}
}
