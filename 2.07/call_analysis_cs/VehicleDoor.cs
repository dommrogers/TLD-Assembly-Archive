using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using UnityEngine;

public class VehicleDoor : TimedHoldInteraction
{
	public string m_OpenAudio;

	public string m_CloseAudio;

	public GameObject m_CameraDummy;

	public GameObject m_ExitPoint;

	public BoxCollider m_ItemDropBox;

	public Bed m_Bed;

	public bool m_BlockSavingWhileInside;

	public override bool CanInteract
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseHoldInteraction), Member = "get_CanInteract")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(TimedHoldInteraction), Member = "InitializeInteraction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public override void InitializeInteraction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerInVehicle), Member = "EnterVehicle")]
	[Calls(Type = typeof(PlayerInVehicle), Member = "ExitVehicle")]
	[Calls(Type = typeof(BaseInteraction), Member = "TriggerEvent")]
	[CallsUnknownMethods(Count = 4)]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public VehicleDoor()
	{
	}
}
