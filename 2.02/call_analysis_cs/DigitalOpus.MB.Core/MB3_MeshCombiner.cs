using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

[Serializable]
public abstract class MB3_MeshCombiner
{
	public delegate void GenerateUV2Delegate(Mesh m, float hardAngle, float packMargin);

	public class MBBlendShapeKey
	{
		public int gameObjecID;

		public int blendShapeIndexInSrc;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public MBBlendShapeKey(int srcSkinnedMeshRenderGameObjectID, int blendShapeIndexInSource)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			return 0;
		}
	}

	public class MBBlendShapeValue
	{
		public GameObject combinedMeshGameObject;

		public int blendShapeIndex;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public MBBlendShapeValue()
		{
		}
	}

	protected MB2_LogLevel _LOG_LEVEL;

	protected MB2_ValidationLevel _validationLevel;

	protected string _name;

	protected MB2_TextureBakeResults _textureBakeResults;

	protected GameObject _resultSceneObject;

	protected Renderer _targetRenderer;

	protected MB_RenderType _renderType;

	protected MB2_OutputOptions _outputOption;

	protected MB2_LightmapOptions _lightmapOption;

	protected bool _doNorm;

	protected bool _doTan;

	protected bool _doCol;

	protected bool _doUV;

	protected bool _doUV3;

	protected bool _doUV4;

	protected bool _doBlendShapes;

	protected bool _recenterVertsToBoundsCenter;

	public bool _optimizeAfterBake;

	public float uv2UnwrappingParamsHardAngle;

	public float uv2UnwrappingParamsPackMargin;

	protected bool _usingTemporaryTextureBakeResult;

	public static bool EVAL_VERSION
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public virtual MB2_LogLevel LOG_LEVEL
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(MB2_LogLevel);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public virtual MB2_ValidationLevel validationLevel
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		get
		{
			return default(MB2_ValidationLevel);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
		set
		{
		}
	}

	public virtual MB2_TextureBakeResults textureBakeResults
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		set
		{
		}
	}

	public virtual GameObject resultSceneObject
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 24)]
		set
		{
		}
	}

	public virtual Renderer targetRenderer
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 17)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public virtual MB_RenderType renderType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(MB_RenderType);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public virtual MB2_OutputOptions outputOption
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(MB2_OutputOptions);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public virtual MB2_LightmapOptions lightmapOption
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(MB2_LightmapOptions);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public virtual bool doNorm
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public virtual bool doTan
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public virtual bool doCol
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public virtual bool doUV
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public virtual bool doUV1
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		set
		{
		}
	}

	public virtual bool doUV3
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public virtual bool doUV4
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public virtual bool doBlendShapes
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public virtual bool recenterVertsToBoundsCenter
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool optimizeAfterBake
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	public virtual bool doUV2()
	{
		return false;
	}

	public abstract int GetLightmapIndex();

	public abstract void ClearBuffers();

	public abstract void ClearMesh();

	public abstract void DestroyMesh();

	public abstract void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods);

	public abstract List<GameObject> GetObjectsInCombined();

	public abstract int GetNumObjectsInCombined();

	public abstract int GetNumVerticesFor(GameObject go);

	public abstract int GetNumVerticesFor(int instanceID);

	public abstract Dictionary<MBBlendShapeKey, MBBlendShapeValue> BuildSourceBlendShapeToCombinedIndexMap();

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void Apply()
	{
	}

	public abstract void Apply(GenerateUV2Delegate uv2GenerationMethod);

	public abstract void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, bool bones = false, bool blendShapeFlag = false, GenerateUV2Delegate uv2GenerationMethod = null);

	public abstract bool UpdateGameObjects(GameObject[] gos, bool recalcBounds = true, bool updateVertices = true, bool updateNormals = true, bool updateTangents = true, bool updateUV = false, bool updateUV2 = false, bool updateUV3 = false, bool updateUV4 = false, bool updateColors = false, bool updateSkinningInfo = false);

	public abstract bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true);

	public abstract bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource);

	public abstract bool CombinedMeshContains(GameObject go);

	public abstract void UpdateSkinnedMeshApproximateBounds();

	public abstract void UpdateSkinnedMeshApproximateBoundsFromBones();

	public abstract void CheckIntegrity();

	public abstract void UpdateSkinnedMeshApproximateBoundsFromBounds();

	[CalledBy(Type = typeof(MB2_UpdateSkinnedMeshBoundsFromBones), Member = "Update")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "UpdateSkinnedMeshApproximateBoundsFromBones")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 16)]
	public static void UpdateSkinnedMeshApproximateBoundsFromBonesStatic(Transform[] bs, SkinnedMeshRenderer smr)
	{
	}

	[CalledBy(Type = typeof(MB2_UpdateSkinnedMeshBoundsFromBounds), Member = "Update")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "UpdateSkinnedMeshApproximateBoundsFromBounds")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MB_Utility), Member = "GetBounds")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void UpdateSkinnedMeshApproximateBoundsFromBoundsStatic(List<GameObject> objectsInCombined, SkinnedMeshRenderer smr)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB2_TextureBakeResults), Member = "CreateForMaterialsOnRenderer")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	protected virtual bool _CreateTemporaryTextrueBakeResult(GameObject[] gos, List<Material> matsOnTargetRenderer)
	{
		return false;
	}

	public abstract List<Material> GetMaterialsOnTargetRenderer();

	[CallerCount(Count = 0)]
	protected MB3_MeshCombiner()
	{
	}
}
