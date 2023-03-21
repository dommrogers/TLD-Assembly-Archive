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

	private class InputActionComparer : IEqualityComparer<InputManager.InputAction>
	{
		public static readonly InputActionComparer Comparer;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private InputActionComparer()
		{
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public bool Equals(InputManager.InputAction x, InputManager.InputAction y)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public int GetHashCode(InputManager.InputAction x)
		{
			return default(int);
		}
	}

	private class InputAxisComparer : IEqualityComparer<InputManager.InputAxis>
	{
		public static readonly InputAxisComparer Comparer;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private InputAxisComparer()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool Equals(InputManager.InputAxis x, InputManager.InputAxis y)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public int GetHashCode(InputManager.InputAxis x)
		{
			return default(int);
		}
	}

	private class InputController_ButtonState
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

	private class InputController_AxisState
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

	private const float STEAM_INPUT_SENSITIVITY = 0.118f;

	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	private int m_ActiveSteamControllerIndex;

	private bool m_SteamControllerInitialized;

	private bool m_InInteractiveDisplay;

	private InputActionSetHandle_t m_ActionSetHandleGameplay;

	private InputActionSetHandle_t m_ActionSetHandleInterface;

	private InputActionSetHandle_t m_ActionSetHandleInteractiveDisplay;

	private readonly InputActionSetHandle_t INVALID_ACTION_SETHANDLE;

	private readonly InputHandle_t[] m_TempControllerHandles;

	private readonly EInputActionOrigin[] m_InputOrigins;

	private readonly Dictionary<InputManager.InputAction, InputController_ButtonState> m_SteamControllerButtonState;

	private readonly Dictionary<InputManager.InputAxis, InputController_AxisState> m_SteamControllerAxisState;

	private static readonly InputManager.InputAction[] s_ButtonEnums;

	private static readonly InputManager.InputAxis[] s_AxisEnums;

	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareName")]
	[CallsUnknownMethods(Count = 108)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareIdentifier")]
	[Calls(Type = typeof(Controller), Member = "get_buttonCount")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PrintDebugInfo")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "get_axisCount")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(Controller.Button), Member = "get_value")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_AllPlayers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ContainsController")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Controller), Member = "get_buttonCount")]
	[Calls(Type = typeof(Controller), Member = "get_Buttons")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	private string PrintJoystickDebugInfo(int joystickIndex)
	{
		return null;
	}

	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetMapCategory")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ControllerMap), Member = "get_layoutId")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetJoystickLayout")]
	[Calls(Type = typeof(ControllerMap), Member = "get_enabled")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 77)]
	[Calls(Type = typeof(ControllerMap), Member = "GetElementMaps")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_elementIdentifierName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PrintDebugInfo")]
	[Calls(Type = typeof(ControllerMap), Member = "get_categoryId")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMaps")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_Players")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(Player), Member = "get_name")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Format")]
	private string PrintPlayerDebugInfo(int playerIndex)
	{
		return null;
	}

	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Initialize")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Rewired.Logger), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InputSystemRewired), Member = "PrintPlayerDebugInfo")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "PrintJoystickDebugInfo")]
	private void PrintDebugInfo()
	{
	}

	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeSetMouseOrKeyboardActive")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeSetGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "FindActiveGamepad")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "UpdateSteamController")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(InputManager), Member = "ResetControllerState")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[Calls(Type = typeof(Controller.Element), Member = "Reset")]
	[Calls(Type = typeof(Controller), Member = "get_Buttons")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Controller), Member = "get_Buttons")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(InputSystemRewired), Member = "ResetSteamControllerState")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	public void ResetControllerState()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InputManager), Member = "SaveRemapping")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnBeforeSerialization")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "SetAllMapsEnabled")]
	[Calls(Type = typeof(ControllerMap), Member = "ToXmlString")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
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
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "LoadRemapping")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
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
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
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
	[CallsDeduplicatedMethods(Count = 9)]
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
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[CallsDeduplicatedMethods(Count = 3)]
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
	[CalledBy(Type = typeof(InputManager), Member = "AnyButtonsOrKeysPressed")]
	[CallsUnknownMethods(Count = 2)]
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
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "CheckForActiveController")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Keyboard")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Keyboard")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "FindActiveGamepad")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ClearAllControllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Mouse")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 16)]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetMenuNavigationPrimary")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetCameraMovementGamepad")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetScroll")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetAnyMouseOrStickMovement")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetAnyMouseOrStickMovement")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetAnyMouseOrStickMovement")]
	[CalledBy(Type = typeof(InteractiveScrollText), Member = "Update")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(InputManager), Member = "GetScroll")]
	private Vector2 GetAxis(InputManager.InputAxis axis, int axisXActionId, int axisYactionId)
	{
		return default(Vector2);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	private bool GetRewiredButtonPressed(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 174)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private bool GetButtonPressed(InputManager.InputAction action)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Player), Member = "GetButtonUp")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool GetRewiredButtonUnpressed(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Condition_ActionInputButton), Member = "Test")]
	[CalledBy(Type = typeof(Condition_ActionInputButton), Member = "OnCheck")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetInputActionReleased")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetAltFireReleased")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetFireReleased")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetInventoryDropReleased")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetInteractReleased")]
	[CalledBy(Type = typeof(InputManager), Member = "GetAltFireReleased")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "GetInventoryDropReleased")]
	[CalledBy(Type = typeof(InputManager), Member = "GetInteractReleased")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "Update")]
	[Calls(Type = typeof(Player), Member = "GetButtonUp")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[CalledBy(Type = typeof(InputManager), Member = "GetFireReleased")]
	[CallerCount(Count = 14)]
	private bool GetButtonUnpressed(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "GetButton")]
	private bool GetRewiredButton(InputManager.InputAction action)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[CallerCount(Count = 65)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Player), Member = "GetButton")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 3)]
	private bool GetButton(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetFlyModeMoveFastMultiplier")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetFlyModeMoveSlowMultiplier")]
	[CalledBy(Type = typeof(InputManager), Member = "GetFlyModeMoveFastMultiplier")]
	[CalledBy(Type = typeof(InputManager), Member = "GetFlyModeMoveSlowMultiplier")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[CalledBy(Type = typeof(FlyMode), Member = "LateUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(FlyMode), Member = "LateUpdate")]
	private float GetRewiredActionAsAxis(InputManager.InputAction action)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetMenuNavigationPrimary")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 2)]
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

	[CalledBy(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "GetAxisValue")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "OnCheck")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetSafeCrackingMovementDirection")]
	[CalledBy(Type = typeof(InputManager), Member = "GetSafeCrackingMovementDirection")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovementKeyboard")]
	[CalledBy(Type = typeof(SafeCracking), Member = "GetDialDelta")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "Test")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "UpdateLimpAnimation")]
	public Vector2 GetPlayerMovement()
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "GetAxisValue")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "OnCheck")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "Test")]
	[CalledBy(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public Vector2 GetCameraMovementMouse()
	{
		return default(Vector2);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "Test")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "GetAxisValue")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "OnCheck")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	public Vector2 GetCameraMovementGamepad()
	{
		return default(Vector2);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetInteractPressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown")]
	[Calls(Type = typeof(Application), Member = "get_platform")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
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

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetOpenFirstAidPressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
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

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(InputManager), Member = "GetMenuNavigationPrimary")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovementKeyboard")]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonUp")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
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

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
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

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetFeedFireTakeTorchePressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	public bool GetQuickSelect1Pressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
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

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetRewiredActionAsAxis")]
	[CallsUnknownMethods(Count = 2)]
	public float GetFlyModeMoveSlowMultiplier()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetRewiredActionAsAxis")]
	public float GetFlyModeMoveFastMultiplier()
	{
		return default(float);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetFlyModeCancelPlacement()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetDebugMenuTogglePressed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(KeyRebindingButton), Member = "SetValueLabel")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_elementIdentifierName")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(KeyRebindingButton), Member = "SetValueLabel")]
	[CalledBy(Type = typeof(InputManager), Member = "UpdateKeyBindingTable")]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateKeyBindingTable()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void ApplyRemapping()
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "LoadRemapping")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "AZOxHXNYoYmDNxdKLSbyHBepCxG")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "LoadDefaultMaps")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "vCwWmZNlNchsKYePzGBBmGGyFOB")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[CalledBy(Type = typeof(InputManager), Member = "ResetKeybindingsToDefault")]
	[CallsUnknownMethods(Count = 1)]
	public void ResetKeybindingsToDefault()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void InitializeDefaultKeyBindings()
	{
	}

	[CalledBy(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolWithKeycode")]
	[CalledBy(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolWithKeycode")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetSteamButtonOrAxisNameForAction")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PoleForKeyRemap")]
	[CalledBy(Type = typeof(InputManager), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(InputManager), Member = "ConvertKeycodeToLabel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnGUI")]
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
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AEAGuWUxmCMnWwXPzMBFgjoWoCu")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
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
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromMousePolling")]
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
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	private KeyboardMap GetKeyboardMap()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromMousePolling")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "CreateReassignment")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "RemoveKeybinding")]
	private MouseMap GetMouseMap()
	{
		return null;
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "AnySteamButtonPressed")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "Update")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(InputSystemRewired), Member = "AnySteamAxisPressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Update")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "IsInBootScene")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ControllerWithAxes), Member = "PollForFirstAxis")]
	[CallerCount(Count = 2)]
	private void MaybeSetGamepadActive()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Update")]
	[CalledBy(Type = typeof(InputManager), Member = "Update")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(Keyboard), Member = "PollForFirstKeyDown")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Keyboard")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "PollForFirstAxis")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Mouse")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Mouse")]
	private void MaybeSetMouseOrKeyboardActive()
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMap")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ClearAllControllers")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void JoystickConnect(ControllerStatusChangedEventArgs args)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ContainsController")]
	[Calls(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[Calls(Type = typeof(InputManager), Member = "OnPlayerControllerDisconnected")]
	[CallsUnknownMethods(Count = 2)]
	private void JoystickPreDisconnect(ControllerStatusChangedEventArgs args)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void JoystickDisconnect(ControllerStatusChangedEventArgs args)
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "UpdateSteamController")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "FindActiveGamepad")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "JoystickPreDisconnect")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "JoystickConnect")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "SetGamepadEnabled")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GouCKvssMFMACiWJfaRQHCDLBuzb")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Keyboard")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ClearAllControllers")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InputSystemRewired), Member = "DebugLogControllerConnected")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Mouse")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	private void SetActiveController(Controller controller)
	{
	}

	[Calls(Type = typeof(string), Member = "Contains")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "CheckForActiveController")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Update")]
	[CalledBy(Type = typeof(InputManager), Member = "Update")]
	[Calls(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "PollForFirstAxis")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "FindActiveSteamController")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	private bool FindActiveGamepad(bool includeAxis)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(ControllerMap), Member = "DeleteButtonMapsWithAction")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMouseMap")]
	[Calls(Type = typeof(ControllerMap), Member = "DeleteButtonMapsWithAction")]
	private void RemoveKeybinding(InputAction action)
	{
	}

	[Calls(Type = typeof(Keyboard), Member = "untSoBSHcWcUVKSpUbQMajhzKPH")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "RebindKeybindingConflicts")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ActionElementMap), Member = "get_modifierKeyFlags")]
	[Calls(Type = typeof(ControllerMap), Member = "ReplaceOrCreateElementMap")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMouseMap")]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromMousePolling")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private ActionElementMap GetExistingBinding(InputAction action)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnGUI")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PoleForKeyRemap")]
	private bool MaybeCreateElementAssignmentFromKeyboardPolling(string actionName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "RebindKeybindingConflicts")]
	[Calls(Type = typeof(ControllerMap), Member = "ReplaceOrCreateElementMap")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PoleForKeyRemap")]
	[Calls(Type = typeof(ControllerMap), Member = "DeleteButtonMapsWithAction")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnGUI")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMouseMap")]
	[Calls(Type = typeof(ControllerMap), Member = "DeleteButtonMapsWithAction")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetExistingBinding")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Player.ControllerHelper.PollingHelper), Member = "PollControllerForFirstButtonDown")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
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

	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ControllerMap), Member = "get_categoryId")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMaps")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetMapCategory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetJoystickLayout")]
	[Calls(Type = typeof(ControllerMap), Member = "get_enabled")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ControllerMap), Member = "GetElementMaps")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_elementIdentifierName")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 127)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ControllerMap), Member = "get_layoutId")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
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
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "IsControllerAssigned")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_Players")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	private void DebugLogControllerConnected()
	{
	}

	[CallerCount(Count = 0)]
	public string GetPS4ControllerHardwareGuid()
	{
		return null;
	}

	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "IsXboxController")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[CalledBy(Type = typeof(InputManager), Member = "GetButtonMap")]
	[CalledBy(Type = typeof(BootUpdate), Member = "ShowOptionalContentErrorState")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateControlsMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateControlsMenuItems")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "GetActiveDictionary")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	public bool IsPS4Controller()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsXboxController()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Joystick), Member = "StopVibration")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(InputManager), Member = "StopVibration")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[CallerCount(Count = 1)]
	public void StopVibration()
	{
	}

	[Calls(Type = typeof(Joystick), Member = "SetVibration")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Joystick), Member = "get_supportsVibration")]
	[Calls(Type = typeof(Joystick), Member = "get_vibrationMotorCount")]
	[Calls(Type = typeof(Joystick), Member = "SetVibration")]
	[Calls(Type = typeof(Joystick), Member = "get_vibrationMotorCount")]
	[CallsUnknownMethods(Count = 3)]
	public void SetVibration(float motor0, float motor1)
	{
	}

	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(SteamInput), Member = "GetAnalogActionHandle")]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(SteamInput), Member = "GetDigitalActionHandle")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "UpdateSteamController")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(SteamInput), Member = "GetActionSetHandle")]
	[Calls(Type = typeof(SteamInput), Member = "GetActionSetHandle")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SteamInput), Member = "GetActionSetHandle")]
	private void InitializeSteamController()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "IsInBootScene")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	public static float GetSteamInputSensitivityFactor()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "TryUpdateSteamControllerActionSet")]
	public void RefreshSteamControllerActionSet()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Update")]
	[CalledBy(Type = typeof(InputManager), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "OnPlayerControllerDisconnected")]
	[Calls(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(SteamInput), Member = "GetAnalogActionData")]
	[Calls(Type = typeof(SteamInput), Member = "RunFrame")]
	[Calls(Type = typeof(InputSystemRewired), Member = "TryUpdateSteamControllerActionSet")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "InitializeSteamController")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SteamInput), Member = "GetDigitalActionData")]
	public void UpdateSteamController()
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeSetGamepadActive")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Update")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CalledBy(Type = typeof(InputManager), Member = "Update")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallerCount(Count = 8)]
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

	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallerCount(Count = 0)]
	private bool IsSteamControllerPresent()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SteamInput), Member = "RunFrame")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(SteamInput), Member = "GetDigitalActionData")]
	[Calls(Type = typeof(SteamInput), Member = "GetAnalogActionData")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "FindActiveGamepad")]
	private bool FindActiveSteamController()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeSetGamepadActive")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "AnyButtonsOrKeysPressed")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool AnySteamButtonPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetAnyMouseOrStickMovement")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeSetGamepadActive")]
	[CallsUnknownMethods(Count = 2)]
	private bool AnySteamAxisPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool GetSteamButtonPressed(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool GetSteamButtonUnpressed(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool GetSteamButton(InputManager.InputAction action)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(string), Member = "Remove")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(SteamInput), Member = "GetCurrentActionSet")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "IndexOf")]
	private string GetSteamButtonOrAxisNameForAction(string action)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "ResetControllerState")]
	[CallsUnknownMethods(Count = 2)]
	private void ResetSteamControllerState()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	public void ShowSteamControllerBindingPanel()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "UpdateSteamController")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "RefreshSteamControllerActionSet")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InputManager), Member = "IsInBootScene")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SteamInput), Member = "GetCurrentActionSet")]
	private bool TryUpdateSteamControllerActionSet(int connectedSteamControllers)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 89)]
	[CalledBy(Type = typeof(InputManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 1)]
	public InputSystemRewired()
	{
	}
}
