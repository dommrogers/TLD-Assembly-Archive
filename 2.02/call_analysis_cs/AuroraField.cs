using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class AuroraField : MonoBehaviour
{
	public enum ControlledComponents
	{
		None,
		Electrolizer,
		Toggle
	}

	public float m_ChanceActive;

	public bool m_IsStaticField;

	public float m_Radius;

	private bool m_IsActive;

	private bool m_CanRollChance;

	private Collider[] m_Colliders;

	private static AuroraFieldDataProxy m_AuroraFieldDataProxy;

	private float m_ExtentRadius;

	private const float m_Margin = 0.5f;

	private ControlledComponents m_ControlledComponents;

	private float m_InvSqrRootOfTwo;

	public List<GameObject> m_InfluencedObjects;

	private List<AuroraElectrolizer> m_InfluencedAuroraElectrolizers;

	private List<AuroraActivatedToggle> m_InfluencedAAuroraActivatedToggles;

	[Calls(Type = typeof(AuroraManager), Member = "RegisterAuroraField")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 14)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(AuroraManager), Member = "UnRegisterAuroraField")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AuroraField), Member = "ComputeRadiusExtent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetExtentRadius()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(FlashlightItem), Member = "Awake")]
	[Calls(Type = typeof(AuroraManager), Member = "RegisterAuroraField")]
	[Calls(Type = typeof(AuroraManager), Member = "UnRegisterAuroraField")]
	[CallsDeduplicatedMethods(Count = 4)]
	public void SetDynamic(bool isDynamic)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetControlledComponents(ControlledComponents controlledComponentFlags)
	{
	}

	[CallerCount(Count = 0)]
	public bool DoesFieldControlComponents(ControlledComponents flag)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void UnsetControlledComponents(ControlledComponents flag)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsActive()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterInvestigate")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeMoveInvestigationPositionOutsideOfField")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 GetClosestPointOnFieldExtent(Vector3 position, float margin)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Collider), Member = "ClosestPointOnBounds")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeMoveWanderPosOutsideOfField")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public Vector3 GetClosestPointOnFieldBorder(Vector3 position)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraFields")]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "UpdateAuroraFields")]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnAuroraEnabled()
	{
	}

	[Calls(Type = typeof(AuroraField), Member = "ActivateElectrolizers")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateAuroraFields")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AuroraField), Member = "ActivateToggles")]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "UpdateAuroraFields")]
	public void OnAuroraDisabled()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundInsideAuroraField")]
	[CalledBy(Type = typeof(AuroraField), Member = "ActivateElectrolizers")]
	[CalledBy(Type = typeof(AuroraField), Member = "ActivateToggles")]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 4)]
	public bool Contains(Vector3 position)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetVisibleFieldNearby")]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public bool Contains(Vector3 position, float radius)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	public void Enable(bool enabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public bool IsStaticField()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(GearItem), Member = "Awake")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	public static void ResetAllAuroraFieldLayerToDefault(GameObject rootObject)
	{
	}

	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "EnableAllStaticFields")]
	[CalledBy(Type = typeof(AuroraField), Member = "Deserialize")]
	[CalledBy(Type = typeof(AuroraField), Member = "OnAuroraEnabled")]
	[CalledBy(Type = typeof(AuroraField), Member = "Enable")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_aurorafields")]
	[CalledBy(Type = typeof(Action_AuroraFielEnable), Member = "DoWork")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AuroraField), Member = "ActivateToggles")]
	[Calls(Type = typeof(AuroraField), Member = "ActivateElectrolizers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	private void SetFieldActive(bool enabled)
	{
	}

	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool ShouldActivate()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(AuroraField), Member = "OnAuroraDisabled")]
	[CalledBy(Type = typeof(AuroraField), Member = "OnFieldEnableChanged")]
	private void ActivateElectrolizers(bool enabled)
	{
	}

	[CalledBy(Type = typeof(AuroraField), Member = "OnAuroraDisabled")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(AuroraField), Member = "OnFieldEnableChanged")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	private void ActivateToggles(bool enabled)
	{
	}

	[Calls(Type = typeof(AuroraField), Member = "ActivateToggles")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AuroraField), Member = "ActivateElectrolizers")]
	[CallsUnknownMethods(Count = 4)]
	private void OnFieldEnableChanged(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(AuroraField), Member = "Start")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Bounds), Member = "get_max")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void ComputeRadiusExtent()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 15)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public AuroraField()
	{
	}
}
