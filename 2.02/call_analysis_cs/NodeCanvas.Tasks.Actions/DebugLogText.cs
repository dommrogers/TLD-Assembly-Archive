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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private Texture2D tex
	{
		[CalledBy(Type = typeof(DebugLogText), Member = "OnGUI")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 9)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GUISkin), Member = "GetStyle")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GUISkin), Member = "get_error")]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(GUIContent), Member = ".ctor")]
	[Calls(Type = typeof(GUI), Member = "set_color")]
	[Calls(Type = typeof(DebugLogText), Member = "get_tex")]
	[Calls(Type = typeof(GUI), Member = "DrawTexture")]
	[Calls(Type = typeof(GUI), Member = "Label")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 26)]
	private void OnGUI()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	public DebugLogText()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
