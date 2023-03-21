using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BrightnessCalibration : MonoBehaviour
{
	private GameObject[] m_EnableOnShow;

	private GameObject[] m_DisableOnShow;

	private const float DAY_TIME = 0.7f;

	private const float NIGHT_TIME = 0f;

	private const float CAMERA_NUDGE = 0.2f;

	private static bool s_IsShowing;

	private static List<BrightnessCalibration> s_Instances;

	[CallerCount(Count = 0)]
	public static bool IsShowing()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BrightnessCalibration), Member = "SetVisibility")]
	public static void Show(bool isShown)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(BrightnessCalibration), Member = "RefreshAmbientLightShaderValue")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallsUnknownMethods(Count = 2)]
	public static void ForceNight()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[Calls(Type = typeof(BrightnessCalibration), Member = "RefreshAmbientLightShaderValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	public static void ForceDay()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static float DayScreenRatio()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BrightnessCalibration), Member = "SetVisibility")]
	[Calls(Type = typeof(BrightnessCalibration), Member = "SetVisibility")]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(BrightnessCalibration), Member = "Awake")]
	[CalledBy(Type = typeof(BrightnessCalibration), Member = "Awake")]
	[CalledBy(Type = typeof(BrightnessCalibration), Member = "Show")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void SetVisibility(bool isShown)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(BrightnessCalibration), Member = "ForceNight")]
	[CalledBy(Type = typeof(BrightnessCalibration), Member = "ForceDay")]
	[CallsUnknownMethods(Count = 3)]
	private static void RefreshAmbientLightShaderValue()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BrightnessCalibration()
	{
	}
}
