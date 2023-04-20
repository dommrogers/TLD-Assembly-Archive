using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class IceCrackVisualizationData : ScriptableObject
{
	private float m_CrackDecalLifetime;

	private float m_FallInDecalLifetime;

	private float m_RecrackBlendRate;

	private float m_AffectedRadius;

	private float m_SpacingRadius;

	private Material m_CrackDecalMaterial;

	private Material m_FallInDecalMaterial;

	private Vector3 m_DecalMinSize;

	private Vector3 m_DecalMaxSize;

	private float m_DecalRotationRandomization;

	private AnimationCurve m_CrackRateDecalRChannel;

	private AnimationCurve m_CrackRateDecalGChannel;

	private AnimationCurve m_CrackRateDecalBChannel;

	private float m_CrackDecalStartRatio;

	private float m_FallInDecalStartRatio;

	[CallerCount(Count = 0)]
	public bool IsInSpacingRadius(Vector3 pos1, Vector3 pos2)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsInAffectedRadius(Vector3 pos1, Vector3 pos2)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	private bool IsInRange(Vector3 pos1, Vector3 pos2, float radius)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public Material GetMaterial(bool fellIntoWater)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public float GetLifetime(bool fellIntoWater)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetStartingCrackRatio(bool fellIntoWater)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Vector3 GetRandomSize()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public Quaternion GetRandomRotation()
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	public Vector3 GetCrackAmountByColorChannel(float normalizedTime)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(IceCrackVisualization), Member = "OnIceCracked")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public float BlendRecrack(float currentUpdateTime)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public IceCrackVisualizationData()
	{
	}
}
