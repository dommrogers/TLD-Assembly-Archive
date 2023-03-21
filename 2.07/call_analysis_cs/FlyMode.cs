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

	[Calls(Type = typeof(InputManager), Member = "GetFlyModeMoveDownDown")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(FlyMode), Member = "Exit")]
	[Calls(Type = typeof(FlyMode), Member = "TeleportPlayerAndExit")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetRewiredActionAsAxis")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetRewiredActionAsAxis")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[CallsUnknownMethods(Count = 10)]
	public void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fly")]
	[CalledBy(Type = typeof(FlyMode), Member = "Warp")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(InputManager), Member = "GetFlyModeMoveDownDown")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowPlayer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	public static void Enter()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(LightingCapture._003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fly")]
	[CalledBy(Type = typeof(FlyMode), Member = "LateUpdate")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowPlayer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	public static void Exit()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[CalledBy(Type = typeof(FlyMode), Member = "LateUpdate")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowPlayer")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public static void TeleportPlayerAndExit()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CalledBy(Type = typeof(Utils), Member = "RestoreView")]
	[CalledBy(Type = typeof(LightingCapture._003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[CalledBy(Type = typeof(FlyMode), Member = "Warp")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(FlyMode), Member = "Enter")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	public static void Warp(Vector3 pos, Quaternion rot, float setTOD = -1f)
	{
	}

	[Calls(Type = typeof(FlyMode), Member = "Warp")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void Warp(Transform transform, float setTOD = -1f)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FlyMode()
	{
	}
}
