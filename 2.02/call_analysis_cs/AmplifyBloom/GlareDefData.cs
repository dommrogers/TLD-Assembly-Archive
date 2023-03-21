using System;
using Cpp2ILInjected.CallAnalysis;

namespace AmplifyBloom;

[Serializable]
public class GlareDefData
{
	public bool FoldoutValue;

	private StarLibType m_starType;

	private float m_starInclination;

	private float m_chromaticAberration;

	private StarDefData m_customStarData;

	public StarLibType StarType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return default(StarLibType);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public float StarInclination
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float StarInclinationDeg
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float ChromaticAberration
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public StarDefData CustomStarData
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CallerCount(Count = 41)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CalledBy(Type = typeof(AmplifyGlare), Member = "set_CustomGlareDefAmount")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public GlareDefData()
	{
	}

	[CallerCount(Count = 0)]
	public GlareDefData(StarLibType starType, float starInclination, float chromaticAberration)
	{
	}
}
