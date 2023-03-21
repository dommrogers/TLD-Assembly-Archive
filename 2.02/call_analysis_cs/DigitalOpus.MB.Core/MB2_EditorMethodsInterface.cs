using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public interface MB2_EditorMethodsInterface
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void Clear();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void RestoreReadFlagsAndFormats(ProgressUpdateDelegate progressInfo);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void SetReadWriteFlag(Texture2D tx, bool isReadable, bool addToList);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void AddTextureFormat(Texture2D tx, bool isNormalMap);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	void SaveAtlasToAssetDatabase(Texture2D atlas, ShaderTextureProperty texPropertyName, int atlasNum, Material resMat);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	bool IsNormalMap(Texture2D tx);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	string GetPlatformString();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void SetTextureSize(Texture2D tx, int size);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	bool IsCompressed(Texture2D tx);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void CheckBuildSettings(long estimatedAtlasSize);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	bool CheckPrefabTypes(MB_ObjsToCombineTypes prefabType, List<GameObject> gos);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	bool ValidateSkinnedMeshes(List<GameObject> mom);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	void CommitChangesToAssets();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void OnPreTextureBake();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void OnPostTextureBake();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void Destroy(Object o);
}
