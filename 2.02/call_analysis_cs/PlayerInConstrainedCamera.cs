using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayerInConstrainedCamera : MonoBehaviour
{
	[Serializable]
	public class ConstrainedCameraInfo
	{
		public float m_TransitionTime;

		public Transform m_PlayerEntryPoint;

		public bool m_PlayerExitPointIsEnterPoint;

		public Transform m_PlayerExitPoint;

		public float m_EnterCameraPitch;

		public float m_ExitCameraPitch;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public ConstrainedCameraInfo()
		{
		}
	}

	public enum ConstrainedState
	{
		Unconstrained,
		TransitionIn,
		Constrained,
		TransitionOut
	}

	public bool m_UseFOV;

	public float m_FOV;

	public Vector2 m_PitchLimitDegrees;

	public Vector2 m_YawLimitDegrees;

	public float m_FadeOutSeconds;

	public float m_FadeInSeconds;

	private float m_StartCameraFOV;

	private Vector2 m_StartPitchLimit;

	private Vector2 m_StartYawLimit;

	public float m_PanViewSeconds;

	public int m_EasingLevel;

	private Vector3 m_TargetPos;

	private Quaternion m_TargetRot;

	private Vector3 m_LerpStartPos;

	private Quaternion m_LerpStartRot;

	private float m_PanStartTime;

	private float m_LerpStartCameraPitch;

	private float m_TargetCameraPitch;

	private float m_LerpStartCameraYaw;

	private float m_TargetCameraYaw;

	private ConstrainedCameraInfo m_ConstrainedCameraInfo;

	public ConstrainedState m_ConstrainedState;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInConstrainedCamera), Member = "TransitionCamera")]
	[Calls(Type = typeof(PlayerInConstrainedCamera), Member = "OnExitConstrainedState")]
	[Calls(Type = typeof(PlayerInConstrainedCamera), Member = "TransitionCamera")]
	[Calls(Type = typeof(PlayerInConstrainedCamera), Member = "OnEnterConstrainedState")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(PlayerInConstrainedCamera), Member = "PanToLocation")]
	[Calls(Type = typeof(PlayerManager), Member = "DisableCharacterController")]
	[CalledBy(Type = typeof(Chair), Member = "ProcessInteraction")]
	public void Enter(ConstrainedCameraInfo constrainedCameraInfo)
	{
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	public void Exit()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ConstrainedState GetConstrainedState()
	{
		return default(ConstrainedState);
	}

	[CallerCount(Count = 0)]
	public bool InTransition()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "Enter")]
	[CallsUnknownMethods(Count = 14)]
	private void PanToLocation(Transform target)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "Update")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private bool TransitionCamera()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 46)]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "Update")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void OnEnterConstrainedState()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[CallsUnknownMethods(Count = 33)]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	private void OnExitConstrainedState()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PlayerInConstrainedCamera()
	{
	}
}
