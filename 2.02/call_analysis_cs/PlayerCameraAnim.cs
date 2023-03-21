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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "UpdateTeleport")]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "PlayingIdle")]
	public void Update()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(PlayerCameraAnim), Member = "Update")]
	[CallerCount(Count = 2)]
	private bool PlayingIdle()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool AnimIsPlaying(int id, int layerIndex)
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 28)]
	public void UpdateMainCamera()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(GameManager), Member = "EarlyUpdate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public void RestoreMainCameraPos()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CameraAnimationState GetState()
	{
		return default(CameraAnimationState);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPosition")]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "UpdateTeleport")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void TeleportPlayerToCameraNow(float blendTime)
	{
	}

	[CalledBy(Type = typeof(PlayerCameraAnim), Member = "Update")]
	[CalledBy(Type = typeof(PlayerCameraAnim), Member = "TeleportPlayerToCameraNow")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	private void UpdateTeleport()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PlayerCameraAnim()
	{
	}
}
