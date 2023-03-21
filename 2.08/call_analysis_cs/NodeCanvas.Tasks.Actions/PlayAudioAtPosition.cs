using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class PlayAudioAtPosition : ActionTask<Transform>
{
	public BBParameter<AudioClip> audioClip;

	public float volume;

	public bool waitActionFinish;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AudioSource), Member = "PlayClipAtPoint")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public PlayAudioAtPosition()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
