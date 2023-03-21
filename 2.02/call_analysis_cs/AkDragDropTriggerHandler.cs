using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;

public abstract class AkDragDropTriggerHandler : AkTriggerHandler
{
	protected abstract BaseType WwiseType
	{
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		get;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkTriggerHandler), Member = "Awake")]
	protected override void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkTriggerHandler), Member = "Start")]
	protected override void Start()
	{
	}

	[CallAnalysisFailed]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(AkState), Member = ".ctor")]
	[CalledBy(Type = typeof(AkSwitch), Member = ".ctor")]
	[CalledBy(Type = typeof(AkEvent), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkTriggerHandler), Member = ".ctor")]
	protected AkDragDropTriggerHandler()
	{
	}
}
