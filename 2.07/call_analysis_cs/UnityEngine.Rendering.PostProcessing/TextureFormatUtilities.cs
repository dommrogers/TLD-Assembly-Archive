using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public static class TextureFormatUtilities
{
	private static Dictionary<int, RenderTextureFormat> s_FormatAliasMap;

	private static Dictionary<int, bool> s_SupportedRenderTextureFormats;

	private static Dictionary<int, bool> s_SupportedTextureFormats;

	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsObsolete")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsTextureFormat")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsObsolete")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 48)]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsRenderTextureFormat")]
	static TextureFormatUtilities()
	{
	}

	[CalledBy(Type = typeof(TextureFormatUtilities), Member = ".cctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(TextureFormatUtilities), Member = ".cctor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private static bool IsObsolete(object value)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
	[Calls(Type = typeof(RenderTexture), Member = "get_format")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public static RenderTextureFormat GetUncompressedRenderTextureFormat(Texture texture)
	{
		return default(RenderTextureFormat);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MotionBlurRenderer), Member = "Render")]
	[CalledBy(Type = typeof(GrainRenderer), Member = "GetLookupFormat")]
	[CalledBy(Type = typeof(GrainRenderer), Member = "Render")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "SelectFormat")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "SelectFormat")]
	[CalledBy(Type = typeof(AutoExposure), Member = "IsEnabledAndSupported")]
	[CalledBy(Type = typeof(MotionBlur), Member = "IsEnabledAndSupported")]
	[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported")]
	[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "SelectFormat")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "SelectFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported")]
	[CallerCount(Count = 16)]
	internal static bool IsSupported(this RenderTextureFormat format)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	internal static bool IsSupported(this TextureFormat format)
	{
		return default(bool);
	}
}
