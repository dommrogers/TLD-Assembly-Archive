using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraBasedJointPositioning : MonoBehaviour
{
	private struct JointSavedData
	{
		public Vector3 m_PositionToRestore;

		public bool m_HasSetPositionToRestore;

		public Quaternion m_Rotation;
	}

	public GameObject m_Joint;

	public float m_Camera_MaxAngle;

	public float m_Camera_MinAngle;

	public float m_Camera_CenterAngle;

	public float m_Joint_MaxAngle;

	public float m_Joint_MinAngle;

	public float m_Joint_CenterAngle;

	public float m_JointAngleMinDifferenceForUpdate;

	public float m_JointRotationMaxDegreesPerSecond;

	public bool m_ApplyCameraMotionToJoint;

	public string m_Layer;

	public float m_LayerWeight;

	public GameObject m_CameraBone;

	private float m_LastAngle;

	private Vector3 m_JointPositionAtStart;

	private bool m_Enabled;

	private Vector3 m_StandingPositionOffset;

	private int m_LayerIndex;

	private Vector3 m_PositionToRestore;

	private bool m_HasSetPositionToRestore;

	private bool m_WasStruggling;

	private const string STRUGGLE_SAVE_ID = "Strugle";

	private Dictionary<string, JointSavedData> m_SavedJoints;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool CanApplyCameraMotionToJoint()
	{
		return false;
	}

	[CalledBy(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "GetShoulderRotation")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Load")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	public void UpdateJoint()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Animator), Member = "get_layerCount")]
	[Calls(Type = typeof(Animator), Member = "SetLayerWeight")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	public void Enable(bool enabled)
	{
	}

	[CalledBy(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "RestoreCameraBasedHandPositioning")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Animator), Member = "SetLayerWeight")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "UpdateJoint")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void Restore()
	{
	}

	[CalledBy(Type = typeof(CameraBasedJointPositioning), Member = "ResetForStruggle")]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SaveCameraBasedHandPositioning")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void Save(string saveName)
	{
	}

	[CalledBy(Type = typeof(CameraBasedJointPositioning), Member = "UpdateJoint")]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "LoadCameraBasedHandPositioning")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	public void Load(string saveName)
	{
	}

	[CalledBy(Type = typeof(CameraBasedJointPositioning), Member = "GetShoulderRotation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetAngleFromPercentageOfAngleRange(float min, float max, float value, float outMin, float outMax)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CameraBasedJointPositioning), Member = "UpdateJoint")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "GetAngleFromPercentageOfAngleRange")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public float GetShoulderRotation()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetStandardAimingMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(CameraBasedJointPositioning), Member = "ResetForStruggle")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "FullResetAimingModes")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	public void FullReset()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetAimingModesForStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "FullReset")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ResetForStruggle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public CameraBasedJointPositioning()
	{
	}
}
