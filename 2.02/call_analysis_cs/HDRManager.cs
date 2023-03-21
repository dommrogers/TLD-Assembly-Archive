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

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static void Initialize()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnBrightnessChanged")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyBrightness")]
	[CalledBy(Type = typeof(HDRManager), Member = "SetPaperWhiteFromRange")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetPaperWhiteNits(float value)
	{
	}

	[CallerCount(Count = 0)]
	public static float GetPaperWhiteAsRange(float value)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnBrightnessChanged")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmBrightness")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CalledBy(Type = typeof(HDRManager), Member = "SetPaperWhiteFromRange")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static float GetPaperWhiteFromRange(float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HDRManager), Member = "GetPaperWhiteFromRange")]
	[Calls(Type = typeof(HDRManager), Member = "SetPaperWhiteNits")]
	public static void SetPaperWhiteFromRange(float value)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyBrightness")]
	[CalledBy(Type = typeof(HDRManager), Member = "SetPeakBrightnessFromRange")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetPeakBrightnessNits(float value)
	{
	}

	[CallerCount(Count = 0)]
	public static float GetPeakBrightnessNitsAsRange(float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static float GetPeakBrightnessNitsFromRange(float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(HDRManager), Member = "SetPeakBrightnessNits")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetPeakBrightnessFromRange(float value)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnBrightnessTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeBrightnessMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DeserializeSettings")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsOutputtingHDR()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static void Render(RenderTexture source, RenderTexture destination)
	{
	}
}
