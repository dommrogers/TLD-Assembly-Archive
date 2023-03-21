using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public sealed class vp_Layer
{
	public static readonly vp_Layer instance;

	public const int TriggerReverb = 31;

	public const int TriggerCollideCapsule = 30;

	public const int InspectGear = 29;

	public const int GroundNoNavmesh = 28;

	public const int NPCBones = 27;

	public const int CharacterControllerCollideOnly = 26;

	public const int TriggerIgnoreRaycast = 25;

	public const int InteractivePropNoCollidePlayer = 24;

	public const int Weapon = 23;

	public const int SoundEmitter = 22;

	public const int Trigger = 21;

	public const int Corpse = 20;

	public const int InteractiveProp = 19;

	public const int Container = 18;

	public const int Gear = 17;

	public const int NPC = 16;

	public const int NoCollidePlayer = 15;

	public const int Player = 14;

	public const int ParticleKiller = 13;

	public const int InteractivePropNoCollideGear = 12;

	public const int Buildings = 11;

	public const int NPC_Trigger = 10;

	public const int TerrainObject = 9;

	public const int Ground = 8;

	public const int UI = 5;

	public const int Water = 4;

	public const int IgnoreRaycast = 2;

	public const int TransparentFX = 1;

	public const int Default = 0;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	static vp_Layer()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private vp_Layer()
	{
	}

	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "PlayDetonateInHand")]
	[CalledBy(Type = typeof(SafeCracking), Member = "Start")]
	[CalledBy(Type = typeof(GearItem), Member = "Awake")]
	[CalledBy(Type = typeof(LoadScene), Member = "Start")]
	[CalledBy(Type = typeof(LoadingZone), Member = "Start")]
	[CalledBy(Type = typeof(HeightFogVolume), Member = "Start")]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "Start")]
	[CalledBy(Type = typeof(RenderObjectInstanceVolume), Member = "Awake")]
	[CalledBy(Type = typeof(BoxSector), Member = "Start")]
	[CalledBy(Type = typeof(DoorTrigger), Member = "Start")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "Start")]
	[CalledBy(Type = typeof(IceCrackingWarningTrigger), Member = "Start")]
	[CalledBy(Type = typeof(SunShadowOverrideVolume), Member = "Start")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(vp_Layer), Member = "Set")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Start")]
	[CalledBy(Type = typeof(RenderObjectInstanceTriggerVolume), Member = "Awake")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeaponLayer")]
	public static void Set(GameObject obj, int layer, bool recursive = false)
	{
	}
}
