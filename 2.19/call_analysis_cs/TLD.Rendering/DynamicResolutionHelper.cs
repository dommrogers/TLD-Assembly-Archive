using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Logging;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Rendering;

public static class DynamicResolutionHelper
{
	private const int FORCED_RESOLUTION_LIMIT = 50;

	private const string CONFIG_NAME = "DynamicResolutionConfig";

	private static readonly LogFilter s_LogFilter;

	private static DynamicResolutionConfig s_Config;

	private static DynamicResolutionPlatformConfig s_ActivePlatformConfig;

	public static bool CanMeasureFrameTimings;

	private static int _003CMaxWidth_003Ek__BackingField;

	private static int _003CMaxHeight_003Ek__BackingField;

	private static int _003CRenderWidth_003Ek__BackingField;

	private static int _003CRenderHeight_003Ek__BackingField;

	private static double _003CGPUFrameTime_003Ek__BackingField;

	private static double _003CCPUFrameTime_003Ek__BackingField;

	private static List<int> _003CValidFramerateTargets_003Ek__BackingField;

	private static int s_TargetFrameRate;

	private static double s_TargetFrameTime;

	private static uint s_FrameCount;

	private static FrameTiming[] s_FrameTimings;

	private static double s_GPUFrameTimeDelta;

	private static uint s_ScaleRaiseCounter;

	private static float s_CurrentScaleFactor;

	private static float s_CurrentScale;

	private static bool s_AllowDynamicResolutionScaling;

	private static int s_LastSceneMaxResolution;

	private static float s_LastSceneMaxResolutionFactor;

	private static bool s_UseEnhancedRenderSettings;

	private static bool s_Initialized;

	public static bool IsDynamicResolutionEnabled
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public static float StaticScalingMin
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	public static float StaticScalingMax
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	public static int MaxWidth
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public static int MaxHeight
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public static int RenderWidth
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public static int RenderHeight
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public static double GPUFrameTime
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return 0.0;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public static double CPUFrameTime
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return 0.0;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public static List<int> ValidFramerateTargets
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[Calls(Type = typeof(DynamicResolutionHelper), Member = "UpdatePlatformConfig")]
	[Calls(Type = typeof(DynamicResolutionHelper), Member = "UpdateScreenResolution")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void Initialize()
	{
	}

	[CalledBy(Type = typeof(DynamicResolutionHelper), Member = "Initialize")]
	[CalledBy(Type = typeof(DynamicResolutionHelper), Member = "UpdateDynamicResolution")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicResolutionHelper), Member = "UpdateValidFramerates")]
	[Calls(Type = typeof(DynamicResolutionPlatformConfig), Member = "GetMaxResolutionScaleForPlatform")]
	[Calls(Type = typeof(DynamicResolutionHelper), Member = "TrySetFramerateTarget")]
	[Calls(Type = typeof(DynamicResolutionHelper), Member = "ResetDynamicResolution")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static void UpdatePlatformConfig()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static int DetermineMaxRefreshRate()
	{
		return 0;
	}

	[CalledBy(Type = typeof(DynamicResolutionHelper), Member = "UpdatePlatformConfig")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DynamicResolutionPlatformConfig), Member = "GetFramerateTargets")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private static void UpdateValidFramerates()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CalledBy(Type = typeof(DynamicResolutionHelper), Member = "Initialize")]
	[CallerCount(Count = 3)]
	public static void UpdateScreenResolution()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVsyncAndFramerateCap")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dynamic_resolution_set_framerate_target")]
	[CalledBy(Type = typeof(DynamicResolutionHelper), Member = "UpdatePlatformConfig")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DynamicResolutionPlatformConfig), Member = "FindBestTargetConfigMatchForFramerate")]
	[Calls(Type = typeof(DynamicResolutionPlatformConfig), Member = "ApplySystemSettings")]
	[Calls(Type = typeof(DynamicResolutionHelper), Member = "ResetDynamicResolution")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void TrySetFramerateTarget(int framerateTarget)
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(DynamicResolutionHelper), Member = "UpdatePlatformConfig")]
	[CalledBy(Type = typeof(DynamicResolutionHelper), Member = "TrySetFramerateTarget")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DynamicResolutionHelper), Member = "UpdateResolutionScale")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void ResetDynamicResolution()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dynamic_resolution_set_scale")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DynamicResolutionHelper), Member = "UpdateResolutionScale")]
	[CallsUnknownMethods(Count = 1)]
	public static void SetForcedResolutionScale(float resolutionScale)
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DynamicResolutionHelper), Member = "UpdateFrameStats")]
	[Calls(Type = typeof(DynamicResolutionHelper), Member = "UpdateResolutionScale")]
	[Calls(Type = typeof(DynamicResolutionHelper), Member = "UpdatePlatformConfig")]
	[CallsUnknownMethods(Count = 2)]
	public static void UpdateDynamicResolution()
	{
	}

	[CalledBy(Type = typeof(DynamicResolutionHelper), Member = "UpdateDynamicResolution")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private static void UpdateFrameStats()
	{
	}

	[CalledBy(Type = typeof(DynamicResolutionHelper), Member = "ResetDynamicResolution")]
	[CalledBy(Type = typeof(DynamicResolutionHelper), Member = "SetForcedResolutionScale")]
	[CalledBy(Type = typeof(DynamicResolutionHelper), Member = "UpdateDynamicResolution")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	private static void UpdateResolutionScale()
	{
	}
}
