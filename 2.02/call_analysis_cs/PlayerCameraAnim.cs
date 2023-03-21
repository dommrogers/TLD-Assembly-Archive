using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayerCameraAnim : MonoBehaviour
{
	public enum CameraAnimationState
	{
		Idle,
		Animating,
		Teleporting
	}

	public bool m_DebugOverrideCameraPosition;

	public Vector3 m_DebugCameraPositionOverride;

	public bool m_DebugDisableRotation;

	public Animator m_Animator;

	private GameObject m_CameraBone;

	private int m_MainLayer_AnimState_Idle;

	private int m_HipLayer_AnimState_Idle;

	private vp_FPSCamera m_FpsCamera;

	private Vector3 m_LastPositionOffset;

	private Vector2 m_SavedCameraAngles;

	private Quaternion m_SavedCameraRotaiton;

	private bool m_SavedCameraTransform;

	private Vector3 m_LastCameraPosition;

	private Quaternion m_LastCameraRotation;

	private Vector3 m_TeleportPosition;

	private Quaternion m_TeleportRotation;

	private float m_BlendTime;

	private float m_BlendTimeRemaining;

	private CameraAnimationState m_State;

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void Start()
	{
	}

	[Calls(Type = typeof(PlayerCameraAnim), Member = "PlayingIdle")]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "PlayingIdle")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "UpdateTeleport")]
	public void Update()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayerCameraAnim), Member = "Update")]
	[CalledBy(Type = typeof(PlayerCameraAnim), Member = "Update")]
	private bool PlayingIdle()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool AnimIsPlaying(int id, int layerIndex)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LateUpdate")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	public void UpdateMainCamera()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(GameManager), Member = "EarlyUpdate")]
	[CallsUnknownMethods(Count = 6)]
	public void RestoreMainCameraPos()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CameraAnimationState GetState()
	{
		return default(CameraAnimationState);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPosition")]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "UpdateTeleport")]
	[CallsUnknownMethods(Count = 3)]
	public void TeleportPlayerToCameraNow(float blendTime)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[CalledBy(Type = typeof(PlayerCameraAnim), Member = "Update")]
	[CalledBy(Type = typeof(PlayerCameraAnim), Member = "TeleportPlayerToCameraNow")]
	private void UpdateTeleport()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public PlayerCameraAnim()
	{
	}
}
