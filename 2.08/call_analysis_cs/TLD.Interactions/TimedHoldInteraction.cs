using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Interactions;

public class TimedHoldInteraction : BaseHoldInteraction
{
	public float m_DefaultHoldTime;

	private float _003CHoldTime_003Ek__BackingField;

	private float m_Timer;

	public float HoldTime
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public override float NormalizedProgress
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	[CalledBy(Type = typeof(ContainerInteraction), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(OpenClose), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(RadioTower), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(VehicleDoor), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(LoadingZone), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(LoadScene), Member = "InitializeInteraction")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BaseInteraction), Member = "InitializeInteraction")]
	[CallsUnknownMethods(Count = 1)]
	public override void InitializeInteraction()
	{
	}

	[CalledBy(Type = typeof(ContainerInteraction), Member = "PerformHold")]
	[CalledBy(Type = typeof(HarvestableInteraction), Member = "PerformHold")]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "PerformHold")]
	[CalledBy(Type = typeof(OpenClose), Member = "PerformHold")]
	[CalledBy(Type = typeof(LoadScene), Member = "PerformHold")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override bool PerformHold()
	{
		return false;
	}

	[CalledBy(Type = typeof(HarvestableInteraction), Member = "BeginHold")]
	[CalledBy(Type = typeof(RadioTower), Member = "BeginHold")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[CallsUnknownMethods(Count = 1)]
	protected override void BeginHold()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void UpdateHoldInteraction(float deltaTime)
	{
	}

	[CalledBy(Type = typeof(ContainerInteraction), Member = "EndHold")]
	[CalledBy(Type = typeof(HarvestableInteraction), Member = "EndHold")]
	[CalledBy(Type = typeof(LoadScene), Member = "EndHold")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[CallsUnknownMethods(Count = 1)]
	protected override void EndHold()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public TimedHoldInteraction()
	{
	}
}
