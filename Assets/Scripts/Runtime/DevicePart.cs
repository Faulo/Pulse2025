﻿using UnityEngine;

namespace Runtime {
    sealed class DevicePart : MonoBehaviour {
        [SerializeField]
        internal Bounds bounds;
        [SerializeField]
        internal Vector3 pivot;
        [SerializeField]
        internal Vector2Int tileSize;
    }
}
