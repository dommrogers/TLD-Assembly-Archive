using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class BatchLightingCapture : MonoBehaviour
{
	public enum UpdatePhase
	{
		Constant,
		Coloured,
		Night,
		Midday,
		NonTOD,
		Other
	}

	private static Queue<string> m_CaptureQueue;

	private static List<string> m_ScenePaths;

	private static bool m_BatchMode;

	private static readonly string m_LightSceneSuffix;

	private static readonly string[] m_ScenesToSkip;

	private static List<AsyncOperationHandle<SceneInstance>> m_AsyncOperations;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void InitializeBatchCapture()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(LightingCapture._003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_capture_lighting_all")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "CaptureLighting")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "GetLightScenePath")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BatchLightingCapture), Member = "GetSceneName")]
	public static void CaptureNextScene()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_capture_lighting")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
	[CallsUnknownMethods(Count = 13)]
	public static void CaptureLighting(string scenePath, bool batchMode)
	{
	}

	[Calls(Type = typeof(LightingCapture), Member = "SampleCameras")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectOfType")]
	[CallsUnknownMethods(Count = 3)]
	private static void OnLevelFinishedLoading(AsyncOperationHandle<SceneInstance> thisAsync)
	{
	}

	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	private static string GetSceneName(string scenePath)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
	[CallsUnknownMethods(Count = 1)]
	private static string GetLightScenePath(string sceneName)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BatchLightingCapture()
	{
	}
}
