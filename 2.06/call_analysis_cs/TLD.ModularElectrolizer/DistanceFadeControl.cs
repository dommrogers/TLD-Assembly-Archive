using Cpp2ILInjected.CallAnalysis;

namespace TLD.ModularElectrolizer;

public class DistanceFadeControl
{
	private DistanceParameters m_OutdoorDistance;

	private DistanceParameters m_IndoorDistance;

	private float m_MaxCullDistSqr;

	private float m_MaxFadeDistSqr;

	private float m_DistanceIntensity;

	private QualityLodBias m_CachedQualitySetting;

	public float DistanceIntensity
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	public float MaxDistanceSqr
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	public float MaxFadeSqr
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 230)]
	public DistanceFadeControl(DistanceParameters outdoor, DistanceParameters indoor)
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraElectrolizers")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "Initialize")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void SetLocationDistances(bool useOutdoorValues, QualityLodBias quality, bool forceUpdate = false)
	{
	}

	[CallerCount(Count = 0)]
	public void CalculateDistanceIntensity(float camDistSqr)
	{
	}
}
