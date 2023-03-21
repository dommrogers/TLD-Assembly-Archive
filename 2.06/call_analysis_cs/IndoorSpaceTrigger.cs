using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class IndoorSpaceTrigger : MonoBehaviour
{
	public bool m_AllowCampfires;

	public bool m_UseOutdoorLighting;

	public bool m_UseOutdoorTemperature;

	public bool m_IgnoreHibernation;

	public bool m_IgnoreCabinFever;

	public bool m_DontCountAsInterior;

	public bool m_CantSurvey;

	public float m_TemperatureDeltaCelsius;

	public string m_TriggerID;

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[Calls(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitIndoorSpaceTrigger")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallerCount(Count = 0)]
	private void OnTriggerExit(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public IndoorSpaceTrigger()
	{
	}
}
