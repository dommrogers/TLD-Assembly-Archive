using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Rendering;

[Serializable]
public class DynamicResolutionPlatformConfig
{
	[Serializable]
	private class TargetConfig
	{
		public int m_Framerate;

		public int m_MinResolution;

		public int m_MaxResolution;

		public int m_OverrideVsync;

		[CallerCount(Count = 0)]
		public TargetConfig()
		{
		}
	}

	[Serializable]
	private enum SystemApplicationMethod
	{
		SetFrameTargetAndVSync,
		SetFrameTargetOnly,
		SetVSyncOnly,
		SetAsResolution
	}

	private const string NO_ACTIVE_TARGET = "No active target";

	private const int INVALID_VSYNC_VALUE = -1;

	private List<TargetConfig> m_Targets;

	private SystemApplicationMethod m_ApplicationMethod;

	private int m_DefaultVsync;

	private uint m_FrameTimings;

	private uint m_ScaleRaiseCounterLimit;

	private uint m_ScaleRaiseCounterBigIncrement;

	private uint m_ScaleRaiseCounterSmallIncrement;

	private double m_HeadroomThreshold;

	private double m_DeltaThreshold;

	private float m_ScaleIncreaseSmallFactor;

	private float m_ScaleIncreaseBigFactor;

	private float m_ScaleHeadroomClampMin;

	private float m_ScaleHeadroomClampMax;

	private float _003CMinRenderScale_003Ek__BackingField;

	private float _003CMaxRenderScale_003Ek__BackingField;

	private TargetConfig m_Target;

	public uint FrameTimings
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0u;
		}
	}

	public uint ScaleRaiseCounterLimit
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return 0u;
		}
	}

	public uint ScaleRaiseCounterBigIncrement
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0u;
		}
	}

	public uint ScaleRaiseCounterSmallIncrement
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0u;
		}
	}

	public double HeadroomThreshold
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0.0;
		}
	}

	public double DeltaThreshold
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0.0;
		}
	}

	public float MinRenderScale
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public float MaxRenderScale
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public bool AllowDynamicResolutionScaling
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public int TargetFramerate
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicResolutionPlatformConfig), Member = "FindBestTargetConfigMatchForFramerate")]
	[Calls(Type = typeof(DynamicResolutionPlatformConfig), Member = "ApplySystemSettings")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void UpdateFramerateTarget(int targetFramerate)
	{
	}

	[CalledBy(Type = typeof(DynamicResolutionPlatformConfig), Member = "UpdateFramerateTarget")]
	[CalledBy(Type = typeof(DynamicResolutionPlatformConfig), Member = "GetMaxResolutionScaleForPlatform")]
	[CalledBy(Type = typeof(DynamicResolutionHelper), Member = "TrySetFramerateTarget")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 5)]
	private TargetConfig FindBestTargetConfigMatchForFramerate(int targetFramerate)
	{
		return null;
	}

	[CalledBy(Type = typeof(DynamicResolutionHelper), Member = "UpdatePlatformConfig")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DynamicResolutionPlatformConfig), Member = "FindBestTargetConfigMatchForFramerate")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsUnknownMethods(Count = 7)]
	public float GetMaxResolutionScaleForPlatform(List<int> framerates)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float ConvertResolutionScaleToFactor(float resolutionScale)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float CalculateScaleIncrease(float headroomFactor)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(DynamicResolutionHelper), Member = "UpdateValidFramerates")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void GetFramerateTargets(List<int> targets)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 1)]
	public override string ToString()
	{
		return null;
	}

	[CalledBy(Type = typeof(DynamicResolutionPlatformConfig), Member = "UpdateFramerateTarget")]
	[CalledBy(Type = typeof(DynamicResolutionHelper), Member = "TrySetFramerateTarget")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(QualitySettings), Member = "set_vSyncCount")]
	[Calls(Type = typeof(Screen), Member = "SetResolution")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void ApplySystemSettings()
	{
	}

	[CallerCount(Count = 0)]
	public DynamicResolutionPlatformConfig()
	{
	}
}
