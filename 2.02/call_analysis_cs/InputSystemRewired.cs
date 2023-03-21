using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Conditions;
using Rewired;
using Rewired.Utils;
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
			return false;
		}

		[CallerCount(Count = 0)]
		public bool GetButtonUp()
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool GetButtonValue()
		{
			return false;
		}

		[CallerCount(Count = 0)]
		public bool GetButtonValueChanged()
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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

		[CalledBy(Type = typeof(InputSystemRewired), Member = "AnySteamAxisPressed")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Vector2), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		public bool ValueChanged()
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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

	[CalledBy(Type = typeof(InputSystemRewired), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareName")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(Guid), Member = "op_Inequality")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "IsControllerAssigned")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_Players")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMaps")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ControllerMap), Member = "get_categoryId")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetMapCategory")]
	[Calls(Type = typeof(ControllerMap), Member = "get_layoutId")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetJoystickLayout")]
	[Calls(Type = typeof(ControllerMap), Member = "get_enabled")]
	[Calls(Type = typeof(bool), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ControllerMap), Member = "GetElementMaps")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_elementIdentifierName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 101)]
	private void PrintDebugInfo()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ReInput), Member = "get_configuration")]
	[Calls(Type = typeof(ReInput.ConfigHelper), Member = "set_windowsStandalonePrimaryInputSource")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerPreDisconnectEvent")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerConnectedEvent")]
	[Calls(Type = typeof(ReInput), Member = "add_ControllerDisconnectedEvent")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "GetPlayer")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "SetAllMapsEnabled")]
	[Calls(Type = typeof(InputSystemRewired), Member = "PrintDebugInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	public void Initialize()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "UpdateSteamController")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(InputSystemRewired), Member = "FindActiveGamepad")]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeSetMouseOrKeyboardActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeSetGamepadActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ResetControllerState")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Controller), Member = "get_Buttons")]
	[Calls(Type = typeof(Controller.Element), Member = "Reset")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputSystemRewired), Member = "ResetSteamControllerState")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 24)]
	public void ResetControllerState()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Serialize")]
	[CalledBy(Type = typeof(InputManager), Member = "SaveRemapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetMappingFromCInput")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Player), Member = "GetSaveData")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ControllerMapSaveData), Member = "get_map")]
	[Calls(Type = typeof(ControllerMap), Member = "ToXmlString")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "SetAllMapsEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	public void SaveRemapping()
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "LoadRemapping")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 81)]
	private void PatchControllerMapping()
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(ListTools), Member = "ToArray")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(TypeFullName = "Rewired.Utils.EmptyObjects`1", Member = "get_array")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private bool CheckForExistingKeyboardMapping(KeyCode keycode)
	{
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "LoadRemapping")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "ClearMaps")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "AddMapsFromXml")]
	[Calls(Type = typeof(InputSystemRewired), Member = "ResetKeybindingsToDefault")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "RemoveController")]
	[Calls(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 34)]
	public void LoadRemapping()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(InputManager), Member = "AnyInput")]
	[CalledBy(Type = typeof(InputManager), Member = "AnyButtonsOrKeysPressed")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Mouse")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Keyboard")]
	[Calls(Type = typeof(InputSystemRewired), Member = "AnySteamButtonPressed")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	public bool AnyButtonsOrKeysPressed()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(InputManager), Member = "AnyInput")]
	[CalledBy(Type = typeof(InputManager), Member = "AnyMouseOrStickMovement")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	[Calls(Type = typeof(InputSystemRewired), Member = "AnySteamAxisPressed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool GetAnyMouseOrStickMovement()
	{
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "CheckForActiveController")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "FindActiveGamepad")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Mouse")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Keyboard")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ClearAllControllers")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public bool CheckForActiveController()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public float GetScroll()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetActiveUserID()
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ulong GetActiveJoystickID()
	{
		return 0uL;
	}

	[CalledBy(Type = typeof(InputManager), Member = "GetScroll")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetAnyMouseOrStickMovement")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetScroll")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetCameraMovementGamepad")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetMenuNavigationPrimary")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Vector2 GetAxis(InputManager.InputAxis axis, int axisXActionId, int axisYactionId)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private bool GetRewiredButtonPressed(InputManager.InputAction action)
	{
		return false;
	}

	[CallerCount(Count = 157)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Player), Member = "GetButtonDown")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private bool GetButtonPressed(InputManager.InputAction action)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "GetButtonUp")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private bool GetRewiredButtonUnpressed(InputManager.InputAction action)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[CalledBy(Type = typeof(InputManager), Member = "GetInteractReleased")]
	[CalledBy(Type = typeof(InputManager), Member = "GetInventoryDropReleased")]
	[CalledBy(Type = typeof(InputManager), Member = "GetFireReleased")]
	[CalledBy(Type = typeof(InputManager), Member = "GetAltFireReleased")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetInteractReleased")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetInventoryDropReleased")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetFireReleased")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetAltFireReleased")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetInputActionReleased")]
	[CalledBy(Type = typeof(Condition_ActionInputButton), Member = "OnCheck")]
	[CalledBy(Type = typeof(Condition_ActionInputButton), Member = "Test")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Player), Member = "GetButtonUp")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private bool GetButtonUnpressed(InputManager.InputAction action)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "GetButton")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private bool GetRewiredButton(InputManager.InputAction action)
	{
		return false;
	}

	[CallerCount(Count = 64)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Player), Member = "GetButton")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private bool GetButton(InputManager.InputAction action)
	{
		return false;
	}

	[CalledBy(Type = typeof(FlyMode), Member = "LateUpdate")]
	[CalledBy(Type = typeof(InputManager), Member = "GetFlyModeMoveSlowMultiplier")]
	[CalledBy(Type = typeof(InputManager), Member = "GetFlyModeMoveFastMultiplier")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetFlyModeMoveSlowMultiplier")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetFlyModeMoveFastMultiplier")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private float GetRewiredActionAsAxis(InputManager.InputAction action)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetMenuNavigationPrimary")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public Vector2 GetPlayerMovementKeyboard()
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	public bool WasLastControllerActiveSteam()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool WasLastControllerActivePS4()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool WasLastControllerActiveSwitch()
	{
		return false;
	}

	[CalledBy(Type = typeof(SafeCracking), Member = "GetDialDelta")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "UpdateLimpAnimation")]
	[CalledBy(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[CalledBy(Type = typeof(InputManager), Member = "GetSafeCrackingMovementDirection")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetSafeCrackingMovementDirection")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "GetAxisValue")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "Test")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovementKeyboard")]
	[CallsDeduplicatedMethods(Count = 1)]
	public Vector2 GetPlayerMovement()
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "GetAxisValue")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "Test")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Player), Member = "GetAxis")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Vector2 GetCameraMovementMouse()
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "GetAxisValue")]
	[CalledBy(Type = typeof(Condition_ActionInputAxisAtRest), Member = "Test")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Vector2 GetCameraMovementGamepad()
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetInteractPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	public bool GetInteractReleased()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetSprintDown()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetAutoWalkDown()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetCompassPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetCrouchPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetReloadPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetEquipPressed()
	{
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "GetPickupPressed")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public bool GetPickupPressed()
	{
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "GetPutBackPressed")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(Application), Member = "get_platform")]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public bool GetPutBackPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetHolsterPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetOpenActionsPanelPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetOpenActionsPanelHeldDown()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetOpenInventoryPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetOpenClothingPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetOpenJournalPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetOpenFirstAidPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetOpenMapPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetPauseMenuTogglePressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetEscapePressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetCarryPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetQuarterPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetHarvestCharcoalPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetContinuePressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetStartFirePressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetEquipLightSourcePressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetDeployDecoyPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetEquipWeaponPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetMenuToolSelectPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetMenuBuyNowPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetQuickSavePressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetQuickLoadPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetHinterlandMailingListPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetSkyboundInsidersPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetScrollDownPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetScrollUpPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetScrollDownHeld()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetScrollUpHeld()
	{
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "GetMenuNavigationPrimary")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovementKeyboard")]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonUp")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	public Vector2 GetMenuNavigationPrimary()
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public Vector2 GetMenuNavigationSecondary()
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetRadialButtonHeldDown()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetRadialButton()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetInventoryDropPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetInventoryDropHeldDown()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	public bool GetInventoryDropReleased()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetInventoryFilterLeftPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetInventoryFilterRightPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetInventoryEquipPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetInventoryExaminePressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetInventorySortPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetInventoryAddToSatchelPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetContainerSelectLeftTablePressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetContainerSelectRightTablePressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetOptionsConfirmPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool GetStruggleTapPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool GetStruggleTapHeldDown()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetFeedFireTakeTorchePressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetQuickSelect1Pressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetQuickSelect2Pressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetQuickSelect3Pressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetQuickSelect4Pressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool GetTabLeftPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool GetTabRightPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool GetFirePressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool GetFireReleased()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetAltFirePressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetAltFire()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	public bool GetAltFireReleased()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetRewiredActionAsAxis")]
	public float GetFlyModeMoveSlowMultiplier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetRewiredActionAsAxis")]
	public float GetFlyModeMoveFastMultiplier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetFlyModeMoveUpDown()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetFlyModeMoveDownDown()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetFlyModeLockOrientationDown()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetFlyModeAcceptPlacement()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetFlyModeCancelPlacement()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetFlyModeToggleEnabled()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetThreeDaysOfNightToggle()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetFlyModeToggleCoords()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetSafeCrackingLeft()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetSafeCrackingRight()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	public float GetSafeCrackingMovementDirection()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public bool GetDebugMenuTogglePressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetLeftPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetRightPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetShowAccountPickerPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetShowStatsScreenPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetResetAllTimeStatsPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetRenamePressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetDeletePressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetOverwritePressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetSaveJournalPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetRotateClockwiseHeld()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetRotateCounterClockwiseHeld()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetCraftingPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetShowSteamControllerBindingsPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromKeyboardPolling")]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromMousePolling")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool PoleForKeyRemap(string actionName, out string keyName)
	{
		keyName = null;
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "UpdateKeyBindingTable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetFirstButtonMapWithAction")]
	[Calls(Type = typeof(KeyRebindingButton), Member = "SetValueLabel")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_elementIdentifierName")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	public void UpdateKeyBindingTable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void ApplyRemapping()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ResetKeybindingsToDefault")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "LoadRemapping")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "LoadDefaultMaps")]
	[CallsUnknownMethods(Count = 1)]
	public void ResetKeybindingsToDefault()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void InitializeDefaultKeyBindings()
	{
	}

	[CalledBy(Type = typeof(NGUIText), Member = "MaybeReplaceSymbolWithKeycode")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnGUI")]
	[CalledBy(Type = typeof(InputManager), Member = "GetButtonNameForAction")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PoleForKeyRemap")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMouseMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_elementIdentifierName")]
	[Calls(Type = typeof(InputManager), Member = "ConvertKeycodeToLabel")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetSteamButtonOrAxisNameForAction")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public string GetButtonNameForAction(InputManager.ControllerType controllerType, string action, bool convertKeycodes = true)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "RemoveController")]
	[CallsUnknownMethods(Count = 1)]
	public void SetGamepadEnabled(bool enabled)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DeserializeSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "LoadDefaultMaps")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMouseMap")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(InputSystemRewired), Member = "RemoveKeybinding")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(ControllerMap), Member = "CreateElementMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "SaveRemapping")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 20)]
	public void GetMappingFromCInput()
	{
	}

	[CallerCount(Count = 0)]
	public void OnPlayerControllerDisconnected()
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "PatchControllerMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "CheckForExistingKeyboardMapping")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetMappingFromCInput")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "RemoveKeybinding")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "CreateReassignment")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetExistingBinding")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromKeyboardPolling")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMap")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private KeyboardMap GetKeyboardMap()
	{
		return null;
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetMappingFromCInput")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "RemoveKeybinding")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "CreateReassignment")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetExistingBinding")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromMousePolling")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMap")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private MouseMap GetMouseMap()
	{
		return null;
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "IsInBootScene")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "PollForFirstAxis")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "AnySteamButtonPressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "AnySteamAxisPressed")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private void MaybeSetGamepadActive()
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Mouse")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "PollForFirstAxis")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Keyboard")]
	[Calls(Type = typeof(Keyboard), Member = "PollForFirstKeyDown")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void MaybeSetMouseOrKeyboardActive()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(ReInput), Member = "CheckInitialized")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPS4ControllerHardwareGuid")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ClearAllControllers")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	private void JoystickConnect(ControllerStatusChangedEventArgs args)
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "UpdateSteamController")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ContainsController")]
	[Calls(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[Calls(Type = typeof(InputManager), Member = "OnPlayerControllerDisconnected")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void JoystickPreDisconnect(ControllerStatusChangedEventArgs args)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void JoystickDisconnect(ControllerStatusChangedEventArgs args)
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "JoystickConnect")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "JoystickPreDisconnect")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "FindActiveGamepad")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "ClearAllControllers")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[Calls(Type = typeof(InputSystemRewired), Member = "DebugLogControllerConnected")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "AddController")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Mouse")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Keyboard")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMap")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "RemoveController")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 28)]
	private void SetActiveController(Controller controller)
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "Update")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "CheckForActiveController")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InputSystemRewired), Member = "FindActiveSteamController")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(ControllerWithAxes), Member = "PollForFirstAxis")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private bool FindActiveGamepad(bool includeAxis)
	{
		return false;
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetMappingFromCInput")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromKeyboardPolling")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromMousePolling")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(ControllerMap), Member = "DeleteButtonMapsWithAction")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMouseMap")]
	private void RemoveKeybinding(InputAction action)
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "RebindKeybindingConflicts")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMouseMap")]
	[Calls(Type = typeof(ControllerMap), Member = "ReplaceOrCreateElementMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_modifierKeyFlags")]
	[Calls(Type = typeof(Keyboard), Member = "GetElementIdentifierIdByKeyCode")]
	[CallsUnknownMethods(Count = 1)]
	private void CreateReassignment(ActionElementMap existingBinding, InputAction action)
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromKeyboardPolling")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromMousePolling")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ElementAssignment), Member = "ToElementAssignmentConflictCheck")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CreateReassignment")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private void RebindKeybindingConflicts(ControllerMap controllerMap, ElementAssignment elementAssignment, ActionElementMap existingBinding)
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromKeyboardPolling")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromMousePolling")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMouseMap")]
	[CallsDeduplicatedMethods(Count = 2)]
	private ActionElementMap GetExistingBinding(InputAction action)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnGUI")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PoleForKeyRemap")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetKeyboardMap")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Keyboard")]
	[Calls(Type = typeof(Keyboard), Member = "PollForAllKeys")]
	[Calls(Type = typeof(InputManager), Member = "GetKeycodeCanBeBound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetExistingBinding")]
	[Calls(Type = typeof(InputSystemRewired), Member = "RemoveKeybinding")]
	[Calls(Type = typeof(ElementAssignment), Member = "KeyboardKeyAssignment")]
	[Calls(Type = typeof(InputSystemRewired), Member = "RebindKeybindingConflicts")]
	[Calls(Type = typeof(ControllerMap), Member = "ReplaceOrCreateElementMap")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private bool MaybeCreateElementAssignmentFromKeyboardPolling(string actionName)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnGUI")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "PoleForKeyRemap")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMouseMap")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(Player.ControllerHelper.PollingHelper), Member = "PollControllerForFirstButtonDown")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetExistingBinding")]
	[Calls(Type = typeof(InputSystemRewired), Member = "RemoveKeybinding")]
	[Calls(Type = typeof(InputSystemRewired), Member = "RebindKeybindingConflicts")]
	[Calls(Type = typeof(ControllerMap), Member = "ReplaceOrCreateElementMap")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private bool MaybeCreateElementAssignmentFromMousePolling(string actionName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public bool GetInputActionPressed(InputManager.InputAction action)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	public bool GetInputActionReleased(InputManager.InputAction action)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public bool GetInputActionHeld(InputManager.InputAction action)
	{
		return false;
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReInput), Member = "get_controllers")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Controller), Member = "get_name")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareName")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(Guid), Member = "op_Inequality")]
	[Calls(Type = typeof(Controller), Member = "get_type")]
	[Calls(Type = typeof(ReInput.ControllerHelper), Member = "IsControllerAssigned")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ReInput), Member = "get_players")]
	[Calls(Type = typeof(ReInput.PlayerHelper), Member = "get_Players")]
	[Calls(Type = typeof(Player), Member = "get_id")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Player.ControllerHelper.MapHelper), Member = "GetMaps")]
	[Calls(Type = typeof(ReInput), Member = "get_mapping")]
	[Calls(Type = typeof(ControllerMap), Member = "get_categoryId")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetMapCategory")]
	[Calls(Type = typeof(ControllerMap), Member = "get_layoutId")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetJoystickLayout")]
	[Calls(Type = typeof(ControllerMap), Member = "get_enabled")]
	[Calls(Type = typeof(bool), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ControllerMap), Member = "GetElementMaps")]
	[Calls(Type = typeof(ReInput.MappingHelper), Member = "GetAction")]
	[Calls(Type = typeof(ActionElementMap), Member = "get_elementIdentifierName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 101)]
	private void DebugLogControllerConnected()
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "JoystickConnect")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetPS4ControllerHardwareGuid()
	{
		return null;
	}

	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "GetActiveDictionary")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateControlsMenuItems")]
	[CalledBy(Type = typeof(InputManager), Member = "GetButtonMap")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "SetActiveController")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "IsXboxController")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Controller), Member = "get_hardwareTypeGuid")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPS4ControllerHardwareGuid")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public bool IsPS4Controller()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsSwitchController()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasReconnectedPS4Controller()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasReconnectedJoystick()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	public bool IsXboxController()
	{
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "StopVibration")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Joystick), Member = "StopVibration")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public void StopVibration()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "SetVibration")]
	[CalledBy(Type = typeof(RumbleEffectManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Joystick), Member = "get_supportsVibration")]
	[Calls(Type = typeof(Joystick), Member = "get_vibrationMotorCount")]
	[Calls(Type = typeof(Joystick), Member = "SetVibration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public void SetVibration(float motor0, float motor1)
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "UpdateSteamController")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(SteamInput), Member = "GetActionSetHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(SteamInput), Member = "GetDigitalActionHandle")]
	[Calls(Type = typeof(SteamInput), Member = "GetAnalogActionHandle")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 33)]
	private void InitializeSteamController()
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "TryUpdateSteamControllerActionSet")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "IsInBootScene")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool InMenus()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void SetInInteractiveDisplay(bool inInteractiveDisplay)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsInInteractiveDisplay()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "TryUpdateSteamControllerActionSet")]
	public void RefreshSteamControllerActionSet()
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "InitializeSteamController")]
	[Calls(Type = typeof(SteamInput), Member = "RunFrame")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "TryUpdateSteamControllerActionSet")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(SteamInput), Member = "GetDigitalActionData")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(InputSystemRewired), Member = "JoystickPreDisconnect")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 25)]
	public void UpdateSteamController()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	private bool IsSteamControllerPresent()
	{
		return false;
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "FindActiveGamepad")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SteamInput), Member = "RunFrame")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(SteamInput), Member = "GetDigitalActionData")]
	[Calls(Type = typeof(SteamInput), Member = "GetAnalogActionData")]
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	private bool FindActiveSteamController()
	{
		return false;
	}

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsSteamControllerActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[CallsUnknownMethods(Count = 5)]
	public ESteamInputType GetCurrentControllerSteamInputType()
	{
		return default(ESteamInputType);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallsUnknownMethods(Count = 3)]
	public bool IsSteamControllerDisconnected()
	{
		return false;
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "AnyButtonsOrKeysPressed")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeSetGamepadActive")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private bool AnySteamButtonPressed()
	{
		return false;
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetAnyMouseOrStickMovement")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeSetGamepadActive")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(InputController_AxisState), Member = "ValueChanged")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private bool AnySteamAxisPressed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool GetSteamButtonPressed(InputManager.InputAction action)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool GetSteamButtonUnpressed(InputManager.InputAction action)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool GetSteamButton(InputManager.InputAction action)
	{
		return false;
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(SteamInput), Member = "GetCurrentActionSet")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetSteamButtonOrAxisNameForAction")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private string GetSteamButtonOrAxisNameForAction(string action)
	{
		return null;
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetSteamButtonOrAxisNameForAction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "TryParse")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 31)]
	private string GetSteamButtonOrAxisNameForAction(InputHandle_t[] controllers, InputActionSetHandle_t actionSetHandle, string action)
	{
		return null;
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "ResetControllerState")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	private void ResetSteamControllerState()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void ShowSteamControllerBindingPanel()
	{
	}

	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "RefreshSteamControllerActionSet")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "UpdateSteamController")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputSystemRewired), Member = "InMenus")]
	[Calls(Type = typeof(SteamInput), Member = "GetCurrentActionSet")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private bool TryUpdateSteamControllerActionSet(int connectedSteamControllers)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static float GetSteamInputSensitivityFactor()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(InputManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 90)]
	[CallsUnknownMethods(Count = 24)]
	public InputSystemRewired()
	{
	}
}
