using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public static class TextureFormatUtilities
{
	private static Dictionary<int, RenderTextureFormat> s_FormatAliasMap;

	private static Dictionary<int, bool> s_SupportedRenderTextureFormats;

	private static Dictionary<int, bool> s_SupportedTextureFormats;

	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsObsolete")]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsTextureFormat")]
	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsObsolete")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 48)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsRenderTextureFormat")]
	static TextureFormatUtilities()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(TextureFormatUtilities), Member = ".cctor")]
	[CalledBy(Type = typeof(TextureFormatUtilities), Member = ".cctor")]
	[CallsUnknownMethods(Count = 3)]
	private static bool IsObsolete(object value)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTexture), Member = "get_format")]
	[CallsUnknownMethods(Count = 9)]
	public static RenderTextureFormat GetUncompressedRenderTextureFormat(Texture texture)
	{
		return default(RenderTextureFormat);
	}

	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	[CalledBy(Type = typeof(GrainRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MotionBlur), Member = "IsEnabledAndSupported")]
	[CalledBy(Type = typeof(MotionBlurRenderer), Member = "Render")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "SelectFormat")]
	[CalledBy(Type = typeof(GrainRenderer), Member = "GetLookupFormat")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "SelectFormat")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "SelectFormat")]
	[CalledBy(Type = typeof(AutoExposure), Member = "IsEnabledAndSupported")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "SelectFormat")]
	[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported")]
	[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported")]
	internal static bool IsSupported(this RenderTextureFormat format)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static bool IsSupported(this TextureFormat format)
	{
		return default(bool);
	}
}
