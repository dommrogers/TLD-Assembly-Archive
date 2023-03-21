using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class StaticDecal
{
	public Vector3 m_Pos;

	public Vector3 m_Scale;

	public Quaternion m_Rotation;

	public Material m_Material;

	public Material m_CameraClippedMaterial;

	public Vector4 m_Uvs;

	public bool m_UseZTestProperty;

	public int m_Layer;

	public float m_ClipAngleCos;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public StaticDecal()
	{
	}
}
