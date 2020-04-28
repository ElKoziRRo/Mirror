using System;
using NUnit.Framework;
using UnityEngine;

namespace Mirror.Tests
{
    public class ClientSceneTests
    {
        [Test]
        [Ignore("Not Implemented")]
        public void PrepareToSpawnSceneObjects()
        {
            // Finds All inactive Network Identities In Scene With SceneIds
            // ClearsExistingDictionary
            ClientScene.PrepareToSpawnSceneObjects();
        }

        [Test]
        [Ignore("Not Implemented")]
        public void GetPrefab()
        {
            // Returns False For Empty Guid
            // Returns False If Prefab Is Not Found
            // Returns False If Prefab Is Null
            // Returns True When Prefab Is Found
            // Has Out Prefab With Correct Guid
            bool result = ClientScene.GetPrefab(new System.Guid(), out GameObject prefab);
        }

        [Test]
        [Ignore("Not Implemented")]
        public void RegisterPrefab()
        {
            // overloads
            // RegisterPrefab(GameObject prefab)
            // RegisterPrefab(GameObject prefab, SpawnDelegate spawnHandler, UnSpawnDelegate unspawnHandler)
            // RegisterPrefab(GameObject prefab, SpawnHandlerDelegate spawnHandler, UnSpawnDelegate unspawnHandler)
            // RegisterPrefab(GameObject prefab, Guid newAssetId)


            // Adds Prefab To Prefab Dictionary
            // gives errors when...
            //   prefab is null
            //   prefab does not have NetworkIdentity
            // gives warning when...
            //   prefab has multiple prefab does not have NetworkIdentity
            //   assetId is already being used by different prefab/handler
            ClientScene.RegisterPrefab(null);

            // Sets newAssetId
            // gives warning when...
            //   assetId is already being used by different prefab/handler
            ClientScene.RegisterPrefab(null, new Guid());

            // Adds Delegate to spawnHandlers dictionary
            // Adds Delegate to unspawnHandlers dictionary
            // gives errors when...
            //   prefab is null
            //   prefab does not have NetworkIdentity
            //   spawnHandler is null
            //   unspawnHandler is null
            //   assetId is empty
            // gives warning when...
            //   assetId is already being used by different prefab/handler
            ClientScene.RegisterPrefab(null, new SpawnDelegate((x, y) => null), new UnSpawnDelegate((x) => { }));
            ClientScene.RegisterPrefab(null, new SpawnHandlerDelegate((x) => null), new UnSpawnDelegate((x) => { }));
        }

        [Test]
        [Ignore("Not Implemented")]
        public void UnregisterPrefab()
        {
            // Removes Prefab from Prefab Dictionary (if it exists)
            // Removes handlers from spawnHandlers Dictionary (if it exists)
            // Removes handlers from unSpawnHandlers Dictionary (if it exists)
            // gives errors when...
            //   prefab is null
            //   prefab does not have NetworkIdentity
            ClientScene.UnregisterPrefab(null);
        }

        [Test]
        [Ignore("Not Implemented")]
        public void RegisterSpawnHandler()
        {
            // overloads
            // RegisterSpawnHandler(Guid assetId, SpawnDelegate spawnHandler, UnSpawnDelegate unspawnHandler)
            // RegisterSpawnHandler(Guid assetId, SpawnHandlerDelegate spawnHandler, UnSpawnDelegate unspawnHandler)


            // Adds Delegate to spawnHandlers dictionary
            // Adds Delegate to unspawnHandlers dictionary
            // gives errors when...
            //   spawnHandler is null
            //   unspawnHandler is null
            //   assetId is empty
            ClientScene.RegisterSpawnHandler(new Guid(), new SpawnDelegate((x, y) => null), new UnSpawnDelegate((x) => { }));
            ClientScene.RegisterSpawnHandler(new Guid(), new SpawnHandlerDelegate((x) => null), new UnSpawnDelegate((x) => { }));
        }

        [Test]
        [Ignore("Not Implemented")]
        public void UnregisterSpawnHandler()
        {
            // Removes handlers from spawnHandlers Dictionary (if it exists)
            // Removes handlers from unSpawnHandlers Dictionary (if it exists)
            // gives errors when...
            //   assetId is empty
            ClientScene.UnregisterSpawnHandler(new Guid());
        }

        [Test]
        [Ignore("Not Implemented")]
        public void ClearSpawners()
        {
            // Removes all prefabs from prefabs Dictionary
            // Removes all handlers from spawnHandlers Dictionary
            // Removes all handlers from unspawnHandlers Dictionary
            ClientScene.ClearSpawners();
        }

        [Test]
        [Ignore("Not Implemented")]
        public void DestroyAllClientObjects()
        {
            // Destroys all NetworkIdentity prefabs in scene
            // Disables all NetworkIdentity scene objects in scene
            // Calls unspawnHandler instead of Destroy/Disable (if one exists)
            ClientScene.DestroyAllClientObjects();
        }



        [Test]
        [Ignore("Not Implemented")]
        public void OnSpawn()
        {
            // Applies Payload Correctly
            // Applies Payload to existing object (if one exists
            // Spawns Prefab from prefab Dictionary
            // Spawns Prefab from Handler
            // Spawns Scene object from spawnableObjects Dictionary
            // gives errors when...
            //   guid and sceneId is empty
            //   cant find prefab/handler with assetId
            //   cant find object with sceneId
            //   failed to spawn prefab
            ClientScene.OnSpawn(new SpawnMessage());
        }
    }
}
