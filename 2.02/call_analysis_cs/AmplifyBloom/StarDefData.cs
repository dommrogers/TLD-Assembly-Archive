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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string StarName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
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
			return 0;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StarDefData), Member = "CalculateStarData")]
		set
		{
		}
	}

	public int PassCount
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return 0;
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
			return 0f;
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
			return 0f;
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
			return 0f;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StarDefData), Member = "CalculateStarData")]
		set
		{
		}
	}

	public float CameraRotInfluence
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
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

	public StarLineData[] StarLinesArr
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
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
			return 0f;
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
			return 0f;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StarDefData), Member = "CalculateStarData")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public StarDefData()
	{
	}

	[CallerCount(Count = 0)]
	public void Destroy()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(AmplifyGlare), Member = ".ctor")]
	[CallerCount(Count = 5)]
	public StarDefData(StarLibType starType, string starName, int starLinesCount, int passCount, float sampleLength, float attenuation, float inclination, float rotation, float longAttenuation = 0f, float customIncrement = -1f)
	{
	}

	[CalledBy(Type = typeof(StarDefData), Member = "set_StarlinesCount")]
	[CalledBy(Type = typeof(StarDefData), Member = "set_PassCount")]
	[CalledBy(Type = typeof(StarDefData), Member = "set_SampleLength")]
	[CalledBy(Type = typeof(StarDefData), Member = "set_Attenuation")]
	[CalledBy(Type = typeof(StarDefData), Member = "set_Inclination")]
	[CalledBy(Type = typeof(StarDefData), Member = "set_CustomIncrement")]
	[CalledBy(Type = typeof(StarDefData), Member = "set_LongAttenuation")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 33)]
	public void CalculateStarData()
	{
	}
}
