using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.Serialization;
using UnityEngine;

public class HeatSource : MonoBehaviour
{
	public float m_MaxTempIncrease;

	public float m_MaxTempIncreaseInnerRadius;

	public float m_MaxTempIncreaseOuterRadius;

	public float m_TimeToReachMaxTempMinutes;

	public float m_StartingTemp;

	public bool m_StartOn;

	public bool m_MaskTempIncrease;

	private float m_TempIncrease;

	private bool m_TurnedOn;

	private static HeatSourceSaveDataProxy m_HeatSourceSaveDataProxy;

	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(HeatSourceManager), Member = "GetTemperatureIncrease")]
	[CalledBy(Type = typeof(HeatSourceManager), Member = "GetBestHeatSourceInRange")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public float GetTempIncrease(Vector3 pos)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsTurnedOn()
	{
		return false;
	}

	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(FlareItem), Member = "DestroyHeatSource")]
	[CalledBy(Type = typeof(FlareItem), Member = "BurnOut")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "DestroyHeatSource")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnDroppedInWater")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[CalledBy(Type = typeof(TorchItem), Member = "DestroyHeatSource")]
	[CalledBy(Type = typeof(TorchItem), Member = "Extinguish")]
	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "DestroyHeatSource")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(HeatSourceManager), Member = "RemoveHeatSource")]
	[CallsUnknownMethods(Count = 1)]
	public void TurnOffImmediate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetCurrentTempIncrease()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "TurnOnEffects")]
	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOn")]
	[CalledBy(Type = typeof(HeatSource), Member = "Start")]
	[CalledBy(Type = typeof(HeatSource), Member = "Deserialize")]
	[CalledBy(Type = typeof(FlareItem), Member = "Ignite")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[CalledBy(Type = typeof(TorchItem), Member = "Ignite")]
	[CalledBy(Type = typeof(FirstPersonLightSource), Member = "TurnOnEffects")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOn")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void TurnOn()
	{
	}

	[CallerCount(Count = 0)]
	public void TurnOff()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeatSourceManager), Member = "RemoveHeatSource")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public HeatSource()
	{
	}
}
