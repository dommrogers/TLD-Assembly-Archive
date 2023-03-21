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

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(FireMesh), Member = "SetMesh")]
	[Calls(Type = typeof(FireMesh), Member = "SetMesh")]
	[Calls(Type = typeof(FireMesh), Member = "SetMesh")]
	[Calls(Type = typeof(FireMesh), Member = "SetMesh")]
	[CallsUnknownMethods(Count = 5)]
	private void StartFire()
	{
	}

	[CalledBy(Type = typeof(FireMesh), Member = "UpdateRatesAndSizes")]
	[CalledBy(Type = typeof(FireMesh), Member = "UpdateRatesAndSizes")]
	[CalledBy(Type = typeof(FireMesh), Member = "UpdateRatesAndSizes")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(FireMesh), Member = "UpdateRatesAndSizes")]
	[CallsUnknownMethods(Count = 3)]
	private void SetEmissionRate(GameObject ps, float newRate)
	{
	}

	[CalledBy(Type = typeof(FireMesh), Member = "StartFire")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(FireMesh), Member = "StartFire")]
	[CalledBy(Type = typeof(FireMesh), Member = "StartFire")]
	[CalledBy(Type = typeof(FireMesh), Member = "StartFire")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	private void SetMesh(ParticleSystem ps, Mesh newMesh)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	private void SetSize(GameObject ps, float newSize)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(FireMesh), Member = "Update")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(Type = typeof(FireMesh), Member = "SetEmissionRate")]
	[Calls(Type = typeof(FireMesh), Member = "SetEmissionRate")]
	[Calls(Type = typeof(FireMesh), Member = "SetEmissionRate")]
	[Calls(Type = typeof(FireMesh), Member = "SetEmissionRate")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void UpdateRatesAndSizes()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FireMesh), Member = "UpdateRatesAndSizes")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public FireMesh()
	{
	}
}
