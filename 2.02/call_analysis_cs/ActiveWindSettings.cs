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
	[CallerCount(Count = 2)]
	public ActiveWindSettings()
	{
	}

	[CalledBy(Type = typeof(Wind), Member = "StartPhase")]
	[CalledBy(Type = typeof(Wind), Member = "StartPhase")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	public ActiveWindSettings(WindSettings ws, float angle = -1f)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public ActiveWindSettings(ActiveWindSettings other)
	{
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	public void SetBlended(ActiveWindSettings a, ActiveWindSettings b, float blend)
	{
	}
}
