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
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private Texture2D tex
	{
		[CallsUnknownMethods(Count = 9)]
		[CalledBy(Type = typeof(DebugLogText), Member = "OnGUI")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 10)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(GUIContent), Member = ".ctor")]
	[Calls(Type = typeof(GUI), Member = "set_color")]
	[Calls(Type = typeof(GUI), Member = "Label")]
	[Calls(Type = typeof(GUI), Member = "set_color")]
	[Calls(Type = typeof(GUI), Member = "DrawTexture")]
	[Calls(Type = typeof(DebugLogText), Member = "get_tex")]
	[Calls(Type = typeof(GUI), Member = "set_color")]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GUISkin), Member = "GetStyle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUISkin), Member = "get_error")]
	private void OnGUI()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public DebugLogText()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
