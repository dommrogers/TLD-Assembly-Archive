using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;

public class DialogueStatement : Statement
{
	private VoiceOverAnimationState _003Canim_003Ek__BackingField;

	public new VoiceOverAnimationState anim
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return default(VoiceOverAnimationState);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public DialogueStatement()
	{
	}
}
