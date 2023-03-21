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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private Texture2D tex
	{
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[CalledBy(Type = typeof(DebugLogText), Member = "OnGUI")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnUpdate()
	{
	}

	[Calls(Type = typeof(GUI), Member = "Label")]
	[Calls(Type = typeof(GUI), Member = "DrawTexture")]
	[Calls(Type = typeof(DebugLogText), Member = "get_tex")]
	[Calls(Type = typeof(GUIContent), Member = ".ctor")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUIStyle), Member = ".ctor")]
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
