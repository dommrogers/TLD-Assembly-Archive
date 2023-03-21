using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_ShowHUDMessage : ActionTask
{
	public enum MessageShowType
	{
		Normal,
		IgnoreOverlay,
		FadeIn
	}

	public bool HighPriority;

	public float FadeInSeconds;

	public MessageShowType MessageType;

	public string StringKey;

	protected override string info
	{
		[CallsUnknownMethods(Count = 22)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessageToQueue")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HUDMessage), Member = "CreateMessageInfo")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_ShowHUDMessage()
	{
	}
}
