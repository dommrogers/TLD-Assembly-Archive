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

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BrightnessCalibration), Member = "SetVisibility")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CallsUnknownMethods(Count = 3)]
	public static void Show(bool isShown)
	{
	}

	[Calls(Type = typeof(BrightnessCalibration), Member = "RefreshAmbientLightShaderValue")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	public static void ForceNight()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(BrightnessCalibration), Member = "RefreshAmbientLightShaderValue")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallsUnknownMethods(Count = 2)]
	public static void ForceDay()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BrightnessCalibration), Member = "Awake")]
	[CalledBy(Type = typeof(BrightnessCalibration), Member = "Awake")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(BrightnessCalibration), Member = "Show")]
	[CallerCount(Count = 3)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BrightnessCalibration()
	{
	}
}
