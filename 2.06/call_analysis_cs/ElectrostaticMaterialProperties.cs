using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ElectrostaticMaterialProperties : ActivatedMaterialProperties
{
	public Texture2D m_NoiseTexture;

	public Vector4 m_NoiseTextureOffset;

	public float m_Power;

	public float m_Strength;

	public Color m_PrimaryColor;

	public Color m_SecondaryColor;

	public float m_Gain;

	public Vector2 m_Speed;

	private static readonly int s_NoiseTextureShaderID;

	private static readonly int s_NoiseTextureOffsetShaderID;

	private static readonly int s_PowerShaderID;

	private static readonly int s_StrengthShaderID;

	private static readonly int s_PrimaryColorShaderID;

	private static readonly int s_SecondaryColorShaderID;

	private static readonly int s_GainShaderID;

	private static readonly int s_SpeedShaderID;

	public override string ActivationKeyword
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(ActivatedMaterialProperties), Member = "UpdateMaterial")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public override void UpdateMaterial(Material mat, bool isActive)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public ElectrostaticMaterialProperties()
	{
	}
}
