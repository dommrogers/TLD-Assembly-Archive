using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FireMesh : MonoBehaviour
{
	public Mesh m_MeshToBurn;

	public float m_Intensity;

	public float m_Coverage;

	public float m_SpriteExpansion;

	public GameObject m_CoverageParticles;

	public GameObject m_SmokeParticles;

	public GameObject m_SparkParticles;

	public GameObject m_SpriteParticles;

	private ParticleSystem m_SpriteParticlesPS;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(FireMesh), Member = "SetMesh")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	private void StartFire()
	{
	}

	[CalledBy(Type = typeof(FireMesh), Member = "UpdateRatesAndSizes")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void SetEmissionRate(GameObject ps, float newRate)
	{
	}

	[CalledBy(Type = typeof(FireMesh), Member = "StartFire")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetMesh(ParticleSystem ps, Mesh newMesh)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetSize(GameObject ps, float newSize)
	{
	}

	[CalledBy(Type = typeof(FireMesh), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FireMesh), Member = "SetEmissionRate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateRatesAndSizes()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FireMesh), Member = "UpdateRatesAndSizes")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FireMesh()
	{
	}
}
