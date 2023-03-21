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
		[CallerCount(Count = 6)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInConstrainedCamera), Member = "TransitionCamera")]
	[Calls(Type = typeof(PlayerInConstrainedCamera), Member = "OnExitConstrainedState")]
	[Calls(Type = typeof(PlayerInConstrainedCamera), Member = "OnEnterConstrainedState")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(Chair), Member = "PerformInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(PlayerInConstrainedCamera), Member = "PanToLocation")]
	[Calls(Type = typeof(PlayerManager), Member = "DisableCharacterController")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	public void Enter(ConstrainedCameraInfo constrainedCameraInfo)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Exit()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	public ConstrainedState GetConstrainedState()
	{
		return default(ConstrainedState);
	}

	[CallerCount(Count = 0)]
	public bool InTransition()
	{
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "Enter")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	private void PanToLocation(Transform target)
	{
	}

	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 12)]
	private bool TransitionCamera()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 15)]
	private void OnEnterConstrainedState()
	{
	}

	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 10)]
	private void OnExitConstrainedState()
	{
	}

	[CallerCount(Count = 0)]
	public PlayerInConstrainedCamera()
	{
	}
}
