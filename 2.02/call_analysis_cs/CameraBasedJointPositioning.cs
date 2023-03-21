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

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void Start()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private bool CanApplyCameraMotionToJoint()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[CalledBy(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "GetShoulderRotation")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Load")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public void UpdateJoint()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Animator), Member = "SetLayerWeight")]
	[Calls(Type = typeof(Animator), Member = "get_layerCount")]
	[Calls(Type = typeof(Animator), Member = "SetLayerWeight")]
	[Calls(Type = typeof(Animator), Member = "get_layerCount")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	public void Enable(bool enabled)
	{
	}

	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "UpdateJoint")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "RestoreCameraBasedHandPositioning")]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[Calls(Type = typeof(Animator), Member = "SetLayerWeight")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "RestoreCameraBasedHandPositioning")]
	public void Restore()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "SaveCameraBasedHandPositioning")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SaveCameraBasedHandPositioning")]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[CalledBy(Type = typeof(CameraBasedJointPositioning), Member = "ResetForStruggle")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 5)]
	public void Save(string saveName)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "LoadCameraBasedHandPositioning")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "LoadCameraBasedHandPositioning")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(CameraBasedJointPositioning), Member = "UpdateJoint")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void Load(string saveName)
	{
	}

	[CalledBy(Type = typeof(CameraBasedJointPositioning), Member = "GetShoulderRotation")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private float GetAngleFromPercentageOfAngleRange(float min, float max, float value, float outMin, float outMax)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(CameraBasedJointPositioning), Member = "UpdateJoint")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "GetAngleFromPercentageOfAngleRange")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public float GetShoulderRotation()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetStandardAimingMode")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "FullResetAimingModes")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CalledBy(Type = typeof(CameraBasedJointPositioning), Member = "ResetForStruggle")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "FullResetAimingModes")]
	[CallsUnknownMethods(Count = 12)]
	public void FullReset()
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetAimingModesForStruggle")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetAimingModesForStruggle")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "FullReset")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
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
