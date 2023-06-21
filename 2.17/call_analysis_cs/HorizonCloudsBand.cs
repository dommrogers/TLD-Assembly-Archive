using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HorizonCloudsBand : MonoBehaviour
{
	public enum HorizonBandId
	{
		Band1,
		Band2,
		Band3,
		Grad,
		SkyCloudEdge1,
		SkyCloudEdge2
	}

	public HorizonBandId m_HorizonBandId;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetHorizonCloudsBand2Renderer")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetHorizonCloudsBand3Renderer")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetHorizonCloudsBand2Renderer")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetHorizonCloudsBand3Renderer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public HorizonCloudsBand()
	{
	}
}
