using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay.Tunable;
using UnityEngine;

public class ActiveWindSettings
{
	public float m_Angle;

	public float m_Velocity;

	public float m_Gustiness;

	public float m_LateralBluster;

	public float m_VerticalBluster;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ActiveWindSettings()
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "StartPhase")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = "GetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public ActiveWindSettings(WindSettings ws, float angle = -1f)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public ActiveWindSettings(ActiveWindSettings other)
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[CallsUnknownMethods(Count = 2)]
	public void SetBlended(ActiveWindSettings a, ActiveWindSettings b, float blend)
	{
	}
}
