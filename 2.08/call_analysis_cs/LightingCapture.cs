using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CCaptureFrame_003Ed__15(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
		[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[Calls(Type = typeof(GameObject), Member = "get_scene")]
		[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "UnloadSceneAsync")]
		[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
		[CallsUnknownMethods(Count = 13)]
		[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
		[Calls(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
		[Calls(Type = typeof(FlyMode), Member = "Warp")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 8)]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(LightingCapture), Member = "RenderCameraToTexture")]
		[Calls(Type = typeof(FlyMode), Member = "Exit")]
		[Calls(Type = typeof(Time), Member = "get_deltaTime")]
		[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
		[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
		[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
		[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 4)]
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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(LightingCapture), Member = "SampleCameras")]
	[Calls(Type = typeof(LightingCapture), Member = "MakeNextDirectoryID")]
	[Calls(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Breath), Member = "StopBreathEffectImmediate")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Initialize()
	{
	}

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(LightingCapture), Member = "Initialize")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_capture_lighting_all")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(Directory), Member = "InternalEnumeratePaths")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Substring")]
	public static string MakeNextDirectoryID()
	{
		return null;
	}

	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "OnLevelFinishedLoading")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	[Calls(Type = typeof(LightingCapture), Member = "Initialize")]
	public void SampleCameras(bool batchMode)
	{
	}

	[IteratorStateMachine(typeof(_003CCaptureFrame_003Ed__15))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator CaptureFrame()
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(_003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void RenderCameraToTexture(int idx, int curHour, string weatherType)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public LightingCapture()
	{
	}
}
