using Service;
using UnityEngine;

namespace Controller
{
    public class ApplicationStartupController : MonoBehaviour
    {
        private ApplicationStartUpService _applicationStartUpService;
        // Start is called before the first frame update
        void Start()
        {
            _applicationStartUpService = new ApplicationStartUpService();
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnApplicationQuit()
        {
            _applicationStartUpService.Dispose();
        }
    }
}
