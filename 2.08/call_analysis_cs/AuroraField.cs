using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.ModularElectrolizer;
using TLD.Serialization;
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

	private List<AuroraModularElectrolizer> m_InfluencedAuroraElectrolizers;

	private List<AuroraActivatedToggle> m_InfluencedAAuroraActivatedToggles;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AuroraManager), Member = "RegisterAuroraField")]
	[CallsUnknownMethods(Count = 17)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "UnRegisterAuroraField")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(FlashlightItem), Member = "Awake")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AuroraManager), Member = "RegisterAuroraField")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(AuroraManager), Member = "UnRegisterAuroraField")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void SetDynamic(bool isDynamic)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeMoveInvestigationPositionOutsideOfField")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterInvestigate")]
	public Vector3 GetClosestPointOnFieldExtent(Vector3 position, float margin)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeMoveWanderPosOutsideOfField")]
	[CallsUnknownMethods(Count = 8)]
	public Vector3 GetClosestPointOnFieldBorder(Vector3 position)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "UpdateAuroraFields")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateActivation")]
	public void OnAuroraEnabled()
	{
	}

	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "UpdateAuroraFields")]
	[Calls(Type = typeof(AuroraField), Member = "ActivateToggles")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateActivation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AuroraField), Member = "ActivateElectrolizers")]
	public void OnAuroraDisabled()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CalledBy(Type = typeof(AuroraField), Member = "ActivateToggles")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundInsideAuroraField")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(AuroraField), Member = "ActivateElectrolizers")]
	public bool Contains(Vector3 position)
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundDueToSafeHaven")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetVisibleFieldNearby")]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "GetFieldContaining")]
	[CallsUnknownMethods(Count = 5)]
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
	[CallerCount(Count = 0)]
	public bool IsStaticField()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[CalledBy(Type = typeof(GearItem), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	public static void ResetAllAuroraFieldLayerToDefault(GameObject rootObject)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_AuroraFielEnable), Member = "DoWork")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_aurorafields")]
	[CalledBy(Type = typeof(FlashlightItem), Member = "EnableLights")]
	[CalledBy(Type = typeof(AuroraField), Member = "Enable")]
	[CalledBy(Type = typeof(AuroraFieldsSceneManager), Member = "EnableAllStaticFields")]
	[CalledBy(Type = typeof(AuroraField), Member = "Deserialize")]
	[Calls(Type = typeof(AuroraField), Member = "ActivateToggles")]
	[Calls(Type = typeof(AuroraField), Member = "ActivateElectrolizers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(AuroraField), Member = "OnAuroraEnabled")]
	private void SetFieldActive(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	private bool ShouldActivate()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(AuroraField), Member = "OnFieldEnableChanged")]
	[CalledBy(Type = typeof(AuroraField), Member = "OnAuroraDisabled")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	private void ActivateElectrolizers(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(AuroraField), Member = "OnFieldEnableChanged")]
	[CalledBy(Type = typeof(AuroraField), Member = "OnAuroraDisabled")]
	[CalledBy(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[Calls(Type = typeof(AuroraField), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private void ActivateToggles(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AuroraField), Member = "ActivateElectrolizers")]
	[Calls(Type = typeof(AuroraField), Member = "ActivateToggles")]
	private void OnFieldEnableChanged(bool enabled)
	{
	}

	[CalledBy(Type = typeof(AuroraField), Member = "Start")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void ComputeRadiusExtent()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public AuroraField()
	{
	}
}
