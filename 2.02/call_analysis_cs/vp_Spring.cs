using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class vp_Spring
{
	public enum TransformType
	{
		Position,
		PositionAdditive,
		Rotation,
		RotationAdditive,
		Scale,
		ScaleAdditive
	}

	protected delegate void TransformDelegate();

	public TransformType Modifier;

	protected TransformDelegate m_TransformFunc;

	public Vector3 State;

	protected TransformType m_CurrentTransformType;

	protected Vector3 m_Velocity;

	public Vector3 RestState;

	public Vector3 Stiffness;

	public Vector3 Damping;

	protected float m_VelocityFadeInCap;

	protected float m_VelocityFadeInEndTime;

	protected float m_VelocityFadeInLength;

	public float MaxVelocity;

	public float MinVelocity;

	public Vector3 MaxState;

	public Vector3 MinState;

	public float RotationResetThreshold;

	protected Transform m_Transform;

	protected bool m_IsRefreshing;

	public Transform Transform
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
		set
		{
		}
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Awake")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Awake")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Awake")]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	public vp_Spring(Transform transform, TransformType modifier)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	public void FixedUpdate(float fixedTime, float fixedDeltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "Calculate")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Position()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(vp_Spring), Member = "Calculate")]
	private void PositionAdditive()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "Reset")]
	[Calls(Type = typeof(vp_Spring), Member = "Calculate")]
	private void Rotation()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_Spring), Member = "Calculate")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(vp_Spring), Member = "Reset")]
	private void RotationAdditive()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "Calculate")]
	[CallsUnknownMethods(Count = 2)]
	private void Scale()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(vp_Spring), Member = "Calculate")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void ScaleAdditive()
	{
	}

	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "Stop")]
	[CalledBy(Type = typeof(vp_Spring), Member = "set_Transform")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RefreshCameraTransform")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RefreshCameraTransform")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RefreshCameraTransform")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(vp_Spring), Member = "Refresh")]
	[CallsUnknownMethods(Count = 49)]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "Stop")]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "Stop")]
	[CalledBy(Type = typeof(vp_Spring), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	protected void RefreshTransformType()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "ClampMagnitude")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(vp_Spring), Member = "Rotation")]
	[CalledBy(Type = typeof(vp_Spring), Member = "Position")]
	[CalledBy(Type = typeof(vp_Spring), Member = "ScaleAdditive")]
	[CalledBy(Type = typeof(vp_Spring), Member = "Scale")]
	[CalledBy(Type = typeof(vp_Spring), Member = "RotationAdditive")]
	[Calls(Type = typeof(vp_Spring), Member = "Reset")]
	[CalledBy(Type = typeof(vp_Spring), Member = "PositionAdditive")]
	[Calls(Type = typeof(vp_Spring), Member = "Move")]
	protected void Calculate()
	{
	}

	[CallerCount(Count = 58)]
	[CallAnalysisFailed]
	public void AddForce(Vector3 force)
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 0)]
	public void AddForce(float x, float y, float z)
	{
	}

	[CalledBy(Type = typeof(vp_Spring), Member = "Calculate")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void Move()
	{
	}

	[CalledBy(Type = typeof(vp_Spring), Member = "RotationAdditive")]
	[CalledBy(Type = typeof(vp_Spring), Member = "Rotation")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(vp_Spring), Member = "Calculate")]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(Action_LookAtTargetForTime), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_LookAtTargetForTime), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_LookAtTargetForTime), Member = "OnExecute")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "StopSprings")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "StopSprings")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "StopSprings")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "StopSprings")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "SnapSprings")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "SnapSprings")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "SnapSprings")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "SnapSprings")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "SnapSprings")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "StopSprings")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "StopSprings")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "StopSprings")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SnapSprings")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "StopSprings")]
	public void Stop()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "ResetSprings")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "ResetSprings")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public void ForceVelocityFadeIn(float seconds)
	{
	}
}
