using UnityEngine;
using GWENT.Pooling;

namespace GWENT.Bootstrap
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private CardPool cardPool;

        private void Start()
        {
            cardPool.InitializePool();
        }
    }
}