using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Timeline;

public class Sparks : MonoBehaviour, ITimeControl
{
	public float m_IntervalSeconds;

	public float m_SparkSize;

	public float m_SparkSpeed;

	public float m_SparkGravity;

	public float m_EmissionRate;

	public float m_Fluxuations;

	public float m_Lifetime;

	public GameObject m_SparkParticles;

	public GameObject m_SmokeParticles;

	public bool m_ContinuousSmoke;

	public float m_CurrentEmissionRate;

	public bool m_Fade;

	public float m_FadeTime;

	private float m_CurrentFadeTime;

	private float m_FadeMultiplier;

	private float m_CurrentTime;

	private float m_Destination;

	private float m_EmissionStart;

	private ParticleSystem m_SparkPS;

	private ParticleSystem.MainModule m_SparkPSMain;

	private ParticleSystem m_SmokePS;

	private bool m_IsTimeControlled;

	private float m_CurrentControlledTime;

	[CalledBy(Type = typeof(Sparks), Member = "OnControlTimeStart")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	public void SetTime(double t)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sparks), Member = "Start")]
	public void OnControlTimeStart()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnControlTimeStop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetEmissonRate(ParticleSystem ps, float newRate)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Sparks()
	{
	}
}
