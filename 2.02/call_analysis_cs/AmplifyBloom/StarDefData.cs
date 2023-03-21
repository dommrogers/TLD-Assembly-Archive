using System;
using Cpp2ILInjected.CallAnalysis;

namespace AmplifyBloom;

[Serializable]
public class StarDefData
{
	private StarLibType m_starType;

	private string m_starName;

	private int m_starlinesCount;

	private int m_passCount;

	private float m_sampleLength;

	private float m_attenuation;

	private float m_inclination;

	private float m_rotation;

	private StarLineData[] m_starLinesArr;

	private float m_customIncrement;

	private float m_longAttenuation;

	public StarLibType StarType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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

	public string StarName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		set
		{
		}
	}

	public int StarlinesCount
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(StarDefData), Member = "CalculateStarData")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int PassCount
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StarDefData), Member = "CalculateStarData")]
		set
		{
		}
	}

	public float SampleLength
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StarDefData), Member = "CalculateStarData")]
		set
		{
		}
	}

	public float Attenuation
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StarDefData), Member = "CalculateStarData")]
		set
		{
		}
	}

	public float Inclination
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StarDefData), Member = "CalculateStarData")]
		set
		{
		}
	}

	public float CameraRotInfluence
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
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

	public StarLineData[] StarLinesArr
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
	}

	public float CustomIncrement
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StarDefData), Member = "CalculateStarData")]
		set
		{
		}
	}

	public float LongAttenuation
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StarDefData), Member = "CalculateStarData")]
		set
		{
		}
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public StarDefData()
	{
	}

	[CallerCount(Count = 0)]
	public void Destroy()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(AmplifyGlare), Member = ".ctor")]
	[CalledBy(Type = typeof(AmplifyGlare), Member = ".ctor")]
	[CalledBy(Type = typeof(AmplifyGlare), Member = ".ctor")]
	[CalledBy(Type = typeof(AmplifyGlare), Member = ".ctor")]
	[CalledBy(Type = typeof(AmplifyGlare), Member = ".ctor")]
	public StarDefData(StarLibType starType, string starName, int starLinesCount, int passCount, float sampleLength, float attenuation, float inclination, float rotation, float longAttenuation = 0f, float customIncrement = -1f)
	{
	}

	[CallsUnknownMethods(Count = 33)]
	[CalledBy(Type = typeof(StarDefData), Member = "set_LongAttenuation")]
	[CalledBy(Type = typeof(StarDefData), Member = "set_Inclination")]
	[CalledBy(Type = typeof(StarDefData), Member = "set_Attenuation")]
	[CalledBy(Type = typeof(StarDefData), Member = "set_CustomIncrement")]
	[CalledBy(Type = typeof(StarDefData), Member = "set_PassCount")]
	[CalledBy(Type = typeof(StarDefData), Member = "set_StarlinesCount")]
	[CalledBy(Type = typeof(StarDefData), Member = "set_SampleLength")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 7)]
	public void CalculateStarData()
	{
	}
}
