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

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Mathf), Member = "PerlinNoise")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Wiggle()
	{
	}
}
