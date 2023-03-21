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
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SmokeWispTrail()
	{
	}
}
