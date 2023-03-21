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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		set
		{
		}
	}

	public override float NormalizedProgress
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LoadingZone), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(VehicleDoor), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(RadioTower), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(OpenClose), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(LoadScene), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "InitializeInteraction")]
	[Calls(Type = typeof(BaseInteraction), Member = "InitializeInteraction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "InitializeInteraction")]
	public override void InitializeInteraction()
	{
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "PerformHold")]
	[CalledBy(Type = typeof(HarvestableInteraction), Member = "PerformHold")]
	[CalledBy(Type = typeof(RockCacheInteraction), Member = "PerformHold")]
	[CalledBy(Type = typeof(OpenClose), Member = "PerformHold")]
	[CalledBy(Type = typeof(LoadScene), Member = "PerformHold")]
	public override bool PerformHold()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(HarvestableInteraction), Member = "BeginHold")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RadioTower), Member = "BeginHold")]
	[Calls(Type = typeof(Panel_HUD), Member = "StartItemProgressBar")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	protected override void BeginHold()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void UpdateHoldInteraction(float deltaTime)
	{
	}

	[CalledBy(Type = typeof(HarvestableInteraction), Member = "EndHold")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[Calls(Type = typeof(Panel_HUD), Member = "CancelItemProgressBar")]
	[CalledBy(Type = typeof(ContainerInteraction), Member = "EndHold")]
	[CalledBy(Type = typeof(LoadScene), Member = "EndHold")]
	[CallsUnknownMethods(Count = 1)]
	protected override void EndHold()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public TimedHoldInteraction()
	{
	}
}
