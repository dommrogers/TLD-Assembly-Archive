using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SmokeWispTrail : MonoBehaviour
{
	private float m_Gravity;

	private float m_UVOffsetSpeed;

	private float m_UVOffsetSeed;

	private float m_Alpha1SpeedMultiplier;

	private float m_Alpha2SpeedMultiplier;

	private float m_DistortionSpeedMultiplier;

	private TrailRenderer m_TrailRenderer;

	private int m_VertCount;

	private Vector3[] m_VertPositions;

	private Material m_Material;

	private int m_UVOffsetID;

	private Vector4 m_UVOffsets;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	public SmokeWispTrail()
	{
	}
}
