using Cpp2ILInjected.CallAnalysis;
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
		[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Awake")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Awake")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Awake")]
	[CallerCount(Count = 8)]
	public vp_Spring(Transform transform, TransformType modifier)
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	public void FixedUpdate(float fixedTime, float fixedDeltaTime)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	public void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(vp_Spring), Member = "Calculate")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Position()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "Calculate")]
	[CallsUnknownMethods(Count = 3)]
	private void PositionAdditive()
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(vp_Spring), Member = "Calculate")]
	[CallerCount(Count = 0)]
	private void Rotation()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(vp_Spring), Member = "Calculate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	private void RotationAdditive()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "Calculate")]
	private void Scale()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(vp_Spring), Member = "Calculate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void ScaleAdditive()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RefreshCameraTransform")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RefreshCameraTransform")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RefreshCameraTransform")]
	[CalledBy(Type = typeof(vp_Spring), Member = "set_Transform")]
	[CalledBy(Type = typeof(vp_Spring), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(vp_Spring), Member = "Refresh")]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "Stop")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[CallsUnknownMethods(Count = 31)]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "Stop")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "Stop")]
	protected void RefreshTransformType()
	{
	}

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(vp_Spring), Member = "Reset")]
	[Calls(Type = typeof(vp_Spring), Member = "Move")]
	[CalledBy(Type = typeof(vp_Spring), Member = "Position")]
	[CalledBy(Type = typeof(vp_Spring), Member = "PositionAdditive")]
	[CalledBy(Type = typeof(vp_Spring), Member = "Rotation")]
	[CalledBy(Type = typeof(vp_Spring), Member = "RotationAdditive")]
	[CalledBy(Type = typeof(vp_Spring), Member = "ScaleAdditive")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_Spring), Member = "Scale")]
	protected void Calculate()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 59)]
	public void AddForce(Vector3 force)
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallerCount(Count = 0)]
	public void AddForce(float x, float y, float z)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_Spring), Member = "Calculate")]
	protected void Move()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_Spring), Member = "Calculate")]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	public void Stop()
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "ResetSprings")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "ResetSprings")]
	public void ForceVelocityFadeIn(float seconds)
	{
	}
}
