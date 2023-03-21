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

		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(FPSLogger), Member = "OnFPSChanged")]
		[CallsUnknownMethods(Count = 2)]
		public void AddSample(FPSCounterEvent eventData)
		{
		}

		[CallsUnknownMethods(Count = 45)]
		[CalledBy(Type = typeof(FPSLogger), Member = "WriteToFile")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(Utils), Member = "GetFormattedBytes")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Utils), Member = "GetFormattedBytes")]
		[Calls(Type = typeof(Utils), Member = "GetFormattedBytes")]
		[Calls(Type = typeof(Utils), Member = "GetFormattedBytes")]
		public string FormatForWrite()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
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
	public static bool IsRecording()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FPSLogger), Member = "StopRecording")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_record_fps")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[CallsUnknownMethods(Count = 1)]
	public static void StartRecording(string newExtension)
	{
	}

	[CalledBy(Type = typeof(FPSLogger), Member = "StartRecording")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_record_fps")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	public static void StopRecording()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(LogData), Member = "FormatForWrite")]
	[Calls(Type = typeof(string), Member = "JoinCore")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[CalledBy(Type = typeof(FPSLogger), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 25)]
	private static void WriteToFile(string outputPath)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(FPSLogger), Member = "WriteToFile")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(LogData), Member = "AddSample")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(SceneManager), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	private void OnFPSChanged(FPSCounterEvent eventData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 2)]
	private string GetCurrentLogKey()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FPSLogger()
	{
	}
}
