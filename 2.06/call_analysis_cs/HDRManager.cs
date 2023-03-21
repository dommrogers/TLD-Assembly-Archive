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
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetPaperWhiteNits(float value)
	{
	}

	[CallerCount(Count = 0)]
	public static float GetPaperWhiteAsRange(float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float GetPaperWhiteFromRange(float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetPaperWhiteFromRange(float value)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyBrightness")]
	[CalledBy(Type = typeof(HDRManager), Member = "SetPeakBrightnessFromRange")]
	public static void SetPeakBrightnessNits(float value)
	{
	}

	[CallerCount(Count = 0)]
	public static float GetPeakBrightnessNitsAsRange(float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float GetPeakBrightnessNitsFromRange(float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HDRManager), Member = "SetPeakBrightnessNits")]
	public static void SetPeakBrightnessFromRange(float value)
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnBrightnessTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeBrightnessMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ValidateSettingsState")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsOutputtingHDR()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Graphics), Member = "Blit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Render(RenderTexture source, RenderTexture destination)
	{
	}
}
