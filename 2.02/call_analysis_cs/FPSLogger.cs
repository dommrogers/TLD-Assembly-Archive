using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FPSLogger : MonoBehaviour
{
	private class LogData
	{
		private float m_WorstFPS;

		private double m_CumulativeFPS;

		private long m_SampleCount;

		private long m_ValidCPUTimingCount;

		private long m_ValidGPUTimingCount;

		private long m_PeakAllocatedMemory;

		private long m_PeakReservedMemory;

		private long m_PeakGraphicsMemory;

		private ulong m_PeakTextureMemory;

		private double m_CumulativeCPUTimeMs;

		private double m_CumulativeGPUTimeMs;

		private float m_WorstCPUTimeMs;

		private float m_WorstGPUTime;

		[CalledBy(Type = typeof(FPSLogger), Member = "OnFPSChanged")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Utils), Member = "IsZero")]
		[CallsDeduplicatedMethods(Count = 1)]
		public void AddSample(FPSCounterEvent eventData)
		{
		}

		[CalledBy(Type = typeof(FPSLogger), Member = "WriteToFile")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Utils), Member = "GetFormattedBytes")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 45)]
		public string FormatForWrite()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		public LogData()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<KeyValuePair<string, LogData>, string> _003C_003E9__11_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal string _003CWriteToFile_003Eb__11_0(KeyValuePair<string, LogData> x)
		{
			return null;
		}
	}

	private const string DEBUG_LOG_FORMAT = "FPSLogger: {0}";

	private const string OUTPUT_FILENAME_FORMAT = "fps_{0:d-M-yyyy_HH-mm-ss}.csv";

	private const string OUTPUT_CONTENT_HEADER = "Scene,Weather,Average,Worst,Peak Allocated,Peak Reserved,Peak Textures,Peak Graphics,Cpu avg,Cpu max,Gpu avg,Gpu max,Resolution";

	private static bool s_IsRecording;

	private static Dictionary<string, LogData> s_Logs;

	private static string s_OutputFile;

	private FPSCounter m_Counter;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsRecording()
	{
		return false;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_record_fps")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FPSLogger), Member = "StopRecording")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void StartRecording(string newExtension)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_record_fps")]
	[CalledBy(Type = typeof(FPSLogger), Member = "StartRecording")]
	[CallerCount(Count = 2)]
	public static void StopRecording()
	{
	}

	[CalledBy(Type = typeof(FPSLogger), Member = "OnDisable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(LogData), Member = "FormatForWrite")]
	[Calls(Type = typeof(string), Member = "Join")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StreamWriter), Member = "get_UTF8NoBOM")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 45)]
	private static void WriteToFile(string outputPath)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(FPSLogger), Member = "WriteToFile")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(LogData), Member = "AddSample")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	private void OnFPSChanged(FPSCounterEvent eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private string GetCurrentLogKey()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FPSLogger()
	{
	}
}
