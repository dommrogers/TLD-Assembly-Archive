using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using Rewired;
using Steamworks;
using TLD.Gear;
using TLD.News;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
	public enum InputAction
	{
		AnyButton,
		Up,
		Down,
		Left,
		Right,
		Interact,
		Sprint,
		Crouch,
		Reload,
		Equip,
		PickUp,
		PutBack,
		Holster,
		ActionsPanel,
		Inventory,
		PauseMenu,
		Escape,
		Continue,
		StartFire,
		LightSource,
		Decoy,
		Weapon,
		Menu_ToolSelect,
		Inventory_Drop,
		Inventory_FilterLeft,
		Inventory_FilterRight,
		Inventory_Equip,
		Inventory_Examine,
		Inventory_Sort,
		Container_SelectLeftTable,
		Container_SelectRightTable,
		Options_Confirm,
		Struggle_Tap,
		FeedFire_TakeTorch,
		Fire,
		AltFire,
		SafeCrackLeft,
		SafeCrackRight,
		ResetAllTimeStats,
		Menu_Secondary_MoveLeft,
		Menu_Secondary_MoveRight,
		Menu_Secondary_MoveUp,
		Menu_Secondary_MoveDown,
		ShowSteamControllerBindings,
		OpenRadial,
		Rename,
		Delete,
		Overwrite,
		SaveJournal,
		Carry,
		Quarter,
		HarvestCharcoal,
		TabLeft,
		TabRight,
		OpenMap,
		Inventory_AddToSatchel,
		Clothing,
		Journal,
		FirstAid,
		QuickSave,
		QuickLoad,
		Menu_HinterlandMailingList,
		Menu_SkyboundInsiders,
		Scroll,
		Interact_ScrollDown,
		Interact_ScrollUp,
		Compass,
		BuyNow,
		QuickSelectSlot1,
		QuickSelectSlot2,
		QuickSelectSlot3,
		QuickSelectSlot4,
		FlyModeMoveSlow,
		FlyModeMoveFast,
		FlyModeMoveUp,
		FlyModeMoveDown,
		FlyModeLockOrientation,
		FlyModeAcceptPlacement,
		FlyModeCancelPlacement,
		FlyModeToggleEnabled1,
		FlyModeToggleEnabled2,
		FlyModeToggleCoords,
		ShowAccountPicker,
		ShowStatsScreen,
		AutoWalk,
		RotateClockwise,
		RotateCounterClockwise,
		Crafting
	}

	public enum InputState
	{
		Pressed,
		Released
	}

	public enum InputAxis
	{
		Move,
		MouseCamera,
		JoystickCamera,
		Scroll
	}

	public enum InputAxisState
	{
		AtRest,
		HasInput
	}

	public enum ScreenshotOptions
	{
		None,
		Debug,
		HDR,
		HighRes
	}

	private enum CursorState
	{
		None,
		Show,
		ShowPending,
		ShowReady,
		Hide
	}

	private enum LightSource
	{
		Flashlight,
		RedFlare,
		BlueFlare,
		Lamp,
		Torch,
		Match,
		None
	}

	private delegate GearItem OnDelegate();

	public enum ControllerType
	{
		Keyboard,
		Gamepad,
		Both
	}

	public static Dictionary<string, string> s_ButtonMapDesktop;

	public static Dictionary<string, string> s_ButtonMapSteam;

	public static Dictionary<string, string> s_ButtonMapPS4;

	public static Dictionary<string, string> s_ButtonMapXbox;

	public static Dictionary<string, string> s_ButtonMapSwitch;

	public static Dictionary<string, string> s_ButtonMapXboxToSwitch;

	public static InputManager instance;

	public static InputSystemRewired m_InputSystem;

	public static bool m_TouchControlsEnabled;

	public static bool m_DebugShortcutsEnabled;

	public static int m_LastCursorLockCounter;

	public static bool m_IsRumbleEnabled;

	public static bool m_IgnoreButtonInput;

	public static bool m_ShowResetBindingsConfirmation;

	private static CursorState m_CursorState;

	private static bool m_RestoreHudDisplayMode;

	private static HudDisplayMode m_PendingScreenshotRestoreHudMode;

	private static bool m_InteractedWithItemThisFrame;

	private static int m_debugScreenshotCountdown;

	private static int m_highResScreenshotCountdown;

	private static int m_HDRScreenshotCountdown;

	private static float m_ConsoleUnlockTime;

	private static bool m_IsShowingControllerDisconnectedPanel;

	private static float m_MoterIntensityLeft;

	private static float m_MoterIntensityLeftTrigger;

	private static float m_MoterIntensityRight;

	private static float m_MoterIntensityRightTrigger;

	private static EmergencyStim m_EmergencyStimUsed;

	private static CameraGlobalRT m_CameraRenderTexture;

	public static bool m_InputDebugEnabled;

	private static bool m_HasFocus;

	private static StringBuilder s_DebugStringBuilder;

	private PanelReference<Panel_Actions> m_ActionsPanel;

	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	private PanelReference<Panel_Clothing> m_ClothingPanel;

	private PanelReference<Panel_Crafting> m_CraftingPanel;

	private PanelReference<Panel_Debug> m_DebugPanel;

	private PanelReference<Panel_FirstAid> m_FirstAidPanel;

	private PanelReference<Panel_GearSelect> m_GearSelect;

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Inventory> m_Inventory;

	private PanelReference<Panel_Loading> m_LoadingPanel;

	private PanelReference<Panel_Log> m_LogPanel;

	private PanelReference<Panel_Map> m_MapPanel;

	private PanelReference<Panel_MissionsStory> m_MissionsStory;

	private PanelReference<Panel_PauseMenu> m_PauseMenu;

	private static List<MonoBehaviour> m_InputContexts;

	private static float m_InputDisableTime;

	private static MonoBehaviour m_CurrentContext;

	[Calls(Type = typeof(InputManager), Member = "HasReconnectedJoystick")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingPS4ControllerDisconnectedPanel")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingSteamControllerDisconnectedPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasReconnectedJoystick")]
	public static string GetButtonMap(string button)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InputSystemRewired), Member = ".ctor")]
	[Calls(Type = typeof(InputSystemRewired), Member = "Initialize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "UpdateSteamController")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_joystickCount")]
	[Calls(Type = typeof(InputSystemRewired), Member = "FindActiveGamepad")]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeSetMouseOrKeyboardActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeSetGamepadActive")]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	public static bool GetApplicationHasFocus()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void OnApplicationFocus(bool focusStatus)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Loading), Member = "IsShowingQuote")]
	[Calls(Type = typeof(InputManager), Member = "ProcessInput")]
	[CallsUnknownMethods(Count = 1)]
	public static void Process(MonoBehaviour context)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "TakeHighResolutionScreenshot")]
	[Calls(Type = typeof(InputManager), Member = "TakeScreenshot")]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdatePaused")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallsUnknownMethods(Count = 1)]
	public static void ProcessScreenshotInput()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "UpdatePaused")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallerCount(Count = 2)]
	public static void ProcessTimeGatedUnlocks()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void ProcessDebugInput()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "TakeScreenshot")]
	[Calls(Type = typeof(InputManager), Member = "TakeScreenshot")]
	[Calls(Type = typeof(InputManager), Member = "TakeScreenshot")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdatePaused")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	public static void MaybeTakeScreenshot()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static float GetAxisRawMouseX(MonoBehaviour context)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallsUnknownMethods(Count = 1)]
	public static float GetAxisRawMouseY(MonoBehaviour context)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallsUnknownMethods(Count = 2)]
	public static float GetAxisMouseX(MonoBehaviour context)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static float GetAxisMouseY(MonoBehaviour context)
	{
		return default(float);
	}

	[CallerCount(Count = 36)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallsUnknownMethods(Count = 1)]
	public static float GetAxisScrollWheel(MonoBehaviour context)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAxis")]
	[CallsUnknownMethods(Count = 1)]
	public static float GetScroll(MonoBehaviour context)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetKeyDown(MonoBehaviour context, KeyCode key)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToLoadActiveGame")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingIn")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsShowingQuote")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPaused")]
	[CallerCount(Count = 3)]
	public static bool CanInvokePauseMenu()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuOpen")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	public static void PauseGame()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerInConstrainedCamera), Member = "PanToLocation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "ExecuteSurvivalPanelAction")]
	[Calls(Type = typeof(InputManager), Member = "GetInteractPressed")]
	[Calls(Type = typeof(InputManager), Member = "ExecuteInteractAction")]
	[Calls(Type = typeof(InputManager), Member = "ExecuteJournalAction")]
	[Calls(Type = typeof(InputManager), Member = "IsClickHoldActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	[Calls(Type = typeof(InputManager), Member = "MaybeCancelClickHold")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[Calls(Type = typeof(InputManager), Member = "GetOpenActionsPanelPressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "ExecuteFirstAidAction")]
	[Calls(Type = typeof(InputManager), Member = "ExecuteOpenMapActionFromObjective")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputManager), Member = "GetOpenMapPressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(HUDObjectives), Member = "GetMissionId")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "ExecuteOpenMapAction")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "ExecuteCraftingAction")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "ExecuteClothingAction")]
	[Calls(Type = typeof(InputManager), Member = "ExecuteInventoryAction")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(InputManager), Member = "GetReloadPressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "ExecuteDecoyAction")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "ExecuteStartFireAction")]
	[Calls(Type = typeof(InputManager), Member = "GetRadialButton")]
	[Calls(Type = typeof(InputManager), Member = "OpenRadialMenu")]
	[Calls(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(InputManager), Member = "Process")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputManager), Member = "ExecuteAltFire")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[Calls(Type = typeof(InputManager), Member = "ExecuteReloadAction")]
	[Calls(Type = typeof(InputManager), Member = "GetHolsterPressed")]
	[Calls(Type = typeof(InputManager), Member = "ExecuteHolsterAction")]
	[Calls(Type = typeof(InputManager), Member = "GetCrouchPressed")]
	[Calls(Type = typeof(InputManager), Member = "CanExecuteCrouchAction")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "ExecuteLightSourceAction")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputManager), Member = "ExecuteJournalActionFromObjective")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(HUDObjectives), Member = "GetMissionId")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsZooming")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(InputManager), Member = "ExecuteJournalActionFromMap")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(InputManager), Member = "GetPauseMenuTogglePressed")]
	[Calls(Type = typeof(InputManager), Member = "PauseGame")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	[Calls(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	private static void ProcessInput(MonoBehaviour context)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(BodyCarry), Member = "HasBody")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "ShowBodyCarryRadial")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "DoTween")]
	[Calls(Type = typeof(Panel_ActionsRadial), Member = "ShowPrimaryRadial")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	private static void OpenRadialMenu()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CharcoalItem), Member = "StartDetailSurvey")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[Calls(Type = typeof(EmergencyStimItem), Member = "Use")]
	[Calls(Type = typeof(WildlifeItem), Member = "IsActionAllowed")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(FlashlightItem), Member = "Toggle")]
	[Calls(Type = typeof(PlayerManager), Member = "Throw")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "IgniteDelayed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "Toggle")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "PullTrigger")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(BowItem), Member = "PressFire")]
	[Calls(Type = typeof(PlayerManager), Member = "AttemptToPlaceObject")]
	[Calls(Type = typeof(InputManager), Member = "ProcessReleaseFireAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MatchesItem), Member = "IgniteDelayed")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectUnderCrosshairCanLightTorch")]
	[Calls(Type = typeof(TorchItem), Member = "IgniteDelayed")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "GetFireReleased")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInPlacementMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "IsClickHoldActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlareItem), Member = "IgniteDelayed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(TorchItem), Member = "ExtinguishDelayed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsProgressBarRelatedItem")]
	[Calls(Type = typeof(TorchItem), Member = "AttemptToLight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static void ProcessFireAction(MonoBehaviour context, Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteHolsterAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteDecoyAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteStrikeMatchAction")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BowItem), Member = "ReleaseFire")]
	[Calls(Type = typeof(InputManager), Member = "MaybeCancelClickHold")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelItemInHandsAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static void ProcessReleaseFireAction()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsClickHoldActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessReleaseFireAction")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ItemProgressBarCheck")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ItemProgressBarCheck")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "DoClickHoldCancel")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(PlayerManager), Member = "IsCancelableActionInProgress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "TryCancelHoldInteraction")]
	public static bool MaybeCancelClickHold(bool forceCancel = false)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InputManager), Member = "MaybeClosePanelDueToHotkey")]
	[Calls(Type = typeof(InputManager), Member = "CanExecutePanelActivateAction")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static void ExecuteInventoryAction()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "MaybeClosePanelDueToHotkey")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InputManager), Member = "CanExecutePanelActivateAction")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	private static void ExecuteCraftingAction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InputManager), Member = "MaybeClosePanelDueToHotkey")]
	[Calls(Type = typeof(InputManager), Member = "CanExecutePanelActivateAction")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static void ExecuteClothingAction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[Calls(Type = typeof(InputManager), Member = "CanExecutePanelActivateAction")]
	[Calls(Type = typeof(InputManager), Member = "MaybeClosePanelDueToHotkey")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	private static void ExecuteJournalAction()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "NavigateToMissionById")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	private static void ExecuteJournalActionFromMap(string missionId)
	{
	}

	[Calls(Type = typeof(Panel_MissionsStory), Member = "NavigateToMissionById")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterSectionNav")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "MaybeClosePanelDueToHotkey")]
	private static void ExecuteJournalActionFromObjective(string missionId)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InputManager), Member = "MaybeClosePanelDueToHotkey")]
	[Calls(Type = typeof(InputManager), Member = "CanExecutePanelActivateAction")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private static void ExecuteFirstAidAction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(InputManager), Member = "MaybeClosePanelDueToHotkey")]
	[Calls(Type = typeof(InputManager), Member = "CanExecutePanelActivateAction")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private static void ExecuteOpenMapAction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(Panel_Map), Member = "CenterOn")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(InputManager), Member = "MaybeClosePanelDueToHotkey")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static void ExecuteOpenMapActionFromObjective(string missionId)
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteCraftingAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteOpenMapAction")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteJournalAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteClothingAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteInventoryAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirstAidAction")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private static bool CanExecutePanelActivateAction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteOpenMapActionFromObjective")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteOpenMapAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirstAidAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteJournalActionFromObjective")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteJournalAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteClothingAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteCraftingAction")]
	[Calls(Type = typeof(Panel_Map), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Log), Member = "OnBack")]
	[Calls(Type = typeof(Panel_Clothing), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnBack")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteInventoryAction")]
	private static void MaybeClosePanelDueToHotkey()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "ProcessReleaseFireAction")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(Inventory), Member = "GetBestMatches")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void ExecuteStrikeMatchAction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteLightSourceAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static LightSource GetCurrentLightSourceType()
	{
		return default(LightSource);
	}

	[CallsUnknownMethods(Count = 36)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(Inventory), Member = "GetBestMatches")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetBestLamp")]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByCurrentHP")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(InputManager), Member = "GetCurrentLightSourceType")]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByCurrentHP")]
	[Calls(Type = typeof(Inventory), Member = "GetBestFlare")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(Inventory), Member = "GetBestFlare")]
	public static void ExecuteLightSourceAction()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(InputManager), Member = "ProcessReleaseFireAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetBestDecoy")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public static void ExecuteDecoyAction()
	{
	}

	[Calls(Type = typeof(HUDMessage), Member = "CreateMessageInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "CreateMessageInfo")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CallsUnknownMethods(Count = 40)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(Inventory), Member = "GetBestGun")]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByNormalizedCondition")]
	[Calls(Type = typeof(Inventory), Member = "GetBestGun")]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetBestStone")]
	[Calls(Type = typeof(Inventory), Member = "GetBestItemByNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GetBestGun")]
	public static void ExecuteFirearmAction()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteStartFireAction")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNoCampfireMessage")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	public static bool CanStartFireIndoors()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnStartFire")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(FireManager), Member = "InstantiateCampFire")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(FireManager), Member = "GetMissingMaterialsString")]
	[Calls(Type = typeof(InputManager), Member = "CanStartFireIndoors")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public static bool ExecuteStartFireAction()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "IsInPlacementMode")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteCrouchAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(BodyCarry), Member = "HasBody")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool CanExecuteCrouchAction(bool playGUIError)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "DisableActiveSubMenu")]
	[Calls(Type = typeof(InputManager), Member = "DisableActiveSubMenu")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(InputManager), Member = "IsInSurvivalPanelSubMenu")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(InputManager), Member = "IsInSurvivalPanelSubMenu")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Panel_Harvest), Member = "HarvestInProgress")]
	[CallerCount(Count = 1)]
	private static void ExecuteSurvivalPanelAction()
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteSurvivalPanelAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteSurvivalPanelAction")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	private static bool IsInSurvivalPanelSubMenu()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Panel_Inventory), Member = "ExitInterface")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteSurvivalPanelAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteSurvivalPanelAction")]
	[CallsUnknownMethods(Count = 1)]
	private static void DisableActiveSubMenu()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(PlayerManager), Member = "AttemptToPlaceObject")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsZooming")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	private static void ExecuteInteractAction()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "Throw")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BowItem), Member = "ForceReady")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WildlifeItem), Member = "IsActionAllowed")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdatePlaceMesh")]
	[Calls(Type = typeof(PlayerManager), Member = "AttemptToPlaceObject")]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsThrowable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsPlaceable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowShelterManager), Member = "PlayerInShelter")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "EraseDecal")]
	[Calls(Type = typeof(EquipItemPopup), Member = "OnOverlappingDecalChange")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "MaybePlace")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "TryStartPlaceMeshInteraction")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInPlacementMode")]
	private static void ExecuteAltFire()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private static void OnTorchMidSwing()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(PlayerManager), Member = "CanHolsterItem")]
	[Calls(Type = typeof(InputManager), Member = "ProcessReleaseFireAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ControlModeAllowsInterface")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "HasBody")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static void ExecuteHolsterAction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "CanExecuteCrouchAction")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[CallsUnknownMethods(Count = 3)]
	private static void ExecuteCrouchAction()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static void ExecuteReloadAction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	private static void ExecuteQuickSaveAction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	private static void ExecuteQuickLoadAction()
	{
	}

	[CallerCount(Count = 0)]
	private static bool WaitingForScreenshot()
	{
		return default(bool);
	}

	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	[CallerCount(Count = 0)]
	private static void TakeDebugScreenshot()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void TakeHDRScreenshot()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "TakeScreenshot")]
	private static void TakeNormalResolutionScreenshot()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessScreenshotInput")]
	private static void TakeHighResolutionScreenshot()
	{
	}

	[Calls(Type = typeof(ArgumentException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(File), Member = "InternalWriteAllBytes")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeTakeScreenshot")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessScreenshotInput")]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeTakeScreenshot")]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeTakeScreenshot")]
	[CalledBy(Type = typeof(InputManager), Member = "TakeNormalResolutionScreenshot")]
	[CallsUnknownMethods(Count = 48)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "ReadPixels")]
	[Calls(Type = typeof(ScreenCapture), Member = "CaptureScreenshot")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "ReadPixels")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(File), Member = "InternalWriteAllBytes")]
	private static void TakeScreenshot(ScreenshotOptions options)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	private static void RestoreHudDisplayMode()
	{
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "ResetControllerState")]
	[CallerCount(Count = 20)]
	public static void ResetControllerState()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "AnyButtonsOrKeysPressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAnyMouseOrStickMovement")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	public static bool AnyInput()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[CalledBy(Type = typeof(Condition_ActionInputButton), Member = "Test")]
	[CalledBy(Type = typeof(Condition_ActionInputButton), Member = "OnCheck")]
	[CalledBy(Type = typeof(BootUpdate), Member = "HasPressedKey")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "Update")]
	[Calls(Type = typeof(InputSystemRewired), Member = "AnyButtonsOrKeysPressed")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "AnyButtonsOrKeysPressed")]
	public static bool AnyButtonsOrKeysPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAnyMouseOrStickMovement")]
	[CallsUnknownMethods(Count = 1)]
	public static bool AnyMouseOrStickMovement()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetInInteractiveDisplay(bool inInteractiveDisplay)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "IsInBootScene")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool GetGamepadEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "SetGamepadEnabled")]
	[Calls(Type = typeof(UICamera), Member = "SetSchemeOverride")]
	[CallsUnknownMethods(Count = 1)]
	public static void SetGamepadEnabled(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "HasPressedSkip")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ExitDialogueUpdate")]
	[CalledBy(Type = typeof(GenericInteractionCancelUI), Member = "RefreshButtonPrompt")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 4)]
	public static bool GetRadialButton(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Utils), Member = "InputControlRotate")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetRadialButtonHeldDown(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BootUpdate), Member = "HasPressedKey")]
	[Calls(Type = typeof(InputSystemRewired), Member = "CheckForActiveController")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	public static bool CheckForActiveController()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetActiveUserID()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static ulong GetActiveJoystickID()
	{
		return default(ulong);
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "UpdateSteamController")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "JoystickPreDisconnect")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	public static void OnPlayerControllerDisconnected()
	{
	}

	[CallerCount(Count = 0)]
	public static void OnPlayerControllerDisconnectedEnd()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "IsShowingPS4ControllerDisconnectedPanel")]
	[CalledBy(Type = typeof(InputManager), Member = "IsShowingSteamControllerDisconnectedPanel")]
	[CalledBy(Type = typeof(InputManager), Member = "GetButtonMap")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(GameManager), Member = "ShouldPauseMoviePlayer")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "SetActiveButtons")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "MaybeUpdateDisconnectedGamepadConfirmButton")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "JoystickConnect")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePause")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "CheckForPause")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "GetActiveDictionary")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "GetCurrentConfirmationRequest")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "IsControllerSchemeEnabled")]
	public static bool IsShowingControllerDisconnectedPanel()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InputManager), Member = "GetButtonMap")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "GetActiveDictionary")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	public static bool IsShowingSteamControllerDisconnectedPanel()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "GetActiveDictionary")]
	[CalledBy(Type = typeof(InputManager), Member = "GetButtonMap")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsShowingPS4ControllerDisconnectedPanel()
	{
		return default(bool);
	}

	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "GetActiveDictionary")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "GetActiveDictionary")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "IsControllerSchemeEnabled")]
	[CalledBy(Type = typeof(InputManager), Member = "GetButtonMap")]
	[CalledBy(Type = typeof(InputManager), Member = "GetButtonMap")]
	[CallsUnknownMethods(Count = 1)]
	public static bool HasReconnectedJoystick()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 133)]
	public static bool HasContext(MonoBehaviour context)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_PickWater), Member = "Enable")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_List<, >), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	public static void PushContext(MonoBehaviour context)
	{
	}

	[CalledBy(Type = typeof(Panel_PickUnits), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Enable")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_List<, >), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Enable")]
	public static void PopContext(MonoBehaviour context)
	{
	}

	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitForUpOrDown")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "SetClimbingState")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdateClimbing")]
	[CalledBy(Type = typeof(GameManager), Member = "MaybeBlockMoveInputUntilReleased")]
	[CalledBy(Type = typeof(Panel_Map), Member = "MagnetTowardsHoveredIcon")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateWaitForPlayerMovement")]
	[CalledBy(Type = typeof(FlyMode), Member = "LateUpdate")]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "GetMovementInput")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputStrafing")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputWalk")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputWalk")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Update")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InspectGearController), Member = "Update")]
	public static Vector2 GetPlayerMovement(MonoBehaviour context)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(Utils), Member = "GetMenuMovementHorizontalRightStick")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetCameraMovementMouse")]
	[CalledBy(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateGearTransformForInspection")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoWeaponSwaying")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "GetMouseDelta")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CalledBy(Type = typeof(InspectGearController), Member = "Update")]
	public static Vector2 GetCameraMovementMouse(MonoBehaviour context)
	{
		return default(Vector2);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "GetMenuMovementHorizontalRightStick")]
	[CalledBy(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateGearTransformForInspection")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(InspectGearController), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "ComputeJoystickInput")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoWeaponSwaying")]
	public static Vector2 GetCameraMovementGamepad(MonoBehaviour context)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	public static Vector2 GetGamepadGyroMovement(MonoBehaviour context)
	{
		return default(Vector2);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "UpdateWaitForFirstClick")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "CheckForInterrupt")]
	public static bool GetInteractPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetInteractReleased(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateStaminaBar")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "Update")]
	[CalledBy(Type = typeof(Utils), Member = "InputControlRotate")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetSprintDown(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 0)]
	public static bool GetAutoWalkDown(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	public static bool GetCompassPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputCrouch")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetCrouchPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeShootRevolver")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetCustomFireInput")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	public static bool GetReloadPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdateGamePad")]
	public static bool GetEquipPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	public static bool GetPickupPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(Application), Member = "get_platform")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateInspectGear")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public static bool GetPutBackPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CalledBy(Type = typeof(ElevatorPrototypeController), Member = "OnWaitAtFloor")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateIdleDockedAtFloor")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetHolsterPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_List<, >), Member = "HandleInput")]
	public static bool GetOpenActionsPanelPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetOpenActionsPanelHeldDown(MonoBehaviour context)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	public static bool GetOpenInventoryPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetOpenClothingPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetOpenJournalPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetOpenFirstAidPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetOpenMapPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Update")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 3)]
	public static bool GetPauseMenuTogglePressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 105)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetEscapePressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 67)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetContinuePressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	public static bool GetCarryPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetQuarterPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetHarvestCharcoalPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static bool GetStartFirePressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	public static bool GetEquipLightSourcePressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetDeployDecoyPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetEquipWeaponPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	public static bool GetMenuToolSelectPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Update")]
	public static bool GetMenuBuyNowPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[CalledBy(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "GetMovementPressed")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMenuNavigationPrimary")]
	[CalledBy(Type = typeof(Utils), Member = "GetMovementPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	public static Vector2 GetMenuNavigationPrimary(MonoBehaviour context)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(Utils), Member = "GetMovementPressed")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[CalledBy(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[CalledBy(Type = typeof(Utils), Member = "GetMovementPressed")]
	[CalledBy(Type = typeof(CustomCameraPosition), Member = "AnyButtonsOrKeysPressed")]
	[CalledBy(Type = typeof(InteractiveScrollText), Member = "Update")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public static Vector2 GetMenuNavigationSecondary(MonoBehaviour context)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "DoMainScreenControls")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatControls")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	public static bool GetInventoryDropPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetInventoryDropHeldDown(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	[CallerCount(Count = 0)]
	public static bool GetInventoryDropReleased(MonoBehaviour context)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NewsCarousel), Member = "UpdateActiveCarousel")]
	[CalledBy(Type = typeof(Utils), Member = "GetMenuMovementFilterLeft")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateReadPanelNavigation")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateFilterNavigation")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateMenuNavigation")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	public static bool GetInventoryFilterLeftPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsDailyListStats")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NewsCarousel), Member = "UpdateActiveCarousel")]
	[CalledBy(Type = typeof(Utils), Member = "GetMenuMovementFilterRight")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectionList")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateReadPanelNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCollectibleList")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateFilterNavigation")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateMenuNavigation")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "DoSectionNavControls")]
	public static bool GetInventoryFilterRightPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public static bool GetInventoryEquipPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "UpdateActiveCarousel")]
	[CalledBy(Type = typeof(BootUpdate), Member = "UpdateOptionalContentErrorState")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "ProcessMenu")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "DoMainScreenControls")]
	public static bool GetInventoryExaminePressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateSortNavigation")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateSortNavigation")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateSortNavigation")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	public static bool GetInventorySortPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	public static bool GetInventoryAddToSatchelPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetContainerSelectLeftTablePressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public static bool GetContainerSelectRightTablePressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessBrightnessMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetOptionsConfirmPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_ScrapMetalStruggle), Member = "UpdateStruggle")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateTapInput")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	public static bool GetStruggleTapPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetStruggleTapHeldDown(MonoBehaviour context)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGamepadControls")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Update")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 3)]
	public static bool GetFeedFireTakeTorchePressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetQuickSelect1Pressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	public static bool GetQuickSelect2Pressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetQuickSelect3Pressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetQuickSelect4Pressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	public static bool GetTabLeftPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetTabRightPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ProcessSelectionConfirm")]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "HandleBearSpearInput")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	public static bool GetFirePressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessFireAction")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "HandleBearSpearInput")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "CheckForFireRelease")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	public static bool GetFireReleased(MonoBehaviour context)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Update")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonTriggers")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Credits), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "Update")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "DoGamepadControls")]
	public static bool GetAltFirePressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 7)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetCustomFireInput")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeShootRevolver")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	public static bool GetAltFire(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonUnpressed")]
	public static bool GetAltFireReleased(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetRewiredActionAsAxis")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	public static float GetFlyModeMoveSlowMultiplier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetRewiredActionAsAxis")]
	[CallsUnknownMethods(Count = 2)]
	public static float GetFlyModeMoveFastMultiplier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetFlyModeMoveUpDown()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FlyMode), Member = "Enter")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(FlyMode), Member = "LateUpdate")]
	public static bool GetFlyModeMoveDownDown()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetFlyModeLockOrientationDown()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetFlyModeAcceptPlacementPressed()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	public static bool GetFlyModeCancelPlacementPressed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetFlyModeToggleEnabled()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool GetFlyModeToggleCoords()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetSafeCrackingLeft(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetSafeCrackingRight(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 0)]
	public static float GetSafeCrackingMovementDirection(MonoBehaviour context)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallsUnknownMethods(Count = 3)]
	public static bool GetDebugMenuTogglePressed()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	public static bool GetShowAccountPickerPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetShowStatsScreenPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallsUnknownMethods(Count = 1)]
	public static bool ResetAllTimeStatsPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCViewOverwrite")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 3)]
	public static bool GetRenamePressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTOCView")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetDeletePressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	public static bool GetOverwritePressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetSaveJournalPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetQuickSavePressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 0)]
	public static bool GetQuickLoadPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetHinterlandMailingListPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetSkyboundInsidersPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	public static bool GetScrollDownPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetScrollUpPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallerCount(Count = 0)]
	public static bool GetScrollDownHeld(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetScrollUpHeld(MonoBehaviour context)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	public static bool GetShowSteamControllerBindingsPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ProcessSelectionConfirm")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Navigate")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Navigate")]
	public static bool GetMouseButtonDown(MonoBehaviour context, int button)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	public static bool GetLeftPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetRightPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetRotateClockwiseHeld(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	public static bool GetRotateCounterClockwiseHeld(MonoBehaviour context)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetCraftingPressed(MonoBehaviour context)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "SaveRemapping")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void SaveRemapping()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[Calls(Type = typeof(InputSystemRewired), Member = "LoadRemapping")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	public static void LoadRemapping()
	{
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputSystemRewired), Member = "UpdateKeyBindingTable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "MaybeShowResetBindingsConfirmation")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ResetBindings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessKeyRebindMenu")]
	[CallsUnknownMethods(Count = 1)]
	public static void UpdateKeyBindingTable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void ApplyRemapping()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnResetKeyBindings")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "MaybeShowResetBindingsConfirmation")]
	[Calls(Type = typeof(InputSystemRewired), Member = "ResetKeybindingsToDefault")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ResetBindings")]
	public static void ResetKeybindingsToDefault()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void InitializeDefaultKeybindings()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyMouseSensitivity")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetSensititivyFromSlider")]
	public static float GetMouseSensitivity()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetSensititivyFromSlider")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Start")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyZoomSensitivity")]
	[CallsUnknownMethods(Count = 1)]
	public static float GetZoomSensitivity()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAnalogSticksSensitivity")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetSensititivyFromSlider")]
	public static float GetGamepadCameraSensitivity()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static float GetGyroHorizontalLookSensitivity()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static float GetGyroVerticalLookSensitivity()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float GetGyroHorizontalAimSensitivity()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float GetGyroVerticalAimSensitivity()
	{
		return default(float);
	}

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateKeyBindingLabels")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateKeyBindingLabels")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetButtonNameForAction(ControllerType controllerType, string action, bool convertKeycodes = true)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(InputManager), Member = "GetMouseSensitivity")]
	[CalledBy(Type = typeof(InputManager), Member = "GetZoomSensitivity")]
	[CalledBy(Type = typeof(InputManager), Member = "GetGamepadCameraSensitivity")]
	private static float GetSensititivyFromSlider(float sliderValue, float min, float mid, float max)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static bool GetKeycodeCanBeBound(KeyCode keycode)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[CalledBy(Type = typeof(KeyRebindingButton), Member = "SetValueLabel")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	public static string ConvertKeycodeToLabel(string keycode)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static bool WaitingCursor()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "Update")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "UpdateMousePointerState")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "UpdateMousePointerState")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(GameManager), Member = "UpdatePaused")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	public static void ShowCursor(bool show)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	private static void MaybeRestoreHudDisplayMode()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "GetMenuMovementHorizontalRightStick")]
	[CalledBy(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateGearTransformForInspection")]
	[CalledBy(Type = typeof(BootUpdate), Member = "ShowOptionalContentErrorState")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateControlsMenuItems")]
	public static bool IsSteamControllerActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	public static void ShowSteamControllerBindingPanel()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "StopVibration")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_rumble")]
	[CalledBy(Type = typeof(RumbleEffectManager), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	public static void StopVibration()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RumbleEffectManager), Member = "Update")]
	[Calls(Type = typeof(Joystick), Member = "SetVibration")]
	[Calls(Type = typeof(Joystick), Member = "get_vibrationMotorCount")]
	[Calls(Type = typeof(Joystick), Member = "SetVibration")]
	[Calls(Type = typeof(Joystick), Member = "get_supportsVibration")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[Calls(Type = typeof(Player.ControllerHelper), Member = "get_Joysticks")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Joystick), Member = "get_vibrationMotorCount")]
	public static void SetVibration(float motor0, float motor1)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public static bool IsGyroCameraMovementEnabled()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public static bool IsGyroCameraMovementOnlyOnAim()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void SetGamepadGyroHorizontalLookSensitivity(float sensitivity)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void SetGamepadGyroVerticalLookSensitivity(float sensitivity)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void SetGamepadGyroHorizontalAimSensitivity(float sensitivity)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void SetGamepadGyroVerticalAimSensitivity(float sensitivity)
	{
	}

	[CalledBy(Type = typeof(InputSystemRewired), Member = "InMenus")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneByName")]
	[CalledBy(Type = typeof(InputManager), Member = "GetGamepadEnabled")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "MaybeSetGamepadActive")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "TryUpdateSteamControllerActionSet")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsInBootScene()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool HasInteractedThisFrame()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CalledBy(Type = typeof(PlayableBehaviourJumpToTime), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayLine")]
	[CalledBy(Type = typeof(PlayableBehaviourSkip), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "ProcessAfterDuration")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[Calls(Type = typeof(InputManager), Member = "GetRadialButton")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPreparingPending")]
	[CallerCount(Count = 7)]
	public static bool HasPressedSkip(MonoBehaviour context)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public InputManager()
	{
	}
}
