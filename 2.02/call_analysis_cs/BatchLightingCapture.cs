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

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_capture_lighting_all")]
	[CalledBy(TypeFullName = "LightingCapture.<CaptureFrame>d__15", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Queue<>), Member = "Dequeue")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "GetLightScenePath")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "GetSceneName")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "CaptureLighting")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static void CaptureNextScene()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_capture_lighting")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "GetSceneName")]
	[Calls(Type = typeof(GameManager), Member = "AddAsyncLoadRequest")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "GetLightScenePath")]
	[Calls(Type = typeof(GameManager), Member = "LoadModeConditionalScenes")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public static void CaptureLighting(string scenePath, bool batchMode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "GetSceneName")]
	[Calls(Type = typeof(GameManager), Member = "AddAsyncLoadRequest")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "GetLightScenePath")]
	[Calls(Type = typeof(GameManager), Member = "LoadModeConditionalScenes")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(AsyncOperation), Member = "add_completed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public static void CaptureLightingStory(string scenePath, bool batchMode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectOfType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LightingCapture), Member = "SampleCameras")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private static void OnLevelFinishedLoading(AsyncOperation thisAsync)
	{
	}

	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureLighting")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureLightingStory")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private static string GetSceneName(string scenePath)
	{
		return null;
	}

	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureLighting")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureLightingStory")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
