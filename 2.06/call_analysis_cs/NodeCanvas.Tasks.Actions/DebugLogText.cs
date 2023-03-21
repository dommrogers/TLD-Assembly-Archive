using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class DebugLogText : ActionTask<Transform>
{
	public enum LogMode
	{
		Log,
		Warning,
		Error
	}

	public enum VerboseMode
	{
		LogAndDisplayLabel,
		LogOnly,
		DisplayLabelOnly
	}

	public BBParameter<string> log;

	public float labelYOffset;

	public float secondsToRun;

	public VerboseMode verboseMode;

	public LogMode logMode;

	public CompactStatus finishStatus;

	private Texture2D _tex;

	protected override string info
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private Texture2D tex
	{
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[CalledBy(Type = typeof(DebugLogText), Member = "OnGUI")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	protected override void OnUpdate()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(GUI), Member = "Label")]
	[Calls(Type = typeof(GUI), Member = "DrawTexture")]
	[Calls(Type = typeof(DebugLogText), Member = "get_tex")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIContent), Member = ".ctor")]
	private void OnGUI()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public DebugLogText()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
