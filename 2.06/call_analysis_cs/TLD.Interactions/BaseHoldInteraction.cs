using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Interactions;

public abstract class BaseHoldInteraction : BaseInteraction, IHoldInteraction, IInteraction
{
	public LocalizedString m_DefaultHoldText;

	private string _003CHoldText_003Ek__BackingField;

	private bool _003CIsActive_003Ek__BackingField;

	public string HoldText
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 65)]
		set
		{
		}
	}

	public bool IsActive
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		protected set
		{
		}
	}

	public abstract float NormalizedProgress { get; }

	public virtual bool CanCancel
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public override bool CanInteract
	{
		[CalledBy(Type = typeof(ContainerInteraction), Member = "get_CanInteract")]
		[CalledBy(Type = typeof(HarvestableInteraction), Member = "get_CanInteract")]
		[CalledBy(Type = typeof(OpenClose), Member = "get_CanInteract")]
		[CalledBy(Type = typeof(VehicleDoor), Member = "get_CanInteract")]
		[CalledBy(Type = typeof(LoadingZone), Member = "get_CanInteract")]
		[CalledBy(Type = typeof(LoadScene), Member = "get_CanInteract")]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnDisable()
	{
	}

	public abstract bool PerformHold();

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	protected virtual void BeginHold()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	protected abstract void UpdateHoldInteraction(float deltaTime);

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual void CancelHold()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	protected virtual void EndHold()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	protected BaseHoldInteraction()
	{
	}
}
