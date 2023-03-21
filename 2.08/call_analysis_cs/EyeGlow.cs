using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EyeGlow : MonoBehaviour
{
	public string m_eyeMeshName;

	public string m_headBoneName;

	public float m_minSensitivity;

	public float m_MaxSensitivity;

	public bool m_ignorePitch;

	public float m_minDistance;

	public float m_maxDistance;

	public float m_minIntensity;

	public float m_MaxIntensity;

	public float m_curDistance;

	private Color m_glowIntensity;

	private Material m_material;

	private Transform m_fpsCamTransform;

	private Transform m_headBoneTransform;

	private BaseAi m_BaseAi;

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private bool TurnOffEyeGlow()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public EyeGlow()
	{
	}
}
