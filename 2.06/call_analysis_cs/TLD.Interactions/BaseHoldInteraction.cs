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
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 55)]
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
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		protected set
		{
		}
	}

	public abstract float NormalizedProgress
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	public virtual bool CanCancel
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public override bool CanInteract
	{
		[CalledBy(Type = typeof(LoadScene), Member = "get_CanInteract")]
		[CalledBy(Type = typeof(LoadingZone), Member = "get_CanInteract")]
		[CalledBy(Type = typeof(VehicleDoor), Member = "get_CanInteract")]
		[CalledBy(Type = typeof(OpenClose), Member = "get_CanInteract")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(ContainerInteraction), Member = "get_CanInteract")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(HarvestableInteraction), Member = "get_CanInteract")]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract bool PerformHold();

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	protected virtual void BeginHold()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	public override void UpdateInteraction(float deltaTime)
	{
	}

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	protected abstract void UpdateHoldInteraction(float deltaTime);

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
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
