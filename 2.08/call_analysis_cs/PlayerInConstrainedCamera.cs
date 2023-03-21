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

	[Calls(Type = typeof(PlayerInConstrainedCamera), Member = "OnEnterConstrainedState")]
	[Calls(Type = typeof(PlayerInConstrainedCamera), Member = "TransitionCamera")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInConstrainedCamera), Member = "TransitionCamera")]
	[Calls(Type = typeof(PlayerInConstrainedCamera), Member = "OnExitConstrainedState")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(PlayerManager), Member = "DisableCharacterController")]
	[Calls(Type = typeof(PlayerInConstrainedCamera), Member = "PanToLocation")]
	[CalledBy(Type = typeof(Chair), Member = "PerformInteraction")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	public void Enter(ConstrainedCameraInfo constrainedCameraInfo)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Exit()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ConstrainedState GetConstrainedState()
	{
		return default(ConstrainedState);
	}

	[CallerCount(Count = 0)]
	public bool InTransition()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "Enter")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	private void PanToLocation(Transform target)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "Update")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "Update")]
	[CallsUnknownMethods(Count = 12)]
	private bool TransitionCamera()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "Update")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	private void OnEnterConstrainedState()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[CalledBy(Type = typeof(PlayerInConstrainedCamera), Member = "Update")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(PlayerManager), Member = "StickPlayerToGround")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "UpdateCameraRotation")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "set_Angle")]
	private void OnExitConstrainedState()
	{
	}

	[CallerCount(Count = 0)]
	public PlayerInConstrainedCamera()
	{
	}
}
