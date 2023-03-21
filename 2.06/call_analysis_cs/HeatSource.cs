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

	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(HeatSourceManager), Member = "GetBestHeatSourceInRange")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(HeatSourceManager), Member = "GetTemperatureIncrease")]
	public float GetTempIncrease(Vector3 pos)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsTurnedOn()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CalledBy(Type = typeof(TorchItem), Member = "Extinguish")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "DestroyHeatSource")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[CalledBy(Type = typeof(TorchItem), Member = "DestroyHeatSource")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "DestroyHeatSource")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnDroppedInWater")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "BurnOut")]
	[CalledBy(Type = typeof(FlareItem), Member = "BurnOut")]
	[CalledBy(Type = typeof(FlareItem), Member = "DestroyHeatSource")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[Calls(Type = typeof(HeatSourceManager), Member = "RemoveHeatSource")]
	[CallerCount(Count = 13)]
	public void TurnOffImmediate()
	{
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float GetCurrentTempIncrease()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "TurnOn")]
	[CalledBy(Type = typeof(FirstPersonLightSource), Member = "TurnOnEffects")]
	[CalledBy(Type = typeof(TorchItem), Member = "Ignite")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(FlareItem), Member = "Ignite")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Ignite")]
	[CalledBy(Type = typeof(HeatSource), Member = "Start")]
	[CalledBy(Type = typeof(Fire), Member = "TurnOn")]
	[CalledBy(Type = typeof(Fire), Member = "AddFuel")]
	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "TurnOnEffects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(HeatSource), Member = "Deserialize")]
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

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public HeatSource()
	{
	}
}
