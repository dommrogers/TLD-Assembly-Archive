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

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void InitializeBatchCapture()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "GetLightScenePath")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "GetSceneName")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "CaptureLighting")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_capture_lighting_all")]
	[CalledBy(Type = typeof(LightingCapture._003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 4)]
	public static void CaptureNextScene()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_capture_lighting")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void CaptureLighting(string scenePath, bool batchMode)
	{
	}

	[Calls(Type = typeof(LightingCapture), Member = "SampleCameras")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectOfType")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private static void OnLevelFinishedLoading(AsyncOperationHandle<SceneInstance> thisAsync)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
	[CallsUnknownMethods(Count = 2)]
	private static string GetSceneName(string scenePath)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Replace")]
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
