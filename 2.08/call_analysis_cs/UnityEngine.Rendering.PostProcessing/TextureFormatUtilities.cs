using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public static class TextureFormatUtilities
{
	private static Dictionary<int, RenderTextureFormat> s_FormatAliasMap;

	private static Dictionary<int, bool> s_SupportedRenderTextureFormats;

	private static Dictionary<int, bool> s_SupportedTextureFormats;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsObsolete")]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsRenderTextureFormat")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsTextureFormat")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 48)]
	[CallsUnknownMethods(Count = 41)]
	static TextureFormatUtilities()
	{
	}

	[CalledBy(Type = typeof(TextureFormatUtilities), Member = ".cctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private static bool IsObsolete(object value)
	{
		return false;
	}

	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTexture), Member = "get_format")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public static RenderTextureFormat GetUncompressedRenderTextureFormat(Texture texture)
	{
		return default(RenderTextureFormat);
	}

	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "SelectFormat")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported")]
	[CalledBy(Type = typeof(AutoExposure), Member = "IsEnabledAndSupported")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "SelectFormat")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	[CalledBy(Type = typeof(GrainRenderer), Member = "Render")]
	[CalledBy(Type = typeof(GrainRenderer), Member = "GetLookupFormat")]
	[CalledBy(Type = typeof(MotionBlur), Member = "IsEnabledAndSupported")]
	[CalledBy(Type = typeof(MotionBlurRenderer), Member = "Render")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static bool IsSupported(this RenderTextureFormat format)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static bool IsSupported(this TextureFormat format)
	{
		return false;
	}
}
