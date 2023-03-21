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

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_capture_lighting_all")]
	[CalledBy(TypeFullName = "LightingCapture.<CaptureFrame>d__15", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Queue<>), Member = "Dequeue")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "GetLightScenePath")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "GetSceneName")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "CaptureLighting")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void CaptureNextScene()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_capture_lighting")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "add_Completed")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public static void CaptureLighting(string scenePath, bool batchMode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_IsDone")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectOfType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LightingCapture), Member = "SampleCameras")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private static void OnLevelFinishedLoading(AsyncOperationHandle<SceneInstance> thisAsync)
	{
	}

	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 2)]
	private static string GetSceneName(string scenePath)
	{
		return null;
	}

	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
	private static string GetLightScenePath(string sceneName)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public BatchLightingCapture()
	{
	}
}
