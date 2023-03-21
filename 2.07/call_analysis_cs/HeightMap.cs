using System;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using UnityEngine;

public class HeightMap : ScriptableObject
{
	public Vector3 m_MinBounds;

	public Vector3 m_MaxBounds;

	public int m_Spacing;

	public float[] m_Heights;

	[NonSerialized]
	public Vector3 m_ActiveMinBounds;

	[NonSerialized]
	public Vector3 m_ActiveMaxBounds;

	private Bounds m_Bounds;

	[NonSerialized]
	public int m_Stride;

	private float m_SpacingScalar;

	private NativeArray<float> m_HeightsNativeArray;

	private WeatherParticleManager.ParticleCollisionHeightMapInfo m_Info;

	public static WeatherParticleManager.ParticleCollisionHeightMapInfo s_InvalidHeightMapInfo;

	public float Width
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	public float Height
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public void OnEnable()
	{
	}

	[CalledBy(TypeFullName = "WeatherParticleManager.WTTask", Member = "NoWrap")]
	[CalledBy(TypeFullName = "WeatherParticleManager.WTTask", Member = "KillPoint")]
	[CalledBy(TypeFullName = "WeatherParticleManager.WTTask", Member = "KillBox")]
	[CalledBy(TypeFullName = "WeatherParticleManager.WTTask", Member = "UpdateParticle")]
	[CalledBy(TypeFullName = "WeatherParticleManager.WTTask", Member = "UpdateParticleNoTurbulence")]
	[CalledBy(TypeFullName = "WeatherParticleManager.WTTask", Member = "Execute")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public float GetHeight(Vector3 p)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static float GetHeightStaticNativeArray(Vector3 p, WeatherParticleManager.ParticleCollisionHeightMapInfo info, NativeArray<float> heights)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	public NativeArray<float> GetHeightsNativeArray()
	{
		return default(NativeArray<float>);
	}

	[CallerCount(Count = 0)]
	public WeatherParticleManager.ParticleCollisionHeightMapInfo GetInfo()
	{
		return default(WeatherParticleManager.ParticleCollisionHeightMapInfo);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static NativeArray<float> CreateEmptyHeights()
	{
		return default(NativeArray<float>);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void DisposeHeightsNativeArray()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void AllocateHeightsNativeArray()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public HeightMap()
	{
	}
}
