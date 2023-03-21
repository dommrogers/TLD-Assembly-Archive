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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsUnknownMethods(Count = 4)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "UpdateTeleport")]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "PlayingIdle")]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "PlayingIdle")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(PlayerCameraAnim), Member = "Update")]
	[CalledBy(Type = typeof(PlayerCameraAnim), Member = "Update")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	private bool PlayingIdle()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool AnimIsPlaying(int id, int layerIndex)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "LateUpdate")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	public void UpdateMainCamera()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(GameManager), Member = "EarlyUpdate")]
	[CallsUnknownMethods(Count = 4)]
	public void RestoreMainCameraPos()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CameraAnimationState GetState()
	{
		return default(CameraAnimationState);
	}

	[Calls(Type = typeof(PlayerCameraAnim), Member = "UpdateTeleport")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetStickToGroundPosition")]
	public void TeleportPlayerToCameraNow(float blendTime)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "TeleportPlayer")]
	[CalledBy(Type = typeof(PlayerCameraAnim), Member = "Update")]
	[CalledBy(Type = typeof(PlayerCameraAnim), Member = "TeleportPlayerToCameraNow")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateTeleport()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PlayerCameraAnim()
	{
	}
}
