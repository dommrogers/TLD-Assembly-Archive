using Cpp2ILInjected.CallAnalysis;
using Steamworks;
using TLD.UI.Generics;
using UnityEngine;

public class FlyMode : MonoBehaviour
{
	private PanelReference<Panel_Debug> m_Debug;

	private PanelReference<Panel_PauseMenu> m_PauseMenu;

	public float m_MoveSpeedSlow;

	public float m_MoveSpeedNormal;

	public float m_MoveSpeedFast;

	public static bool m_Enabled;

	public static Vector3 m_RestoreCameraPos;

	public static Quaternion m_RestoreCameraOrient;

	public static float m_SetTimeOfDay;

	private static Camera m_Camera;

	private static bool m_IgnoreDownUntilDownIsUp;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Start()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(FlyMode), Member = "Exit")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(InputManager), Member = "GetFlyModeMoveDownDown")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(FlyMode), Member = "TeleportPlayerAndExit")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetRewiredActionAsAxis")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetRewiredActionAsAxis")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public void LateUpdate()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fly")]
	[CalledBy(Type = typeof(FlyMode), Member = "Warp")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "GetFlyModeMoveDownDown")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowPlayer")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public static void Enter()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(LightingCapture._003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fly")]
	[CalledBy(Type = typeof(FlyMode), Member = "LateUpdate")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowPlayer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	public static void Exit()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[CalledBy(Type = typeof(FlyMode), Member = "LateUpdate")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowPlayer")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public static void TeleportPlayerAndExit()
	{
	}

	[CalledBy(Type = typeof(FlyMode), Member = "Warp")]
	[CalledBy(Type = typeof(Utils), Member = "RestoreView")]
	[CalledBy(Type = typeof(LightingCapture._003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(FlyMode), Member = "Enter")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	public static void Warp(Vector3 pos, Quaternion rot, float setTOD = -1f)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(FlyMode), Member = "Warp")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[CallsUnknownMethods(Count = 3)]
	public static void Warp(Transform transform, float setTOD = -1f)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public FlyMode()
	{
	}
}
