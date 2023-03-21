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

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsNight")]
	[Calls(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(FirstPersonItem), Member = "SetExteriorInteriorSwitch")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[Calls(Type = typeof(PlayerManager), Member = "ExitIndoorSpaceTrigger")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	private void OnTriggerExit(Collider c)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public IndoorSpaceTrigger()
	{
	}
}
