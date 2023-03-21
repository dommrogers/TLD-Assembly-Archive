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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanApplyCameraMotionToJoint()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CalledBy(Type = typeof(CameraBasedJointPositioning), Member = "Restore")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "GetShoulderRotation")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Load")]
	public void UpdateJoint()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateActiveJointPositioning")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Animator), Member = "get_layerCount")]
	[Calls(Type = typeof(Animator), Member = "SetLayerWeight")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Animator), Member = "SetLayerWeight")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "UpdateShoulderRotation")]
	[Calls(Type = typeof(Animator), Member = "get_layerCount")]
	public void Enable(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnPlayerDeath")]
	[Calls(Type = typeof(Animator), Member = "SetLayerWeight")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "RestoreCameraBasedHandPositioning")]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "UpdateJoint")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "RestoreCameraBasedHandPositioning")]
	public void Restore()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "SaveCameraBasedHandPositioning")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetAimingModesForStruggle")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetAimingModesForStruggle")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "SaveCameraBasedHandPositioning")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[CalledBy(Type = typeof(CameraBasedJointPositioning), Member = "ResetForStruggle")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwapFPController")]
	public void Save(string saveName)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "LoadCameraBasedHandPositioning")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "LoadCameraBasedHandPositioning")]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[CalledBy(Type = typeof(CameraBasedJointPositioning), Member = "UpdateJoint")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(CinematicManager), Member = "SwapFPController")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public void Load(string saveName)
	{
	}

	[CallerCount(Count = 0)]
	private float GetAngleFromPercentageOfAngleRange(float min, float max, float value, float outMin, float outMax)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CameraBasedJointPositioning), Member = "UpdateJoint")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public float GetShoulderRotation()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void Reset()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "Begin")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetAimingModesForStruggle")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetAimingModesForStruggle")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "FullResetAimingModes")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "FullResetAimingModes")]
	[CalledBy(Type = typeof(CameraBasedJointPositioning), Member = "ResetForStruggle")]
	[CallsDeduplicatedMethods(Count = 5)]
	public void FullReset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "Save")]
	[Calls(Type = typeof(CameraBasedJointPositioning), Member = "FullReset")]
	public void ResetForStruggle()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public CameraBasedJointPositioning()
	{
	}
}
