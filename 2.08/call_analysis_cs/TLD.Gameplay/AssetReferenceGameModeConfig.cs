using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.AddressableAssets;

namespace TLD.Gameplay;

[Serializable]
public class AssetReferenceGameModeConfig : AssetReferenceT<GameModeConfig>
{
	[Calls(Type = typeof(AssetReference), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public AssetReferenceGameModeConfig(string guid)
	{
		((AssetReferenceT<TObject>)(object)this)._002Ector((string)null);
	}
}
