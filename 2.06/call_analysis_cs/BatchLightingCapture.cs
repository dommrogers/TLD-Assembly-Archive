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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(LightingCapture._003CCaptureFrame_003Ed__15), Member = "MoveNext")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "CaptureLighting")]
	[Calls(Type = typeof(BatchLightingCapture), Member = "GetSceneName")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_capture_lighting_all")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BatchLightingCapture), Member = "GetLightScenePath")]
	public static void CaptureNextScene()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_capture_lighting")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureNextScene")]
	[CallsUnknownMethods(Count = 19)]
	public static void CaptureLighting(string scenePath, bool batchMode)
	{
	}

	[Calls(Type = typeof(LightingCapture), Member = "SampleCameras")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectOfType")]
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
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
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
