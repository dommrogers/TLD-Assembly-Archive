using System;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
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
			return default(float);
		}
	}

	public float Height
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(WeatherParticleManager.WTTask), Member = "UpdateParticle")]
	[CalledBy(Type = typeof(WeatherParticleManager.WTTask), Member = "UpdateParticleNoTurbulence")]
	[CalledBy(Type = typeof(WeatherParticleManager.WTTask), Member = "KillBox")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(WeatherParticleManager.WTTask), Member = "NoWrap")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(WeatherParticleManager.WTTask), Member = "KillPoint")]
	public float GetHeight(Vector3 p)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static float GetHeightStaticNativeArray(Vector3 p, WeatherParticleManager.ParticleCollisionHeightMapInfo info, NativeArray<float> heights)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[CallsUnknownMethods(Count = 6)]
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

	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void DisposeHeightsNativeArray()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
