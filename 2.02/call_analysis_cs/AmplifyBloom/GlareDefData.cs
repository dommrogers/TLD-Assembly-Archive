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
		[CallerCount(Count = 6)]
		get
		{
			return default(StarLibType);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
			return 0f;
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
			return 0f;
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
			return 0f;
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
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(AmplifyGlare), Member = "set_CustomGlareDefAmount")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public GlareDefData()
	{
	}

	[CallerCount(Count = 0)]
	public GlareDefData(StarLibType starType, float starInclination, float chromaticAberration)
	{
	}
}
