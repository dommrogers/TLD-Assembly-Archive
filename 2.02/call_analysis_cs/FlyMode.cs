using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FlyMode : MonoBehaviour
{
	public float m_MoveSpeedSlow;

	public float m_MoveSpeedNormal;

	public float m_MoveSpeedFast;

	public static bool m_Enabled;

	public static Vector3 m_RestoreCameraPos;

	public static Quaternion m_RestoreCameraOrient;

	public static float m_SetTimeOfDay;

	private static Camera m_Camera;

	private static bool m_IgnoreDownUntilDownIsUp;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(FlyMode), Member = "TeleportPlayerAndExit")]
	[Calls(Type = typeof(FlyMode), Member = "Exit")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(InputManager), Member = "GetFlyModeMoveDownDown")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetRewiredActionAsAxis")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetRewiredActionAsAxis")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	public void LateUpdate()
	{
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fly")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(FlyMode), Member = "Warp")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowPlayer")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetFlyModeMoveDownDown")]
	public static void Enter()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(LightingCapture._003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_fly")]
	[CalledBy(Type = typeof(FlyMode), Member = "LateUpdate")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowPlayer")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	public static void Exit()
	{
	}

	[CalledBy(Type = typeof(FlyMode), Member = "LateUpdate")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ShowPlayer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	public static void TeleportPlayerAndExit()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Utils), Member = "RestoreView")]
	[CalledBy(Type = typeof(LightingCapture._003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_warp")]
	[CalledBy(Type = typeof(FlyMode), Member = "Warp")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(FlyMode), Member = "Enter")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
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

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public FlyMode()
	{
	}
}
