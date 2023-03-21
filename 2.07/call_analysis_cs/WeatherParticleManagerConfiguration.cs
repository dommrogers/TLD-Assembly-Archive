using System;
using UnityEngine;

[Serializable]
public struct WeatherParticleManagerConfiguration
{
	public Vector3 m_SnowBoxDimensions;

	public float m_SnowBoxNearThreshold;

	public Vector3 m_SnowBoxBias;

	public bool m_CalcBoxXY;

	public bool m_EnableTurbulence;

	public bool m_EnableTerrainHeightTests;

	public Vector2 m_WindTurbulenceInputScalars;

	public Vector2 m_WindTurbulenceOutputScalars;

	public Vector3 m_WindTurbulenceSineScalarsMin;

	public Vector3 m_WindTurbulenceSineScalarsMax;

	public Vector3 m_WindTurbulenceGustScalar;

	public Vector2 m_WindTurbulenceGustOffsets;

	public Vector2 m_WindTransverseScalars;

	public Vector2 m_NoiseWindSpeeds;

	public Vector4 m_NoiseScalars;

	public Vector2 m_GrassPhaseConstantStepScalars;

	public Vector2 m_GrassPhaseNoiseStepScalars;

	public float m_BranchPhaseFrequencyScalar;

	[NonSerialized]
	public bool m_UseNoise;
}
