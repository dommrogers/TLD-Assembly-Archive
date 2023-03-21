using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Wiggle : MonoBehaviour
{
	public Vector3 m_PositionHeightScale;

	public Vector3 m_PositionNoiseScale;

	public bool m_UniformScaleBasedOnX;

	public Vector3 m_ScaleHeightScale;

	public Vector3 m_ScaleNoiseScale;

	public Vector3 m_RotationHeightScale;

	public Vector3 m_RotationNoiseScale;

	private float m_Seed;

	private float m_SeededTime;

	private Vector3 m_PositionPerlinValues;

	private Vector3 m_ScalePerlinValues;

	private Vector3 m_RotationPerlinValues;

	private Vector3 m_PositionOriginal;

	private Vector3 m_ScaleOriginal;

	private Vector3 m_RotationOriginal;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 14)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Wiggle()
	{
	}
}
