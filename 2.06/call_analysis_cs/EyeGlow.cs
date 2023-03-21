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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool TurnOffEyeGlow()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public EyeGlow()
	{
	}
}
