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

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(FireMesh), Member = "SetMesh")]
	[Calls(Type = typeof(FireMesh), Member = "SetMesh")]
	[Calls(Type = typeof(FireMesh), Member = "SetMesh")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FireMesh), Member = "SetMesh")]
	private void StartFire()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(FireMesh), Member = "UpdateRatesAndSizes")]
	[CalledBy(Type = typeof(FireMesh), Member = "UpdateRatesAndSizes")]
	[CalledBy(Type = typeof(FireMesh), Member = "UpdateRatesAndSizes")]
	[CalledBy(Type = typeof(FireMesh), Member = "UpdateRatesAndSizes")]
	[CallsUnknownMethods(Count = 4)]
	private void SetEmissionRate(GameObject ps, float newRate)
	{
	}

	[CalledBy(Type = typeof(FireMesh), Member = "StartFire")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(FireMesh), Member = "StartFire")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(FireMesh), Member = "StartFire")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(FireMesh), Member = "StartFire")]
	private void SetMesh(ParticleSystem ps, Mesh newMesh)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	private void SetSize(GameObject ps, float newSize)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(FireMesh), Member = "Update")]
	[Calls(Type = typeof(ParticleSystem.MinMaxCurve), Member = ".ctor")]
	[Calls(Type = typeof(FireMesh), Member = "SetEmissionRate")]
	[Calls(Type = typeof(FireMesh), Member = "SetEmissionRate")]
	[Calls(Type = typeof(FireMesh), Member = "SetEmissionRate")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FireMesh), Member = "SetEmissionRate")]
	private void UpdateRatesAndSizes()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FireMesh), Member = "UpdateRatesAndSizes")]
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
