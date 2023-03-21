using Cpp2ILInjected.CallAnalysis;
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

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Wind), Member = "StartPhase")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Random), Member = "Range")]
	public ActiveWindSettings(WindSettings ws, float angle = -1f)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public ActiveWindSettings(ActiveWindSettings other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	public void SetBlended(ActiveWindSettings a, ActiveWindSettings b, float blend)
	{
	}
}
