using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightingCapture : MonoBehaviour
{
	private sealed class _003CCaptureFrame_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LightingCapture _003C_003E4__this;

		private int _003CcurWeather_003E5__2;

		private int _003CcamCounter_003E5__3;

		private int _003CcurHour_003E5__4;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		public _003CCaptureFrame_003Ed__15(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
		[CallsUnknownMethods(Count = 35)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "UnloadSceneAsync")]
		[Calls(Type = typeof(GameObject), Member = "get_scene")]
		[Calls(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
		[Calls(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
		[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
		[Calls(Type = typeof(FlyMode), Member = "Exit")]
		[Calls(Type = typeof(FlyMode), Member = "Warp")]
		[Calls(Type = typeof(Transform), Member = "get_position")]
		[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
		[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
		[Calls(Type = typeof(Time), Member = "get_deltaTime")]
		[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
		[Calls(Type = typeof(LightingCapture), Member = "RenderCameraToTexture")]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public List<WeatherStage> m_WeatherTypes;

	public List<GameObject> m_RefCameras;

	public string m_CaptureName;

	public static string m_ThisPath;

	private List<Transform> m_CapturePoints;

	private HudDisplayMode m_CachedHudState;

	private float m_CachedTOD;

	private WeatherStage m_CachedWeather;

	private bool m_IsInitialized;

	private bool m_BatchMode;

	private float m_TimeDelay;

	private BoxSectorManager m_BoSeMan;

	[Calls(Type = typeof(LightingCapture), Member = "MakeNextDirectoryID")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(LightingCapture), Member = "SampleCameras")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Breath), Member = "StopBreathEffectImmediate")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Initialize()
	{
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(LightingCapture), Member = "Initialize")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_capture_lighting_all")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Directory), Member = "GetDirectories")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Substring")]
	public static string MakeNextDirectoryID()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "OnLevelFinishedLoading")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(LightingCapture), Member = "CaptureFrame")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[Calls(Type = typeof(uConsole), Member = "TurnOff")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(LightingCapture), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	public void SampleCameras(bool batchMode)
	{
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(LightingCapture), Member = "SampleCameras")]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator CaptureFrame()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(_003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	private void RenderCameraToTexture(int idx, int curHour, string weatherType)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	public LightingCapture()
	{
	}
}
