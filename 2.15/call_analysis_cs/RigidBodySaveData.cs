using UnityEngine;

public struct RigidBodySaveData
{
	public bool m_IsKinematic;

	public Vector3 m_Velocity;

	public Vector3 m_AngularVelocity;

	public CollisionDetectionMode m_CollisionDetectionMode;

	public float m_Mass;

	public float m_Drag;

	public float m_AngularDrag;

	public Vector3 m_CenterOfMass;
}
