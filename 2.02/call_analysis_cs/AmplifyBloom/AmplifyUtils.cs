using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace AmplifyBloom;

public class AmplifyUtils
{
	public static int MaskTextureId;

	public static int BlurRadiusId;

	public static string HighPrecisionKeyword;

	public static string ShaderModeTag;

	public static string ShaderModeValue;

	public static string DebugStr;

	public static int UpscaleContributionId;

	public static int SourceContributionId;

	public static int LensStarburstRTId;

	public static int LensDirtRTId;

	public static int LensFlareRTId;

	public static int LensGlareRTId;

	public static int[] MipResultsRTS;

	public static int[] AnamorphicRTS;

	public static int[] AnamorphicGlareWeightsMatStr;

	public static int[] AnamorphicGlareOffsetsMatStr;

	public static int[] AnamorphicGlareWeightsStr;

	public static int[] UpscaleWeightsStr;

	public static int[] LensDirtWeightsStr;

	public static int[] LensStarburstWeightsStr;

	public static int BloomRangeId;

	public static int LensDirtStrengthId;

	public static int BloomParamsId;

	public static int TempFilterValueId;

	public static int LensFlareStarMatrixId;

	public static int LensFlareStarburstStrengthId;

	public static int LensFlareGhostsParamsId;

	public static int LensFlareLUTId;

	public static int LensFlareHaloParamsId;

	public static int LensFlareGhostChrDistortionId;

	public static int LensFlareHaloChrDistortionId;

	public static int BokehParamsId;

	public static RenderTextureFormat CurrentRTFormat;

	public static FilterMode CurrentFilterMode;

	public static TextureWrapMode CurrentWrapMode;

	public static RenderTextureReadWrite CurrentReadWriteMode;

	public static bool IsInitialized;

	private static List<RenderTexture> _allocatedRT;

	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "Awake")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 83)]
	[CallsUnknownMethods(Count = 214)]
	public static void InitializeIds()
	{
	}

	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "Awake")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DebugLog(string value, LogType type)
	{
	}

	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "ApplyGaussianBlur")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "ApplyUpscale")]
	[CalledBy(Type = typeof(AmplifyBokeh), Member = "ApplyBokehFilter")]
	[CalledBy(Type = typeof(AmplifyGlare), Member = "OnRenderFromCache")]
	[CalledBy(Type = typeof(AmplifyGlare), Member = "OnRenderImage")]
	[CalledBy(Type = typeof(AmplifyLensFlare), Member = "ApplyFlare")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static RenderTexture GetTempRenderTarget(int width, int height)
	{
		return null;
	}

	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "ApplyGaussianBlur")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[CalledBy(Type = typeof(AmplifyBokehData), Member = "Destroy")]
	[CalledBy(Type = typeof(AmplifyBokeh), Member = "Destroy")]
	[CalledBy(Type = typeof(AmplifyBokeh), Member = "ApplyBokehFilter")]
	[CalledBy(Type = typeof(AmplifyGlare), Member = "Destroy")]
	[CalledBy(Type = typeof(AmplifyGlare), Member = "OnRenderFromCache")]
	[CalledBy(Type = typeof(AmplifyGlare), Member = "OnRenderImage")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(RenderTexture), Member = "DiscardContents")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void ReleaseTempRenderTarget(RenderTexture renderTarget)
	{
	}

	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "FinalComposition")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderTexture), Member = "DiscardContents")]
	[Calls(Type = typeof(RenderTexture), Member = "ReleaseTemporary")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static void ReleaseAllRT()
	{
	}

	[CalledBy(Type = typeof(AmplifyBloomBase), Member = "OnRenderImage")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "IsKeywordEnabled")]
	[Calls(Type = typeof(Material), Member = "EnableKeyword")]
	[Calls(Type = typeof(Material), Member = "DisableKeyword")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void EnsureKeywordEnabled(Material mat, string keyword, bool state)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public AmplifyUtils()
	{
	}
}
