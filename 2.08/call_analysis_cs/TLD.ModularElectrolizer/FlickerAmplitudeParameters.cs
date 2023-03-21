using System;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.ModularElectrolizer;

[Serializable]
public class FlickerAmplitudeParameters
{
	public MinMax m_CurveRange;

	public float m_CurveBias;

	public float m_CurveGain;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public FlickerAmplitudeParameters()
	{
	}
}
