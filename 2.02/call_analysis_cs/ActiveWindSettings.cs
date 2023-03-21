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
	[CallerCount(Count = 7)]
	public ActiveWindSettings()
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "StartPhase")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public ActiveWindSettings(WindSettings ws, float angle = -1f)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public ActiveWindSettings(ActiveWindSettings other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetBlended(ActiveWindSettings a, ActiveWindSettings b, float blend)
	{
	}
}
