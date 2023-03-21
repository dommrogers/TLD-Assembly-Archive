using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Scenes;
using UnityEngine;

namespace TLD.Gameplay.Challenges.DarkWalker;

public class ToxicFogConfig : ScriptableObject
{
	[Serializable]
	public class SceneSetTunables
	{
		public SceneSet m_SceneSet;

		public float m_TimeToFillUpToMaximumMinutes;

		[CallerCount(Count = 0)]
		public SceneSetTunables()
		{
		}
	}

	[Serializable]
	public class IndicatorLevels
	{
		public float m_Level1;

		public float m_Level2;

		public float m_Level3;

		[CallerCount(Count = 0)]
		public IndicatorLevels()
		{
		}
	}

	public float m_TimeToFillUpToMaximumMinutes;

	public float m_TimePassingScalar;

	public List<SceneSetTunables> m_SceneTunables;

	public float m_FogScaleToRuinFood;

	public float m_FogScaleToKillAllWildlife;

	public float m_FogScaleToReduceCondition;

	public float m_FogReductionOnDispelFogGlyph;

	public float m_MinimumFogScale;

	public float m_MaximumFogScale;

	public IndicatorLevels m_ToxicFogIndicatorTunables;

	[CallerCount(Count = 0)]
	public float GetAdjustedFogScale(float fogScale)
	{
		return default(float);
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public ToxicFogConfig()
	{
	}
}
