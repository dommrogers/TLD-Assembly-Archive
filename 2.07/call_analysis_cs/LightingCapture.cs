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
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
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

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(LightingCapture), Member = "RenderCameraToTexture")]
		[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
		[Calls(Type = typeof(Time), Member = "get_deltaTime")]
		[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
		[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
		[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetImmediate")]
		[Calls(Type = typeof(FlyMode), Member = "Warp")]
		[Calls(Type = typeof(FlyMode), Member = "Exit")]
		[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(BoxSectorManager), Member = "RestoreSectorState")]
		[Calls(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
		[Calls(Type = typeof(GameObject), Member = "get_scene")]
		[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "UnloadSceneAsync")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 13)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
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

	[CalledBy(Type = typeof(LightingCapture), Member = "SampleCameras")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(Breath), Member = "StopBreathEffectImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectOfType")]
	[Calls(Type = typeof(BoxSectorManager), Member = "ForceAllActive")]
	[Calls(Type = typeof(LightingCapture), Member = "MakeNextDirectoryID")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private void Initialize()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_capture_lighting_all")]
	[CalledBy(Type = typeof(LightingCapture), Member = "Initialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Directory), Member = "InternalEnumeratePaths")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static string MakeNextDirectoryID()
	{
		return null;
	}

	[CalledBy(Type = typeof(BatchLightingCapture), Member = "OnLevelFinishedLoading")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightingCapture), Member = "Initialize")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(_003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
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
