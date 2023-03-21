using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PKInstance
{
	public BoxCollider m_Collider;

	public bool m_KillsFallingSnow;

	public bool m_KillsBlowingSnow;

	public Bounds BoundingBox
	{
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
		get
		{
			return default(Bounds);
		}
	}

	[CalledBy(Type = typeof(WeatherParticleManager), Member = "InitializeForScene")]
	[CallerCount(Count = 1)]
	public PKInstance(BoxCollider bc)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "InitializeForScene")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public PKInstance(ParticleKiller pk)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collider), Member = "ClosestPointOnBounds")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
	[CallsUnknownMethods(Count = 5)]
	public bool ShouldUpdate(Vector3 camPos)
	{
		return default(bool);
	}
}
