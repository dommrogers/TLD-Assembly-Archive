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
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsShowing()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(BrightnessCalibration), Member = "SetVisibility")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void Show(bool isShown)
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(BrightnessCalibration), Member = "RefreshAmbientLightShaderValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void ForceNight()
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(BrightnessCalibration), Member = "RefreshAmbientLightShaderValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void ForceDay()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static float DayScreenRatio()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(BrightnessCalibration), Member = "SetVisibility")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(BrightnessCalibration), Member = "Show")]
	[CalledBy(Type = typeof(BrightnessCalibration), Member = "Awake")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void SetVisibility(bool isShown)
	{
	}

	[CalledBy(Type = typeof(BrightnessCalibration), Member = "ForceNight")]
	[CalledBy(Type = typeof(BrightnessCalibration), Member = "ForceDay")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
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
