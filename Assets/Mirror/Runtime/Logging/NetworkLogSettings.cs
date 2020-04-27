using UnityEngine;

namespace Mirror.Logging
{
    /// <summary>
    /// Used to load LogSettings in build
    /// </summary>
    [DisallowMultipleComponent]
    [AddComponentMenu("Network/NetworkLogSettings")]
    [HelpURL("https://mirror-networking.com/docs/Components/NetworkLogSettings.html")]
    public class NetworkLogSettings : MonoBehaviour
    {
        [SerializeField] internal LogSettings settings;

        void Awake()
        {
            RefreshDictionary();
        }

        void OnValidate()
        {
            // if settings field is changed
            RefreshDictionary();
        }

        void RefreshDictionary()
        {
            settings.LoadIntoDictionary(LogFactory.loggers);
        }
    }
}