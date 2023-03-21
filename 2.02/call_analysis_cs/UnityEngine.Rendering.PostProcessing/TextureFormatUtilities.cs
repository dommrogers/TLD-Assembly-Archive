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
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 50)]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsTextureFormat")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 45)]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsObsolete")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsRenderTextureFormat")]
	static TextureFormatUtilities()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(TextureFormatUtilities), Member = ".cctor")]
	[CalledBy(Type = typeof(TextureFormatUtilities), Member = ".cctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private static bool IsObsolete(object value)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(RenderTexture), Member = "get_format")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
	[CalledBy(Type = typeof(TextureLerper), Member = "Lerp")]
	[CallsUnknownMethods(Count = 9)]
	public static RenderTextureFormat GetUncompressedRenderTextureFormat(Texture texture)
	{
		return default(RenderTextureFormat);
	}

	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "SelectFormat")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "SelectFormat")]
	[CalledBy(Type = typeof(GrainRenderer), Member = "GetLookupFormat")]
	[CalledBy(Type = typeof(MotionBlur), Member = "IsEnabledAndSupported")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GrainRenderer), Member = "Render")]
	[CalledBy(Type = typeof(AutoExposure), Member = "IsEnabledAndSupported")]
	[CalledBy(Type = typeof(MotionBlurRenderer), Member = "Render")]
	[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "SelectFormat")]
	[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "Render")]
	[CalledBy(Type = typeof(MaskedBlurEffectRenderer), Member = "SelectFormat")]
	[CalledBy(Type = typeof(AmbientOcclusion), Member = "IsEnabledAndSupported")]
	internal static bool IsSupported(this RenderTextureFormat format)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal static bool IsSupported(this TextureFormat format)
	{
		return default(bool);
	}
}
