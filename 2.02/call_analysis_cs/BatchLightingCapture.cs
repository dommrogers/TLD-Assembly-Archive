using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
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

	private static List<AsyncOperation> m_AsyncOperations;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void InitializeBatchCapture()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(LightingCapture._003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_capture_lighting_all")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "CaptureLighting")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "GetLightScenePath")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BatchLightingCapture), Member = "GetSceneName")]
	public static void CaptureNextScene()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "LoadModeConditionalScenes")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_capture_lighting")]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed")]
	[Calls(Type = typeof(GameManager), Member = "AddAsyncLoadRequest")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GameManager), Member = "AddAsyncLoadRequest")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "GetSceneName")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BatchLightingCapture), Member = "GetLightScenePath")]
	public static void CaptureLighting(string scenePath, bool batchMode)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed")]
	[Calls(Type = typeof(GameManager), Member = "LoadModeConditionalScenes")]
	[Calls(Type = typeof(GameManager), Member = "AddAsyncLoadRequest")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "GetLightScenePath")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "GetSceneName")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "AddAsyncLoadRequest")]
	public static void CaptureLightingStory(string scenePath, bool batchMode)
	{
	}

	[Calls(Type = typeof(LightingCapture), Member = "SampleCameras")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectOfType")]
	private static void OnLevelFinishedLoading(AsyncOperation thisAsync)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureLighting")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureLightingStory")]
	[CallsUnknownMethods(Count = 8)]
	private static string GetSceneName(string scenePath)
	{
		return null;
	}

	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureLighting")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureLightingStory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 3)]
	private static string GetLightScenePath(string sceneName)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BatchLightingCapture()
	{
	}
}
