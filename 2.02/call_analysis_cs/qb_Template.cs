using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class qb_Template
{
	public bool live;

	public string brushName;

	public string lastKnownAs;

	public float brushRadius;

	public float brushRadiusMin;

	public float brushRadiusMax;

	public float brushSpacing;

	public float brushSpacingMin;

	public float brushSpacingMax;

	public float scatterRadius;

	public bool alignToNormal;

	public bool flipNormalAlign;

	public bool alignToStroke;

	public bool flipStrokeAlign;

	public Vector3 rotationRangeMin;

	public Vector3 rotationRangeMax;

	public Vector3 positionOffset;

	public float scaleMin;

	public float scaleMax;

	public Vector3 scaleRandMin;

	public Vector3 scaleRandMax;

	public float scaleRandMinUniform;

	public float scaleRandMaxUniform;

	public bool scaleUniform;

	public bool paintToSelection;

	public bool paintToLayer;

	public int layerIndex;

	public bool groupObjects;

	public string groupName;

	public bool eraseByGroup;

	public bool eraseBySelected;

	public bool dirty;

	public qb_PrefabObject[] prefabGroup;

	public bool active;

	public int selectedPrefabIndex;

	public qb_Stroke curStroke;

	public qb_Group curGroup;

	public string layerText;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	public qb_Template()
	{
	}
}
