using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public static class HDRManager
{
	public const float PAPER_WHITE_DEFAULT = 160f;

	public const float PEAK_BRIGHTNESS_DEFAULT = 1000f;

	public const float PAPER_WHITE_MIN = 0f;

	public const float PAPER_WHITE_MAX = 1000f;

	public const float PEAK_BRIGHTNESS_MIN = 300f;

	public const float PEAK_BRIGHTNESS_MAX = 6000f;

	private static IHDRHandler m_HDRHandler;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 9)]
	public static void Initialize()
	{
	}

	[CalledBy(Type = typeof(HDRManager), Member = "SetPaperWhiteFromRange")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyBrightness")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnBrightnessChanged")]
	[CallerCount(Count = 3)]
	public static void SetPaperWhiteNits(float value)
	{
	}

	[CallerCount(Count = 0)]
	public static float GetPaperWhiteAsRange(float value)
	{
		return default(float);
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnBrightnessChanged")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnBrightnessChanged")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmBrightness")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CalledBy(Type = typeof(HDRManager), Member = "SetPaperWhiteFromRange")]
	public static float GetPaperWhiteFromRange(float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HDRManager), Member = "GetPaperWhiteFromRange")]
	[Calls(Type = typeof(HDRManager), Member = "SetPaperWhiteNits")]
	public static void SetPaperWhiteFromRange(float value)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(HDRManager), Member = "SetPeakBrightnessFromRange")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyBrightness")]
	public static void SetPeakBrightnessNits(float value)
	{
	}

	[CallerCount(Count = 0)]
	public static float GetPeakBrightnessNitsAsRange(float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	public static float GetPeakBrightnessNitsFromRange(float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(HDRManager), Member = "SetPeakBrightnessNits")]
	public static void SetPeakBrightnessFromRange(float value)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DeserializeSettings")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DeserializeSettings")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnBrightnessTab")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeBrightnessMenuItems")]
	public static bool IsOutputtingHDR()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[CallsUnknownMethods(Count = 3)]
	public static void Render(RenderTexture source, RenderTexture destination)
	{
	}
}
