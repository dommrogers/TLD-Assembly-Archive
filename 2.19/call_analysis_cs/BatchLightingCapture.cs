using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

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

	private static Queue<string> m_SceneSetQueue;

	private static readonly string m_LightSceneSuffix;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void CaptureLighting(string sceneName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static string GetLightSceneName(string scenePath)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BatchLightingCapture()
	{
	}
}
