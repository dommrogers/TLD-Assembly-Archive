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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
		set
		{
		}
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Awake")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Awake")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Start")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Awake")]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	public vp_Spring(Transform transform, TransformType modifier)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void FixedUpdate(float fixedTime, float fixedDeltaTime)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_Spring), Member = "RefreshTransformType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Refresh()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(vp_Spring), Member = "Calculate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Position()
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "Calculate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void PositionAdditive()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(vp_Spring), Member = "Calculate")]
	[CallerCount(Count = 0)]
	private void Rotation()
	{
	}

	[Calls(Type = typeof(vp_Spring), Member = "Calculate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 3)]
	private void RotationAdditive()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(vp_Spring), Member = "Calculate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Scale()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Spring), Member = "Calculate")]
	private void ScaleAdditive()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "Stop")]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "Stop")]
	[CalledBy(Type = typeof(TLD_FPHandsTrack), Member = "Stop")]
	[CalledBy(Type = typeof(vp_Spring), Member = "Refresh")]
	[CalledBy(Type = typeof(vp_Spring), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_Spring), Member = "set_Transform")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RefreshCameraTransform")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RefreshCameraTransform")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "RefreshCameraTransform")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[CalledBy(Type = typeof(vp_Spring), Member = "FixedUpdate")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	protected void RefreshTransformType()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_Spring), Member = "ScaleAdditive")]
	[CalledBy(Type = typeof(vp_Spring), Member = "Scale")]
	[CalledBy(Type = typeof(vp_Spring), Member = "RotationAdditive")]
	[CalledBy(Type = typeof(vp_Spring), Member = "Rotation")]
	[CalledBy(Type = typeof(vp_Spring), Member = "PositionAdditive")]
	[CalledBy(Type = typeof(vp_Spring), Member = "Position")]
	[Calls(Type = typeof(vp_Spring), Member = "Move")]
	[Calls(Type = typeof(vp_Spring), Member = "Reset")]
	[CallerCount(Count = 6)]
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

	[CalledBy(Type = typeof(vp_Spring), Member = "Calculate")]
	[CallerCount(Count = 1)]
	protected void Move()
	{
	}

	[CalledBy(Type = typeof(vp_Spring), Member = "Calculate")]
	[CallerCount(Count = 1)]
	public void Reset()
	{
	}

	[CallerCount(Count = 0)]
	public void Stop()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "ResetSprings")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "ResetSprings")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ForceVelocityFadeIn(float seconds)
	{
	}
}
