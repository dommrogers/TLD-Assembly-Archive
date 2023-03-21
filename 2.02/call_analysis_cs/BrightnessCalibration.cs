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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool IsShowing()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[Calls(Type = typeof(BrightnessCalibration), Member = "SetVisibility")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public static void Show(bool isShown)
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[Calls(Type = typeof(BrightnessCalibration), Member = "RefreshAmbientLightShaderValue")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	public static void ForceNight()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(BrightnessCalibration), Member = "RefreshAmbientLightShaderValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	public static void ForceDay()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static float DayScreenRatio()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BrightnessCalibration), Member = "SetVisibility")]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(BrightnessCalibration), Member = "Show")]
	[CalledBy(Type = typeof(BrightnessCalibration), Member = "Awake")]
	[CallsUnknownMethods(Count = 6)]
	private void SetVisibility(bool isShown)
	{
	}

	[CalledBy(Type = typeof(BrightnessCalibration), Member = "ForceDay")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BrightnessCalibration), Member = "ForceNight")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	private static void RefreshAmbientLightShaderValue()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BrightnessCalibration()
	{
	}
}
